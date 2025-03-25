
using System;
using System.Collections.Generic;
using System.Text;

namespace studyProJect
{
    /// <summary>
    /// 같은 개발자 분이 자주쓰던거 여기서 나옴
    /// string format 할때 추가 된 기능 문자열 앞에 $ 넣고 {변수} 쓰면 변수 값들어간다
    /// 변수를 "변수" 와같이 출력하고싶으면 {{변수}} 처럼하면 무시된다
    /// </summary>
    public class StringInterpolation
    {
        public static void t()
        {
            TestCleaa ta = new TestCleaa();
            int test1 = 1;
            int test2 = 2;
            string a = $"아에이오우 {ta.a} + {{ta.a}}";
            
            Console.WriteLine(a);
        }
    }
    public class TestCleaa
    {
        public int a=5;
        public int b=6;
    }
}
