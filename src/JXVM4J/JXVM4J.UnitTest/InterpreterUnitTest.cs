using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JXVM4J.Share.Interpreter;

namespace JXVM4J.UnitTest
{
    [TestClass]
    public class InterpreterUnitTest
    {
        [TestMethod]
        public void TestHexValue()
        {
            int i = 0x10;
            Assert.AreNotEqual(i, 0);
        }

        [TestMethod]
        public void TestExecutor_Execute()
        {
            JavaInstruction ji = new JavaInstruction((char)EumJavaOpCode.aaload, "aaload", "无|将引用型数组指定索引的值推送至栈顶", null);
            NativeExecutor executor = new NativeExecutor();
            executor.Execute(ji);
        }
    }
}
