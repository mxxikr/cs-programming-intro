using System.Collections;

namespace Variable;

class MainClass {
  public static void Main(string[] args)
  { 
    Console.WriteLine("나눌 숫자를 입력하세요 : ");
    int divider = int.Parse(Console.ReadLine());

    try
    {
      Console.WriteLine(10 / divider);
    }
    catch (Exception e)
    {
      Console.WriteLine("예외 상황 : " + e.Message);
    }
  }
}