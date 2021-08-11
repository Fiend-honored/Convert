using System;
using System.ComponentModel;

namespace Convert
{
    class Program
    {       

        static void Main(string[] args)
        {
            Console.WriteLine("Редактор КопиРайтер готов к работе");
            
            while (true)
            {
                DocumentWorker worker = new DocumentWorker();

                Console.WriteLine(new string('#', 40));
                Console.WriteLine("Выберете дейсвтвие:\n" +
                "1. Открыть документ \n" +
                "2. Редактировать документ \n" +
                "3. Сохранить документ \n" +
                "4. Ввести серийный ключ для версии Pro/Expert");
                Console.WriteLine(new string ('#', 40));
                int choice = System.Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        worker.OpenDocument();
                        break;
                    case 2:
                        worker.EditDocument();
                        break;
                    case 3:
                        worker.SaveDocument();
                        break;
                    case 4:
                        CheckKey key = new CheckKey();
                        key.CheckEnterKey();
                        string valueKey = key.statusKey;
                        if(valueKey == "pro")
                        {
                            ProDocumentWorker proWorker = (ProDocumentWorker)worker;
                        }
                        break;
                }

            }



                                  


        }

       

    }
}
