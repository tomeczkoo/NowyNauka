
using System;

namespace Fajguji
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Kwadrat k1 = new Kwadrat(4.2); 
			Console.WriteLine(k1.obliczPole());
			Console.WriteLine(k1.obliczObwod());
			
			Kolo kol1 = new Kolo(8.1);
			Console.WriteLine(kol1.obliczPole());
			Console.WriteLine(kol1.obliczObwod());
			
			
		
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}