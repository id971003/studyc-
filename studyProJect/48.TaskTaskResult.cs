using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace projectstudy
{
    /// <summary>
    /// 병렬처리 : 하나의 작업을 여러 작업자가 나눠서 실행한뒤 다시 하나로만드는거
    /// 비동기처리 : 작업 하나 시작후 결과 나오기전에 다른 작업들도 실행하다 작업 하던거 다시 받아서 처리하는 방식
    /// 
    ///                
    /// </summary>
    class TaskTaskResult
    {
        //Start 쓰기 
        public static void SomeThing()
        {
            Action someAction = () =>
              {
                  Thread.Sleep(1000);
                  Console.WriteLine("1초지남");
              };
            Task myTaks = new Task(someAction);

            myTaks.Start();

            Console.WriteLine("끝");

            myTaks.Wait();
        }
        //run 쓰기
        public static void SomeThing2()
        {
            var myTask = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("1초지남");
            });

            Console.WriteLine("끝");
            myTask.Wait();
        }
        //Task<TRETRUN> 쓰기
        public static void SomeThing3()
        {
            var myTask = Task<List<int>>.Run(() =>
            {
                Thread.Sleep(1000);
                List<int> list = new List<int>();
                list.Add(3);
                list.Add(4);
                list.Add(5);

                //Task<Tresult> 반환
                return list;
            });

            var myList = new List<int>();
            myList.Add(0);
            myList.Add(1);
            myList.Add(2);
            //안써도됨 비동기가 끝나야 작업 반환하므로 근디 써주는 습관이 있어야함
            myTask.Wait();
            myList.AddRange(myTask.Result.ToArray());

            foreach (var m in myList)
                Console.WriteLine(m);
        }
    }



}

