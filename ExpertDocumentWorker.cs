using System;
using System.Collections.Generic;
using System.Text;

namespace Convert
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Документ сохранен в новом формате \n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
