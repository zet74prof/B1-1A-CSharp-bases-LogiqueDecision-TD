using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiqueDecision
{
    static class BoucleBase
    {
        public static void Main() {
            char action = 'O';

            while (action != 'X')
            {
                Console.WriteLine("Saisissez X pour quitter:");
                action = Console.ReadKey(true).KeyChar;
            }

        }

    }
}
