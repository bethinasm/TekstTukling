using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekstTukling
{
    internal class RotateText
    {
        private string reversedText = "";
        private string userInput = "";
        // private string text = "";


        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Enter the text you want me to reverse:");
            userInput = Console.ReadLine();
            ReverseText(userInput);
            Console.WriteLine($"Your reversed text it: \n{reversedText}");
            Console.WriteLine();
            Thread.Sleep(1000);

        }

        public string ReverseText(string userInput)
        {
            foreach (var letter in userInput)
            {
                reversedText = letter + reversedText;
            }
            return reversedText;
        }


        // Hvordan var det Rebecka ville jeg skulle bruke ctor igjen?

        /*
        public RotateText() // ctor, ikke metode
        {
            string input = Console.ReadLine();
            text = input;
        }
        */

    }
}
