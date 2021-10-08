using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Employeepartt : Employee
    {
        private Double workhour;

        public Double WORKHOUR
        {
            get { return workhour; }
            set { workhour = value; }
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Please enter workhour:");
            workhour = double.Parse(Console.ReadLine());
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Workhour is " + this.workhour);
        }
    }
}
