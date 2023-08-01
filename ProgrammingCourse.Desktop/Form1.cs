namespace ProgrammingCourse.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonDownload_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            textBoxSource.Text = await httpClient.GetStringAsync(textBoxUrl.Text);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                await Task.Delay(3000);                
            });
            MessageBox.Show("Finished");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Task.Delay(3000).Wait();
            }).Wait();
            MessageBox.Show("Finished");
        }
    }
}