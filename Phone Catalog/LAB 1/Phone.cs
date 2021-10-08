using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_1
{
    class Phone
    {
        protected string model;
        protected int price;
        protected string brand;
        protected int year;

        public Phone()
        {
        }

        public Phone(string m, int p, string b, int y)
        {
            model = m;
            price = p;
            brand = b;
            year = y;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public void print ()
        {
            Console.WriteLine("\nModel: " + this.model);
            Console.WriteLine("\nPrice: " + this.price);
            Console.WriteLine("\nBrand: " + this.brand.);
            Console.WriteLine("\nPublic in: " + this.year + "\n");
        }

        public void input()
        {
            //code for entry model
            Console.WriteLine("\nPlease enter model:");
            model = Console.ReadLine();

            //code for entry valid price
            Console.WriteLine("\nPlease enter price:");
            int p = int.Parse(Console.ReadLine());
            while (p < 0)
            {
                Console.WriteLine("\nPrice unvalid, re-entry:");
                p = int.Parse(Console.ReadLine());
            }
            price = p;

            //code for entry valid brand
            Console.WriteLine("\nPlease enter Brand:");
            String[] ValidB = { "LG", "Samsung", "Motorola", "Sony", "Nokia" };
            String B = Console.ReadLine();
            bool found = false;
            do
            {
                foreach (string z in ValidB)
                {
                    if (B == z)
                    {
                        brand = B;
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("\nBrand unvallid, re-entry:");
                    B = Console.ReadLine();
                }
            }
            while (!found);
            brand = B;

            //code for entry valid year
            Console.WriteLine("\nPlease enter published year:");
            int y = int.Parse(Console.ReadLine());
            while (y < 1970 & 2012 < y)
            {
                Console.WriteLine("\nYear unvalid, re-entry:");
                y = int.Parse(Console.ReadLine());
            }
            year = y;
        }
    }
}
