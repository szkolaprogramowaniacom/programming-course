using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using VideoLibrary;

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
            try
            {
                tokenSource = new CancellationTokenSource();
                buttonDownload.Enabled = false;
                textBoxDownload.Enabled = false;
                buttonCancel.Enabled = true;
                await DownloadFileAsync(textBoxDownload.Text, tokenSource.Token);
                MessageBox.Show("Film downloaded");
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

        private async Task DownloadFileAsync(string movieUrl, CancellationToken cancellationToken)
        {
            var youtube = YouTube.Default;
            var movie = await youtube.GetVideoAsync(movieUrl);
            var videoClient = new VideoClient();

            // get data without token
            //var data = await movie.GetBytesAsync();

            // get data with token
            using var stream = await videoClient.StreamAsync(movie);
            var destFilePath = @"C:\Projekty\SzkolaProgramowania.com\Pliki\" + movie.FullName;

            // using RAM
            //var data = await ReadStreamToByteArrayAsync(stream, cancellationToken);
            //await File.WriteAllBytesAsync(destFilePath, data, cancellationToken);

            // write direct to file stream
            await WriteStreamToFileAsync(stream, destFilePath, cancellationToken);
        }

        private async Task WriteStreamToFileAsync(Stream stream, string destFilePath, CancellationToken cancellationToken)
        {
            byte[] buffer = new byte[16 * 1024];
            using FileStream fileStream = File.OpenWrite(destFilePath);
            int read;
            while ((read = await stream.ReadAsync(buffer, 0, buffer.Length, cancellationToken)) > 0)
            {
                cancellationToken.ThrowIfCancellationRequested();
                fileStream.Write(buffer, 0, read);
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