using Microsoft.VisualBasic.Devices;
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
            var stream = await videoClient.StreamAsync(movie);
            var data = await ReadStreamToByteArrayAsync(stream, cancellationToken);

            var destFilePath = @"C:\Projekty\SzkolaProgramowania.com\Pliki\" + movie.FullName;
            await File.WriteAllBytesAsync(destFilePath, data, cancellationToken);
        }

        private async Task<byte[]> ReadStreamToByteArrayAsync(Stream stream, CancellationToken token)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = await stream.ReadAsync(buffer, 0, buffer.Length, token)) > 0)
                {
                    token.ThrowIfCancellationRequested();
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
        }
    }
}