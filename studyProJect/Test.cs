using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using static projectstudy.UsingStatic;
using static System.Console;
using System.Diagnostics;

namespace projectstudy
{

    class Test
    {
        static void Main(string[] arg)
        {
            TaskTestClass Ta = new TaskTestClass();
            Ta.TA();
            Console.Read();
        }

    }
}

