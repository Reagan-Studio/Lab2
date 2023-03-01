using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Tor
    {
        private string? _name;


        public double R1 { get; set; }
        public double R2 { get; set; }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public Tor() { }
        public Tor(double r1, double r2)
        {
            R1 = r1;
            R2 = r2;
        }
        public Tor(string name, double r1, double r2) : this(r1, r2)
        {
            _name = name;
        }
        public Tor(Tor tor)
        {
            Name = tor.Name;
            R1 = tor.R1;
            R2 = tor.R2;
        }


        public double Area()
        {
            return 4 * Math.PI * Math.PI * R1 * R2;
        }

        public double Volume()
        {
            return 2 * Math.PI * Math.PI * R1 * R2 * R2;
        }


        public void Input()
        {
            Console.WriteLine("Введите имя фигуры: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите радиус окружности вращения (направляющей): ");
            R1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус образующей окружности: ");
            R2 = Convert.ToDouble(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine($"Информация о фигуре:\nИмя: {Name}\nРадиус окружности вращения (направляющей): {R1}\nРадиус образующей окружности: {R2}\nПлощадь поверхности: {Area()}\nОбъем фигуры: {Volume()}");
        }


        public void CoefCopy(Tor tor, double coef)
        {
            R1 = coef * tor.R1;
            R2 = coef * tor.R2;
        }


        public void MIN_rename()
        {
            Name = "MIN" + Name;
        }

    }
}
