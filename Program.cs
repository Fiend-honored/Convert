using System;
using System.ComponentModel;

namespace Convert
{
    class Program
    {       

        static void Main(string[] args)
        {
            Console.WriteLine("Редактор КопиРайтер готов к работе");

            DocumentWorker worker = new DocumentWorker();
            ProDocumentWorker proWorker = new ProDocumentWorker();
            ExpertDocumentWorker expertWorker = new ExpertDocumentWorker();

            string status = worker.Choice();

            while (true)
            {                
                if(status == "pro")
                {
                    status = proWorker.Choice();
                } else if (status == "expert")
                {
                    status = expertWorker.Choice();
                } else
                {
                    status = worker.Choice();
                }

            }                                


        }

       

    }
}
