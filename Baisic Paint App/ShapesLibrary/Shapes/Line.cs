using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    [Serializable]
    public class Line : Shape
    {
        public override int ShapeNumber { get => 4; }
        public Point firstPoint { get; set; }
        public Point endPoint { get; set; }

        public override float Area
        {
            get
            {
                int area = 0;
                area += Math.Abs(endPoint.X - firstPoint.X);
                return area;
            }
        }

        public override void Paint(IGraphics graphics)
        {
            var selectedColorBorder = Selected
               ? Color.Red
               : ColorBorder;

            graphics.DrawLine(selectedColorBorder, ColorFill, Location.X, Location.Y, Width, Height, firstPoint, endPoint);
        }

        public override bool PointInShape(Point point)
        {
            return
                Location.X <= point.X && point.X <= Location.X + Math.Abs(endPoint.X - firstPoint.X)
                &&
                Location.Y <= point.Y && point.Y <= Location.Y + Math.Abs(endPoint.Y - firstPoint.Y);
        }

        public override bool Intersect(Rectangle rectangle)
        {         
            return
                this.Location.X <= rectangle.Location.X + rectangle.Width &&
                rectangle.Location.X <= this.Location.X + Math.Abs(endPoint.X - firstPoint.X)  &&
                this.Location.Y <= rectangle.Location.Y + rectangle.Height &&
                rectangle.Location.Y <= this.Location.Y + Math.Abs(endPoint.Y - firstPoint.Y);
        }
    }
}
