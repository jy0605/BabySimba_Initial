// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// babysimba 의 tools 내에 있는 클래스들을 모두 사용할 수 있게됨
using BabySimba.Tools;
using BabySimba.Extensions;

// -- Day 1
//Console.WriteLine(BabySimba.Tools.Application.Root); // Application(Class).Root(Property) 식으로 호출할 수 있다.

// -- Day 2
//LogManager log = new LogManager(null, "_BabySimbaTestApp");

//log.WriteLine("[Begin Processing]------");

// i가 각각의 프로세스라고 생각하면 아래와 같이 로그를 남길수도 있을 것임
//for (int i = 0; i < 10; i++)
//{
//    log.WriteConsole("Processing".PadRight(10) + ": " + i);
//    log.WriteLine("Processing".PadRight(10) + ": " + i);

//    // Do Processing
//    System.Threading.Thread.Sleep(500);

//    log.WriteLine("Done".PadRight(10) + ": " + i);

//}

//log.WriteLine("[End Processing]------");


// -- Day 3

// 확장메소드 구현하기
// 1. static class 안에서 구현이 되어야 함
// 2. static function으로 구현이 되어야 함
// 3. 첫번째 인자가 this를 붙이고 확장할 클래스나 타입이 와야 함
//public static class ExtensionTest
//{
//    public static void WriteConsole(this LogManager log, string data)
//    {
//        log.Write(data);
//        Console.WriteLine(data);
//    }
//}

// 웹앱 개발할때 특정 string이 날짜인지 체크하는 function을 유용하게 활용했었는데, 이를 한번 추가해보자.
// Extension method를 한군데에 모아보자.(Folder 생성, IsNumeric?. IsDataTime? 등)
// 자주사용하는 method를 추가추가하면 나중에 재산이 되는것임

//string temp = "2022-05-02";
// using BabySimba.Extensions; 으로 import
//Console.WriteLine("IsNumeric? : " + temp.IsNumeric());
//Console.WriteLine("IsDateTime? : " + temp.IsDatetime());


// 2022.5.2 => enum 개념 다시 확인(Boxing, unBoxing이랑 같이 정리)
enum City
{
    Seoul,   // 0
    Daejun,  // 1
    Busan = 5,  // 5
    Jeju = 10   // 10
}
namespace BabySimbaTestApp
{
    public static class Program
    {
        static void Main(string[] args)
        {
            // enum 타입 변수 myCity 선언
            City myCity;

            // myCity에 City.Seoul값을 대입
            myCity = City.Seoul;

            if (myCity == City.Seoul) // enum값 비교
            {
                Console.WriteLine("Welcome to Seoul");
            }
        }
    }

}