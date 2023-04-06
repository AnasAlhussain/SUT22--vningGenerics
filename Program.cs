namespace SUT22_ÖvningGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentCollection students = new StudentCollection();
            students.Add(new Student(1, 75, 88));
            students.Add(new Student(2, 77, 88));
            students.Add(new Student(3, 60, 88));
            students.Add(new Student(4, 68, 88));

            DisplayData(students);



            //students.Add(new Student(3, 60, 88));

            //students.Remove(new Student(2, 77, 88));


            Student studentCheck = new Student(2, 77, 88);
            Console.WriteLine("Conaines ID :{0} , Grade {1} , Total : {2} {3}" , 
                studentCheck.ID.ToString(),studentCheck.Grade.ToString(),studentCheck.Total.ToString(),
                students.Contains(studentCheck).ToString());




            students.Remove(new Student(2, 77, 88));
            Console.WriteLine("---------------");
            Student studentCheck2 = new Student(2, 77, 88);
            Console.WriteLine("Conaines ID :{0} , Grade {1} , Total : {2} {3}",
                studentCheck2.ID.ToString(), studentCheck2.Grade.ToString(), studentCheck2.Total.ToString(),
                students.Contains(studentCheck2,new StudentSameValue()).ToString());

            DisplayData(students);

            Console.ReadKey();

        }


        public static void DisplayData(StudentCollection studentsList)
        {
            Console.WriteLine("\nID\tGrade\tTotal\tHash Code");
            foreach(Student s in studentsList)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                    s.ID.ToString(),s.Grade.ToString(),s.Total.ToString(),s.GetHashCode().ToString());
            }
        }

    }
}