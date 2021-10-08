using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class EmployeeFullTime : Employee
    {
        private double basic_salary;
        private int overtime;
        private int typeOfPosition;
        
        public EmployeeFullTime()
        { }

        public EmployeeFullTime(double S, int O, int P, string Id, string N, string A) : base(Id, N, A)
        {
            basic_salary = S;
            overtime = O;
            typeOfPosition = P;
        }

        public double Bsalary
        {
            get { return basic_salary; }
            set { basic_salary = value; }
        }
        public int OverTime
        {
            get { return overtime; }
            set { overtime = value; }
        }
        public int Position
        {
            get { return typeOfPosition; }
            set { typeOfPosition = value; }
        }

        public override void inputInfo()
        {
            base.inputInfo();
            partTime = false;
            Console.WriteLine("Please enter basic salary:");
            basic_salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter over time:");
            overtime = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter position type:");
            int T = int.Parse(Console.ReadLine());
            while (T != 1 & T != 2 & T!= 3)
            {
                Console.WriteLine("Position invalid, re-entry:");
                T = int.Parse(Console.ReadLine());
            }
            typeOfPosition = T;
        }

        public override void printInfo()
        {
            base.printInfo();
            Console.WriteLine("Basic salary is " + this.basic_salary);
            Console.WriteLine("Overtime is " + this.overtime);
            Console.WriteLine("Position type is " + this.typeOfPosition);
            Console.WriteLine("Calculated salary is " + calculateSalary() + "\n");
        }

        public override double calculateSalary()
        {
            int allowance;
            if (typeOfPosition == 1)
                allowance = 200;
            if (typeOfPosition == 3)
                allowance = 300;
            else allowance = 500;

            return basic_salary + allowance + (overtime * 50);
        }


    }
}
