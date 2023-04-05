using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace projectstudy
{
    /// <summary>
    ///  Process(프로세스)
    ///     실행 파일이 실행되어 메모리에 적재된 인스턴스 
    ///     프로세스는 하나이상의 Thread(스레드)로 구성됨
    ///  
    /// Thread(스레드)
    ///     운영체제가 cpu 시간을 할당하는 기본단위
    /// 
    /// ex) 프로세스 : 스레드 = 밧줄 : 실
    /// 
    /// 
    /// 단일 스레드
    ///     프로세스를 구성하는 스레드가 하나인놈
    ///     하나진행중일때 다른작업못함
    /// 
    /// 멀티 스레드
    ///     프로스세르르 구성하는 스레드가 두개이상인놈
    ///     
    /// 멀티 프로세스 vs 멀티 스레드
    ///     장점
    ///     성능
    ///     응답성을 높일수 있다 [작업중 취소 input 을 받을수있다.]
    ///     자원공유가 쉽다 [웹서버나 서버같은 어플리케이션에서 data 교환 용이함]
    ///     경제적이다 [프로세스에 할당된 메모리와 자원을 그대로 사용함]
    ///     
    ///     단점
    ///     어렵다
    ///     스레드 하나가 오류나면 모든 스레드가 죽는다 <> 멀티 프로세스는 프로세스하나가죽으면 그프로세스만죽는다
    ///     스레드가 많아지면 작업전환 비용때문에 오히려 성능이 낮아진다.
    ///     
    ///     
    /// 
    ///                     
    /// </summary>
    class ProcesThread
    {
        public static void DosomThing()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

        }
        /*
        static void Main(string[] arg)
        {
            Thread t1 = new Thread(new ThreadStart(DosomThing));

            t1.Start(); //시작
  
            for (int i=0;i<5;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);

            }

            //스레드 정지인데 앵간하면 쓰지말지
            t1.Abort();

            //종료대기
            t1.Join(); 
        }
        */


    }



}
