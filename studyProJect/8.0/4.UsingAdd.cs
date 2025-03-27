using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using static projectstudy.UsingStatic;
using System.IO;
using System.Diagnostics;

namespace projectstudy
{

    /// <summary>
    /// Using 키워드추가 기존거랑 대비에서 더간결해지는데 구조가 좀더 불명확해진느김
    /// </summary>
    public class UsingAdd
    {
        // C# 8.0
        public void GetDataCS8()
        {
            using var reader = new StreamReader("testfile.txt");
            string data = reader.ReadToEnd();
            Debug.WriteLine(data);

            // 여기서 Dispose() 호출됨
        }

        // C# 모든 버전
        public void GetData()
        {
            using (var reader = new StreamReader("testfile.txt"))
            {
                string data = reader.ReadToEnd();
                Debug.WriteLine(data);
            }  // 여기서 Dispose() 호출됨

            // ...
            Debug.WriteLine("...");
        }
    }
}