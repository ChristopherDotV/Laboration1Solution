using System;
using System.Collections.Generic;

namespace Laboration1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fråga användaren efter sträng till variabeln NumberText
            Console.WriteLine("Skriv din sträng:");
            string NumberText = Console.ReadLine();

            // Hårdkodad sträng till variabeln NumberText
            // const string NumberText = "29535123p48723487597645723645"; 

            // Skapa en tom lista i variabeln "matches"
            var matches = new List<string>();

            // Loopa igenom varje char i NumberText 
            for (int start = 0; start < NumberText.Length; start++)
            {
                // Sätt nuvarande char till StartChar
                char StartChar = NumberText[start];
                // Debug text - Printa värdet i StartChar 
                // Console.WriteLine("StarChar:" + StartChar);

                // Loopa igenom återstående chars i NumberText efter med start tecknet efter "StartChar"
                for (int end = start + 1; end < NumberText.Length; end++)
                {
                    // Sätt nuvarande char till EndChar
                    char EndChar = NumberText[end];

                    // Kolla om EndChar är en bokstav
                    if (Char.IsLetter(EndChar))
                    {
                        // EndChar är en bokstav, avsluta loop
                        break;
                    }

                    // Kolla om EndChar och StartChar
                    if (EndChar == StartChar)
                    {
                        // EndChar och StartChar matchar

                        // Debug text - Printa värdet i EndChar
                        // Console.WriteLine("End character:" + EndChar);

                        // Beräkna length för Substring
                        int lenght = end - start + 1;
                        // Substringa text med start från variabeln "start" med antalet chars i "lenght" som matchade
                        string match = NumberText.Substring(start, lenght);
                        // Spara matchande sträng i listan "matches"
                        matches.Add(match);
                        // Debug - Printa match
                        // Console.WriteLine("Match:" + match);

                        // Avsluta loop
                        break;
                    }
                }

            }

            // Loopa igenom alla strängar i listan "matches"

            foreach (var match in matches)
            {
                // Splitta NumberText till en array med strängen i "match" som avgränsare
                var split = NumberText.Split(new string[] { match }, StringSplitOptions.None);

                // Printa första delen i arrayen
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(split[0]);

                // Printa "match" med färgen vi valt
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(match);

                // Printa andra delen av arrayen
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(split[1]);

            }


        }
    }
}
