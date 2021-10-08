using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            EmployeeManage manage = new EmployeeManage();
            do
            {

                Console.WriteLine("PLease choose option below:");
                Console.WriteLine("1. Add employee");
                Console.WriteLine("2. Show all employees");
                Console.WriteLine("3. Show part time employees");
                Console.WriteLine("4. Search employee by ID");
                Console.WriteLine("0. Exit");

                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        manage.addEmployee();
                        break;
                    case 2:
                        manage.showEmployees();
                        break;
                    case 3:
                        manage.showPartTimeEmployees();
                        break;
                    case 4:
                        Console.WriteLine("Please enter ID");
                        string id = Console.ReadLine();
                        manage.searchbyId(id);
                        break;
                    case 0:
                        break;
                }

            } while (option != 0);
        }
    }
}
