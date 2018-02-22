using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_task
{
    /*
     Задание
        Используя Visual Studio, создайте проект по шаблону Console Application.
        Требуется:
        Создайте класс Printer.
        В теле класса создайте метод void Print(string value), который выводит на экран значение
        аргумента.
        Реализуйте возможность того, чтобы в случае наследования от данного класса других классов,
        и вызове
        соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов,
        выводились разными цветами.
        Обязательно используйте приведение типов.
*/

    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer(ConsoleColor.Magenta);
            printer.Print("printer now print same text");

            ColorPrinter colorPrinter = new ColorPrinter(ConsoleColor.Yellow);
            colorPrinter.Print("colorPrinter print sane text now");

            printer = (Printer)colorPrinter;
            printer.Print("printer now print same text");

            ColorPrinter newColorPrinter = (ColorPrinter)printer;
            newColorPrinter.Print("newColorPrinter now print same text");

            Console.ReadKey();

        }
    }
}
