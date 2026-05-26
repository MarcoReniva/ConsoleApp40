using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('C');Console.ResetColor();
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.Write('O');Console.ResetColor();
            Console.ForegroundColor= ConsoleColor.Red;
            Console.Write('L');Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write('O');Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('R');Console.ResetColor();
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write('L');Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write('A'); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write('B');Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("█████ ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("█████ ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("█████ ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("█████ ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("█████ ");
            Console.ResetColor();
            Console.WriteLine();
            Console.Write(" [1]   " +"[2]  " + " [3]   " + "[4]   " + "[5]");
        }
        static void decision ()
        {
            Console.Write("Choose the 1st Color: ");
            string one = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Choose the 2nd Color: ");
            string second = Console.ReadLine();
        }
        static void color ()
        {
            Stack<string> mixhist = new Stack<string>();
        }
    }
}
