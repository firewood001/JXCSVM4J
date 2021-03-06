﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace JXVM4J.Share.Interpreter
{
    public enum EnumJavaOpCode
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
        pop2 = 0x58,
        dup = 0x59,
        dup_x1 = 0x5a,
        dup_x2 = 0x5b,
        dup2 = 0x5c,
        dup2_x1 = 0x5d,
        dup2_x2 = 0x5e,
        swap = 0x5f,
        iadd = 0x60,
        ladd = 0x61,
        fadd = 0x62,
        dadd = 0x63,
        isub = 0x64,
        lsub = 0x65,
        fsub = 0x66,
        dsub = 0x67,
        imul = 0x68,
        lmul = 0x69,
        fmul = 0x6a,
        dmul = 0x6b,
        idiv = 0x6c,
        ldiv = 0x6d,
        fdiv = 0x6e,
        ddiv = 0x6f,
        irem = 0x70,
        lrem = 0x71,
        frem = 0x72,
        drem = 0x73,
        ineg = 0x74,
        lneg = 0x75,
        fneg = 0x76,
        dneg = 0x77,
        ishl = 0x78,
        lshl = 0x79,
        ishr = 0x7a,
        lshr = 0x7b,
        iushr = 0x7c,
        lushr = 0x7d,
        iand = 0x7e,
        land = 0x7f,
        ior = 0x80,
        lor = 0x81,
        ixor = 0x82,
        lxor = 0x83,
        iinc = 0x84,
        i2l = 0x85,
        i2f = 0x86,
        i2d = 0x87,
        l2i = 0x88,
        l2f = 0x89,
        l2d = 0x8a,
        f2i = 0x8b,
        f2l = 0x8c,
        f2d = 0x8d,
        d2i = 0x8e,
        d2l = 0x8f,
        d2f = 0x90,
        i2b = 0x91,
        i2c = 0x92,
        i2s = 0x93,
        lcmp = 0x94,
        fcmpl = 0x95,
        fcmpg = 0x96,
        dcmpl = 0x97,
        dcmpg = 0x98,
        ifeq = 0x99,
        ifne = 0x9a,
        iflt = 0x9b,
        ifge = 0x9c,
        ifgt = 0x9d,
        ifle = 0x9e,
        if_icmpeq = 0x9f,
        if_icmpne = 0xa0,
        if_icmplt = 0xa1,
        if_icmpge = 0xa2,
        if_icmpgt = 0xa3,
        if_icmple = 0xa4,
        if_acmpeq = 0xa5,
        if_acmpne = 0xa6,
        Goto = 0xa7,
        jsr = 0xa8,
        ret = 0xa9,
        tableswitch = 0xaa,
        lookupswitch = 0xab,
        ireturn = 0xac,
        lreturn = 0xad,
        freturn = 0xae,
        dreturn = 0xaf,
        areturn = 0xb0,
        Return = 0xb1,
        getstatic = 0xb2,
        putstatic = 0xb3,
        getfield = 0xb4,
        putfield = 0xb5,
        invokevirtual = 0xb6,
        invokespecial = 0xb7,
        invokestatic = 0xb8,
        invokeinterface = 0xb9,
        NEW = 0xbb,
        newarray = 0xbc,
        anewarray = 0xbd,
        arraylength = 0xbe,
        athrow = 0xbf,
        checkcast = 0xc0,
        instanceof = 0xc1,
        monitorenter = 0xc2,
        monitorexit = 0xc3,
        wide = 0xc4,
        multianewarray = 0xc5,
        ifnull = 0xc6,
        ifnonnull = 0xc7,
        goto_w = 0xc8
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

        #region public methods

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
        
        public JavaInstruction GetInstruction(EnumJavaOpCode opCode)
        {
            JavaInstruction result = null;
            
            _table.TryGetValue((int)opCode, out result);
            result = result.Clone();

            if(result == null)
            {
                throw new NullReferenceException("No instruction exists");
            }
            return result;
        }
        #endregion

        #region private methods

        /// <summary>
        /// 初始化一个Java指令集表
        /// </summary>
        private void InitialJavaInstructionTable()
        {
            JavaInstruction instruction = new JavaInstruction((char)EnumJavaOpCode.nop, "nop", "什么都不做", null);
            _table.Add((char)EnumJavaOpCode.nop, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.aconst_null, "aconst_null", "将null推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.aconst_null, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.iconst_m1, "iconst_m1", "将null将int型-1推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.iconst_m1, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.iconst_0, "iconst_0", "将int常量0推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.iconst_0, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.iconst_1, "iconst_1", "将int常量1推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.iconst_1, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.iconst_2, "iconst_2", "将int常量2推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.iconst_2, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.iconst_3, "iconst_3", "将int常量3推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.iconst_3, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.iconst_4, "iconst_4", "将int常量4推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.iconst_4, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.iconst_5, "iconst_5", "将int常量5推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.iconst_5, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.lconst_0, "lconst_0", "将long常量0推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.lconst_0, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.lconst_1, "lconst_1", "将long常量1推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.lconst_1, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.fconst_0, "fconst_0", "将float常量0推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.fconst_0, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.fconst_1, "fconst_1", "将float常量1推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.fconst_1, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.fconst_2, "fconst_2", "将float常量2推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.fconst_2, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.dconst_0, "dconst_0", "将double常量0推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.dconst_0, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.dconst_1, "dconst_1", "将double常量1推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.dconst_1, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.bipush, "bipush", "将单字节的常量值(-128~127)推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.bipush, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.sipush, "sipush", "将一个短整型常量值(-32768~32767)推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.sipush, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.ldc, "ldc", "将int, float或String型常量值从常量池中推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.ldc, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.ldc_w, "ldc_w", "常量编号|将int, float或String型常量值从常量池中推送至栈顶（宽索引）", null);
            _table.Add((char)EnumJavaOpCode.ldc_w, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.ldc_w, "ldc_w", "常量编号|将int, float或String型常量值从常量池中推送至栈顶（宽索引）", null);
            _table.Add((char)EnumJavaOpCode.ldc_w, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.ldc2_w, "ldc2_w", "常量编号|将long或double型常量值从常量池中推送至栈顶（宽索引）", null);
            _table.Add((char)EnumJavaOpCode.ldc2_w, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.iload, "iload", "将位置为vindex的int类型的局部变量压入栈", null);
            _table.Add((char)EnumJavaOpCode.iload, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.lload, "lload", "将位置为vindex和(vindex+1)的long类型的局部变量压入栈", null);
            _table.Add((char)EnumJavaOpCode.lload, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.fload, "fload", "将位置为vindex的float类型的局部变量压入栈", null);
            _table.Add((char)EnumJavaOpCode.fload, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.dload, "dload", "将位置为vindex和(vindex+1)的double类型的局部变量压入栈", null);
            _table.Add((char)EnumJavaOpCode.dload, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.aload, "aload", "将位置为vindex的对象引用局部变量压入栈", null);
            _table.Add((char)EnumJavaOpCode.aload, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.iload_0, "iload_0", "将位置为0的int类型的局部变量压入栈", null);
            _table.Add((char)EnumJavaOpCode.iload_0, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.iload_1, "iload_1", "将位置为1的int类型的局部变量压入栈", null);
            _table.Add((char)EnumJavaOpCode.iload_1, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.iload_2, "iload_2", "将位置为2的int类型的局部变量压入栈", null);
            _table.Add((char)EnumJavaOpCode.iload_2, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.iload_3, "iload_3", "将位置为3的int类型的局部变量压入栈", null);
            _table.Add((char)EnumJavaOpCode.iload_3, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.lload_0, "lload_0", "将位置为0和1的long类型的局部变量压入栈", null);
            _table.Add((char)EnumJavaOpCode.lload_0, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.lload_1, "lload_1", "将位置为1和2的long类型的局部变量压入栈", null);
            _table.Add((char)EnumJavaOpCode.lload_1, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.lload_2, "lload_2", "将位置为2和3的long类型的局部变量压入栈", null);
            _table.Add((char)EnumJavaOpCode.lload_2, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.lload_3, "lload_3", "将位置为3和4的long类型的局部变量压入栈", null);
            _table.Add((char)EnumJavaOpCode.lload_3, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.fload_1, "fload_1", "将本地变量表的第二个float型本地变量推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.fload_1, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.fload_2, "fload_2", "将本地变量表的第三个float型本地变量推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.fload_2, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.fload_3, "fload_3", "将本地变量表的第四个float型本地变量推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.fload_3, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.dload_0, "dload_0", "将本地变量表的第一个double型本地变量推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.dload_0, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.dload_1, "dload_1", "将本地变量表的第二个double型本地变量推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.dload_1, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.dload_2, "dload_2", "将本地变量表的第三个double型本地变量推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.dload_2, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.dload_3, "dload_3", "将本地变量表的第四个double型本地变量推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.dload_3, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.aload_0, "aload_0", "将引用类型变量推送至栈顶,非静态方法中 表示对this的操作，静态方法中表示对方法的第一参数的操作", null);
            _table.Add((char)EnumJavaOpCode.aload_0, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.aload_1, "aload_1", "将本地变量表的第二个引用类型本地变量推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.aload_1, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.aload_1, "aload_1", "将本地变量表的第二个引用类型本地变量推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.aload_1, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.aload_2, "aload_2", "将本地变量表的第三个引用类型本地变量推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.aload_2, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.aload_3, "aload_3", "将本地变量表的第四个引用类型本地变量推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.aload_3, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.iaload, "iaload", "将int型数组指定索引的值推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.iaload, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.laload, "laload", "将long型数组指定索引的值推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.laload, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.faload, "faload", "将float型数组指定索引的值推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.faload, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.daload, "daload", "将double型数组指定索引的值推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.daload, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.aaload, "aaload", "将引用型数组指定索引的值推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.aaload, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.baload, "baload", "将boolean或byte型数组指定索引的值推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.baload, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.caload, "caload", "将char型数组指定索引的值推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.caload, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.caload, "saload", "将short型数组指定索引的值推送至栈顶", null);
            _table.Add((char)EnumJavaOpCode.saload, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.istore, "istore", "将栈顶int型数值存入指定本地变量", null);
            _table.Add((char)EnumJavaOpCode.istore, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.lstore, "lstore", "将栈顶long型数值存入指定本地变量", null);
            _table.Add((char)EnumJavaOpCode.lstore, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.fstore, "fstore", "将栈顶float型数值存入指定本地变量", null);
            _table.Add((char)EnumJavaOpCode.fstore, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.dstore, "dstore", "将栈顶double型数值存入指定本地变量", null);
            _table.Add((char)EnumJavaOpCode.dstore, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.astore, "astore", "将栈顶引用型数值存入指定本地变量", null);
            _table.Add((char)EnumJavaOpCode.astore, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.istore_0, "istore_0", "将栈顶int型数值存入第一个本地变量", null);
            _table.Add((char)EnumJavaOpCode.istore_0, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.istore_1, "istore_1", "将栈顶int型数值存入第二个本地变量", null);
            _table.Add((char)EnumJavaOpCode.istore_1, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.istore_2, "istore_2", "将栈顶int型数值存入第三个本地变量", null);
            _table.Add((char)EnumJavaOpCode.istore_2, instruction);

            instruction = new JavaInstruction((char)EnumJavaOpCode.istore_3, "istore_3", "将栈顶int型数值存入第四个本地变量", null);
            _table.Add((char)EnumJavaOpCode.istore_3, instruction);
        }

        #endregion

    }
}
