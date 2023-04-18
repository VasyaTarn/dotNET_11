using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Device tablet = new Tablet();

            Device notebook = new Notebook();

            Device phone = new Phone();

            List<Device> shop = new List<Device>() { tablet, notebook, phone };


            for(int i = 0; i < shop.Count; i++)
            {
                shop[i].PrintInfo();
                Console.WriteLine();
            }

            

        }
    }
}
