using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        /*
         Задание 4
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Требуется:
            Создайте класс DocumentWorker.
            В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
            В тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт",
            "Редактирование документа доступно в версии Про", "Сохранение документа доступно в
            версии Про".
            Создайте производный класс ProDocumentWorker.
            Переопределите соответствующие методы, при переопределении методов выводите следующие строки:
            "Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных
            форматах доступно в версии Эксперт".
            Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker.
            Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран
            "Документ сохранен в новом формате".
            В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp.
            Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается
            экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, то должен
            создаться экземпляр соответствующей версии класса, приведенный к базовому - DocumentWorker.
        */

        static void Main(string[] args)
        {
            DocumentWorker document = null;
            

            int i = 0;
            Random random = new Random();

            while ((i++) != 4)
            {
                switch (random.Next(1, 4))
                {
                    case 1:
                        {
                            document = new DocumentWorker();
                            WorkWithDocument(document, "DocumentWorker");
                            break;
                        }
                    case 2:
                        {
                            document = new ExpertDocumentWorker();
                            WorkWithDocument(document, "ExpertDocumentWorker");
                            break;
                        }
                    case 3:
                        {
                            document = new ProDocumentWorker();
                            WorkWithDocument(document, "ProDocumentWorker");
                            break;
                        }

                }
            }

            Console.ReadKey();
        }

        static void WorkWithDocument(DocumentWorker document, string objectName)
        {
            Console.WriteLine(new string('.', 10));
            Console.WriteLine("------- {0} ------", objectName);
            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();
        }
    }
}
