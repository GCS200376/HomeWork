using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class EmployeePartTime : Employee
    {
        private int work_hour;

        public EmployeePartTime()
        { }

        public EmployeePartTime(int WH, string Id, string N, string A) : base(Id,N,A)
        {
            work_hour = WH;
        }

        public int Time
        {
            get { return work_hour; }
            set { work_hour = value; }
        }

        public override void inputInfo()
        {
            base.inputInfo();
            partTime = true;
            Console.WriteLine("Please enter work hour:");
            work_hour = int.Parse(Console.ReadLine());
        }

        public override void printInfo()
        {
            base.printInfo();
            Console.WriteLine("Work hour is " + this.work_hour);
            Console.WriteLine("Calculated salary is " + calculateSalary() + "\n");
        }

        public override double calculateSalary()
        {
            return work_hour * 15;
        }
    }
}
