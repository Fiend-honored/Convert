using System;
using System.Collections.Generic;
using System.Text;

namespace Convert
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Документ отредактирован \n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public override void SaveDocument()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт \n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }


    }
}
