using System;
using System.Collections.Generic;

namespace Assignment5
{
    public class PhoneBook: Phone
    {
        private List<DataPhone> PhoneList;
        private static PhoneBook instance = null;

        private PhoneBook()
        {
            PhoneList = new List<DataPhone>();
        }
        public static PhoneBook GetInstance()
        {
            if(instance == null)
            {
                instance = new PhoneBook();
            } 
            return instance;
        }

        public override void InsertPhone(string name, string phone)
        {
           foreach(DataPhone dp in PhoneList)
            {
                if(dp.Name.Equals(name))
                {
                    foreach(string p in dp.Phone)
                    {
                        if (phone.Equals(p))
                            return;
                    }
                    dp.Phone.Add(phone);
                    return;
                }

            }
            PhoneList.Add(new DataPhone(name, phone));
        }

        public override void RemovePhone(string name)
        {
           foreach(DataPhone dp in PhoneList)
            {
                if (dp.Name.Equals(name))
                {
                    PhoneList.Remove(dp);
                    break;
                }
            }
        }


        public override void UpdatePhone(string name, string newPhone)
        {
            foreach(DataPhone dp in PhoneList)
            {
                if(dp.Name.Equals(name))
                {
                    Console.WriteLine("Enter index to update: ");
                    for(int i = 0; i < dp.Phone.Count; i++)
                    {
                        Console.WriteLine(i+1 + " "  + dp.Phone[i]);
                    }
                    int index = Convert.ToInt16(Console.ReadLine());
                    dp.Phone[index] = newPhone;
                    break;
                }
            }
        }

        public override void SearchPhone(string name)
        {
          foreach(DataPhone dp in PhoneList)
            {
                if(dp.Name.Equals(name))
                {
                    for (int i = 0; i < dp.Phone.Count; i++)
                    {
                        Console.WriteLine(dp.Phone[i]);
                    }
                }
            }
        }
    }
}
