using System;
using System.Collections.Generic;
using System.Text;

namespace studyProJect
{
    /// <summary>
    ///  ? 로 널채크해서 널이면 기본값이나 null 던저줌
    /// </summary>
    public class NullConditionalOperator
    {
        public static void t()
        {
            NullTestClass ta = new NullTestClass(1, 5);
            Console.WriteLine(ta?.test);
            ta = null;
            Console.WriteLine(ta?.test);
            //찍히고 ta 가 null 이라 아무것도 안찍힘
        }
        
    }

    public  class NullTestClass
    {
        public int test;

        public int test2;
        
            public NullTestClass(int Test,int Test2)
        {
            test=Test;
            test2=Test2;
        }

    }
}