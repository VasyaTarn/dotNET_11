using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_11
{
    abstract class Device
    {
        private string manufacturer;
        private string model;
        private int count;
        private double price;
        private string color;

        public Device()
        {
            Random rand = new Random();

            this.manufacturer = "RandomManufacturer";
            this.model = "RandomModel";
            this.count = rand.Next(1, 50);
            this.price = rand.Next(1000, 50000);
            this.color = "RandomColor";
        }

        public Device(string manufacturer, string model, int count, double price, string color)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.count = count;
            this.price = price;
            this.color = color;
        }



        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        abstract public void PrintInfo();
    }
}
