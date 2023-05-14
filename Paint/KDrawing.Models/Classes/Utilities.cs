using KDrawing.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace KDrawing.Models
{
    public class Utilities
    {
      
        public static PointF RotatePoint(PointF pointToRotate, PointF centerPoint, int angleInDegrees)
        {
            double angleInRadians = angleInDegrees * (Math.PI / 180);
            double cosTheta = Math.Cos(angleInRadians);
            double sinTheta = Math.Sin(angleInRadians);

            float x = (float)(cosTheta * (pointToRotate.X - centerPoint.X) - sinTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.X);
            float y = (float)(sinTheta * (pointToRotate.X - centerPoint.X) + cosTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.Y);
            return new PointF(x, y);
        }

        public static PointF MovePoint(PointF pointToMove, Direction direction, int movingOffset)
        {
            float x = pointToMove.X;
            float y = pointToMove.Y;

            if (direction == Direction.Left) { x -= movingOffset; }
            else if (direction == Direction.Up) { y -= movingOffset; }
            else if (direction == Direction.Right) { x += movingOffset; }
            else if (direction == Direction.Down) { y += movingOffset; }

            return new PointF(x, y);
        }

        public static Bitmap CreateBimap(int width, int heigth, Color backColor, List<MyShape> listShapes)
        {
            Bitmap bitmap = new Bitmap(width, heigth, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(backColor);
            listShapes.FindAll(shape => !shape.IsHidden).ForEach(shape => shape.Draw(graphics));
            return bitmap;
        }
    }
}
