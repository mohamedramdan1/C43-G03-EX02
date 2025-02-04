using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal abstract class Exam
    {
        #region Property
        public int Time { get; set; }
        public int NumberofQuestion { get; set; }
        public Questions[]? Questions { get; set; }
        #endregion

        #region Constructor
        public Exam(int time, int numberofQuestion, Questions[]? questions)
        {
            Time = time;
            NumberofQuestion = numberofQuestion;
            Questions = questions;
        }
        public Exam(int time, int numberofQuestion)
        {
            Time = time;
            NumberofQuestion = numberofQuestion;
        }
        #endregion

        #region Methods
        public abstract void CreateExamListQuestions();
        public abstract void ShowExam();
        #endregion
    }
}
