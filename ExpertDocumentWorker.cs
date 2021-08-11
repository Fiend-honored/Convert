using System;
using System.Collections.Generic;
using System.Text;

namespace Convert
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public new void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
