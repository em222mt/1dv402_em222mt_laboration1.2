using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S1.L02A
{
    class Program
    {
        static void Main(string[] args)
        {

            //Inledande for loop för att skriva ut asterisker på 25 rader
            for (int row = 0; row < 25; row++)
            {
                //Switchsats för att bestämma en rads färg med hjälp av...
                //...en enkel ekvation som kastar oss in i case 0, case 1, eller case 2
                switch ((row + 3) % 3)
                {
                    case 0:

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;

                    case 1:

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;

                    case 2:

                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }

                //Nästlad for loop för att skriva ut asterisker med mellanslag över 39 kolumner
                for (int col = 0; col < 39; col++)
                {
                    Console.Write("* ");
                }
                //Byter rad då föregående for loop avslutas.
                Console.WriteLine();

                //Bestämmer med en ekvation om ett mellanslag ska skjutas in i början av en rad.
                if ((row + 2) % 2 == 0)
                {
                    Console.Write(" ");
                }
            }

            //Återställer foreground colour när all ovanstånde kod körts klart.
            Console.ResetColor();

        }
    }
}
