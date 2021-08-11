using System;
using System.Collections.Generic;
using System.Text;

namespace Convert
{
    class CheckKey
    {
        private string proKey = "111";
        private string exKey = "222";

        public string statusKey = "free";
        

        public void CheckEnterKey()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Введите ключ для получения нового уровня подписки: ");
            string enterKey = null;
            enterKey = Console.ReadLine();

            while (true)
            {
                if (enterKey == proKey)
                {
                    statusKey = "pro";
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Ключ корректный, уровень вашей подписки PRO");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                }
                else if (enterKey == exKey)
                {
                    statusKey = "expert";
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Ключ корректный, уровень вашей подписки EXPERT");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели некорректный ключ\n" +
                        "Хотите повторить попытку? Y - да, N - нет");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    string secondTry = Console.ReadLine();
                    if(secondTry == "Y" || secondTry == "y")
                    {
                        continue;
                    } else
                    {
                        break;
                    }


                }
            }
            
            

            
        }

    }
}
