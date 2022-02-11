using System;
using System.Collections.Generic;

namespace ObjectOrientedPrinciples
{
    public class Course
    {
        public int ID { get; set; }
        private List<Student> students;
        public Course(int id)
        {
            ID = id;
        }
        public void insertStudents(Student student)
        {
            students.Add(student);
        }
        public List<Student> getEnrolledStudents()
        {
            return students;
        }
    }
}
