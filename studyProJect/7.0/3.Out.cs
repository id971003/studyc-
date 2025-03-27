using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;


namespace projectstudy
{
    /// <summary>
    /// out 은 메서드의 return 타입 이외에 뭔가 밖으로 값을 빼고 싶을때 쓰는데
    /// 이제 미리 선언안해놓고 밖으로뺄떄 선언해도 된다
    /// </summary>
    public class Out
    {
        public void TA()
        {
            //Before
            //기존엔 이리 A , B 미리 선언해야했는데
             int A;
             int B;
             testout(out A, out B);
             Console.WriteLine(A+":"+B);

             //After
             //이제 사용하면서 선언하면됨
             testout(out int C, out int D);
             Console.WriteLine(C+"::"+D);
        }

        public void testout(out int a, out int b)
        {
            a= 5;
            b= 6;
        }
    }



}
