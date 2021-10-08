using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class EmployeeManage
    {
        private List<Employee> list;

        public EmployeeManage()
        {
            list = new List<Employee>();
        }

        public void addEmployee()
        {
            Employee e = new Employee();
            Console.WriteLine("Full time or part time:");
            Console.WriteLine("1. Full time");
            Console.WriteLine("2. Part time");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    e = new EmployeeFullTime();
                    break;
                case 2:
                    e = new EmployeePartTime();
                    break;
                default:
                    Console.WriteLine("Choise invalid, re-entry");
                    break;
            }

            e.inputInfo();
            list.Add(e);
        }

        public void showEmployees()
        {
            Console.WriteLine("\nList of employee:");
            foreach (var e in list)
                e.printInfo();
        }

        public void showPartTimeEmployees()
        {
            Console.WriteLine("\nList of employee:");
            foreach (var e in list)
                if (e.partTime == true)
                    e.printInfo();
        }

        public void searchbyId(string id)
        {
            bool found = false;
            foreach (var e in list)
            {
                if (e.ID == id)
                {
                    e.printInfo();
                    found = true;
                    break;
                }
            }
            if (!found)
                Console.WriteLine("Not found");
        }
    }
}
