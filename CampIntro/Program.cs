using System;

namespace CampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exp = "afdas";
            int exp1 = exp.Length;
            double exp2 = exp1 * 3.4;

            string[] expArr = new string[] { exp, "asdfasf" };

            Course[] AllCources = new Course[2];
            AllCources[0] = new Course();
            AllCources[1] = new Course();
            AllCources[0].CourseName = exp;
            AllCources[0].TutorName = "Hakan";
            AllCources[0].ViewRating = 81.3;
            AllCources[1].CourseName = exp + "course2";
            AllCources[1].TutorName = "Veli";
            AllCources[1].ViewRating = 73;


            if (true)
            {
                Console.WriteLine(exp2);
            }

            for (int i = 0; i < expArr.Length; i++)
            {
                Console.WriteLine(expArr[i]);
            }

            foreach (Course eachCourse in AllCources)
            {
                Console.WriteLine(eachCourse.CourseName + "\n" + eachCourse.TutorName + "\n" + eachCourse.ViewRating);
            }
        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string TutorName { get; set; }
        public double ViewRating { get; set; }
    }
}
