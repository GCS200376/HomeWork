using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3
{
    class employee : person
    {
        private double salary;

        public employee()
            :base()
        { }

        public employee(int id, string name, double salary) : base(id,name)
        {
            this.salary = salary;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Salary: " + salary);
        }

        public override void Input()
        {
            Console.WriteLine("Input ID:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Name:");
            name = Console.ReadLine();
            Console.WriteLine("Input salary:");
            salary = double.Parse(Console.ReadLine());
        }
    }
}
