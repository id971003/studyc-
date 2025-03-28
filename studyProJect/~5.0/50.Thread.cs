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
/// 똑같이 생성자로 만들어서 집어넣음
/// 
/// ParameterizedThreadStart 쓰면 변수받을수있음
/// 
/// Thread.Start : 시작
/// Thread.Abort : 정지 근데안씀이제
/// Thread.Join : 그 쓰레드멈출때까지 지금쓰레드정지
/// 
/// Status
///     Unstarted : 시작전
///     Running : 실행중
///     Suspended : 쓰레드 일시정지 Thread.Suspended() 로 불렸을때 [ Thread.Resume() 으로 품]
///     WaitSleepJoin : Join 써서 멈춘상태
///     
/// </summary>
    class ThreadTestClass
    {
        Thread Newthread ;
        Thread Newthread2 ;

        Thread NewThread3,NewThread4;

        Thread NewThread5;

         Thread NewThread6;
        public void ThreadTest()
        {
            
             Thread tread = Thread.CurrentThread;
             WriteLine(tread.ThreadState);

             Newthread = new Thread(Temp);//(new ThreadStart(Temp));
             Newthread.Start();

            Newthread2=new Thread(new ParameterizedThreadStart(Temp2));
             Newthread2.Start((5,3));

            //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
             NewThread3=new Thread(Temp3);
             NewThread3.Start();
            //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
            
            NewThread5=new Thread(Tmep5);
            NewThread5.Start();

            var a =  Console.Read();
            Console.WriteLine(a);
            if(a==109)
            {
                //NewThread5.Abort(); //더이상지원안함 thread 종료
                NewThread5.Interrupt(); // WaitSleep 상태가 됬을때
            }
            //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
            
            Newthread = new Thread(Temp);
            Newthread.IsBackground=true; //BackGroundThread 는 프로그램 실행 종료에 영향 끼치지 않게해
            //  해당 구문 실행시키면 메인쓰레드끝나고 바로 종료됨
            Newthread.Start();
            Newthread.Join(); 
            //Join 해주면  해당 쓰레드 끝날때까지 기다리니까  로그잘찍힘

            Newthread = new Thread(Temp);
            WriteLine(Newthread.ThreadState); //Unstarted
            Newthread.Start();
            WriteLine(Newthread.ThreadState); ///Running
            

        }
        public void Temp()
        {
            WriteLine("쓰레드시작");
            WriteLine(Newthread.ThreadState);
            Thread.Sleep(2000);
            WriteLine("Thread종료");
        }
        public void Temp2(object a)
        {
            WriteLine("쓰레드시작");
            WriteLine(Newthread2.ThreadState);
            Thread.Sleep(2000);
            WriteLine(a);
            WriteLine("Thread종료");
        }

        public void Temp3()
        {
            NewThread4=new Thread(Temp4);
            NewThread4.Start();
            NewThread4.Join(); //쓰레드 완료시까지 대기
            WriteLine("조인완료"); 
        }
        public void Temp4()
        {
            WriteLine("Thrad4시작");
            Thread.Sleep(2000);
            WriteLine("Thrad끝");
        }

        public void Tmep5()
        {
            try
            {
                WriteLine("스레드시작");
                Thread.Sleep(5000);
                WriteLine("쓰레드종료");
            }
            catch(ThreadAbortException)
            {
                WriteLine("스레드 강제종료");
            }
            catch(ThreadInterruptedException)
            {
                WriteLine("스레드 WaitSleepJoin");
            }

        }
    }
}