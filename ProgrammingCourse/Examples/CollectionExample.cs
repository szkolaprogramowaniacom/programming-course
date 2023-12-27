using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class CollectionExample
    {
        public record Product(int Id, string Name, string Category);

        public void Run()
        {
            var products = new List<Product>
            {
                new Product(1, "TV", "AGD"),
                new Product(2, "Coffee Machine", "AGD"),
                new Product(3, "Phone", "Phones")
            };

            // wrong way
            //foreach (var product in products)
            //{
            //    if(product.Category == "Phones")
            //    {
            //        products.Remove(product);
            //    }
            //}

            // long code and enumeration twice
            //var productsToRemove = new List<Product>();
            //foreach (var product in products)
            //{
            //    if (product.Category == "Phones")
            //    {
            //        productsToRemove.Add(product);
            //    }
            //}
            //products.RemoveAll(product => productsToRemove.Contains(product));

            products.RemoveAll(product => product.Category == "Phones");

            // what predicate is
            //products.RemoveAll(WhereProductIsPhone);

            // show collection after operation
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
        public bool WhereProductIsPhone(Product product)
        {
            return product.Category == "Phones";
        }

        public void ByIndexExample()
        {
            var names = new List<string>() { "John", "Monica", "Ann" };

            if (names.Count > 0)
            {
                var indexOfLast = names.Count - 1; // 2 -1
                Console.WriteLine($"Last: {names[indexOfLast]}");
                Console.WriteLine($"Last: {names[names.Count - 1]}");
                Console.WriteLine($"Last: {names[^1]}");
                var last = names.Last();
                Console.WriteLine(last);
            }
            else
            {
                Console.WriteLine("Collection empty!");
            }
        }

    }
}
