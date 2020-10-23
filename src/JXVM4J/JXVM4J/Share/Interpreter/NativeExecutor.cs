using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JXVM4J.Share.Interpreter
{
    /// <summary>
    /// 本地执行器，直接调用C#.net编写的方法
    /// </summary>
    public class NativeExecutor:AbstractExecutor
    {
        public override void Execute(JavaInstruction instruction)
        {
            System.Diagnostics.Debug.WriteLine(instruction.ToString());
        }
    }
}
