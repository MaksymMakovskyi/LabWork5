using System;

namespace LabWork5._6
{
    // абстрактний клас Solid
    abstract class Solid
    {
        // абстрактний метод обчислення об'єму GetVolume()
        public abstract double GetVolume();
    }
    // успадкований клас Pyramid
    class Pyramid : Solid
    {
        public double a, h;
        public override double GetVolume()
        {
            double volume = (1.0/3) * Math.Pow(a, 2) * h;
            return volume;
        }
        public Pyramid(double a, double h)//конструктор
        {
            this.a = a;
            this.h = h;
        }
    }
    // успадкований клас Cone
    class Cone : Solid
    {
        public double r, h;
        public override double GetVolume()
        {
            double volume = (1.0/3) * Math.PI * Math.Pow(r, 2) * h;
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

            Solid s;
            s = new Pyramid(aPyramid, hPyramid);
            // викликається GetVolume() із Pyramid і об'єм виводиться в консоль
            Console.WriteLine($"Об'єм Пiрамiди: {s.GetVolume()}");

            s = new Cone(rCone, hCone);
            // викликається GetVolume() із Cone і об'єм виводиться в консоль
            Console.WriteLine($"Об'єм Конусу: {s.GetVolume()}");
        }
    }
}
