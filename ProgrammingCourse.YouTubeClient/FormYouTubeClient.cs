using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using VideoLibrary;
using YoutubeExplode;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace ProgrammingCourse.YouTubeClient
{
    public partial class FormYouTubeClient : Form
    {
        private CancellationTokenSource tokenSource;

        public FormYouTubeClient()
        {
            InitializeComponent();
        }

        private async void buttonDownload_Click(object sender, EventArgs e)
        {
            //var url = "https://www.youtube.com/shorts/QxsNnW6W1Fk";
            //https://www.youtube.com/watch?v=ZUfVEj6msOs
            try
            {
                var progress = new Progress<double>((value) =>
                {
                    //labelStatus.Text = value.ToString();
                    progressBarDownload.Value = (int)(value * 100);
                });

                tokenSource = new CancellationTokenSource();
                progressBarDownload.Value = 0;
                buttonDownload.Enabled = false;
                textBoxDownload.Enabled = false;
                buttonCancel.Enabled = true;
                await DownloadFileUsingExplodeAsync(textBoxDownload.Text, progress, tokenSource.Token);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "YouTube Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                buttonDownload.Enabled = true;
                textBoxDownload.Enabled = true;
                buttonCancel.Enabled = false;                
            }
        }

        private async Task DownloadFileUsingExplodeAsync(string videoUrl, IProgress<double> progress, CancellationToken token)
        {
            var youtube = new YoutubeClient();
            var videoId = VideoId.Parse(videoUrl);
            var movie = await youtube.Videos.GetAsync(videoUrl, token);

            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoUrl);
            var streamInfo = streamManifest.GetMuxedStreams().TryGetWithHighestVideoQuality();
            if (streamInfo is null)
            {
                MessageBox.Show("This video has no muxed streams.");
                return;
            }

            var fileName = $"{RemovePathIllegalChars(movie.Title)}.{streamInfo.Container.Name}";
            var filePath = Path.Combine(@"C:\Projekty\SzkolaProgramowania.com\Pliki\", fileName);

            await youtube.Videos.Streams.DownloadAsync(streamInfo, filePath, progress, token);
        }

        private string RemovePathIllegalChars(string title)
        {
            // todo
            //return title;
            return "safe-name-movie";
        }

        private async Task DownloadFileAsync(string movieUrl, IProgress<DownloadStatusModel> progress, CancellationToken cancellationToken)
        {
            var youtube = YouTube.Default;
            var movie = await youtube.GetVideoAsync(movieUrl);
            var videoClient = new VideoLibrary.VideoClient();

            // get data without token
            //var data = await movie.GetBytesAsync();

            // get data with token
            using var stream = await videoClient.StreamAsync(movie);
            var destFilePath = @"C:\Projekty\SzkolaProgramowania.com\Pliki\" + movie.FullName;

            // using RAM
            //var data = await ReadStreamToByteArrayAsync(stream, cancellationToken);
            //await File.WriteAllBytesAsync(destFilePath, data, cancellationToken);

            // write direct to file stream
            await WriteStreamToFileAsync(stream, destFilePath, movie.ContentLength.Value, progress, cancellationToken);
        }

        private async Task WriteStreamToFileAsync(Stream stream, string destFilePath, long contentLength, IProgress<DownloadStatusModel> progress, CancellationToken cancellationToken)
        {
            byte[] buffer = new byte[16 * 1024];
            using FileStream fileStream = File.OpenWrite(destFilePath);
            int read;
            long totalRead = 0;
            while ((read = await stream.ReadAsync(buffer, 0, buffer.Length, cancellationToken)) > 0)
            {
                cancellationToken.ThrowIfCancellationRequested();
                fileStream.Write(buffer, 0, read);
                totalRead += read;

                // send update request to GUI
                progress.Report(new DownloadStatusModel
                {
                    TotalRead = totalRead,
                    TotalSize = contentLength
                });
            }
        }

        private async Task<byte[]> ReadStreamToByteArrayAsync(Stream stream, CancellationToken token)
        {
            byte[] buffer = new byte[16 * 1024];
            using MemoryStream ms = new MemoryStream();
            int read;
            while ((read = await stream.ReadAsync(buffer, 0, buffer.Length, token)) > 0)
            {
                token.ThrowIfCancellationRequested();
                ms.Write(buffer, 0, read);
            }
            return ms.ToArray();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
        }
    }
}