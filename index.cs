using System;

namespace ejercicio1
{
  public class Program
 {


	public static void Main()
	{
		int a;
		int b;
		int c;
		
		a = 2;
		b = 4;
		c = 6;
		
		Console.WriteLine("linea aabc");
		Console.Write(a);
		Console.Write(a);
		Console.Write(c);
		Console.WriteLine(b);
		
		Console.WriteLine("linea bca");
		Console.Write(b);
		Console.Write(c);
		Console.WriteLine(a);
		
		Console.WriteLine("linea bcbc");
		Console.Write(b);
		Console.Write(c);
	    Console.Write(b);
		Console.WriteLine(c);}
  }
}