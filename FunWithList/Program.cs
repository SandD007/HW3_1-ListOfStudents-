namespace FunWithList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var myBursa = new ListOfStudents<Student>();

            myBursa.Add(new Student("Vasia", 19, Group.S412));
            myBursa.Add(new Student("Petro", 17, Group.S413));

            Student[] newPeople = new Student[]
            {
                new Student("Natasha", 18, Group.S412),
                new Student("Dima", 17, Group.S413),
            };

            myBursa.AddRange(newPeople);

            myBursa.Sort();

            myBursa.Remove(new Student("Dima", 17, Group.S413));

            myBursa.RemoveAt(1);

            myBursa.Introduse();
        }
    }
}