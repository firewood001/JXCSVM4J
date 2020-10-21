using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace JXVM4J.Interpreter
{
    public class JavaInstructionTable
    {
        #region private members
        
        /// <summary>
        /// This variable is used to store the Java native instructions, which is not related to any platform
        /// </summary>
        private Dictionary<int, JavaInstruction> _table = new Dictionary<int, JavaInstruction>();

        #endregion

        #region public members

        #endregion
    }
}
