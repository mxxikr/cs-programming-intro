namespace Variable;

using System;

class Person
{

    public string Name = null;
    public string Birthday = null;
    public string Gender = null;

    public void Eat()
    {
        Console.WriteLine(Name + "이(가) 아침을 먹습니다.");
    }

    public void Walk()
    {
        Console.WriteLine(Name + "이(가) 걷습니다.");
    }
    
    public void Run()
    {
        Console.WriteLine(Name + "이(가) 뜁니다.");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Person p1;
        p1 = new Person();
        p1.Name = "서준";
        p1.Eat();
    }
}