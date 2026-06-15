namespace Variable;

using System;

class Robot
{
    public void Move()
    {
        Console.WriteLine("Robot is moving");
    }
}

class CleanRobot : Robot
{
    public void Clean()
    {
        Console.WriteLine("Robot is cleaning");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        CleanRobot cleanRobot = new CleanRobot();
        cleanRobot.Move();
        cleanRobot.Clean();
    }
}