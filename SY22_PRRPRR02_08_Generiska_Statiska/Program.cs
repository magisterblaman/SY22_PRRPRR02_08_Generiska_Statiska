using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_08_Generiska_Statiska {
	internal class Program {
		static void Main(string[] args) {

			// Console.WriteLine(MathUtilities.Add(4, 5));

			Biscuit biscuit0 = new Biscuit(10, "umami");
			Biscuit biscuit1 = new Biscuit(7, "salt");
			Biscuit biscuit2 = new Biscuit(9.23, "sur");

			Console.WriteLine("Total bites taken: " + Biscuit.TotalBitesTaken);
			Console.WriteLine("0. Bites taken: " + biscuit0.BitesTaken);
			Console.WriteLine("1. Bites taken: " + biscuit1.BitesTaken);
			Console.WriteLine("2. Bites taken: " + biscuit2.BitesTaken);

			for (int i = 0; i < 10; i++) {
				biscuit0.TakeABite();
			}
			biscuit1.TakeABite();
			biscuit1.TakeABite();
			biscuit1.TakeABite();
			biscuit2.TakeABite();

			Console.WriteLine("Total bites taken: " + Biscuit.TotalBitesTaken);
			Console.WriteLine("0. Bites taken: " + biscuit0.BitesTaken);
			Console.WriteLine("1. Bites taken: " + biscuit1.BitesTaken);
			Console.WriteLine("2. Bites taken: " + biscuit2.BitesTaken);

		}
	}
}
