using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class TFQuestion : Questions
    {
        #region Property
        public override string? Header => "True | false Question";

        #endregion

        #region Constructor
        public TFQuestion()
        {
            AnswerList = new Answers[2];
            AnswerList[0] = new Answers(1, "True");
            AnswerList[1] = new Answers(2, "False");
        }
        #endregion

        #region Methods
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
            Mark = mark;

            int right_answer_ID;
            do
            {
                Console.WriteLine("Please Enter the right answer id (1 for true | 2 for false): ");
            }
            while (!int.TryParse(Console.ReadLine(), out right_answer_ID) || right_answer_ID < 0 || !(right_answer_ID is 1 or 2));
            Right_Answer.AnswerId = right_answer_ID;
            Right_Answer.AnswerText = AnswerList?[right_answer_ID - 1].AnswerText;

            Console.Clear();
        }
        #endregion
    }
}
