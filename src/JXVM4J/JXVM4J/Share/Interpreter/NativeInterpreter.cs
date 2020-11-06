using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JXVM4J.Share.Interpreter
{
    /// <summary>
    /// 本地执行器，直接调用C#.net编写的方法
    /// </summary>
    public class NativeInterpreter:AbstractInterpreter
    {
        #region private memebers
        private readonly JavaInstructionTable _javaInstructionTable = JavaInstructionTable.GetInstance();
        #endregion

        #region public constuctor

        public NativeInterpreter()
        {

        }

        #endregion

        #region public methods

        public override void Execute(EnumJavaOpCode opCode, object operand)
        {
            JavaInstruction instruction = _javaInstructionTable.GetInstruction(opCode);
            instruction.SetOperands(operand);
            System.Diagnostics.Debug.WriteLine(instruction.ToString());
        }

        #endregion
    }
}
