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
        #endregion

        #region Constructor

        #endregion

    }
}
