using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Employeemanage
    {
        private List<Employee> list;

        public Employeemanage()
        {
            list = new List<Employee>();
        }

        public void add()
        {
            Employee e = new Employee();
            Console.WriteLine("Full time or part time");
            Console.WriteLine("1. Full time");
            Console.WriteLine("2. Part time");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    e = new Employeefullt();
                    break;
                case 2:
                    e = new Employeepartt();
                    break;
                default:
                    Console.WriteLine("Wrong answer now die");
                    break;
            }

            e.Input();
            list.Add(e);
        }

        public void showall()
        {
            Console.WriteLine("List of employee");
            foreach (var e in list)
                e.Display();
        }

        public void searchbyId(int id)
        {
            bool found = false;
            foreach (var e in list)
            {
                if (e.ID == id)
                {
                    e.Display();
                    found = true;
                    break;
                }
            }
            if (!found)
                Console.WriteLine("Not found"); 
        }
    }
}
