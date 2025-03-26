using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using studyProJect;
using static studyProJect.UsingStatic;

namespace projectstudy
{

    class Deconstruct
    { 
        /// <summary>
        /// 생성자는 만들때 값 집어넣는거고 Deconstruct 는 파라미터를 밖으로 뺄때 쓴다.
        /// </summary>
            public void Ta()
            {
                Test test = new Test(1,2,3);
                (int a,int b, int c)=test; //이렇게
            }
            public class Test
            {
                int a;
                int b;
                int c;

                public Test(int a, int b, int c)
                {
                    this.a=a;
                    this.b=b;
                    this.c=c;
                }
                public void Deconstruct(out int a, out int b, out int c)
                {
                    a=this.a;
                    b=this.b;
                    c=this.c;
                }
            }
    }
    
}