﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JXVM4J.Share.Interpreter
{
    /// <summary>
    /// 抽象执行器
    /// </summary>
    public abstract class AbstractInterpreter
    {
        #region private members
        
        //private static volatile AbstractInterpreter _executor  = null;

        //private static readonly object _obj = new Object();

        #endregion

        #region public method
        /////<summary>
        ///// Use the singleton pattern to create a unique object  in the  runtime
        /////<summary>
        //public static AbstractInterpreter GetInstance()
        //{
        //    if(_executor == null)
        //    {
        //        lock(_obj)
        //        {
        //            if(_executor == null)
        //            {
        //                _executor = GetExecutor();
        //            }
        //        }
        //    }
        //    return _executor;
        //}

        #endregion

        #region public abstract methods
        /// <summary>
        /// 执行Java指令
        /// </summary>
        /// <param name="instruction"></param>
        public abstract void Execute(EnumJavaOpCode opcode, object operand);

        #endregion

        #region private methods
        
        //private static AbstractInterpreter GetExecutor()
        //{
        //    return new NativeInterpreter();
        //}

        #endregion
        
    }
}
