using System.Collections;

namespace Variable;

using System;

class MainClass
{
	public static void Main(string[] args)
	{
		bool isPalindrome = true;
		
		Console.WriteLine("입력 : ");
		string word = Console.ReadLine();
		
		Stack st = new Stack();
		Queue q = new Queue();

		foreach (char c in word)
		{
			st.Push(c);
			q.Enqueue(c);
		}

		while (q.Count > 0)
		{
			char a = (char) q.Dequeue();
			char b = (char) st.Pop();
			
			if (a != b)
			{
				isPalindrome = false;
				break;
			}
			
		}
		
		if (isPalindrome)
			Console.WriteLine("참(True)");
		else
			Console.Write("거짓(False)");
	}
}