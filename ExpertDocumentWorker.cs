using System;
using System.Collections.Generic;
using System.Text;

namespace Convert
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override string SaveDocument()
        {
            return "Документ сохранен в новом формате";
        }
    }
}
