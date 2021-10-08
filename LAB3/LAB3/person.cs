using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3
{
    public abstract class person
    {
        protected int id;
        protected string name;

        public person()
        {

        }

        public person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual void Display()
        {
            Console.WriteLine("\nID:" + id);
            Console.WriteLine("Name:" + name);
        }

        public abstract void Input();
    }
}
