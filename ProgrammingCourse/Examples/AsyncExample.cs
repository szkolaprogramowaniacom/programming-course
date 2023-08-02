namespace ProgrammingCourse.Examples
{
    internal class AsyncExample
    {
        List<string> pageUrls = new List<string> {
            "https://onet.pl",
            "https://wp.pl",
            "https://dziennik.pl",
            "https://fakt.pl",
            "https://wydarzenia.interia.pl",
            "https://www.se.pl",
            "https://wiadomosci.tvp.pl",
            "https://www.bankier.pl",
            "https://wpolityce.pl",
        };

        List<string> fileUrls = new List<string>
        {
            "https://filesamples.com/samples/audio/wav/sample1.wav",
            "https://filesamples.com/samples/audio/wav/sample2.wav",
            "https://filesamples.com/samples/audio/wav/sample3.wav",
            "https://filesamples.com/samples/audio/wav/sample4.wav",
        };

        void LoadItems()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Loading item: " + i);
                Task.Delay(500).Wait();
            }
        }

        async Task RunAsync()
        {
            await Task.Run(LoadItems);
            Console.WriteLine("Finished");
        }

        void Run()
        {
            Task.Run(LoadItems).Wait();
            Console.WriteLine("Finished");
        }

        string LoadPage(string pageUrl)
        {
            Console.WriteLine($"Downloading {pageUrl}...");
            var client = new HttpClient();
            var content = client.GetStringAsync(pageUrl).Result;
            var preview = GetPreview(content);
            Console.WriteLine($"Downloaded: {preview}");
            return content;
        }

        async Task<string> LoadPageAsync(string pageUrl)
        {
            Console.WriteLine($"Downloading {pageUrl}...");
            var client = new HttpClient();
            var content = await client.GetStringAsync(pageUrl);
            var preview = GetPreview(content);
            Console.WriteLine($"Downloaded: {preview}");
            return content;
        }
        string GetPreview(string content)
        {
            return content
                .Substring(0, 50)
                .Replace("\n", string.Empty);
        }
        async Task<byte[]> LoadFileAsync(string fileUrl)
        {
            Console.WriteLine($"Downloading {fileUrl}...");
            var client = new HttpClient();
            return await client.GetByteArrayAsync(fileUrl);
        }

        /// <summary>
        /// First excercise
        /// </summary>
        public void RunExcercise1()
        {
            Console.WriteLine("Press ENTER to start...");
            Console.ReadLine();

            Run();

            Console.WriteLine("Press ENTER to start async...");
            Console.ReadLine();

            RunAsync();
            
            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();
        }


        /// <summary>
        /// Second excercise
        /// </summary>
        public void RunExercise2()
        {
            Console.WriteLine("Press ENTER to start...");
            Console.ReadLine();

            foreach (var pageUrl in pageUrls)
            {
                LoadPage(pageUrl);
            }

            Console.WriteLine("Press ENTER to start async...");
            Console.ReadLine();

            foreach (var pageUrl in pageUrls)
            {
                var task = LoadPageAsync(pageUrl);        
            }

            var tasks = new List<Task>();
            foreach (var fileUrl in fileUrls)
            {
                var task = LoadFileAsync(fileUrl).ContinueWith((result) => {
                    if (result.IsCompleted)
                    {
                        Console.WriteLine($"Downloaded {result.Result.LongLength} B");
                    }
                    else
                    {
                        Console.WriteLine("Task not complited");
                    }
                });
                tasks.Add(task);
            }

            while (true)
            {
                if (tasks.All(task => task.IsCompleted))
                {
                    break;
                }
                Console.Write(".");
                Task.Delay(100).Wait();
            }

            Console.WriteLine("Finished");
        }
    }
}
