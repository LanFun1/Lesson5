using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Кем вы работаете?");
            string work = Console.ReadLine();
            Console.WriteLine("Кто вы по знаку зодиака?");
            string sign = Console.ReadLine();

            Console.WriteLine($"Вас зовут {name}. Вам {age} год(года,лет). Вы {work}. Ваш знак зодиака {sign}");
        }
    }
}
