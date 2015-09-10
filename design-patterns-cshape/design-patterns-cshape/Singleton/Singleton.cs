using System;

namespace design_patterns_cshape.Singleton
{
    public class Singleton
    {
        private static Singleton _instance = null;
        public static Singleton Instance
        {
            get
            {
                if(_instance==null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        public void test()
        {
            Console.WriteLine("this is a test.");
        }


    }
}
