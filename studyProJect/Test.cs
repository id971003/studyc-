using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace projectstudy
{

    class Test
    {
        static void Main(string[] arg)
        {
            AA();
            Console.Read();

        }
        static async void AA()
        {
            Console.WriteLine("1");
            await WaitForSecond(5);
            Console.WriteLine("2");   
        }
        public static async Task WaitForSecond(int a)
        {
            await Task.Delay(1000); // 1�� ��� (�񵿱���)
            Console.WriteLine("5");
        }

    }
}

