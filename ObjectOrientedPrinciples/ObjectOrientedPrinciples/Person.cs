using System;
using System.Collections.Generic;

namespace ObjectOrientedPrinciples
{
    public abstract class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        private decimal salary;
        public decimal Salary { get => salary; set { if (value > -1) value = salary; else Console.WriteLine("Wrong input"); } }
        public List<String> addresses;

        public Person()
        {
            
        }

        public Person(int id, string name, DateTime birthday, decimal salary, string Address)
        {
            ID = id;
            Name = name;
            BirthDay = birthday;
            if(salary < 0)
            {
                Console.WriteLine("Wrong input. salary will be 0");
            }
            else
            {
                this.salary = salary;
            }
            addresses.Add(Address);
        }
        public List<string> GetAllAddresses()
        {
            return addresses;
        }

        public void insertAddress(string address)
        {
            addresses.Add(address);
        }

        public virtual decimal calculateSalary()
        {
            return 0;
        }

        public virtual int calculateAge()
        {
            DateTime now = DateTime.Now;
            return now.Year - BirthDay.Year;
        }
    }
}
