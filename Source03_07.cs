namespace Variable;

using System;

class MainClass {
    static void Main(string[] args)
    {
        bool result;
        int num1, num2;

        num1 = 3;
        num2 = 5;
        
        result = num1 > num2;
        Console.WriteLine(result);
        
        result = num1 < num2;
        Console.WriteLine(result);
        
        result = num1 >= num2;
        Console.WriteLine(result);
        
        result = num1 <= num2;
        Console.WriteLine(result);
        
        result = num1 == num2;
        Console.WriteLine(result);
        
        result = num1 != num2;
        Console.WriteLine(result);
        
    }
}