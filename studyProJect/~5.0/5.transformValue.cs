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
    public class TransformValue
    {
        public static void TransformValueTestClass()
        {
            //string>int
            string a = "12345";
            int b = int.Parse(a);

            Console.WriteLine(b + ":" + b.GetType());

            //int>string
            int c = 12345;
            string d = c.ToString();

            Console.WriteLine(d + ":" + d.GetType());


            //float>int
            float f = 1234.5f;
            int g = (int)f;

            Console.WriteLine(g + ":" + g.GetType()); //소숫점없어짐


            //int>float
            int h = 1245;
            float i = (float)h; //더큰범위로 바굴때는 캐스팅 안해도 됨

            Console.WriteLine(i + ":" + i.GetType());
        }
    }
}
