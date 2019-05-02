using System;

namespace Assignment5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            PhoneBook pb = PhoneBook.GetInstance();
       
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. Insert Phone");
                Console.WriteLine("2. Remove Phone");
                Console.WriteLine("3. Update Phone");
                Console.WriteLine("4. Search Phone");

                int choose = Convert.ToInt16(Console.ReadLine());
                if(choose > 0 && choose < 6)
                {
                    string name, phone;
                    switch (choose)
                    {
                        case 1:
                            Console.WriteLine("enter name: ");
                            name = Console.ReadLine();
                            Console.WriteLine("enter phone");
                            phone = Console.ReadLine();
                            pb.InsertPhone(name, phone);
                            break;
                        case 2:
                            Console.WriteLine("enter name: ");
                            name = Console.ReadLine();
                            pb.RemovePhone(name);
                            break;
                        case 3:
                            Console.WriteLine("enter name: ");
                            name = Console.ReadLine();
                            Console.WriteLine("enter phone");
                            phone = Console.ReadLine();
                            pb.UpdatePhone(name, phone);
                            break;
                        case 4:
                            Console.WriteLine("enter name: ");
                            name = Console.ReadLine();
                            pb.SearchPhone(name);
                            break;
                        default:
                            flag = false;
                            break;
                    }
                   
                }  
            }

        }
    
    }
}
