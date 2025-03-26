using System;
using System.Collections.Generic;


namespace projectstudy
{
    /// <summary>
    /// 파이썬에있던건데 C# 에 추가됨 인자 2개나 3개 정도 간단하게 넘길때
    /// 막 어거지로 struct class 만들어서 넘겨왔는데
    /// 간단하게 넘겨줄수있는타입
    /// </summary>
    public class Tuple
    {
        public void TA()
        {
            //item[Index] 로 접근가능하다
            (int,string) userdata = UserInfo(15,"KIM");
            DebugUserData(userdata.Item1,userdata.Item2);

            //이렇게도 받을수있고 이걸 Deconstruction 이라한데]
            (int Age , string Name)=userdata;
            Console.WriteLine($"유저정보는{Age} 의 나이와 {Name} 의 이름을 가지고있다.");
        }
        (int age, string name) UserInfo(int age, string name)
        {
            return (age, name);
        }
        public void DebugUserData(int age, string name)
        {
            Console.WriteLine($"유저정보는{age} 의 나이와 {name} 의 이름을 가지고있다.");
        }
    }


}
