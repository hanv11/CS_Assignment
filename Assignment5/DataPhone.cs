using System;
using System.Collections.Generic;
namespace Assignment5
{
    public class DataPhone
    {
        public DataPhone()
        {
        }
        private string name;
        private List<string> phone = new List<string>();

        public DataPhone(string name, string phone)
        {
            this.name = name;
            this.phone.Add(phone);
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        public List<string> Phone
        {
            get
            {
                return phone;
            }
            set
            {
                this.phone = value;
            }
        }
    }
}
