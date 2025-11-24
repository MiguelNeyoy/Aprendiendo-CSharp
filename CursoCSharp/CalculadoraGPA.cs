using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    internal class CalculadoraGPA
    {
        public static void resultadoGPA()
        {
            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "ComputerScienceI";
            string course5Name = "Psychology 101";

            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;

            int gradeA = 3;
            int gradeB = 4;

            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeB;
            int course4Grade = gradeB;
            int course5Grade = gradeA;

            Console.WriteLine("Curso\t\t\tGrado\t\tCréditos");
            Console.WriteLine(course1Name + "\t\t" + course1Grade + "\t\t" + course1Credit);
            Console.WriteLine(course2Name + "\t\t" + course2Grade + "\t\t" + course2Credit);
            Console.WriteLine(course3Name + "\t\t" + course3Grade + "\t\t" + course3Credit);
            Console.WriteLine(course4Name + "\t" + course4Grade + "\t\t" + course4Credit);
            Console.WriteLine(course5Name + "\t\t" + course5Grade + "\t\t" + course5Credit);

            float total = 
                      (course1Credit * course1Grade) +
                      (course2Credit * course2Grade) +
                      (course3Credit * course3Grade) +
                      (course4Credit * course4Grade) +
                      (course5Credit * course5Grade);

            Console.WriteLine("Final GPA for " + studentName + ":" + total/17);
        }
        




    }
}
