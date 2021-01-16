using System;

namespace ClassIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Kurslar Kurs1 = new Kurslar();
			Kurs1.KursAdi = "c++";
			Kurs1.EgitmenAdi = "engin";
			Kurs1.IzlenmeOrani = 36;

			Kurslar Kurs2 = new Kurslar();
			Kurs2.KursAdi = "python";
			Kurs2.EgitmenAdi = "ezgi";
			Kurs2.IzlenmeOrani = 100;


			Kurslar Kurs3 = new Kurslar();
			Kurs3.KursAdi = "java";
			Kurs3.EgitmenAdi = "Kerem varış";
			Kurs3.IzlenmeOrani = 50;

			Kurslar[] Kurs = new Kurslar[] { Kurs1, Kurs2, Kurs3 };

			foreach (var Kurss in Kurs)
			{
				Console.WriteLine(Kurss.KursAdi +" : "+ Kurss.EgitmenAdi);

			}

		}
	}

}
class Kurslar
	{
		public string KursAdi { get; set; }
		public string EgitmenAdi { get; set; }
		public int IzlenmeOrani { get; set; }

	}


