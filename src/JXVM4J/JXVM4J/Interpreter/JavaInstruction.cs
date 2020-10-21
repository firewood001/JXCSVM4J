using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JXVM4J.Interpreter
{
    /// <summary>
    /// This is a class used to describe the Java Instruction
    /// </summary>
    public class JavaInstruction
    {
        #region private members
        
        /// <summary>
        /// 操作码
        /// opcode
        /// </summary>
        private char _op_code;
        /// <summary>
        /// 助记符
        /// </summary>
        private string _mnemonic = null;
        /// <summary>
        /// Java指令描述
        /// </summary>
        private string _description = null;

        /// <summary>
        /// 操作数集合
        /// </summary>
        private List<object> _operands = null;

        #endregion

        #region public properties
        /// <summary>
        /// 获取操作码
        /// </summary>
        public char OpCode
        {
            get
            {
                return _op_code;
            }
        }

        /// <summary>
        /// 获取助记符
        /// </summary>
        public string Mnemonic
        {
            get
            {
                return _mnemonic;
            }
        }

        /// <summary>
        /// 获得Java指令的描述
        /// </summary>
        public string Description
        {
            get { return _description; }
        }
        #endregion

        #region public methods
        public override string ToString()
        {
            if (_mnemonic != null)
            {
                return _mnemonic;
            }
            return string.Empty;
        }
        #endregion
    }
}
