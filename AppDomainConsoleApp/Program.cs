using System;

namespace AppDomainConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * In standard .NET Framework AppDomain.CurrentDomain.BaseDirectory
             */
            Console.WriteLine($"AppContext.BaseDirectory:\n{AppContext.BaseDirectory}");
            Console.ReadLine();
        }
    }
}
