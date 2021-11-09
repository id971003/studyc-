using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /*요약
      * enum 은 변수를 만든다?
      * enum convert to string 
      */
    public class EnumValue
    {
        enum Language
        {
            c, java, python, english = 10, go
        }
        public static void EnumValueTestClass()
        {
            //Tostring
            Console.WriteLine((int)Language.c);
            Console.WriteLine(Language.c.ToString() == "c"); //tostring() 으로 enum > string 값을 변환 가능 


            //GetValue(typeof)
            foreach (Language b in Enum.GetValues(typeof(Language))) // 열거형 상수의 배열 검색 후 string 전환 
            {
                string value = b.ToString();
                Console.WriteLine(value);
            }


            //TryParse(Type Enum(구문구석에 사용할 열거형) , value (대소문자 구문할건지 할거면true),out result (반환 되는 개체) )
            string MyLanguage = "c";
            Language parm;
            Enum.TryParse(MyLanguage, true, out parm);

            Console.WriteLine(MyLanguage + " " + MyLanguage.GetType());
            Console.WriteLine(parm + " " + parm.GetType());
        }
    }
}