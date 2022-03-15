using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAS_Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Задание 3.";
            string password = "12345";
            string vvod = "";
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите пароль, чтобы увидеть тайное сообщение: ");
                vvod = Console.ReadLine();
                if (vvod != password)
                {
                    Console.WriteLine($"Пароль неверный. Осталось попыток: {2-i} .");
                }
                else
                {
                    Console.WriteLine($"тайное сообщение : {message}");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
