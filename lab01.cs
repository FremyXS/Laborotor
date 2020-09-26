using System;
using System.Net.Http;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Lav01_ver3
{
    class Program
    {

        static void Main(string[] args)
        {
            DateTime dt = DateTime.Today;
            string data1 = dt.ToString("d");
            int datden = Convert.ToInt32(Convert.ToString(data1[0]) + Convert.ToString(data1[1]));
            int datmes = Convert.ToInt32(Convert.ToString(data1[3]) + Convert.ToString(data1[4]));
            int datgod = Convert.ToInt32(Convert.ToString(data1[6]) + Convert.ToString(data1[7]) + Convert.ToString(data1[8]) + Convert.ToString(data1[9]));
            Console.WriteLine("Привет. Введи своё Имя:");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}. Теперь введи дату своего дня рождения:");
            Console.WriteLine("Год");
            int god = 0;
            ProvGod(datgod, ref god);
            Console.WriteLine("Месяц");
            int mes = 0;
            ProvMes(ref mes);
            Console.WriteLine("День");
            int den = 0;
            ProvDnya(mes, god, ref den);
            int vozrast = datgod - god;
            if (mes > datmes) 
                vozrast -= 1;
            else if (mes == datmes)
            {
                if (den > datden)
                    vozrast -= 1;
            }
            Console.WriteLine($"Привет {name}. Ваш возраст равен {vozrast} лет");
        }
        static void ProvMes(ref int x) 
        {
            int mes;
            do
            {
                mes = Convert.ToInt32(Console.ReadLine());
                if (mes < 1 || mes > 12)
                    Console.WriteLine("Нет такого месяца");
                else
                    break;
            } while (mes < 1 || mes > 12);
            x += mes;
        }
        static void ProvDnya(int mes, int god, ref int x) 
        {
            int den;
            if (mes == 2)
            {
                if (god % 4 == 0)
                {
                    do
                    {
                        den = Convert.ToInt32(Console.ReadLine());
                        if (den < 1 || den > 29)
                            Console.WriteLine($"Нет такого дня как {den}");
                        else
                            break;
                    } while (den < 1 || den > 29);
                }
                else
                {
                    do
                    {
                        den = Convert.ToInt32(Console.ReadLine());
                        if (den < 1 || den > 28)
                            Console.WriteLine($"Нет такого дня как {den}");
                        else
                            break;
                    } while (den < 1 || den > 28);
                }
            }
            else if (mes == 1 | mes == 3 | mes == 5 | mes == 7 | mes == 8 | mes == 10 | mes == 12)
            {
                den = Convert.ToInt32(Console.ReadLine());
                if (den < 1 || den > 31)
                    Console.WriteLine($"Нет такого дня как {den}");
            }
            else
            {
                den = Convert.ToInt32(Console.ReadLine());
                if (den < 1 || den > 30)
                    Console.WriteLine($"Нет такого дня как {den}");
            }
            x += den;
        }
        static void ProvGod(int datgod, ref int x) 
        {
            int god;
            do
            {
                god = Convert.ToInt32(Console.ReadLine());
                if (god > datgod)
                    Console.WriteLine("Не верно. Ваш год дня рождения превышает больше сегоднешнего года.");
                else
                    break;
            } while (god > datgod);
            x += god;
        }
    }
}
