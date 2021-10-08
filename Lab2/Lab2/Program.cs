using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        public void Menu()
        {
            Console.WriteLine("PLease choose option below:");
            Console.WriteLine("1. Add employee");
            Console.WriteLine("2. Display all");
            Console.WriteLine("3. Search by ID");
            Console.WriteLine("0. Exit");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 0:
                    break;
            }
        }

        public void Partorfull()
        {
            Console.WriteLine("Full time or part time");
            Console.WriteLine("1. Full time");
            Console.WriteLine("1. Part time");
        }

        static void Main(string[] args)
        {
            int option = 0;
            Employeemanage manage = new Employeemanage();
            do
            {
                
                Console.WriteLine("PLease choose option below:");
                Console.WriteLine("1. Add employee");
                Console.WriteLine("2. Display all");
                Console.WriteLine("3. Search by ID");
                Console.WriteLine("0. Exit");

                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        manage.add();
                        break;
                    case 2:
                        manage.showall();
                        break;
                    case 3:
                        Console.WriteLine("Please enter ID");
                        int id = int.Parse(Console.ReadLine());
                        manage.searchbyId(id);
                        break;
                    case 0:
                        break;
                }

            } while (option != 0);
            
        }
    }
}
