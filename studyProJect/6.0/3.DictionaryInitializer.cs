
using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /// <summary>
    /// 딕셔너리 선언할때 인덱서 처럼 [] 로 선언할수있음
    /// 
    /// 뿐만아니라 인덱서 지원하는 모든 객체에서 인덱서로 수정가능함
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



        static int[] ageList = new int[]{1,2,3};

        public static void Ta2()
        {
            //agelist 복사해서 2번 4로 바꿀수있음 근데굳이??
            var l = new List<int>(ageList){[2]=4};
            for(int i=0;i<ageList.Length;i++)
            {
                Console.WriteLine(ageList[i]);
            }
            foreach(var a in l)
            {
                
                Console.WriteLine(a);
            }
        }




        public static void TA()
        {
            Console.WriteLine(Userinfo["User1"]);
            Console.WriteLine(UserAge["User1"]);
        }
    }
}