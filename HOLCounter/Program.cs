using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!"

            string fullString = "Hello, World!".ToLower();

            int hCounter = 0;
            for (int i = 0; i < fullString.Length; i++)
            {
                if (fullString[i] == 'h')
                {
                    hCounter++;
                    //Console.WriteLine($"Sõnapaaris Hello, World! on {hCounter} 'h' täht.");
                }

            }
            int oCounter = 0;
            for (int i = 0; i < fullString.Length; i++)
            {
                if (fullString[i] == 'o')
                {
                    oCounter++;
                }
            }
            if (oCounter != 1)
            {
                //Console.WriteLine($"Sõnapaaris Hello, World! on {oCounter} 'o' tähte.");
            }

            int lCounter = 0;
            for (int i = 0; i < fullString.Length; i++)
            {
                if(fullString[i] == 'l')
                {
                    lCounter++;
                }
            }
            if(lCounter != 1)
            {
                Console.WriteLine($"Lauses Hello, World! on {hCounter} 'h', {oCounter} 'o' ja {lCounter} 'l' tähte.");
            }

        }
    }
}
