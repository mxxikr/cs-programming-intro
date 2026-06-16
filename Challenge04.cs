namespace Variable;

using System;

class Car
{
    private string name = null;
    private int speed = 0;

    public Car(String name, int speed)
    {
        this.name = name;
        this.speed = speed;
    }
    
    public string getName()
    {
        return this.name;
    }

    public int getSpeed()
    {
        return this.speed;
    }

    public void MovingForward()
    {
        Console.WriteLine("Car is moving forward");
    }

    public void MovingBackward()
    {
        Console.WriteLine("Car is moving backward");
    }

    public void MovingLeft()
    {
        Console.WriteLine("Car is moving left");    
    }

    public void MovingRight()
    {
        Console.WriteLine("Car is moving right");
    }
    
    public void StopMoving()
    {
        Console.WriteLine("Car is stop moving");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Car car = new Car("소나타", 88);
        car.MovingForward();
        car.MovingBackward();
        car.MovingLeft();
        car.MovingRight();
        car.StopMoving();
        
        Console.WriteLine(car.getName());
        Console.WriteLine(car.getSpeed());  
    }
}