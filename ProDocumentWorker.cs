using System;
using System.Collections.Generic;
using System.Text;

namespace Convert
{
    class ProDocumentWorker : DocumentWorker
    {
        public new void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public new void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
}
