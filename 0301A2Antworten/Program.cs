using System;

namespace _0301A2Antworten
{
    class Program
    {
        static void Main(string[] args)
        {
            char yn;  // Eingabevariable

            Console.Write("Antworten Sie mit Ja (j oder J) oder Nein (n oder N):");
            yn = char.Parse(Console.ReadLine());

            switch (yn)
            {
                case 'j':
                case 'J':
                    Console.WriteLine("Sie haben mit ja geantwortet");
                    break;

                case 'n':
                case 'N':
                    Console.WriteLine("Sie haben mit nein geantwortet");
                    break;

                default:
                    Console.WriteLine("Sie haben eine falsche Eingabe gemacht.");
                    break;
            }
        }
    }
}
