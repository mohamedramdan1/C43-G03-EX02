using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal abstract class Questions
    {
        #region Property
        public abstract string? Header { get; }
        public string? Body { get; set; }
        public int Mark { get; set; }
        public Answers[]? AnswerList { get; set; }
        public Answers? Right_Answer { get; set; }
        public Answers? User_Answer { get; set; }
        #endregion

        #region Constructor
        public Questions()
        {
            Right_Answer = new Answers();
            User_Answer = new Answers();
        }
            #endregion

        #region Methods
        public abstract void AddQuestion();

        public override string ToString()
        {
            return $"{Header}\tMark:{Mark}\n" +
               $"\n{Body}\n"; 
        }
        #endregion
    }
}
