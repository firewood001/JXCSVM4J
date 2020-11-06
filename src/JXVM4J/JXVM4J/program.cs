using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JXVM4J
{
    class program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Write("Please input the java instruction file");
            }
            else
            {
                string filename = args[0];
                JavaExecutor executor = JavaExecutor.GetInstance();
                executor.Execute(filename);
            }
        }

    }
}
