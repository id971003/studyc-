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
    /// <summary>
    /// 인터페이스 는 상속받으면 해당 인터페이스내부 모든 메서드 바디 구현 해줘야하는데 
    /// 이미쓰다가 추가된 메서드가 생기면 그 인터페이스 상속받는 모든 곳에서 다 추가해줘야한다.
    /// 그래서 기본형을 구현해놓을수 있다더라
    /// </summary>
    public class DefaultInterFace : ITestInterFace
    {
        public void test(string testMessage)
        {

        }
        //기본형 잡아놔서 구현 안해도 오류 안뜸
        // public void test(int testInt)
        // {
        // }
        

        //기본형있어도 이렇게 구현해주면 기본형 무시하고 구현된거 쓸수있다.
        public void test(int TestInt)
        {
            Console.WriteLine("123123");
        }
    }

    public interface ITestInterFace
    {
        void test(string testMessage);

        //이렇게 기본형 잡아줄수있음
        void test(int TestInt)
        {
            Console.WriteLine(TestInt);
        }
    }
}