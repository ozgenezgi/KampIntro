using System;

namespace KampIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Kurslar Kurs1 = new Kurslar();
			Kurs1.KursAdi = "c++";
			Kurs1.EgitmenAdi = "engin";
			Kurs1.IzlenmeOrani = 36;

			Kurslar Kurs2 = new Kurslar();
			Kurs2.KursAdi = "python";
			Kurs2.EgitmenAdi = "ezgi";
			Kurs2.IzlenmeOrani = 100;

			Kurslar[] Kurs = new Kurslar[] { Kurs1, Kurs2 };

			foreach (var Kurss in Kurs)
			{
				Console.WriteLine(Kurss);

			}

		}
	}
}
class Kurslar
{
	string KursAdi { get; set; }
	string EgitmenAdi { get; set; }
	int IzlenmeOrani { get; set; }

}
