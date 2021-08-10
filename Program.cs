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

            worker.OpenDocument();



                                  


        }

       

    }
}
