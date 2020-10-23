using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JXVM4J.Share.Interpreter
{
    /// <summary>
    /// 抽象执行器
    /// </summary>
    public abstract class AbstractExecutor
    {
        /// <summary>
        /// 执行Java指令
        /// </summary>
        /// <param name="instruction"></param>
        public abstract void Execute(JavaInstruction instruction);
    }
}
