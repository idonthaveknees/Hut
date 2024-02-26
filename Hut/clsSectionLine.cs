using System;
using System.Drawing;

namespace Hut
{
    internal class clsSectionLine
    {
        public int Id { get; set; }
        public PointF StartPoint { get; set; }
        public PointF EndPoint { get; set; }
        public int Length { get; set; }

        public clsSectionLine(int id, PointF startPoint, PointF endPoint)
        {
            Id = id;
            StartPoint = startPoint;
            EndPoint = endPoint;
            Length = (int)Math.Round(Math.Sqrt(Math.Pow(EndPoint.X / 2 - StartPoint.X / 2, 2) + Math.Pow(EndPoint.Y / 2 - StartPoint.Y / 2, 2)));
        }
    }
}
