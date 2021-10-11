using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World!" tagurpidi

            //Console.WriteLine("Sisesta lause 'Hello, World!':");
            //string allString = Console.ReadLine();

            string helloW = "Hello, World!";

            for(int i = helloW.Length-1; i >= 0; i--)
            {
                Console.Write(helloW[i]);
            }
        }
    }
}
