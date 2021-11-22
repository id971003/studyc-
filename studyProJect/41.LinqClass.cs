using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace projectstudy
{
    /*
    Linq : 데이터를 관리하는법
    from : 어디 있는 데이터를 관리할지
    where : 어떤 조건의 데이터를 뽑을지
    orderby : 어떻게 정렬할지 
    Select : 어떤 항목을 뽑을지
    */
    class LinqClass
    {
        public static void LinqClassTestClass()
        {
            Car[] CarArray =
            {
                new Car(){Cost= 57 , MaxSpeed=100},
                new Car(){Cost= 58 , MaxSpeed=120},
                new Car(){Cost= 60 , MaxSpeed=90},
                new Car(){Cost= 45 , MaxSpeed=120}

            };

            var Cars = from Car in CarArray //CarArray 안에
                       where Car.Cost < 58 && Car.MaxSpeed > 110  // cost 가 58 보다작고 Maxspeed 가 110 보다 큰
                       orderby Car.Cost ascending // 값들을 cost 를 기준으로 오름차순으로 정렬해
                       select Car; //Car를 추출한다

            foreach (var car in Cars)
                Console.WriteLine("{0}{1}", car.Cost, car.MaxSpeed);

        }
    }
    class Car
    {
        public int Cost
        {
            get; set;
        }
        public int MaxSpeed
        {
            get; set;
        }
    }
}
