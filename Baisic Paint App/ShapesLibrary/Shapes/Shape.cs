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
    public abstract class Shape
    {
        public Point Location { get; set; }

        protected internal int _height;
        public virtual int Height 
        { 
            get => _height;
            set
            {
                if(value < 0)
                    throw new InvalidValueException("Negative value of height not allowed!");

                _height = value;
            }
        }

        protected internal int _width;
        public virtual int Width 
        { 
            get => _width; 
            set
            {
                if (value < 0)
                    throw new InvalidValueException("Negative value of width not allowed!");

                _width = value;
            }
        }

        public virtual int ShapeNumber { get; set; }
        public Color ColorBorder { get; set; }
        public Color ColorFill { get; set; }

        [NonSerialized]
        protected internal bool _selected;
        public bool Selected 
        { 
            get => _selected; 
            set => _selected = value; 
        }

        public virtual float Area { get; set; }
        public abstract void Paint(IGraphics graphics);
        public abstract bool PointInShape(Point point);
        public abstract bool Intersect(Rectangle rectangle);
    }
}
