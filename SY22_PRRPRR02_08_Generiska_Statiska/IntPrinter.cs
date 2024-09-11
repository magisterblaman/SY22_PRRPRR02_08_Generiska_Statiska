using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_08_Generiska_Statiska {
	internal class IntPrinter {
		private List<int> _printHistory;

		public IntPrinter() {
			_printHistory = new List<int>();
		}

		public void PrintInt(int toBePrinted) {
			Console.WriteLine(toBePrinted);
			_printHistory.Add(toBePrinted);
		}

		public int GetLastPrinted() {
			if (_printHistory.Count > 0) {
				return _printHistory[_printHistory.Count - 1];
			} else {
				return -1;
			}
		}
	}
}
