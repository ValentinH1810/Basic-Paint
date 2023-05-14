using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesLibrary.Exceptions;

namespace ShapesLibrary
{
    [Serializable]
    public class Ellipse : Shape
    {
        public override int ShapeNumber { get => 2; }

        protected internal int _radius1;
        public int Radius1 
        { 
            get => _radius1; 
            set
            {
                if (value < 0)
                    throw new InvalidValueException("Negative value of radius1 not allowed!");

                _radius1 = value;
            }
        }

        protected internal int _radius2;
        public int Radius2 
        {
            get => _radius2;
            set
            {
                if (value < 0)
                    throw new InvalidValueException("Negative value of radius2 not allowed!");

                _radius2 = value;
            }
        }
        public override float Area
        {
            get
            {
                return (float)Math.PI * (Radius1) * (Radius2);
            }
        }

        public override void Paint(IGraphics graphics)
        {
            var selectedColorBorder = Selected
                ? Color.Red
                : ColorBorder;

            graphics.DrawEllipse(selectedColorBorder, ColorFill, Location.X, Location.Y, Radius1, Radius2);
        }

        public override bool PointInShape(Point point)
        {
            return
                Location.X <= point.X && point.X <= Location.X + Radius1
                &&
                Location.Y <= point.Y && point.Y <= Location.Y + Radius2;
        }

        public override bool Intersect(Rectangle rectangle)
        {
            return
                this.Location.X <= rectangle.Location.X + rectangle.Width &&
                rectangle.Location.X <= this.Location.X + this.Radius1 &&
                this.Location.Y <= rectangle.Location.Y + rectangle.Height &&
                rectangle.Location.Y <= this.Location.Y + this.Radius2;
        }
    }
}
