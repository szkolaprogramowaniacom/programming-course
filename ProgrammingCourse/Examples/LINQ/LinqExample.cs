using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples.LINQ
{
    internal class LinqExample
    {
        public void SelectAndOrderByExample()
        {
            var users = new List<User>
            {
                new User{Name = "Monica Smith", Email = "monica@smith.com"},
                new User{Name = "John Smith", Email = "john@smith.com"},
            };

            // select (convertion)
            var usersDto = users.Select(u => new UserDto { Name = u.Name }).ToList();
            Console.WriteLine("U: " + usersDto.First());

            // order by
            var orderdUsers = usersDto.OrderBy(u => u.Name);
            var orderdUsersDesc = usersDto.OrderByDescending(u => u.Name);
            Console.WriteLine("O: " + orderdUsers.First());
            Console.WriteLine("D: " + orderdUsersDesc.First());

        }

        public void GroupByExample()
        {
            // group by
            var text = "Picasso made his first trip to Paris, then the art capital of Europe, in 1900. There, he met his first Parisian friend, journalist and poet Max Jacob, who helped Picasso learn the language and its literature. Soon they shared an apartment; Max slept at night while Picasso slept during the day and worked at night. These were times of severe poverty, cold, and desperation. Much of his work was burned to keep the small room warm. During the first five months of 1901, Picasso lived in Madrid, where he and his anarchist friend Francisco de Asís Soler founded the magazine Arte Joven (Young Art), which published five issues. Soler solicited articles and Picasso illustrated the journal, mostly contributing grim cartoons depicting and sympathizing with the state of the poor. The first issue was published on 31 March 1901, by which time the artist had started to sign his work Picasso. From 1898 he signed his works as \"Pablo Ruiz Picasso\", then as \"Pablo R. Picasso\" until 1901. The change does not seem to imply a rejection of the father figure. Rather, he wanted to distinguish himself from others; initiated by his Catalan friends who habitually called him by his maternal surname, much less current than the paternal Ruiz.";
            var words = text
                .Replace("(", " ")
                .Replace("\"", " ")
                .Replace(")", " ")
                .Replace(";", " ")
                .Split(new char[] { ' ', '.', ',' });
            var groups = words.Select(w => w.ToLower().Trim()).GroupBy(w => w.Length);

            foreach (var group in groups.OrderBy(g => g.Key))
            {
                Console.WriteLine($"Group: {group.Key}");
                foreach (var word in group.Distinct()) // LINQ Distinct
                {
                    Console.WriteLine($" - {word}");
                }
            }
        }
    }
}
