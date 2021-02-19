using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)			
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
			var vector1 = new MyVector(ax, bx, ay, by);
			var vector2 = new MyVector(ax, x, ay, y);
			var vector3 = new MyVector(bx, x, by, y);			
			if (vector2.GetMultiple(vector1) <= 0)
            {
				return vector2.GetLength();
            }
			if (vector3.GetMultiple(vector1) >= 0)
            {
				return vector3.GetLength();
            }
			var a = vector1.GetLength();
			var b = vector2.GetLength();
			var c = vector3.GetLength();
			var p = (a + b + c) / 2d;			
			return (2d * Math.Sqrt(p * (p - a)*(p - b)*(p - c))) / a;
		}			
	}

	public class MyVector
    {
		public readonly double X, Y, X1, X2, Y1, Y2;
		public MyVector(double x1, double x2, double y1, double y2)
        {
			X1 = x1;
			X2 = x2;
			Y1 = y1;
			Y2 = y2;
			X = X2 - X1;
			Y = Y2 - Y1;
        }

		public double GetLength()
        {			            
			return Math.Sqrt((this.X) * (this.X) + (this.Y) * (this.Y));			
        }

		public double GetMultiple(MyVector v2)
        {
			return (this.X * v2.X) + (this.Y * v2.Y);			
        }

		public double GetCosAngle(MyVector v2)
        {
			return Math.Acos(this.GetMultiple(v2) / (this.GetLength() * v2.GetLength()));
        }
    }
		

}