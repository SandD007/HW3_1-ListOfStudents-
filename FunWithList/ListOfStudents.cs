using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithList
{
    public class ListOfStudents<TStudent>
        where TStudent : Student
    {
        private TStudent[] _students;
        private int _count;

        public ListOfStudents()
        {
            this._students = new TStudent[0];
        }

        public TStudent[] GetStudents()
        {
            return this._students;
        }

        public void Add(TStudent student)
        {
            if (this._students.Length == 0)
            {
                this._students = new TStudent[1];
                this._students[0] = student;
                this._count++;
                return;
            }

            if (this._students.Length == this._count)
            {
                Array.Resize(ref this._students, this._students.Length * 2);
            }

            this._students[this._count++] = student;
        }

        public void AddRange(TStudent[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                this.Add(students[i]);
            }
        }

        public void Remove(TStudent student)
        {
            int index = -1;

            for (int i = 0; i < this._students.Length; i++)
            {
                if (this._students[i].GetName() == student.GetName() && this._students[i].GetAge() == student.GetAge() && this._students[i].GetGroup() == student.GetGroup())
                {
                    index = i; 
                    break;
                }
            }

            if (index >= 0)
            {
                for (int i = index; i < this._students.Length - 1; i++)
                {
                    this._students[i] = this._students[i + 1];
                }

                Array.Resize(ref this._students, this._students.Length - 1);
                this._count--;
            }
            else
            {
                Console.WriteLine("Did not find such a student.");
            }
        }

        public void RemoveAt(int index)
        {
            if (index <= this._count)
            {
                this.Remove(index);
            }
            else
            {
                Console.WriteLine("Enter the correct index");
            }
        }

        public void Sort()
        {
            Array.Sort(this._students, (x, y) => x.GetName().CompareTo(y.GetName()));
        }

        public void Introduse()
        {
            foreach (var student in this._students)
            {
                student.SayHello();
            }
        }

        private void Remove(int index)
        {
            if (index >= 0)
            {
                for (int i = index; i < this._students.Length - 1; i++)
                {
                    this._students[i] = this._students[i + 1];
                }

                Array.Resize(ref this._students, this._students.Length - 1);
                this._count--;
            }
            else
            {
                Console.WriteLine("Did not find such a student.");
            }
        }
    }
}
