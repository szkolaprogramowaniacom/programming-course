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
    }
}