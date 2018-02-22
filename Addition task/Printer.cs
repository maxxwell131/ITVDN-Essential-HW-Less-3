using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_task
{
    class Printer
    {
        protected ConsoleColor consoleColor;
        
        public Printer (ConsoleColor consoleColor)
        {
            this.consoleColor = consoleColor;
        }

        public void Print(string value)
        {          
            Console.WriteLine( "Printer Base class" );
        }
    }
}
