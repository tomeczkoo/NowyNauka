using System;

namespace Fajguji
{
	
	public class Kolo : Figura 
	{
		
		public Kolo(double r)
		{
			promien = r; 
		}
		
		public double obliczPole()
		{
			double potegaPromien = promien * promien;
			return PI * potegaPromien;
		}
		public double obliczObwod()
		{
			return 2*PI*promien; 
		}
	}
}
