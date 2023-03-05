using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithList
{
    public enum Group
    {
        S412,
        S413,
    }

    public class Student
    {
        public Student(string name, int age, Group group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        private string Name { get; set; }

        private int Age { get; set; }

        private Group Group { get; set; }

        public void SayHello()
        {
            Console.WriteLine("Hello, i`m " + this.Name + " " + this.Age + " years old, I study in the " + this.Group + " grade.");
        }

        public string GetName()
        {
            return this.Name;
        }

        public int GetAge()
        {
            return this.Age;
        }

        public Group GetGroup()
        {
            return this.Group;
        }
    }
}
