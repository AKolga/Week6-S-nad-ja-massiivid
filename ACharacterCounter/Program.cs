using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kuvab, mitu 'a' tähte on kasutaja ees- ja perekonnanimes kokku

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();//.ToLower();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();//.ToLower();

            string fullName = $"{firstName}{lastName}".ToLower();

            Console.WriteLine(fullName);

            int aCounter = 0;

            //for(int i = 0; i < firstName.Length; i++)
            for (int i = 0; i < fullName.Length; i++)
            {
                //Console.WriteLine(firstName[i]);
                //if(firstName[i] == 'a')
                if (fullName[i] == 'a')
                {
                    aCounter++;
                }
            }
            if (aCounter != 1)
                {
                //Console.WriteLine($"Sinu eesnimes {firstName} on {aCounter} 'a' tähte.");
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' tähte.");
            }
                else
                {
                //Console.WriteLine($"Sinu eesnimes {firstName} on {aCounter} 'a' täht");
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' täht.");
            }
            
        }
    }
}
