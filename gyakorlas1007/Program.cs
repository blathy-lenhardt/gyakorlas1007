using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas1007
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 1. feladat: Írj programot, mely beolvas két pozitív egész számot, és kiírja a számtani és mértani közepüket!
			uint x, y;
			double szamtani_kozep, mertani_kozep;
			Console.WriteLine("1. feladat");
			Console.Write("Adjon meg egy pozitív egész számot: ");
			x = Convert.ToUInt32(Console.ReadLine());
			Console.Write("Adjon meg egy új pozitív egész számot: ");
			y = Convert.ToUInt32(Console.ReadLine());
			szamtani_kozep = ((double)x + y) / 2;
			mertani_kozep = Math.Sqrt(x * y);
			Console.WriteLine("Számtani közép: {0:0.00}\nMértani közép: {1:0.00}", szamtani_kozep, mertani_kozep);

			// 2. feladat: Írj programot, mely beolvassa a téglatest három élének hosszát, és kiírja a felszínének és térfogatának mérőszámát!
			double a, b, c, felszin, terfogat;
			Console.WriteLine("2. feladat");
			Console.Write("Adja meg a téglatest első élét: ");
			a = Convert.ToDouble(Console.ReadLine());
			Console.Write("Adja meg a téglatest második élét: ");
			b = Convert.ToDouble(Console.ReadLine());
			Console.Write("Adja meg a téglatest harmadik élét: ");
			c = Convert.ToDouble(Console.ReadLine());
			felszin = 2 * (a * b + a * c + c * b);
			terfogat = a * b * c;
			Console.WriteLine("A téglatest felszíne: {0:0.00}, térfogata: {1:0.00}", felszin, terfogat);

			// 3. feladat: Készítsünk programot, mely bekér egy hőmérséklet értéket,
			//	majd felajánlja, hogy Celsiusból Fahrenheitbe, vagy Fahrenheitből Celsiusba váltja át.
			double homerseklet;
			char answer;
			Console.WriteLine("3. feladat");
			Console.Write("Adja meg a hőmérsékletet: ");
			homerseklet = Convert.ToDouble(Console.ReadLine());
			Convert: Console.Write("Milyen hőmérsékletbe váltsa át? (c/f) ");
			answer = Convert.ToChar(Console.ReadLine());
			if (answer == 'c')
			{
				Console.Write("{0:0.00}°F = ", homerseklet);
				homerseklet = (homerseklet - 32) * ((double)5 / 9);
				Console.WriteLine("{0:0.00}°C", homerseklet);
			} else if (answer == 'f')
			{
				Console.Write("{0:0.00}°C = ", homerseklet);
				homerseklet = homerseklet * ((double)9 / 5) + 32;
				Console.WriteLine("{0:0.00}°F", homerseklet);
			}
			else
			{
				Console.WriteLine("Hibás bemenet, c vagy f betűt adjon meg.");
				goto Convert;
			}
		}
	}
}
