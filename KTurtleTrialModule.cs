using System;
namespace KTurtleTrialModule{
	public class Program
	{
		public static void Main(string[] args)
		{
			Greeter k1 = new Greeter;
			k1.Greet("User");
		}
	}
	public class Greeter
	{
		public void Greet(string User)
		{
			Console.WriteLine($"Hello {User}!");
		}
	}
}