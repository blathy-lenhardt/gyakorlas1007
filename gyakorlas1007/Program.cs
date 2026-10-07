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

			// 4. feladat: Írjunk programot, mely a testsúly és a testmagasság alapján meghatározza a testtömegindexet,
			//	és kiírja, hogy milyen testsúly osztályba tartozik az adott illető.
			//	A testtömeg osztályokat meghatározhatjuk tetszőlegesen, de alapul vehetünk létező osztályozásokat is.
			// Testtömegindex = Testtömeg[kg] / Testmagasság ^ 2[m ^ 2]
			double tomeg, magassag, testtomegindex;
			Console.WriteLine("4. feladat");
			Console.Write("Adja meg a testsúlyát kilogrammban: ");
			tomeg = Convert.ToDouble(Console.ReadLine());
			Console.Write("Adja meg testmagasságát méterben: ");
			magassag = Convert.ToDouble(Console.ReadLine());
			testtomegindex = tomeg / Math.Pow(magassag, 2);
			if (testtomegindex < 16)
			{
				Console.WriteLine("Súlyos soványság");
			}
			else if (testtomegindex < 17)
			{
				Console.WriteLine("Mérsékelt soványság");
			}
			else if (testtomegindex < 18.5)
			{
				Console.WriteLine("Enyhe soványság");
			}
			else if (testtomegindex < 25)
			{
				Console.WriteLine("Normális testsúly");
			}
			else if (testtomegindex < 30)
			{
				Console.WriteLine("Túlsúlyos");
			}
			else if (testtomegindex < 35)
			{
				Console.WriteLine("1. fokú elhízás");
			}
			else if (testtomegindex < 40)
			{
				Console.WriteLine("2. fokú elhízás");
			}
			else
			{
				Console.WriteLine("3. fokú (súlyos) elhízás");
			}

			// 5. feladat: Készítsünk programot, amely bekéri a víz hőmérsékletét, majd eldönti, hogy az milyen halmazállapotú.
			//	A halmazállapot lehet folyékony, gőz, vagy jég.
			int vhomerseklet;
			Console.WriteLine("5. feladat");
			Console.Write("Adja meg a víz hőmérsékletét °C-ban: ");
			vhomerseklet = Convert.ToInt32(Console.ReadLine());
			if (vhomerseklet < 0)
			{
				Console.WriteLine("A {0}°C fokos víz, szilárd halmazállapotú", vhomerseklet);
			}
			else if (vhomerseklet > 100)
			{
				Console.WriteLine("A {0}°C fokos víz, gáz halmazállapotú", vhomerseklet);
			}
			else
			{
				Console.WriteLine("A {0}°C fokos víz, folyékony", vhomerseklet);
			}
		}
	}
}
