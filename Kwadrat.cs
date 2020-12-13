
using System;

namespace Fajguji
{

	public class Kwadrat : Figura 
	{
		public Kwadrat(double a)
		{
			bokA = a;
			
		}
		public double obliczPole()
		{
			return bokA * bokA;
		}
		public double obliczObwod()
		{
			return bokA * 4;
		}
		
	}
}
