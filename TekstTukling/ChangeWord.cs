using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekstTukling
{
    internal class ChangeWord
    {
        private string userInput = "";
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("I will change all [ e ] characters to [ a ] characters in the text you give me:");
            Thread.Sleep(1500);
            Console.WriteLine("Enter the text you want me to change:");
            userInput = Console.ReadLine();
            Console.WriteLine($"Your new changed text is: \n{WordToBeChanged(userInput.ToCharArray())}");
        }

        private string WordToBeChanged(char[]text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'e')
                {
                    text[i] = 'a';
                }
            }
            return new string(text);
        }
    }
}
