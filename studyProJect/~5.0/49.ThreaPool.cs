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
    /// ThreadPool : 사용하고 다쓰면 풀에 집어넣음
    /// 
    /// 쓰레드 동작방식
    ///     상시실행 :  프로그램 끝날떄까지 실행됨 [무한루프문에서많이씀]
    ///     일회성 임시실행 :  특정 로직 실행시키고 정지
    ///
    /// Why?
    /// 일회성 임시실행시 계속 new Thread 로 쓰레드 만들면서 쓰면 성능에 좋지않아서 재사용하면좋음음
    /// 
    /// 
    /// </summary>
    class ThreadPoolTest
    {
        public void TA()
        {
            for(int i=0;i<10;i++)
            ThreadPool.QueueUserWorkItem(Temp,5);
            
        }
        void Temp(object value)
        {
        WriteLine(value);
        }
    }
    
}