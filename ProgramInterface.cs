using System;

namespace LabWork5._7
{
    // інтерфейс ISolid
    interface ISolid
    {
        // метод обчислення об'єму GetVolume()
        double GetVolume();
    }
    // клас Pyramid, що реалізує інтерфейс ISolid
    class Pyramid : ISolid
    {
        public double a, h;
        public double GetVolume()
        {
            double volume = (1.0 / 3) * Math.Pow(a, 2) * h;
            return volume;
        }
        public Pyramid(double a, double h)//конструктор
        {
            this.a = a;
            this.h = h;
        }
    }
    // клас Cone, що реалізує інтерфейс ISolid
    class Cone : ISolid
    {
        public double r, h;
        public double GetVolume()
        {
            double volume = (1.0 / 3) * Math.PI * Math.Pow(r, 2) * h;
            return volume;
        }
        public Cone(double r, double h)//конструктор
        {
            this.r = r;
            this.h = h;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double aPyramid, hPyramid, rCone, hCone;

            // задання довжини сторони і висоти піраміди
            Console.Write("Введiть довжину сторони основи пiрамiди:   ");
            aPyramid = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введiть висоту пiрамiди:   ");
            hPyramid = Convert.ToDouble(Console.ReadLine());

            // задання радіусу основи і висоти конуса
            Console.Write("Введiть радiус основи конуса:   ");
            rCone = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введiть висоту конуса:   ");
            hCone = Convert.ToDouble(Console.ReadLine());

            ISolid s;
            s = new Pyramid(aPyramid, hPyramid);
            // викликається GetVolume() із Pyramid і об'єм виводиться в консоль
            Console.WriteLine($"Об'єм Пiрамiди: {s.GetVolume()}");

            s = new Cone(rCone, hCone);
            // викликається GetVolume() із Cone і об'єм виводиться в консоль
            Console.WriteLine($"Об'єм Конусу: {s.GetVolume()}");
        }
    }
}
