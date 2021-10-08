using System;

namespace abstactionDEMO
{
    public class StudentTest
    {
        static void Main(string[] args)
        {
            studentManage test = new studentManage();
            int option = 0;
            do
            {
                option = test.menu();
                switch(option)
                {
                    case 1:
                        test.Add();
                        break;
                    case 2:
                        test.ShowAll();
                        break;
                    case 3:
                        Console.WriteLine("\nPlease intput ID:");
                        int i = int.Parse(Console.ReadLine());
                        test.SearchbyID(i);
                        break;
                    case 4:
                        test.ShowAllScholarship();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("\n\t Invalid option!");
                        break;
                }

            } while (option != 5);
        }
    }
}
