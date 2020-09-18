using System;

namespace lab01_ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет. Введи своё Имя:");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}. Теперь введи дату на сегодня:");
            Console.WriteLine("Год");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Месяц");
            int y = Convert.ToInt32(Console.ReadLine());
            if (y < 1 || y > 12) 
            {
                Console.WriteLine($"Нет такого месяца как {y}");
                return;
            }
            Console.WriteLine("День");
            int z = Convert.ToInt32(Console.ReadLine());
            if (y == 2) //если месяц февраль, то проверяем на високосный год
            {
                if (x % 4 == 0)
                {
                    if (z < 1 || z > 29) 
                    {
                        Console.WriteLine($"Уууупс... В этом месяце нет такого дня как {z}");
                        return;
                    }
                }
                else
                {
                    if (z < 1 || z > 28)
                    {
                        Console.WriteLine($"Уууупс... В этом месяце нет такого дня как {z}");
                        return;
                    }
                }
            }
            else if (y == 1 | y == 3 | y == 5 | y == 7 | y == 8 | y == 10 | y == 12) //если у месяца всего 31 день, то выполняем проверку на дни
            {
                if (z < 1 || z > 31)
                {
                    Console.WriteLine($"Уууупс... В этом месяце нет такого дня как {z}");
                    return;
                }
            }
            else if (y == 4 | y == 6 | y == 9 | y == 11) //если у месяца всего 30 дней, то выполняем проверку
            {
                if (z < 1 || z > 30) 
                {
                    Console.WriteLine($"Уууупс... В этом месяце нет такого дня как {z}");
                    return;
                }
            }

            Console.WriteLine("Молодец!!!");
            Console.WriteLine("Теперь введи дату своего дня рождения:");
            Console.WriteLine("Год");
            int x2 = Convert.ToInt32(Console.ReadLine());
            if (x < x2)
            {
                Console.WriteLine("Ошибка. Год Дня рождения превышает год, который идёт сегодня");
                return;
            }
            Console.WriteLine("Месяц");
            int y2 = Convert.ToInt32(Console.ReadLine());
            if (y2 < 1 || y2 > 12)
            {
                Console.WriteLine($"Нет такого месяца как {y2}");
                return;
            }
            Console.WriteLine("День");
            int z2 = Convert.ToInt32(Console.ReadLine());
            if (y2 == 2) //если месяц февраль, то проверяем на високосный год
            {
                if (x2 % 4 == 0)
                {
                    if (z2 < 1 || z2 > 29)
                    {
                        Console.WriteLine($"Уууупс... В этом месяце нет такого дня как {z2}");
                        return;
                    }
                }
                else
                {
                    if (z2 < 1 || z2 > 28)
                    {
                        Console.WriteLine($"Уууупс... В этом месяце нет такого дня как {z2}");
                        return;
                    }
                }
            }
            else if (y2 == 1 | y2 == 3 | y2 == 5 | y2 == 7 | y2 == 8 | y2 == 10 | y2 == 12) //если у месяца всего 31 день, то выполняем проверку на дни
            {
                if (z2 < 1 || z2 > 31)
                {
                    Console.WriteLine($"Уууупс... В этом месяце нет такого дня как {z2}");
                    return;
                }
            }
            else if (y2 == 4 | y2 == 6 | y2 == 9 | y2 == 11) //если у месяца всего 30 дней, то выполняем проверку
            {
                if (z2 < 1 || z2 > 30)
                {
                    Console.WriteLine($"Уууупс... В этом месяце нет такого дня как {z2}");
                    return;
                }
            }            

            int razg = x - x2;
            if (y2 > y) 
            {
                razg -= 1;
            }
            else if(y2 == y) 
            {
                if (z2 > z) 
                {
                    razg -= 1;
                }   
            }
            Console.WriteLine($"Привет {name}, твой возраст равен {razg} лет");
        }  
    }
}
