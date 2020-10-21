using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace JXVM4J.Interpreter
{
    public enum EumJavaOpCode
    {
        nop = 0x00,
        aconst_null = 0x01,
        iconst_m1 = 0x02,
        iconst_0 = 0x03,
        iconst_1 = 0x04,
        iconst_2 = 0x05,
        iconst_3 = 0x06,
        iconst_4 = 0x07,
        iconst_5 = 0x08,
        lconst_0 = 0x09,
        lconst_1 = 0x0a,
        fconst_0 = 0x0b,
        fconst_1 = 0x0c,
        fconst_2 = 0x0d,
        dconst_0 = 0x0e,
        dconst_1 = 0x0f,
        bipush = 0x10,
        sipush = 0x11,
        ldc = 0x12,
        ldc_w = 0x13,
        ldc2_w = 0x14,
        iload = 0x15,
        lload = 0x16,
        fload = 0x17,
        dload = 0x18,
        aload = 0x19,
        iload_0 = 0x1a,
        iload_1 = 0x1b,
        iload_2 = 0x1c,
        iload_3 = 0x1d,
        lload_0 = 0x1e,
        lload_1 = 0x1f,
        lload_2 = 0x20,
        lload_3 = 0x21,
        fload_0 = 0x22,
        fload_1 = 0x23,
        fload_2 = 0x24,
        fload_3 = 0x25,
        dload_0 = 0x26,
        dload_1 = 0x27,
        dload_2 = 0x28,
        dload_3 = 0x29,
        aload_0 = 0x2a,
        aload_1 = 0x2b,
        aload_2 = 0x2c,
        aload_3 = 0x2d,
        iaload = 0x2e,
        laload = 0x2f,
        faload = 0x30,
        daload = 0x31,
        aaload = 0x32,
        baload = 0x33,
        caload = 0x34,
        saload = 0x35,
        istore = 0x36,
        lstore = 0x37,
        fstore = 0x38,
        dstore = 0x39,
        astore = 0x3a,
        istore_0 = 0x3b,
        istore_1 = 0x3c,
        istore_2 = 0x3d,
        istore_3 = 0x3e,
        lstore_0 = 0x3f,
        lstore_1 = 0x40,
        lstore_2 = 0x41,
        lstore_3 = 0x42,
        fstore_0 = 0x43,
        fstore_1 = 0x44,
        fstore_2 = 0x45,
        fstore_3 = 0x46,
        dstore_0 = 0x47,
        dstore_1 = 0x48,
        dstore_2 = 0x49,
        dstore_3 = 0x4a,
        astore_0 = 0x4b,
        astore_1 = 0x4c,
        astore_2 = 0x4d,
        astore_3 = 0x4e,
        iastore = 0x4f,
        lastore = 0x50,
        fastore = 0x51,
        dastore = 0x52,
        aastore = 0x53,
        bastore = 0x54,
        castore = 0x55,
        sastore = 0x56,
        pop = 0x57,
        pop2=0x58,
        dup=0x59,
        dup_x1=0x5a,
        dup_x2=0x5b,
        dup2=0x5c,
        dup2_x1=0x5d,
        dup2_x2=0x5e,
        swap=0x5f,
        iadd=0x60,
        ladd=0x61,
        fadd=0x62,
        dadd=0x63,
        isub=0x64,
        lsub=0x65,
        fsub=0x66,
        dsub=0x67,
        imul=0x68,
        lmul=0x69,
        fmul=0x6a,
        dmul=0x6b,
        idiv=0x6c,
        ldiv=0x6d,
        fdiv=0x6e,
        ddiv=0x6f,
        irem=0x70,
        lrem=0x71,
        frem=0x72,
        drem=0x73
    }
    public class JavaInstructionTable
    {
        #region private members
        
        /// <summary>
        /// This variable is used to store the Java native instructions, which is not related to any platform
        /// </summary>
        private Dictionary<int, JavaInstruction> _table = new Dictionary<int, JavaInstruction>();

        /// <summary>
        /// 使用单例模式提供JavaInstructionTable对象
        /// </summary>
        private static JavaInstructionTable _instance = null;

        private static readonly object _obj = new object();

        #endregion

        #region constructors
        private JavaInstructionTable()
        {
            InitialJavaInstructionTable();
        }

        #endregion

        #region public members

        public static JavaInstructionTable GetInstance()
        {
            if(_instance == null)
            {
                lock(_obj)
                {
                    if(_instance == null)
                    {
                        _instance = new JavaInstructionTable();
                    }
                }
            }

            return _instance;
        }
        
        #endregion

        #region private methods

        /// <summary>
        /// 初始化一个Java指令集表
        /// </summary>
        private void InitialJavaInstructionTable()
        {
            JavaInstruction instruction = new JavaInstruction((char)0x00, "nop", "什么都不做", null);
            _table.Add((char)0x00, instruction);

            instruction = new JavaInstruction((char)0x01, "aconst_null", "将null推送至栈顶", null);
            _table.Add((char)0x01, instruction);

            instruction = new JavaInstruction((char)0x02, "iconst_m1", "将null将int型-1推送至栈顶", null);
            _table.Add((char)0x02, instruction);

            instruction = new JavaInstruction((char)0x03, "iconst_0", "将int常量0推送至栈顶", null);
            _table.Add((char)0x03, instruction);

            instruction = new JavaInstruction((char)0x04, "iconst_1", "将int常量1推送至栈顶", null);
            _table.Add((char)0x04, instruction);

            instruction = new JavaInstruction((char)0x05, "iconst_2", "将int常量2推送至栈顶", null);
            _table.Add((char)0x05, instruction);

        }

        #endregion

    }
}
