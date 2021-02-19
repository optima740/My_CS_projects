using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
		public static int GetAreaRectangle(Rectangle r)
		{
			if (r.Width == 0 && r.Height == 0) return 0;
			if (r.Width == 0 && r.Height != 0) return r.Height;
			if (r.Width != 0 && r.Height == 0) return r.Width;
			return r.Width * r.Height;
		}

		// Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)	
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
			//((max_x1 > min_x2) и(max_x2 > min_x1) и(max_y1 > min_y2) и(max_y2 > min_y1))			
			return (r1.Top + r1.Height >= r2.Top)
			&& (r2.Top + r2.Height >= r1.Top) && (r1.Left + r1.Width >= r2.Left)
			&& (r2.Left + r2.Width >= r1.Left);
		}

		public static int GetSegments(int a1, int a2, int b1, int b2)
		{
			int plane1 = Math.Max(a1, b1);
			int plane2 = Math.Min(a2, b2);
			return Math.Max(plane2 - plane1, 0);
		}

		// Площадь пересечения прямоугольников
		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
			int xIntersection = GetSegments(r1.Top, r1.Top + r1.Height, r2.Top, r2.Top + r2.Height);
			int yIntersection = GetSegments(r1.Left, r1.Left + r1.Width, r2.Left, r2.Left + r2.Width);
			return xIntersection * yIntersection;
		}

		// Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
		// Иначе вернуть -1
		// Если прямоугольники совпадают, можно вернуть номер любого из них.
		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
			if (IntersectionSquare(r1, r2) == 0)
            {
				if ((r2.Top >= r1.Top & r2.Top + r2.Height <= r1.Top + r1.Height) & (r2.Left >= r1.Left & r2.Left + r2.Width <= r1.Left + r1.Width))
				{
					return 1;
				}
				if ((r1.Top >= r2.Top & r1.Top + r1.Height <= r2.Top + r2.Height) & (r1.Left >= r2.Left & r1.Left + r1.Width <= r2.Left + r2.Width))
				{
					return 0;
				}
			return -1;
			}
			if (IntersectionSquare(r1, r2) != 0)
            {
				if (IntersectionSquare(r1, r2) == GetAreaRectangle(r1)) return 0;
				if (IntersectionSquare(r1, r2) == GetAreaRectangle(r2)) return 1;
			}
			return -1;
		}	
	}

}
