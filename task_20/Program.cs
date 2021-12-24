using System;

namespace task_20
{
    class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            while (true)
            {
                MyDelegate myDelegate = null;   //создаем делегат
                myDelegate += CircleLength; //добавляем методы
                myDelegate += CircleArea;
                myDelegate += CircleVolume;
                Console.Write("Введите радиус: r=");
                try
                {
                    myDelegate?.Invoke(Convert.ToDouble(Console.ReadLine()));   //пытаемся считать радиус
                }
                catch
                {
                    Console.WriteLine("Не удалось распознать радиус.");
                }
                Console.WriteLine();
            }
        }
        static double CircleLength(double r)    //расчет длины окружности
        {
            Console.WriteLine("Длина окружности радиусом {1}: {0}", 2 * Math.PI * r, r);
            return 2 * Math.PI * r;
        }
        static double CircleArea(double r)  //расчет площади круга
        {
            Console.WriteLine("Площадь круга радиусом {1}: {0}", Math.PI * r * r, r);
            return Math.PI * r * r;
        }
        static double CircleVolume(double r)    //расчет объема шара
        {
            Console.WriteLine("Объем шара радиусом {1}: {0}", (4 / 3) * Math.PI * r * r * r, r);
            return (4 / 3) * Math.PI * r * r * r;
        }
    }
}