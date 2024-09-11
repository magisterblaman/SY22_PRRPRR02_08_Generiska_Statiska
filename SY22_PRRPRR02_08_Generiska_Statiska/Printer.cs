using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_08_Generiska_Statiska {
	internal class Printer<T> {
		private List<T> _printHistory;

		public Printer() {
			_printHistory = new List<T>();
		}

		public void Print(T toBePrinted) {
			Console.WriteLine(toBePrinted);
			_printHistory.Add(toBePrinted);
		}

		public T GetLastPrinted() {
			if (_printHistory.Count > 0) {
				return _printHistory[_printHistory.Count - 1];
			} else {
				return default;
			}
		}
	}
}
