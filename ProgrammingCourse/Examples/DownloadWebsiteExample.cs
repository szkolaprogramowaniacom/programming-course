using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class DownloadWebsiteExample
    {
        public async void RunAsync()
        {
            var httpClient = new HttpClient();
            var content = await httpClient.GetStringAsync("https://google.com");
            File.WriteAllText(@"C:\Projekty\SzkolaProgramowania.com\Pliki\google.txt", content);
        }
    }
}
