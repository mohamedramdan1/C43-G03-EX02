using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Examination_System
{
    internal class Answers
    {
        #region Property
        public int AnswerId { get; set; }
        public string? AnswerText { get; set; }
        #endregion

        #region Constructor
        public Answers()
        {
            
        }
        public Answers(int answerId, string? answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{AnswerId}.  {AnswerText}";
        }
        #endregion
    }
}
