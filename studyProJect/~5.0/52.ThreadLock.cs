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
    /// <summary>
    /// 서로다른 2개 thread 에서 특정변수 1개의 값을 수정하면 레이스 컨디션이 발생해 고정해줘야한다
    /// </summary>
    public class ThreadlockTest
    {
        Thread T1,T2;
        int num;

        private readonly object _lock = new object(); //잠금객체 this , type value, string 는 안쓰는게좋다 외부에서 접근 못하게끔하자

        public void TA()
        {
             num=0;
             T1 = new Thread(Temp);
             T2 = new Thread(Temp);

             T1.Start();
             T2.Start();
             T1.Join();
             T2.Join();
             Console.WriteLine(num);
             //이런식으로하면 num 이 20000이아니라 이상한 값들이 튀어나올꺼다


             num=0;
             T1 = new Thread(Temp2);
             T2 = new Thread(Temp2);

             T1.Start();
             T2.Start();
             T1.Join();
             T2.Join();
             Console.WriteLine(num);
             //_lock 객체로 잠금 객체로막아줘서 크리티컬섹션 내부에 하나의 쓰레드만 도는게 보장되어 20000이정상적으로나온다

            num=0;
            T1 = new Thread(Temp3);
            T2 = new Thread(Temp3);

            T1.Start();
            T2.Start();
            T1.Join();
            T2.Join();
            Console.WriteLine(num);
            // 최소단위로 연산해 다중스레드 접근이 안된다.

        }
        public void Temp()
        {
            for(int i=0;i<10000;i++)
            {
                num++;
            }
        }
        public void Temp2()
        {
            for(int i=0;i<10000;i++)
            {
                lock(_lock) //잠궈주면 크리티컬 섹션이 된다 : 한번에 한 스레드만 사용할수있는 코드 영역
                {
                    num++;
                }


                //위에껀 내부적으로 이렇게 동작한다
                Monitor.Enter(_lock);
                try{
                    num++;
                }
                finally
                {
                    Monitor.Exit(_lock);
                }
            }
        }
        public void Temp3()
        {
            for(int i=0;i<10000;i++)
            {
                Interlocked.Increment(ref num); // 원자적 연산이라고해서 최소 연산단위로 취급해 다른 쓰레드가 개입할수없데
            }
        }
    }

}
