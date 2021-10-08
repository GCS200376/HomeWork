using System;
using System.Collections.Generic;
using System.Text;

namespace abstactionDEMO
{
    public class studentManage
    {
        private List<student> list;

        public studentManage()
        {
            list = new List<student>();
        }

        public void Add()
        {
            student s = new student();
            s.InputInfo();
            list.Add(s);
        }

        public void ShowAll()
        {
            foreach (var s in list)
                s.ShowInfo();
        }

        public void SearchbyID(int id)
        {
            bool found = false;
            foreach(var s in list)
                if(s.ID == id)
                {
                    s.ShowInfo();
                    found = true;
                    break;
                }
            if (!found)
                Console.WriteLine("\nNot found!");
        }

        public void ShowAllScholarship()
        {
            bool found = false;
            foreach (var s in list)
                if(s.ScholarshipCheck())
                {
                    s.ShowInfo();
                    found = true;
                }
            if (!found)
                Console.WriteLine("\nNot found!");
        }

        public int menu()
        {
            int option;
            Console.WriteLine("\n----STUDENT MANAGEMENT SYSTEM----");
            Console.WriteLine("\t1. Add new student\n\t. Show all\n\t. Search by ID");
            Console.WriteLine("\t4. Show scholarship student\n\t5. Exit");
            Console.WriteLine("Please input your option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
