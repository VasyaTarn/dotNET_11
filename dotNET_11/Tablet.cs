using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_11
{
    class Tablet : Device
    {
        private double diagonal;
        private int memory;

        public Tablet() :
            base()
        {
            Random rand = new Random();

            this.diagonal = rand.Next(5, 15);
            this.memory = rand.Next(8, 128);
        }

        public Tablet(string manufacturer, string model, int count, double price, string color, double diagonal, int memory) :
            base(manufacturer, model, count, price, color)
        {
            Random rand = new Random();

            this.diagonal = diagonal;
            this.memory = memory;
        }

        public double Diagonal
        {
            get
            {
                return diagonal;
            }
            set
            {
                diagonal = value;
            }
        }

        public int Memory
        {
            get
            {
                return memory;
            }
            set
            {
                memory = value;
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Manufacturer's name:{Manufacturer}");
            Console.WriteLine($"Model:{Model}");
            Console.WriteLine($"Count:{Count}");
            Console.WriteLine($"Price:{Price}");
            Console.WriteLine($"Color:{Color}");
            Console.WriteLine($"Display diagonal:{diagonal}");
            Console.WriteLine($"Number of memory(Gb):{memory}");
        }
    }
}
