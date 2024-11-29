using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TekstTukling
{
    internal class Start
    {
        private bool _isActive = true;
        public void Run()
        {
            // Lage meny her med while og switch. Koble denne opp til program.cs.
            // Lage nye classes for hver oppgave. Lage en meny for å kunne bla/gå igjennom de.

            while (_isActive)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[ 1 ] Change Words \n[ 2 ] Reverse Text \n[ 3 ] Exit Program");
                var menuChoiceInput = Convert.ToInt32(Console.ReadLine());

                switch (menuChoiceInput)
                {
                    case 1:
                        var changeWord = new ChangeWord();
                        changeWord.Run();
                        break;

                    case 2:
                        var rotateText = new RotateText();
                        rotateText.Run();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("You chose [ 3 ]. The program will now end.");
                        
                        _isActive = false;
                        Environment.Exit(0); 
                        break;

                    default:
                        Console.WriteLine("Not a valid input. Try again.");
                        break;
                }
            }
        }
    }
}
