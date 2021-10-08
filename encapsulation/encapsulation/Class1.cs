using System;
using System.Collections.Generic;
using System.Text;

namespace encapsulation
{
    class Person
    {
        public string fullname;
        private int id;
        string email;
        protected double grade;

        public Person()
        {
            fullname = "A";
            id = 41;
            email = "B";
            grade = 23.332;
        }

        public void Display()
        {
            Console.WriteLine("\nFull name" + fullname);
            Console.WriteLine("\nID" + id);
            Console.WriteLine("\nEmail" + email);
            Console.WriteLine("\nGrade" + grade);
        }
    }
}
