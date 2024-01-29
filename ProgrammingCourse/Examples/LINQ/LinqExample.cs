using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples.LINQ
{
    internal class LinqExample
    {
        record Child(string Name);
        record Parent(string Name, List<Child> Children);

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

        public void SelectManyExample()
        {
            var parents = new List<Parent>{
            new("John Smith", new List<Child>{
                new("Ann Smith"),
                new("Monica Smith"),
                new("Adam Smith"),
            }),
            new("Monica Kowalsky", new List<Child>
            {
                new("Peter Kowalsky"),
                new("John Kowalsky"),
            })
        };

            // without SelectMany
            //foreach (var parent in parents)
            //{
            //    foreach (var child in parent.Children)
            //    {
            //        Console.WriteLine(child.Name);
            //    }
            //}

            foreach (var child in parents.SelectMany(parent => parent.Children))
            {
                Console.WriteLine(child.Name);
            }
        }

        record Dog(string Name);
        record Cat(string Name);

        internal void OfTypeExample()
        {
            var animals = new List<object>
            {
                new Dog("Dog1"),
                new Cat("Cat1"),
                new Cat("Cat2"),
                new Cat("Cat3"),
                new Dog("Dog2"),
                new Dog("Dog3"),
            };

            var subanimal = animals.OfType<Cat>();
            foreach (var animal in subanimal)
            {
                Console.WriteLine(animal);
            }
        }

        public void WhereExample()
        {
            var numbers = new List<int> { 11, 2, 23, 4, 15, 6 };
            var greater = numbers.Where(n => n > 10).ToList();
            var even = numbers.Where(n => n % 2 == 0).ToList();

            foreach (var number in greater.OrderBy(x => x))
            {
                Console.WriteLine(number);
            }
        }

        public void FirstExample()
        {
            var users = new List<UserDto> {
                new(){ Name = "John" },
                new(){ Name = "Peter" },
                new(){ Name = "Robert" },
            };

            //var first = users.First();
            var firstWithE = users.FirstOrDefault(u => u.Name.ToLower().Contains('e'));
            if (firstWithE == null)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine(firstWithE);
            }
        }

        public void AnyAllExample()
        {
            var numbers = new List<int> { 2, 3, 7, 2, 0, 6, 8, 4, 7, 3 };

            var isZero = numbers.Any(x => x == 0);
            Console.WriteLine($"Is Zero: {isZero}");

            var noZero = numbers.All(x => x != 0);
            Console.WriteLine($"No Zero: {noZero}");
        }

        public void SkipTakeExample()
        {
            var numbers = new List<int> { 2, 3, 7, 2, 0, 6, 8, 4, 7, 3 };
            //var first3 = numbers.Skip(4).Take(2);

            //foreach (var number in first3)
            //{
            //    Console.WriteLine(number);
            //}

            var pageSize = 2;
            var pageCount = numbers.Count / pageSize;
            for (var pageIndex = 0; pageIndex < pageCount; pageIndex++)
            {
                var pageItems = numbers.Skip(pageIndex * pageSize).Take(pageSize);
                Console.WriteLine($"Page: {pageIndex} => {string.Join(',', pageItems)}");
            }
        }
    }
}
