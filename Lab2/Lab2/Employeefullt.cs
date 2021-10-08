using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Employeefullt : Employee
    {
        private Double salary;

        public Double SALARY
        {
            get { return salary; }
            set { salary = value; }
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Please enter Salary:");
            salary = double.Parse(Console.ReadLine());
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Salary is " + this.salary);
        }
    }
}
