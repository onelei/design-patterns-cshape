using System;
using design_patterns_cshape.Singleton;

namespace design_patterns_cshape
{
    class Program
    {
        static void Main(string[] args)
        {
            testSingleton();

            Console.ReadLine();
        }

        static void testSingleton()
        {
            Console.WriteLine("test Singleton");
            Singleton.Singleton.Instance.test();
        }
    }
}
