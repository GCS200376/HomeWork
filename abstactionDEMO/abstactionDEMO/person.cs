using System;
using System.Collections.Generic;
using System.Text;

namespace abstactionDEMO
{
    public abstract class person
    {
        protected string name;
        protected bool sex;
        protected DateTime birthdate;
        protected string address;

        public person()
        { }

        public person(string name, bool sex, DateTime birthdate, string address)
        {
            this.name = name;
            this.sex = sex;
            this.birthdate = birthdate;
            this.address = address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public abstract void InputInfo();
        public abstract void ShowInfo();
    }
}
