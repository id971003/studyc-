
using static System.Console;


namespace studyProJect
{
    /// <summary>
    /// static 메서드 쓸라면 classname.mathodname 과같이 해야했는데
    /// using static 으로 선언해주면  생략가능
    /// </summary>
    public static class UsingStatic
    {
        public static void TestClas()
        {
            WriteLine("1");
            ///사용처에서도 TestClas(); 로 사용가능  using static studyProJect.UsingStatic; 해줬을경우
        }
    }
}
