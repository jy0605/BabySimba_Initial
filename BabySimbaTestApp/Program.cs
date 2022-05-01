// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// babysimba 의 tools 내에 있는 클래스들을 모두 사용할 수 있게됨
using BabySimba.Tools;

// -- Day 1
Console.WriteLine(BabySimba.Tools.Application.Root); // Application(Class).Root(Property) 식으로 호출할 수 있다.

// -- Day 2
LogManager log = new LogManager(null, "_BabySimbaTestApp");

log.WriteLine("[Begin Processing]------");

// i가 각각의 프로세스라고 생각하면 아래와 같이 로그를 남길수도 있을 것임
for (int i = 0; i < 10; i++)
{
    log.WriteConsole("Processing".PadRight(10) + ": " + i);
    log.WriteLine("Processing".PadRight(10) + ": " + i);

    // Do Processing
    System.Threading.Thread.Sleep(500);

    log.WriteLine("Done".PadRight(10) + ": " + i);

}

log.WriteLine("[End Processing]------");


// 확장메소드 구현하기
// 1. static class 안에서 구현이 되어야 함
// 2. static function으로 구현이 되어야 함
// 3. 첫번째 인자가 this를 붙이고 확장할 클래스나 타입이 와야 함
public static class ExtensionTest
{
    public static void WriteConsole(this LogManager log, string data)
    {
        log.Write(data);
        Console.WriteLine(data);
    }
}

