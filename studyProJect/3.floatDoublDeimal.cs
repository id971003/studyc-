using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    //부동소숫점
    /*요약 
     * float 은 뒤에 f 넣어야함 . 1비트는 부조헌용으로 사용 /가부수23비트 , 지수부 8비트로 나타냄 
     * double 은 아무것도 안붙어도됨, float 보다 좀더 긴 부동소숫점 표현가능
     * deimal 은  위에 m 넣어야함 , double 보다도 긴 소숫점 표현가능
     */

    public class FloatDoublDeimal
    {
        public static void FloatDoubleDeimalTestClass()
        {
            float f = 3.14159265358979323846f;

            Console.WriteLine(f);


            double e = 3.14159265358979323846;

            Console.WriteLine(e);


            decimal g = 3.14159265358979323846m;

            Console.WriteLine(g);
        }
    }
}
