using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_task
{
    class ColorPrinter : Printer
    {
        public ColorPrinter(ConsoleColor color) : base(color)
        {

        }

        public void Print(string value)
        {
            ConsoleColor currentConsoleColor = Console.ForegroundColor;
            Console.ForegroundColor = this.consoleColor;
            Console.WriteLine("Printer Color class");
            Console.ForegroundColor = currentConsoleColor;
        }
    }
}
