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

        public int ChoiceCommand()
        {
            Console.WriteLine("Выберете дейсвтвие:\n" +
                "1. Открыть документ \n" +
                "2. Редактировать документ \n" +
                "3. Сохранить документ \n" +
                "4. Ввести серийный ключ для версии Pro/Expert");
            int choice = System.Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case "1":

                    break;
            }
        }
    }
}
