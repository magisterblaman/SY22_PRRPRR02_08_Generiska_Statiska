using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_08_Generiska_Statiska {
	internal static class MathUtilities {
		public static double Add(double a, double b) {
			return a + b;
		}

		public static double LawOfCosines(double b, double c, double A) {
			return Math.Sqrt(b * b + c * c - 2 * b * c * Math.Cos(A));
		}
	}
}
