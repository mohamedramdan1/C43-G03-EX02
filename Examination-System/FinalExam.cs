using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class FinalExam : Exam
    {
        #region Constructor
        public FinalExam(int time, int numberofQuestion) : base(time, numberofQuestion)
        {

        }
        #endregion

        #region Methods
        public override void CreateExamListQuestions()
        {
            Questions = new Questions[NumberofQuestion];
            for (int i = 0; i < Questions?.Length; i++)
            {
                int choice;
                do
                {
                    Console.Write($"Please Enter the Type of Question ({i+1}) (1 For True or False || 2 for MCQ ): ");
                }
                while (!(int.TryParse(Console.ReadLine(), out choice) && (choice is 1 or 2)));
                Console.Clear();

                if (choice == 1)
                {
                    Questions[i] = new TFQuestion();
                    Questions[i].AddQuestion();
                    
                }
                else
                {
                    Questions[i] = new McqQuestions();
                    Questions[i].AddQuestion();
                }
            }
        }

        public override void ShowExam()
        {
            if (Questions is not null)
            {
                foreach (var question in Questions)
                {
                    Console.WriteLine(question);

                    for (int i = 0; i < question?.AnswerList?.Length; i++)
                    {
                        Console.WriteLine(question.AnswerList[i]);
                    }
                    Console.WriteLine("---------------------------------");
                    int userAnswerId;
                    if (question?.GetType() == typeof(McqQuestions))
                    {
                        do
                        {
                            Console.Write("Please Enter The answer Id: ");
                        } while (!(int.TryParse(Console.ReadLine(), out userAnswerId) && (userAnswerId is 1 or 2 or 3)));
                    }
                    else
                    {
                        do
                        {
                            Console.Write("Please Enter The answer Id (1 For True | 2 For False): ");
                        } while (!(int.TryParse(Console.ReadLine(), out userAnswerId) && (userAnswerId is 1 or 2)));
                    }
                    Console.WriteLine("====================================================");
                    question.User_Answer.AnswerId = userAnswerId;
                    question.User_Answer.AnswerText = question?.AnswerList?[userAnswerId - 1].AnswerText;
                }
            }
            Console.Clear();

            int Grade = 0, TotalMarks = 0;

            Console.WriteLine("Your Answer : ");
            for (int i = 0; i < Questions?.Length; i++)
            {
                TotalMarks += Questions[i].Mark;
                if (Questions[i].User_Answer.AnswerId == Questions[i].Right_Answer.AnswerId)
                {
                    Grade += Questions[i].Mark;
                }

                Console.WriteLine($"Question {i+1})\t{Questions[i].Body} : {Questions[i].User_Answer.AnswerText}");
                Console.WriteLine($"Correct Answer : {Questions[i].Right_Answer.AnswerText}");
                Console.WriteLine("===============================");
            }
            Console.WriteLine($"Your Grade is {Grade} from {TotalMarks}");

        }
        #endregion
    }
}
