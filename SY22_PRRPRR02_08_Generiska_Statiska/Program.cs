using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_08_Generiska_Statiska {
	internal class Program {
		static void Main(string[] args) {

			StringPrinter printer = new StringPrinter();

			printer.PrintString("Hej");
			printer.PrintString("Tjena");
			printer.PrintString("Daniel har planeringstid");
			printer.PrintString("Hallå");



			Console.WriteLine(printer.GetLastPrinted());


			IntPrinter intPrinter = new IntPrinter();
			intPrinter.PrintInt(0);
			intPrinter.PrintInt(1);
			intPrinter.PrintInt(2);
			intPrinter.PrintInt(3);

			Console.WriteLine(intPrinter.GetLastPrinted());

			Printer<double> doublePrinter = new Printer<double>();

			doublePrinter.Print(3.0);
			doublePrinter.Print(3.0);
			doublePrinter.Print(3.0);

			Console.WriteLine(doublePrinter.GetLastPrinted());

			List<int> intList = new List<int>();
			intList.Add(3);
		}
	}
}
