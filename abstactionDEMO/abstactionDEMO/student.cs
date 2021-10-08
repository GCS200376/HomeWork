using System;
using System.Collections.Generic;
using System.Text;

namespace abstactionDEMO
{
    public class student:person
    {
        private int id;
        private float avgMark;
        private string email;

        public override void InputInfo()
        {
            Console.WriteLine("\nInput id: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInput name: ");
            name = Console.ReadLine();
            Console.WriteLine("\nInput birth day: ");
            birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("\nInput sex: ");
            sex = bool.Parse(Console.ReadLine());
            Console.WriteLine("\nInput address: ");
            address = Console.ReadLine();
            Console.WriteLine("\nInput average mark: ");
            avgMark = float.Parse(Console.ReadLine());
            Console.WriteLine("\nInput email: ");
            email = Console.ReadLine();
        }

        public override void ShowInfo()
        {
            Console.WriteLine("\nID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Birth day: " + birthdate);
            Console.WriteLine("Sex: " + sex);
            Console.WriteLine("Adress: " + address);
            Console.WriteLine("Average mark: " + avgMark);
            Console.WriteLine("Email: " + email);
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public float Mark
        {
            get { return avgMark; }
            set { avgMark = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public bool ScholarshipCheck()
        {
            if (avgMark >= 8)
                return true;
            return false;
        }
    }
}
