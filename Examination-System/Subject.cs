using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Subject
    {
        #region Property
        public int subject_id { get; set; }
        public string? subject_name { get; set; }
        public Exam? Exam { get; set; }
        #endregion

        #region Constructor
        public Subject(int subject_id, string? subject_name)
        {
            this.subject_id = subject_id;
            this.subject_name = subject_name;
        }
        #endregion

        #region Methods
        public void CreateExam()
        {
            Console.WriteLine("Welcome to the Exam Creator!");
            int type, time, number_of_questions;
            do
            {
                Console.Write("Please Enter the type of Exam (1 for Practical | 2 for Final): ");
            } while (!(int.TryParse(Console.ReadLine(), out type) && (type is 1 or 2)));

            do
            {
                Console.Write("Please Enter the Time For Exam From (30 min to 180 min)): ");
            } while (!(int.TryParse(Console.ReadLine(), out time) && (time >= 30 && time <= 180)));

            do
            {
                Console.Write("Please Enter the Number of Questions You Wanted to Create : ");
            } while (!(int.TryParse(Console.ReadLine(), out number_of_questions) && (number_of_questions > 0)));

            Console.Clear();

            if (type == 1)     
                Exam = new PracticalExam(time, number_of_questions);
            else
                Exam = new FinalExam(time, number_of_questions);
            Console.Clear();
            
            Exam.CreateExamListQuestions();
        }
        #endregion
    }
}
