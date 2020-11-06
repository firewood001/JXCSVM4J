using JXVM4J.Share.Interpreter;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;

namespace JXVM4J
{
    /// <summary>
    /// 执行引擎
    /// </summary>
    public class JavaExecutor
    {
        #region private members

        private static volatile JavaExecutor _executor = null;
        private static readonly object _obj = new Object();

        private AbstractInterpreter _interpreter = null;

        #endregion

        #region private constructor

        private JavaExecutor()
        {
            ///后面可以根据需要动态加载其他类型的解释器
            _interpreter = new NativeInterpreter();
        }

        #endregion

        #region public methods

        #endregion

        #region public method
        ///<summary>
        /// Use the singleton pattern to create a unique object  in the  runtime
        ///<summary>
        public static JavaExecutor GetInstance()
        {
            if (_executor == null)
            {
                lock (_obj)
                {
                    if (_executor == null)
                    {
                        _executor = new JavaExecutor();
                    }
                }
            }
            return _executor;
        }

        public void Execute(string filename)
        {
            var file = File.OpenRead(filename);
            ///一次性把指令全部保存在内存里面
            List<string> jInstructions = new List<string>();
            using(var stream = new StreamReader(file))
            {
                while (!stream.EndOfStream)
                {
                    jInstructions.Add(stream.ReadLine());
                }
            }
            
            foreach(string jInstruction in jInstructions)
            {
                string strOpcode = jInstruction;
                string strOperand = null;
                if(jInstruction.IndexOf(" ") != 0)
                {
                    string[] ins = jInstruction.Split(' ');
                    strOpcode = ins[0];
                    strOperand = ins[1];                 
                }
                char opCode = (char)Convert.ToInt32(strOpcode, 8);
                int operand = Convert.ToInt32(strOperand, 16);
                _interpreter.Execute((EnumJavaOpCode)opCode, strOperand);
            }
            file.Close();
        }

        #endregion
    }
}
