using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_1
{
    class Catalog
    {
        int i = 0;
        private List<Phone> catalog;
        private List<Phone> catalogT;

        public Catalog()
        {
            catalog = new List<Phone>();
            catalogT = new List<Phone>();
        }

        public void add()
        {
            Phone phone = new Phone();
            /*if(i == catalog.Capacity)
            {
                Console.WriteLine("\nCatalog full!!!");
                return;
            }*/

            phone.input();
            catalog.Add(phone);

            i++;
        }

        public void display()
        {
            if ( i == 0)
            {
                Console.WriteLine("\nThere are no avaiable phone in the catalog!!");
                return;
            }

            foreach (var a in catalog)
            {
                a.print();
            }
        }

        public void search(string M)
        {
            bool found = false;
            foreach (var phone in catalog)
            {
                if (phone.Model == M)
                {
                    phone.print();
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("\nNo valid phone of model" + M + "\n");
        }

        public void delete(string M)
        {
            bool found = false;

            foreach (var phone in catalog)
            {
                if (phone.Model != M)
                {
                    catalogT.Add(phone);
                    found = true;
                }
            }
            catalog = catalogT;
            if (found)
                Console.WriteLine("\nDone remove model:" + M + "\n");
            else
                Console.WriteLine("\nNo valid phone of model" + M + "\n");
        }

        public void update(string M)
        {
            bool found = false;
            foreach (var phone in catalog)
            {
                if (phone.Model == M)
                {
                    phone.print();
                    Console.WriteLine("\nInput new price:\n");
                    int p = int.Parse(Console.ReadLine());
                    while (p < 0)
                    {
                        Console.WriteLine("\nPrice unvalid, re-entry:");
                        p = int.Parse(Console.ReadLine());
                    }
                    phone.Price = p;

                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("\nNo valid phone of model" + M + "\n");
        }
    }
}
