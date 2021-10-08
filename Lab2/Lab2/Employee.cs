using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Employee
    {
        protected int id;
        protected string name;
        protected string email;

        public int ID 
        {
            get { return id; }
            set { id = value; }
        }

        public string NAME
        {
            get { return name; }
            set { name = value; }
        }

        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }

        public virtual void Input()
        {
            Console.WriteLine("Please enter ID:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Name:");
            name = Console.ReadLine();
            Console.WriteLine("Please enter Email:");
            email = Console.ReadLine();
        }

        public virtual void Display() {
            Console.WriteLine("ID is " + this.id);
            Console.WriteLine("Name is " + this.name);
            Console.WriteLine("Email is " + this.email);
        }

    }
}
