using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /* 
     * 명명 매개변수: 매개 변수중 어떤 변수에 데이터를 지정할지 숫서 정사기 (? 사용처 : 매개변수가 많을때순서 섞기)
     * 
     * 선택적 매개 변수 : 매개변수중 기본 값을 가지고 싶을때
     */
    class ChoiceNameValue
    {
        static void Main(string[] arg)
        {
            Profile("김갑순", "12341234", "서울");
            Profile(name: "킴취", adress: "미국", phone: "43214321");

            Console.WriteLine(Sum(5));   //0~5 까지합
            Console.WriteLine(Sum(5, 0)); //0~5까지 합
            Console.WriteLine(Sum(5, 2)); // 2~5 까지합
        }
        static void Profile(string name, string phone, string adress)
        {
            Console.WriteLine("name : {0} phonenumber : {1} adress {2}", name, phone, adress);
        }

        static int Sum(int end, int start = 0)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
                sum += i;

            return sum;
        }

    }
}
