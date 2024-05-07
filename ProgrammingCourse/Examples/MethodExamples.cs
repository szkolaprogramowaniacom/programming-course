namespace ProgrammingCourse.Examples
{
    internal class MethodExamples
    {
        record Product(string Name, string Category);

        public void Run()
        {
            AddProduct("Samsung Galaxy S23", "Phones");

            var product = new Product("Samsung Galaxy S21", "Phones");
            AddProductModel(product);

            //AddProductModel(new Product("Samsung Galaxy S6", "Phones"));
        }

        void AddProduct(string name, string category)
        {
            // updating DB
            Console.WriteLine($"Product {name} added...");
        }

        void AddProductModel(Product product)
        {
            // updating DB
            Console.WriteLine($"Product {product.Name} added...");
        }
    }
}
