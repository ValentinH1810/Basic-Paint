using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    [Serializable]
    public class Rectangle : Shape
    {
        public override int ShapeNumber { get => 1; }
        public override float Area
        {
            get => Width * Height;
        }

        public override void Paint(IGraphics graphics)
        {
            var selectedColorBorder = Selected
                ? Color.Red
                : ColorBorder;

            graphics.DrawRectangle(selectedColorBorder, ColorFill, Location.X, Location.Y, Width, Height);
        }

        public override bool PointInShape(Point point)
        {
            return
                Location.X <= point.X && point.X <= Location.X + Width
                &&
                Location.Y <= point.Y && point.Y <= Location.Y + Height;
        }

        public override bool Intersect(Rectangle rectangle)
        {
            return
                this.Location.X <= rectangle.Location.X + rectangle.Width &&
                rectangle.Location.X <= this.Location.X + this.Width &&
                this.Location.Y <= rectangle.Location.Y + rectangle.Height &&
                rectangle.Location.Y <= this.Location.Y + this.Height;
        }
    }
}
