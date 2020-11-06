using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JXVM4J.Share.Interpreter
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
        /// 我怀疑在.net的虚拟机中也是把char转成int处理，最后出栈的时候又转成char，如果验证成功，那么就可以把这个数据类型直接设置为int
        /// 不管上面的怀疑，用EnumJavaOpCode直接进行语法级别的检查
        /// </summary>
        private EnumJavaOpCode _op_code;
        /// <summary>
        /// 助记符
        /// </summary>
        private string _mnemonic = null;
        /// <summary>
        /// Java指令描述
        /// </summary>
        private string _description = null;

        /// <summary>
        /// 操作数
        /// </summary>
        private object _operand = null;
        
        #endregion

        #region public properties
        /// <summary>
        /// 获取操作码
        /// </summary>
        public char OpCode
        {
            get
            {
                return (char)_op_code;
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
            get
            {
                return _description;
            }
        }

        #endregion

        #region constructors

        public JavaInstruction(char opcode, string mnemonic, string description, object operand)
        {
            _op_code = (EnumJavaOpCode)opcode;
            _mnemonic = mnemonic;
            _description = description;
            _operand = operand;
        }
        #endregion

        #region public properties
        public void SetOperands(object operand)
        {
                _operand = operand;
        }
        #endregion

        #region public method

        public override string ToString()
        {
            if (_mnemonic != null)
            {
                return _mnemonic;
            }
            return string.Empty;
        }

        public JavaInstruction Clone()
        {
            JavaInstruction result = new JavaInstruction((char)_op_code, _mnemonic, _description, _operand);
            return result;
        }

        #endregion
    }
}
