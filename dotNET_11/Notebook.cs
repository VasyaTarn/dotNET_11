using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_11
{
    class Notebook : Device
    {
        private string cpu;
        private string gpu;

        public Notebook() :
            base()
        {
            this.cpu = "RandomCPU";
            this.gpu = "RandomGPU";
        }

        public Notebook(string manufacturer, string model, int count, double price, string color, string cpu, string gpu) :
            base(manufacturer, model, count, price, color)
        {
            this.cpu = cpu;
            this.gpu = gpu;
        }

        public string CPU
        {
            get
            {
                return cpu;
            }
            set
            {
                cpu = value;
            }
        }

        public string GPU
        {
            get
            {
                return gpu;
            }
            set
            {
                gpu = value;
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Manufacturer's name:{Manufacturer}");
            Console.WriteLine($"Model:{Model}");
            Console.WriteLine($"Count:{Count}");
            Console.WriteLine($"Price:{Price}");
            Console.WriteLine($"Color:{Color}");
            Console.WriteLine($"CPU:{cpu}");
            Console.WriteLine($"GPU:{gpu}");
        }
    }
}
