using System;
using System.Collections.Generic;

namespace ObjectOrientedPrinciples
{
    public class Student: Person
    {
        Dictionary<Course, char> records;
        public Student(int id, string name, DateTime birthday, decimal salary, string Address): base(id, name, birthday, salary, Address)
        {

        }

        public void registerCourse(Course course)
        {
            if (records.ContainsKey(course))
            {
                Console.WriteLine("Already registered");
            }
            else
            {
                records.Add(course, 'N');
            }
        }

        public void gradeCourse(Course course,char gpa)
        {
            if (!records.ContainsKey(course))
            {
                Console.WriteLine("Course not exist");
            }
            else
            {
                records[course] = gpa;
            }
        }

        public double calculateGPA()
        {
            double gpa = 0;
            foreach(KeyValuePair<Course, Char> entry in records)
            {
                if (entry.Equals("A"))
                {
                    gpa += 4.0;
                }
                else if (entry.Equals("B"))
                {
                    gpa += 3.0;
                }
                else if (entry.Equals("C"))
                {
                    gpa += 2.0;
                }
                else if (entry.Equals("D"))
                {
                    gpa += 1.0;
                }
                else
                {
                    gpa += 0;
                }
            }
            return gpa / records.Count;
        }

    }
}
