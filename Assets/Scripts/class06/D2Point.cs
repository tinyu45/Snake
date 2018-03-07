using System;
namespace Idefined
{
	public struct D2Point
	{
		double x;
		double y;

		public D2Point(double x, double y){
			this.x = x;
			this.y = y;
		}


		public string ToString(){
			return "("+x+","+y+")";
		}

		public static double GetDis(D2Point d1, D2Point d2){
			double dx = d1.x - d2.x;
			double dy = d1.y - d2.y;
			return Math.Sqrt (dx * dx + dy * dy);
		}


		public static D2Point operator+(D2Point d1, D2Point d2){
			return new D2Point (d1.x+d2.x, d1.y+d2.y);
		}
	}



}

