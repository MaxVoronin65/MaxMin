using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит данные
            Console.WriteLine("Формула для которой подбираем значения: Z = max(A + 1, min(B, C + D))      |");
            Console.WriteLine("___________________________________________________________________________|");
            Console.WriteLine("~");
            Console.WriteLine("Найдем значение min, для этого введем значения (Для продолжения нажми Enter)");
            Console.ReadKey();
            Console.WriteLine("Введи значение для B");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введи значение для C");
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введи значение для D");
            double D = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Теперь введем значение A");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Все значения введены, для рассчета формула нажмите Enter");
            Console.ReadKey();

            //Метод нахождения решения данной задачи
            double Z;
            double Max()
            {
                double Min = 0;
                double G = C + D;
                double A1 = A + 1;
                if (B < G)
                {
                    Min = B;
                }
                else
                {
                    Min = G;
                }
                if (A1 > Min)
                {
                    Z = A1;
                }
                else
                {
                    Z = Min;
                }
                return Z;
            }

            //Вывод ответа на экран
            double sum = Max();
            Console.WriteLine("В формуле max(A + 1, min(B, C + D)) Z = {0}", sum);
            Console.ReadKey();
        }
    }
}
