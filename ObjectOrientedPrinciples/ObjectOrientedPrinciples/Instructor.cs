using System;
using System.Collections.Generic;

namespace ObjectOrientedPrinciples
{
    public class Instructor: Person
    {

        private Department department;
        private DateTime joinDate;
        public DateTime JoinDate { get => joinDate; set { value = joinDate; } }
        private string role;
        public string Role { get => role; set { value = role; } }
        public Instructor()
        {

        }
        public Instructor(int id, string name, DateTime birthday, decimal salary, string Address, DateTime joinDate, string role, Department department):base(id,name, birthday,salary,Address)
        {
            this.joinDate = joinDate;
            this.role = role;
            if(this.role == "Head")
            {
                department.Head = name;
            }
        }
        public override decimal calculateSalary()
        {
            int periodWork = DateTime.Now.Year - joinDate.Year;
            if(periodWork < 5)
            {
                Salary += ((10 * Salary) / 100);
            }
            else if(periodWork >= 5 && periodWork <= 10)
            {
                Salary += ((20 * Salary) / 100);
            }
            else
            {
                Salary += ((30 * Salary) / 100);
            }
            return Salary;
        }

    }
}
