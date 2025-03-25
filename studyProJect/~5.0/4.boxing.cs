using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /* 요약
      object 형식과같이 참조 형식은 힙에 데이터를 할당한다
      
      참조 형식: 실제 값이아니라 메모리 내의 위치를 저장하는 데이터로 c의 포인터와 비슷한 개념

      이때 이 object 에 int 와 float 과 같은 스택 형식의 객체를 담았을때 이 스택형식의 값들이 힙에 할당 될수있도록 하는것 

      즉 , BOXING은  메모리 주소로만 되어있는 object 형식의 데이터를 실제 값으로 바꾸거나 그 반대 작업
     */
    public class Boxing
    {
        public static void BoxingTestClass()
        {
            object a = 20;//박싱

            Console.WriteLine(a.GetType());


            int b = (int)a; //언박싱  != typeCast

            Console.WriteLine(b + ": " + b.GetType());


            object c = (object)b;  //박싱

            Console.WriteLine(c + ":" + c.GetType());


            int d = (int)c; //언박싱

            Console.WriteLine(d + ": " + d.GetType());
        }
    }
}
