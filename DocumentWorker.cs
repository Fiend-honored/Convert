using System;
using System.Collections.Generic;
using System.Text;

namespace Convert
{
    class DocumentWorker
    {
       public string OpenDocument()
        {
            return "Документ открыт";
        }

       public virtual string EditDocument()
        {
            return "Редактирование документа доступно в версии Про";
        }

       public virtual string SaveDocument()
        {
            return "Сохранение документа доступно в версии Про";
        }
    }
}
