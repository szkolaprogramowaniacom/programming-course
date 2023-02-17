using System.Security.Cryptography.X509Certificates;

internal class LocalMethod
{
    // easy example
    //var objectWithLocalMethods = new LocalMethod();
    //objectWithLocalMethods.Run();

    public LocalMethod()
    {
    }

    public void Run()
    {
        Step1();
        Step2();

        void Step1()
        {
            Console.WriteLine("Step 1");
        }

        void Step2()
        {
            Console.WriteLine("Step 2");
        }
    }
}