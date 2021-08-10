using System;
using System.ComponentModel;

namespace Convert
{
    class Program
    {       

        static void Main(string[] args)
        {
            Console.WriteLine("Редактор КопиРайтер готов к работе");
            Console.WriteLine(new string ('_', 40));

            ExpertDocumentWorker workerExpert = new ExpertDocumentWorker();
            DocumentWorker worker = workerExpert;

            while (true)
            {
                int command = worker.ChoiceCommand();

                switch (command)
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

                        break;
                }
            }      
                   
                                            

        }

       

    }
}
