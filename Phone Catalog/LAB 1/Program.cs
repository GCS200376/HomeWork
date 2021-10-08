using System;

namespace LAB_1
{
    class Test
    {
        static void Main(string[] args)
        {
            int option = 6;
            string model;
            Catalog manage = new Catalog();

            do
            {
                Console.WriteLine("PLease choose option below:");
                Console.WriteLine("1. Add new phone to catalog");
                Console.WriteLine("2. Display all phone");
                Console.WriteLine("3. Search by model");
                Console.WriteLine("4. delete by model");
                Console.WriteLine("5. Update by model");
                Console.WriteLine("6. Exit\n");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        manage.add();
                        break;
                    case 2:
                        manage.display();
                        break;
                    case 3:
                        Console.WriteLine("Please enter model");
                        model = Console.ReadLine();
                        manage.search(model);
                        break;
                    case 4:
                        Console.WriteLine("Please enter model");
                        model = Console.ReadLine();
                        manage.delete(model);
                        break;
                    case 5:
                        Console.WriteLine("Please enter model");
                        model = Console.ReadLine();
                        manage.update(model);
                        break;
                    case 6:
                        break;
                }
            } while (option != 6);

        }
    }
}
