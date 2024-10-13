using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5
{
    class VolumeCalculator
    {
        public double V {get; set;}
        public double CalculateVolume(double radius)
        {
            V = (4.0 / 3.0) * Math.PI * Math.Pow(radius,3);
            return V; 
        }

        public double CalculateVolume(double length, double width, double height)
        {
            V = length * width * height;
            return V;
        }

        public double CalculateVolume(double radius, double height)
        {
            V = Math.PI * Math.Pow(radius,2) * height;
            return V;
        }

        
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            VolumeCalculator sphere = new VolumeCalculator();
            Console.Write("Введите радиус: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            sphere.CalculateVolume(radius);
            Console.WriteLine($"Объем шара по радиусу равна {sphere.V}");

            VolumeCalculator cube = new VolumeCalculator();
            Console.Write("\nВведите длину: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту: ");
            double height = Convert.ToDouble(Console.ReadLine());
            cube.CalculateVolume(length, width, height);
            Console.WriteLine($"Объем прямоугольного параллелепипеда по радиусу равна {cube.V}");

            VolumeCalculator cylinder = new VolumeCalculator();
            Console.Write("\nВведите радиус цилиндра: ");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту цилиндра: ");
            height = Convert.ToDouble(Console.ReadLine());

            cylinder.CalculateVolume(radius, height);
            Console.WriteLine($"Объем цилиндра по радиусу равна {cylinder.V}");

            VolumeCalculator sumVol = new VolumeCalculator()
            {
                V = sphere.V + cube.V + cylinder.V
            };
            Console.WriteLine($"\nСумма объемов всех фигур равна {sumVol.V}");

            Console.ReadLine();

        }
    }
}
