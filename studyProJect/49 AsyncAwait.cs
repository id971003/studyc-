using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace projectstudy
{
    /// <summary>
    ///  이건 c# 보단 유니티 쪽 개념인 unitask 이해하려고 async,await 개념 정리할꺼임
    ///  코루틴 vs unitask
    /// 
    ///  코루틴 보단 unitask 가 최신임
    ///  
    ///  코루틴 단점 
    ///     서버로직 들어가면 enumerator 타입 함루 리턴 불가능
    ///     startcoroutin 은 gc 할당이 높음
    ///     new 지속할당됨 [yield return new ...]
    ///  
    ///  unitask 장점
    ///     struck 기반 으로 제작되어 zero allocation [ 메모리 안잡아먹음]
    ///     서버로 받은값 return 가능
    ///     메모리 누수 방지위한 tasktracker 창 지원
    ///     
    ///ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
    ///
    /// 병렬처리 : 하나의 작업을 여러 작업자가 나눠서 실행한뒤 다시 하나로만드는거
    /// 비동기처리 : 작업 하나 시작후 결과 나오기전에 다른 작업들도 실행하다 작업 하던거 다시 받아서 처리하는 방식
    /// 
    /// Await, asyc :  c# 5.0 에서 추가된 비동기 처리위한 키워드
    /// asnyc 한정자 : 이걸로 한정하면 비동기메소드가됨
    ///     반환형식이 task , task<Tresult>,void 이여야한다.
    ///     작업끝날때까지 대기 라면 task , task<tresult>   [await 연산자 만나는 곳으로 제어권 넘겨줌 await 없으면 동기임]
    ///     연산하고 잊어버릴(shoot and forget) 이라면 void 로 선언 [await 없어도 비동기임]
    ///     
    /// await 연산자 :
    ///     
    ///     
    ///  
    /// 
    /// 
    ///  
    ///                
    /// </summary>
    class AsyncAwait
    {
        //Start 쓰기 
         async static void SomeThing(int count)
        {
            Console.WriteLine("C");
            Console.WriteLine("D");

            await Task.Run(async () =>
            {
                for(int i=1;i<=count;i++)
                {
                    Console.WriteLine("{0}/{1}", i, count);
                    //thread.sleep 의 비동기코드 반면 코드를 블록 안시킴
                    await Task.Delay(1);
                }
            });
            Console.WriteLine("G");
            Console.WriteLine("I");

        }
        public static void Caller()
        {
            Console.WriteLine("A");
            Console.WriteLine("B");

            SomeThing(3);
            Console.WriteLine("E");
            Console.WriteLine("F");
        }
    }



}

