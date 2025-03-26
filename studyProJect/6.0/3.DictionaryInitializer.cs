
using System;
using System.Collections.Generic;
using System.Text;

namespace studyProJect
{
    /// <summary>
    /// 딕셔너리 선언할때 인덱서 처럼 [] 로 선언할수있음
    /// </summary>
    public static class DictionaryInitializer
    {
        //before
        static Dictionary<string,int> Userinfo=new Dictionary<string, int>()
        {
            {"User1",10},
            {"User2",10},
        };

        //New
        static Dictionary<string,int> UserAge=new Dictionary<string, int>()
        {
            ["User1"]=12,
            ["User2"]=13
        };
        public static void TA()
        {
            Console.WriteLine(Userinfo["User1"]);
            Console.WriteLine(UserAge["User1"]);
        }
    }
}