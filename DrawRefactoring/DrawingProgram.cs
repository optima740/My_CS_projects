using System;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace RefactorMe
{
    class Risovatel
    {
        static float x, y;
        static Graphics graphics;

        public static void Initialization(Graphics newGraphics)
        {
            //Инициализирует объект типа graphics, c черной заливкой
            graphics = newGraphics;
            graphics.SmoothingMode = SmoothingMode.None;
            graphics.Clear(Color.Black);
        }

        public static void SetPosition(float x0, float y0)
        {
            //Задает начальную точку
            x = x0;
            y = y0;
        }

        public static void MakeIt(Pen pen, double length, double angle)
        {
            //Делает шаг длиной length в направлении angle и рисует пройденную траекторию
            var x1 = (float)(x + length * Math.Cos(angle));
            var y1 = (float)(y + length * Math.Sin(angle));
            graphics.DrawLine(pen, x, y, x1, y1);
            x = x1;
            y = y1;
        }

        public static void Change(double length, double angle)
        {
            //Изменяет на заданный угол
            x = (float)(x + length * Math.Cos(angle));
            y = (float)(y + length * Math.Sin(angle));
        }
    }

    public class ImpossibleSquare
    {
        public static void Draw(int width, int height, double angleRotate, Graphics graphics)
        {
            // Рисует фигуру
            // angleRotate не используется
            Risovatel.Initialization(graphics);
            var sz = Math.Min(width, height);
            var diagonal_length = Math.Sqrt(2) * (sz * 0.375f + sz * 0.04f) / 2;
            var x0 = (float)(diagonal_length * Math.Cos(Math.PI / 4 + Math.PI)) + width / 2f;
            var y0 = (float)(diagonal_length * Math.Sin(Math.PI / 4 + Math.PI)) + height / 2f;
            Risovatel.SetPosition(x0, y0);
            //Рисуем 1-ую сторону
            Risovatel.MakeIt(Pens.Yellow, sz * 0.375f, 0);
            Risovatel.MakeIt(Pens.Yellow, sz * 0.04f * Math.Sqrt(2), Math.PI / 4);
            Risovatel.MakeIt(Pens.Yellow, sz * 0.375f, Math.PI);
            Risovatel.MakeIt(Pens.Yellow, sz * 0.375f - sz * 0.04f, Math.PI / 2);
            Risovatel.Change(sz * 0.04f, -Math.PI);
            Risovatel.Change(sz * 0.04f * Math.Sqrt(2), 3 * Math.PI / 4);
            //Рисуем 2-ую сторону
            Risovatel.MakeIt(Pens.Yellow, sz * 0.375f, -Math.PI / 2);
            Risovatel.MakeIt(Pens.Yellow, sz * 0.04f * Math.Sqrt(2), -Math.PI / 2 + Math.PI / 4);
            Risovatel.MakeIt(Pens.Yellow, sz * 0.375f, -Math.PI / 2 + Math.PI);
            Risovatel.MakeIt(Pens.Yellow, sz * 0.375f - sz * 0.04f, -Math.PI / 2 + Math.PI / 2);
            Risovatel.Change(sz * 0.04f, -Math.PI / 2 - Math.PI);
            Risovatel.Change(sz * 0.04f * Math.Sqrt(2), -Math.PI / 2 + 3 * Math.PI / 4);
            //Рисуем 3-ю сторону
            Risovatel.MakeIt(Pens.Yellow, sz * 0.375f, Math.PI);
            Risovatel.MakeIt(Pens.Yellow, sz * 0.04f * Math.Sqrt(2), Math.PI + Math.PI / 4);
            Risovatel.MakeIt(Pens.Yellow, sz * 0.375f, Math.PI + Math.PI);
            Risovatel.MakeIt(Pens.Yellow, sz * 0.375f - sz * 0.04f, Math.PI + Math.PI / 2);
            Risovatel.Change(sz * 0.04f, Math.PI - Math.PI);
            Risovatel.Change(sz * 0.04f * Math.Sqrt(2), Math.PI + 3 * Math.PI / 4);
            //Рисуем 4-ую сторону
            Risovatel.MakeIt(Pens.Yellow, sz * 0.375f, Math.PI / 2);
            Risovatel.MakeIt(Pens.Yellow, sz * 0.04f * Math.Sqrt(2), Math.PI / 2 + Math.PI / 4);
            Risovatel.MakeIt(Pens.Yellow, sz * 0.375f, Math.PI / 2 + Math.PI);
            Risovatel.MakeIt(Pens.Yellow, sz * 0.375f - sz * 0.04f, Math.PI / 2 + Math.PI / 2);
            Risovatel.Change(sz * 0.04f, Math.PI / 2 - Math.PI);
            Risovatel.Change(sz * 0.04f * Math.Sqrt(2), Math.PI / 2 + 3 * Math.PI / 4);
        }
    }
}