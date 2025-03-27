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
    /// ref 레퍼런스타입선언을 return type 에도 할수있다.
    /// </summary>
    class ReturnRef
    {
        public void TA()
        {
            UserAge userAge = new UserAge(5);
            int age = userAge.Age;
            age = 10;
            Console.WriteLine($"{userAge.Age}랑{age}"); //5랑 10찍혀서 다르게나옴


            userAge = new UserAge(5);
            ref int refage =ref userAge.getUserAge();
            refage = 10;
            Console.WriteLine($"{userAge.Age}랑{refage}"); //10이랑 10 같게 찍힘
        }

    }
    public class UserAge
    {
        public int Age;
        public UserAge(int a)
        {
            this.Age = a;
        }
        public ref int getUserAge()
        {
            return ref Age;
        }
    }
}
