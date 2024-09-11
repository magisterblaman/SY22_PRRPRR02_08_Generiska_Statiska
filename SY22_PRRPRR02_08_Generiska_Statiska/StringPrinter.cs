using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_08_Generiska_Statiska {
	internal class StringPrinter {

		private List<string> _printHistory;

		public StringPrinter() {
			_printHistory = new List<string>();
		}

		public void PrintString(string toBePrinted) {
			Console.WriteLine(toBePrinted);
			_printHistory.Add(toBePrinted);
		}

		public string GetLastPrinted() {
			if (_printHistory.Count > 0) { 
				return _printHistory[_printHistory.Count - 1];
			} else {
				return "idiot";
			}
		}
	}
}
