using System;
using System.Security.Cryptography.X509Certificates;


namespace projectstudy
{
    /// <summary>
    /// class 안에 static 메서드를 선언할수잇다. 
    /// 대신 로컬 변수 못건들고 매계 변수 가지고 놀아야한다
    /// 
    /// 객체 생성없이 호출가능
    /// 메모리절약
    /// 의도성 명확해짐 [ 이 함수는 클래스상태랑 관련없음]
    /// 인스턴스 공유안해서 동기화 필요없어짐  [ 멀티스레드작업일때 유리해질듯 ?]
    /// </summary>
    public class StaticLocalFunction
    {
        public int Dmg=5;
        public static void PrintA(int DMG)
        {
            Console.WriteLine(DMG);
        }
        // StaticLocalFunction.PrintA(5); 이런느낌으로 객체안만들고 쓸수있다.
    }
}