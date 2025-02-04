using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class McqQuestions : Questions
    {
        public override string? Header => "MCQ Question";

        public McqQuestions()
        {
            AnswerList = new Answers[3];
        }
        public override void AddQuestion()
        {
            Console.WriteLine(Header);
            do
            {
                Console.WriteLine("Please Enter the Body of Qusetion: ");
                Body = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(Body));

            int mark;
            do
            {
                Console.WriteLine("Please Enter the Mark of Qusetion: ");
            }
            while (!int.TryParse(Console.ReadLine(), out mark) || mark < 0);


            Console.WriteLine("The Choice Of Question: ");
            for (int i = 0; i < AnswerList?.Length; i++)
            {
                AnswerList[i] = new Answers() { AnswerId = i + 1 };
                do
                {
                    Console.Write($"Please Enter Choice number {i + 1} : ");
                    AnswerList[i].AnswerText = Console.ReadLine();
                }
                //check here if the AnswerTextnull or enter white space 
                while (string.IsNullOrWhiteSpace(AnswerList[i].AnswerText));
            }

            int right_answer_ID;
            do
            {
                Console.WriteLine("Please Specify the Right Choice Of Qusetion:");
            }
            while (!int.TryParse(Console.ReadLine(), out right_answer_ID) || right_answer_ID < 0 || !(right_answer_ID is 1 or 2 or 3));
            Right_Answer.AnswerId = right_answer_ID;
            Right_Answer.AnswerText = AnswerList?[right_answer_ID - 1].AnswerText;

            Console.Clear();

        }
    }
}
