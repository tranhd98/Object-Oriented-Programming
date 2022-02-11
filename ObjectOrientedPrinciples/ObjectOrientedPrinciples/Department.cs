using System;
using System.Collections.Generic;

namespace ObjectOrientedPrinciples
{
    public class Department
    {
        public String Head { set; get; }
        public int ID { set; get; }
        public String Name { set; get; }
        private List<Course> courses;
        public Department(int ID, String Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        public void insertCourses(Course course)
        {
            courses.Add(course);
        }
        public List<Course> listCourses()
        {
            return courses;
        }
    }
}
