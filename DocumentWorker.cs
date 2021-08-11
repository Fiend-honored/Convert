using System;
using System.Collections.Generic;
using System.Text;

namespace Convert
{
    class DocumentWorker
    {
       public void OpenDocument()
        {
            Console.WriteLine("Документ открыт"); ;
        }

       public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
            
        }

       public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }

        public string Choice()
        {
            Console.WriteLine(new string('#', 40));
            Console.WriteLine("Выберете дейсвтвие:\n" +
            "1. Открыть документ \n" +
            "2. Редактировать документ \n" +
            "3. Сохранить документ \n" +
            "4. Ввести серийный ключ для версии Pro/Expert");
            Console.WriteLine(new string('#', 40));
            int choice = System.Convert.ToInt32(Console.ReadLine());

            string userChoice = null; 

            switch (choice)
            {
                case 1:
                    OpenDocument();
                    break;
                case 2:
                    EditDocument();
                    break;
                case 3:
                    SaveDocument();
                    break;
                case 4:
                    CheckKey key = new CheckKey();
                    key.CheckEnterKey();
                    string valueKey = key.statusKey;
                    if (valueKey == "pro")
                    {
                        userChoice = "pro";
                    } else if (valueKey == "expert")
                    {
                        userChoice = "expert";
                    }
                    else
                    {
                        userChoice = "free";
                    }                   
                    break;
            }
            return userChoice;
        }
    }
}
