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
            Console.Write("Введите ключ для получения нового уровня подписки: ");
            string enterKey = null;
            enterKey = Console.ReadLine();

            while (true)
            {
                if (enterKey == proKey)
                {
                    statusKey = "pro";
                    Console.WriteLine("Ключ корректный, уровень вашей подписки PRO");
                    break;
                }
                else if (enterKey == exKey)
                {
                    statusKey = "expert";
                    Console.WriteLine("Ключ корректный, уровень вашей подписки EXPERT");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректный ключ\n" +
                        "Хотите повторить попытку? Y - да, N - нет");
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
