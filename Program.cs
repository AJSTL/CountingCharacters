using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string Paragraph = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. " +
                "Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. " +
                "Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            Paragraph = Paragraph.ToLower();

            Dictionary<char, int> charCounts = new Dictionary<char, int>();

           for (int i=0; i<Paragraph.Length; i++)
            {
                if (!charCounts.ContainsKey(Paragraph[i]))
                {
                    charCounts.Add(Paragraph[i], 1);
                }
                else
                {
                    charCounts[Paragraph[i]] += 1;
                }
            }


            foreach (char dictKey in charCounts.Keys)
            {
                Console.WriteLine(dictKey +" : " +charCounts[dictKey]);
            }  
        }
    }
}
