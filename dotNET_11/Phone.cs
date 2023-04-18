using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_11
{
    class Phone : Device
    {
        private string matrixType;
        private int ram;

        public Phone() :
            base()
        {
            Random rand = new Random();

            this.matrixType = "RandomCPU";
            this.ram = rand.Next(8, 32);
        }

        public Phone(string manufacturer, string model, int count, double price, string color, string matrixType, int ram) :
            base(manufacturer, model, count, price, color)
        {
            this.matrixType = matrixType;
            this.ram = ram;
        }

        public string MatrixType
        {
            get
            {
                return matrixType;
            }
            set
            {
                matrixType = value;
            }
        }

        public int RAM
        {
            get
            {
                return ram;
            }
            set
            {
                ram = value;
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Manufacturer's name:{Manufacturer}");
            Console.WriteLine($"Model:{Model}");
            Console.WriteLine($"Count:{Count}");
            Console.WriteLine($"Price:{Price}");
            Console.WriteLine($"Color:{Color}");
            Console.WriteLine($"Matrix type:{matrixType}");
            Console.WriteLine($"RAM:{ram}");
        }
    }
}
