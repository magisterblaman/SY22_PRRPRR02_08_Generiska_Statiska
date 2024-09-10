using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_08_Generiska_Statiska {
	internal class Biscuit {
		private static int _totalBitesTaken;

		public static int TotalBitesTaken {
			get {
				return _totalBitesTaken;
			}
			private set {
				_totalBitesTaken = value;
			}
		}

		private double _radius;
		private string _flavor;

		private int _bitesTaken;

		public double Radius {
			get {
				return _radius;
			}
			set {
				if (value > 0) {
					_radius = value;
				}
			}
		}
		public string Flavor {
			get {
				return _flavor;
			}
			set {
				if (value != "") {
					_flavor = value;
				}
			}
		}
		public int BitesTaken {
			get {
				return _bitesTaken;
			}
			private set {
				_bitesTaken = value;
			}
		}

		public Biscuit(double inputRadius, string inputFlavor) {
			Radius = inputRadius;
			Flavor = inputFlavor;
			BitesTaken = 0;
		}

		public void TakeABite() {
			TotalBitesTaken++;
			BitesTaken++;
			Radius -= 0.5;
			Console.WriteLine("Took a bite");
		}
	}
}
