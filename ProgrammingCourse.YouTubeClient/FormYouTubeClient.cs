using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using VideoLibrary;

namespace ProgrammingCourse.YouTubeClient
{
    public partial class FormYouTubeClient : Form
    {
        public FormYouTubeClient()
        {
            InitializeComponent();
        }

        private async void buttonDownload_Click(object sender, EventArgs e)
        {
            //var url = "https://www.youtube.com/shorts/QxsNnW6W1Fk";
            try
            {
                buttonDownload.Enabled = false;
                textBoxDownload.Enabled = false;
                await DownloadFileAsync(textBoxDownload.Text);
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
            }
        }

        private async Task DownloadFileAsync(string movieUrl)
        {
            var youtube = YouTube.Default;
            var movie = await youtube.GetVideoAsync(movieUrl);
            var data = await movie.GetBytesAsync();
            var destFilePath = @"C:\Projekty\SzkolaProgramowania.com\Pliki\" + movie.FullName;
            await File.WriteAllBytesAsync(destFilePath, data);
        }
    }
}