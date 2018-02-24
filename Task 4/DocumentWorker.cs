using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("DocumentWorker - Документ открыт");
        }

        virtual public void EditDocument()
        {
            Console.WriteLine("DocumentWorker - Редактирование документа доступно в версии Про");
        }

        virtual public void SaveDocument()
        {
            Console.WriteLine("DocumentWorker - Сохранение документа доступно в версии Про");
        }
    }
}
