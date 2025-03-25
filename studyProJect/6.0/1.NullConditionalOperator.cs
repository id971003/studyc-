using System;
using System.Collections.Generic;
using System.Text;

namespace studyProJect
{
    /// <summary>
    ///  ? 로 널채크해서 널이면 기본값이나 null 던저줌
    ///  3항연산자 할때많이쓴듯
    /// </summary>
    public static class NullConditionalOperator
    {
        public static Action OnTestAction;
        public static void t()
        {
            NullTestClass ta = new NullTestClass(1, 5);
            
            Console.WriteLine(ta?.test);
            ta = null;
            Console.WriteLine(ta?.test);
            //찍히고 ta 가 null 이라 아무것도 안찍힘

            Console.WriteLine("ㅡㅡㅡㅡㅡㅡ");
            ta = new NullTestClass(1, 5);
            int a = ta?.test ?? 0;
            Console.WriteLine(a);
            //ta 가 있으니 값 그대로 반환
            ta = null;
            a = ta?.test ?? 0;
            Console.WriteLine(a);
            //ta 가 비었으니까 0 들어가서 0 찍힘

            Console.WriteLine("ㅡㅡㅡㅡㅡㅡ");
            ta = new NullTestClass(1, 5);
            int? b = ta?.test;
            Console.WriteLine(b);
            //ta 가있으니 1들어감
            ta = null;
            b = ta?.test;
            Console.WriteLine(b+":"+ (b==null));
            //ta 가 없으니 b 는 null 이됨

            OnTestAction?.Invoke();

            //OnTestAction 암것도없으니 아무것도안함
            OnTestAction += () =>
            {
                Console.WriteLine("Action");
            };
            OnTestAction?.Invoke();
            //OnTestAction 있으니 실행




            //int c = ta?.test  이구문은 오류난다 int? 를 int 로 강제로 바꾸니
            int? c = ta?.test; // 이렇게써줘야하고 이러면 ta null 이면 c 에 null 이들어감
            c = ta?.test ?? 0; // 이렇게하면 ta 가  null 이면 0 들어감
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