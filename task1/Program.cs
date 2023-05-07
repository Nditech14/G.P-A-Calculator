using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Program
    {
        static void Main(string[] args)

        {
            int score;
            int course_unit;
            string course_code;
            int grade_unit;
            char grade;
            int weight_point;
            Console.WriteLine("Enter number of couse_code you want to grade: ");
            int num = int.Parse(Console.ReadLine());
            string remark;
            string data = " ";

            for (int i = 0; i < num; i++)
            {


                Console.WriteLine("Enter Course_code: ");
                course_code = Console.ReadLine();
                Console.WriteLine("Enter course_unit:  ");
                course_unit = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter score: ");
                score = int.Parse(Console.ReadLine());


                /* grade = score >= 70 ? 'A' :
                             score >= 60 ? 'B' :
                             score >= 50 ? 'C' :
                             score >= 45 ? 'D' :
                             score >= 40 ? 'E' :
                                           'F';
                 grade_unit = score >= 70 ? 5 :
                                  score >= 60 ? 4 :
                                  score >= 50 ? 3 :
                                  score >= 45 ? 2 :
                                  score >= 40 ? 1 :
                                                0;

                 weight_point = (grade_unit) * (course_unit);
                 string remark = score >= 70 ? "Excellent" :
                                 score >= 60 ? "Very Good" :
                                 score >= 50 ? " Good" :
                                 score >= 45 ? " Fair" :
                                 score >= 40 ? " Pass" :
                                               " Fail";  */
                if (score > 69 && score <= 100)
                {
                    grade = 'A'; grade_unit = 5; weight_point = (grade_unit) * (course_unit); remark = "Excellent";
                }
                else if (score > 59 && score <= 69)
                {
                    grade = 'B'; grade_unit = 4; weight_point = (grade_unit) * (course_unit); remark = "Very Good";

                }
                else if (score > 49 && score <= 59)
                {
                    grade = 'C'; grade_unit = 3; weight_point = (grade_unit) * (course_unit); remark = "Good";
                }
                else if (score > 44 && score <= 49)
                {
                    grade = 'D'; grade_unit = 2; weight_point = (grade_unit) * (course_unit); remark = "Fair";
                }
                else if (score > 39 && score <= 44)
                {
                    grade = 'E'; grade_unit = 1; weight_point = (grade_unit) * (course_unit); remark = "Pass";
                }
                else
                {
                    grade = 'F'; grade_unit = 0; weight_point = (grade_unit) * (course_unit); remark = "Fail";
                }
                data = data + $"|{course_code,-15}|{course_unit,-13}|{grade,-7}|{grade_unit,-11}|{weight_point,-14}|{remark,-19}\n";

            }

                Console.Clear();
                Console.WriteLine("This application model a Grade Point Average (GPA) calculator and prints the result.");
                Console.WriteLine("The result should be displayed in a tabular form as shown below:");
                Console.WriteLine(" |---------------|-------------|-------|------------|------------|---------------|");
                Console.WriteLine(" | COURSE _CODE  | COURSE UNIT | GRADE | GRADE-UNIT | WEIGHT Pt. |     REMARK    |");
                Console.WriteLine(" |---------------|-------------|-------|------------|------------|---------------|");

            Console.WriteLine(data);








            

        }
    }
}

 
