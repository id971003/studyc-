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
    public class TaskTestClass
    {
        /// <summary>
        /// 스레드랑 스레드풀 단점 개선한 스레드 클래스임
        /// backGroundThread 고 Threadpool 이용함
        /// </summary>
        public void TA()
        {
             Task ta = new Task(BackGroundTask);
             ta.Start();
             ta.Wait(); // Thread.Join 이랑 비슷함

            Task Tta = new Task(Temp);
            Tta.ContinueWith((obj)=> //스레드 끝났을때 뭐할지 정해줄수잇음
            {
                        Console.WriteLine("Tta끝남"+Tta.Status);
            });
            Tta.Start();
            Tta.Wait();

            Tta = Task.Run(Temp); // 생성과 실행 동시에함 
            Tta = Task.Run(()=> //람다식으로도 받아짐
            {
                Thread.Sleep(3000);
            });

            Task TTTa = Task.WhenAll(ta,Tta); // ta 랑 tta 가 끝나면 TTTa.IsCompleted 가 true 됨
            TTTa=Task.WhenAny(ta,Tta) ; // ta 랑 TTa 둘중 하나라도 먼저 끝나면 TTTa.IsCompleted 가 true 됨됨
        }
        public void BackGroundTask()
        {
            bool isBackGround = Thread.CurrentThread.IsBackground;
            bool isThreadPoolThread = Thread.CurrentThread.IsThreadPoolThread;
            WriteLine(isBackGround+":"+isThreadPoolThread);
        }
        public void Temp()
        {
                Thread.Sleep(3000);
                
        }
        
    }
}
