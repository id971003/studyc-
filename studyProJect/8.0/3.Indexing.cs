using System;


namespace projectstudy
{
    /// <summary>
    /// index 가지고 노는건데
    /// Index  , Range 정도 추가됨
    /// 
    /// </summary>
    public class Indexing
    {
        public void TA()
        {
            string s = "Hello World";

            // System.Index
            Index idx = ^2; //뒤에서 2번째
            char ch = s[idx]; // l

            // System.Range
            Range r1 = 1..4; //1번부터 3번까지
            string str1 = s[r1]; // ell
            Index start = r1.Start; //r1의 1 번
            Index start2 = ^1;
            bool b = start.IsFromEnd; //  앞에서 부터 세서 false
            bool c = start2.IsFromEnd; // 뒤에서부터 세는놈이라 true
            int v1 = start.Value;  // 1
            int v2 = r1.End.Value; // 4
        }
    }
}