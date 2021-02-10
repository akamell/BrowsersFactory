using System;

namespace BrowserFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactoryBrowser factory = new FactoryBrowser();
            IBrowser google = factory.createBrowser<Google>();
            IBrowser firefox = factory.createBrowser<Firefox>();
            IBrowser opera = factory.createBrowser<Opera>();

            Console.WriteLine($"{google.WhoAmI()}");
            Console.WriteLine($"{firefox.WhoAmI()}");
            Console.WriteLine($"{opera.WhoAmI()}");
        }
    }
}
