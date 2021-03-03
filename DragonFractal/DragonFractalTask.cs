// В этом пространстве имен содержатся средства для работы с изображениями. 
// Чтобы оно стало доступно, в проект был подключен Reference на сборку System.Drawing.dll
using System.Drawing;
using System;

namespace Fractals
{
	internal static class DragonFractalTask
	{
		public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
		{
			var random = new Random(seed); // Создаем генератор рандомных чисел с сидом seed
										   // Начнаем с точки (1, 0)
			double x = 1; 
			double y = 0;
			// На каждой итерации цикла: выбираем случайно одно из преобразований, которое пересчитывает значения для точки и рисуем ее методом pixels.SetPixel(x, y).
			for (int i = 0; i < iterationsCount; i++)
            {
				if (random.Next() % 2d == 0)
                {
					var x1 = (x * Math.Cos(Math.PI / 4d) - y * Math.Sin(Math.PI / 4d)) / Math.Sqrt(2);
					var y1 = (x * Math.Sin(Math.PI / 4d) + y * Math.Cos(Math.PI / 4d)) / Math.Sqrt(2);
					x = x1;
					y = y1;
					pixels.SetPixel(x, y); 
				}
				else
                {
					var x1 = (x * Math.Cos(3 * Math.PI / 4d) - y * Math.Sin(3 * Math.PI / 4d)) / Math.Sqrt(2) + 1;
					var y1 = (x * Math.Sin(3 * Math.PI / 4d) + y * Math.Cos(3 * Math.PI / 4d)) / Math.Sqrt(2);
					x = x1;
					y = y1;
					pixels.SetPixel(x, y);
				}
			}
		}
	}
}