using ShapesLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Ellipse = ShapesLibrary.Ellipse;
using Line = ShapesLibrary.Line;
using Rectangle = ShapesLibrary.Rectangle;
using Triangle = ShapesLibrary.Triangle;

namespace Basic_Paint_App
{
    public partial class FormScene : Form, IGraphics
    {
        private List<Shape> _shapes = new List<Shape>();

        private Rectangle _frameRectangle;
        private Ellipse _frameEllipse;
        private Triangle _frameTriangle;
        private Line _frameLine;

        private Point mouseDownLocation;
        private Point pointX;

        private int buttonIndex;
        private Graphics graphics;
        private Graphics graphicsDraw;
        private Bitmap bitmap;        
        private bool paint = false;

        public static int penThickness;
        private Pen pen = new Pen(newColor, penThickness);
        private Pen eraser = new Pen(Color.White, 10);
        public static Color newColor;

        public FormScene()
        {
            InitializeComponent();        

            AddButtons();

            SetStyle(
               ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint |
               ControlStyles.OptimizedDoubleBuffer,
               true);

            if (buttonColor.BackColor == SystemColors.Control)
                pen.Color = Color.Black;

            WindowSize();

            bitmap = new Bitmap(pictureBoxScene.Width, pictureBoxScene.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.Transparent);
            pictureBoxScene.Image = bitmap;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            graphicsDraw = e.Graphics;

            foreach (var s in _shapes)
                s.Paint(this);

            if (_frameRectangle != null)
                _frameRectangle.Paint(this);

            if (_frameEllipse != null)
                _frameEllipse.Paint(this);

            if (_frameTriangle != null)
                _frameTriangle.Paint(this);

            if (_frameLine != null)
                _frameLine.Paint(this);

            graphicsDraw = null;
        }

        private void pictureBoxScene_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            mouseDownLocation = e.Location;

            if (e.Button == MouseButtons.Right)
            {
                switch (buttonIndex)
                {
                    case 1:
                        _frameRectangle = new Rectangle { ColorBorder = Color.FromArgb(100, Color.Gray) };
                        break;
                    case 2:
                        _frameEllipse = new Ellipse{ ColorBorder = Color.FromArgb(100, Color.Gray) };
                        break;
                    case 3:
                        _frameTriangle = new Triangle { ColorBorder = Color.FromArgb(100, Color.Gray) };
                        break;
                    case 4:
                        _frameLine = new Line{ ColorBorder = Color.FromArgb(100, Color.Gray) };
                        break;
                    default:
                        return;
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (buttonIndex != 8)
                {
                    _frameRectangle = new Rectangle
                    {
                        ColorFill = Color.FromArgb(50, Color.Gray),
                        ColorBorder = Color.FromArgb(100, Color.Gray)
                    };
                }

                var deselectShapes = _shapes
                                     .Take(_shapes.Count())
                                     .ToList();
                deselectShapes.ForEach(s => s.Selected = false);

                var selectOneShape = _shapes
                                     .Take(_shapes.Count())
                                     .Where(s => s.PointInShape(e.Location))
                                     .Reverse();

                foreach (var shape in selectOneShape)
                {
                    shape.Selected = true;
                    break;
                }

                for (int s = _shapes.Count() - 1; s >= 0; s--)
                {
                    if (_shapes[s].PointInShape(e.Location))
                    {
                        if (_shapes.Count > 0)
                        {
                            if (buttonIndex == 6)
                            {
                                _shapes[s].ColorFill = Color.FromArgb(175, buttonColor.BackColor);
                                _shapes[s].ColorBorder = buttonColor.BackColor;
                            }
                        }

                        break;
                    }
                }
            }
        }

        private void CreateFrameRectangle(MouseEventArgs e)
        {
            if (_frameRectangle == null)
                return;

            _frameRectangle.Location = new Point
            {
                X = Math.Min(mouseDownLocation.X, e.Location.X),
                Y = Math.Min(mouseDownLocation.Y, e.Location.Y)
            };

            _frameRectangle.Width = Math.Abs(mouseDownLocation.X - e.Location.X);
            _frameRectangle.Height = Math.Abs(mouseDownLocation.Y - e.Location.Y);
        }

        private void CreateFrameEllipse(MouseEventArgs e)
        {
            if (_frameEllipse == null)
                return;

            _frameEllipse.Location = new Point
            {
                X = Math.Min(mouseDownLocation.X, e.Location.X),
                Y = Math.Min(mouseDownLocation.Y, e.Location.Y)
            };

            _frameEllipse.Radius1 = Math.Abs(mouseDownLocation.X - e.Location.X);
            _frameEllipse.Radius2 = Math.Abs(mouseDownLocation.Y - e.Location.Y);
        }

        private void CreateFrameTriangle(MouseEventArgs e)
        {
            if (_frameTriangle == null)
                return;

            _frameTriangle.Location = new Point
            {
                X = Math.Min(mouseDownLocation.X, e.Location.X),
                Y = Math.Min(mouseDownLocation.Y, e.Location.Y)
            };    

            _frameTriangle.Width = Math.Abs(mouseDownLocation.X - e.Location.X);
            _frameTriangle.Height = Math.Abs(mouseDownLocation.Y - e.Location.Y);
        }

        private void CreateFrameLine(MouseEventArgs e)
        {
            if (_frameLine == null)
                return;

            Point first = new Point(mouseDownLocation.X, mouseDownLocation.Y);
            Point end = new Point(e.Location.X, e.Location.Y);

            _frameLine.Location = new Point
            {
                X = Math.Min(mouseDownLocation.X, e.Location.X),
                Y = Math.Min(mouseDownLocation.Y, e.Location.Y)
            };

            _frameLine.firstPoint = first;
            _frameLine.endPoint = end;
        }

        private void pictureBoxScene_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint == true)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (buttonIndex == 5)
                    {
                        pointX = e.Location;
                        pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        graphics.DrawLine(pen, pointX, mouseDownLocation);
                        mouseDownLocation = pointX;
                    }

                    if (buttonIndex == 7)
                    {
                        pointX = e.Location;
                        eraser.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        eraser.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        graphics.DrawLine(eraser, pointX, mouseDownLocation);
                        mouseDownLocation = pointX;
                    }
                }

                if (buttonIndex == 8)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        for (int s = _shapes.Count() - 1; s >= 0; s--)
                        {
                            if (_shapes[s].Selected)
                                _shapes[s].Location = e.Location;
                            else 
                                _shapes[s].Selected = false;
                        }
                    }
                }

                Invalidate();

                if (e.Button == MouseButtons.Left)
                {
                    if (_frameRectangle == null)
                        return;

                    for (int s = 0; s < _shapes.Count(); s++)
                        _shapes[s].Selected = _shapes[s].Intersect(_frameRectangle);
                }
            }

            CreateFrameRectangle(e);
            CreateFrameEllipse(e);
            CreateFrameTriangle(e);
            CreateFrameLine(e);

            Invalidate();
        }

        private void pictureBoxScene_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            mouseDownLocation = e.Location;

            if (e.Button == MouseButtons.Right)
            {
                if (buttonIndex == 1)
                {
                    if (_frameRectangle == null)
                        return;

                    if (buttonColor.BackColor == SystemColors.Control)
                        _frameRectangle.ColorBorder = Color.Black;
                    else
                    {
                        _frameRectangle.ColorBorder = buttonColor.BackColor;
                        _frameRectangle.ColorFill = Color.FromArgb(175, buttonColor.BackColor);
                    }

                    var selectedShapes = _shapes
                                         .Take(_shapes.Count())
                                         .ToList();
                    selectedShapes.ForEach(x => x.Selected = false);

                    _shapes.Add(_frameRectangle);
                    _frameRectangle.Selected = true;
                }

                _frameRectangle = null;

                if (buttonIndex == 2)
                {
                    if (_frameEllipse == null)
                        return;

                    if (buttonColor.BackColor == SystemColors.Control)
                        _frameEllipse.ColorBorder = Color.Black;
                    else
                    {
                        _frameEllipse.ColorBorder = buttonColor.BackColor;
                        _frameEllipse.ColorFill = Color.FromArgb(175, buttonColor.BackColor);
                    }

                    var selectedShapes = _shapes
                                         .Take(_shapes.Count())
                                         .ToList();
                    selectedShapes.ForEach(x => x.Selected = false);

                    _shapes.Add(_frameEllipse);
                    _frameEllipse.Selected = true;
                }

                if (buttonIndex == 3)
                {
                    if (_frameTriangle == null)
                        return;

                    if (buttonColor.BackColor == SystemColors.Control)
                        _frameTriangle.ColorBorder = Color.Black;
                    else
                    {
                        _frameTriangle.ColorBorder = buttonColor.BackColor;
                        _frameTriangle.ColorFill = Color.FromArgb(175, buttonColor.BackColor);
                    }

                    var selectedShapes = _shapes
                                         .Take(_shapes.Count())
                                         .ToList();
                    selectedShapes.ForEach(x => x.Selected = false);

                    _shapes.Add(_frameTriangle);
                    _frameTriangle.Selected = true;
                }

                if (buttonIndex == 4)
                {
                    if (_frameLine == null)
                        return;

                    if (buttonColor.BackColor == SystemColors.Control)
                        _frameLine.ColorBorder = Color.Black;
                    else
                        _frameLine.ColorBorder = buttonColor.BackColor;

                    var selectedShapes = _shapes
                                         .Take(_shapes.Count())
                                         .ToList();
                    selectedShapes.ForEach(x => x.Selected = false);

                    _shapes.Add(_frameLine);
                    _frameLine.Selected = true;
                }
            }

            _frameRectangle = null;
            _frameEllipse = null;
            _frameTriangle = null;
            _frameLine = null;

            Invalidate();
            pictureBoxScene.Refresh();
        }

        private void FormScene_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                for (int s = _shapes.Count() - 1; s >= 0; s--)
                {
                    if (_shapes[s].Selected)
                        _shapes.RemoveAt(s);
                }
            }

            Invalidate();
        }

        private void pictureBoxRectangle_Click(object sender, EventArgs e)
        {
            buttonIndex = 1;
        }

        private void pictureBoxEllipse_Click(object sender, EventArgs e)
        {
            buttonIndex = 2;
        }

        private void pictureBoxTriangle_Click(object sender, EventArgs e)
        {
            buttonIndex = 3;
        }

        private void pictureBoxLine_Click(object sender, EventArgs e)
        {
            buttonIndex = 4;
        }

        private void pictureBoxPencil_Click(object sender, EventArgs e)
        {
            buttonIndex = 5;
        }

        private void pictureBoxColor_Click(object sender, EventArgs e)
        {
            buttonIndex = 6;

            if (_shapes.Count > 0)
            {
                var cd = new ColorDialog();

                if (cd.ShowDialog() == DialogResult.OK)
                    buttonColor.BackColor = cd.Color;
            }
            else
                MessageBox.Show("There are no shapes on the scene!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBoxEraser_Click(object sender, EventArgs e)
        {
            buttonIndex = 7;
        }

        private void pictureBoxCursor_Click(object sender, EventArgs e)
        {
            buttonIndex = 8;
        }

        private void pictureBoxPencil_DoubleClick(object sender, EventArgs e)
        {
            FormPencil fp = new FormPencil(buttonColor.BackColor, penThickness);

            if (fp.ShowDialog() == DialogResult.OK)
            {
                if (buttonColor.BackColor == SystemColors.Control)
                {
                    buttonColor.BackColor = fp.penColor;
                    pen.Color = buttonColor.BackColor;
                    pen = new Pen(buttonColor.BackColor, fp.penThickness);
                }
                else
                {
                    buttonColor.BackColor = fp.penColor;
                    pen.Color = buttonColor.BackColor;
                    pen = new Pen(buttonColor.BackColor, fp.penThickness);
                }
            }
        }

        private void AddButtons()
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>();
            
            pictureBoxes.Add(pictureBoxRectangle);
            pictureBoxes.Add(pictureBoxEllipse);
            pictureBoxes.Add(pictureBoxTriangle);
            pictureBoxes.Add(pictureBoxLine);
            pictureBoxes.Add(pictureBoxPencil);
            pictureBoxes.Add(pictureBoxColor);
            pictureBoxes.Add(pictureBoxEraser);
            pictureBoxes.Add(pictureBoxCursor);

            foreach (var pictureBox in pictureBoxes)
            {
                pictureBox.MouseHover += (s, e) => pictureBox.BackColor = Color.FromArgb(211, 211, 211);
                pictureBox.MouseMove += (s, e) => pictureBox.BackColor = Color.FromArgb(211, 211, 211);
                pictureBox.MouseLeave += (s, e) => pictureBox.BackColor = Color.White;
            }
        }

        private void WindowSize()
        {
            bitmap = new Bitmap(this.Width, this.Height);
        }

        private void pictureBoxScene_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (var shape in _shapes)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (shape.Selected)
                    {
                        switch (shape.ShapeNumber)
                        {
                            case 1:
                                var fr = new FormRectangle();
                                fr.Rectangle = (Rectangle)shape;
                                fr.ShowDialog();
                                break;
                            case 2:
                                var fe = new FormEllipse();
                                fe.Ellipse = (Ellipse)shape;
                                fe.ShowDialog();
                                break;
                            case 3:
                                var ft = new FormTriangle();
                                ft.Triangle = (Triangle)shape;
                                ft.ShowDialog();
                                break;
                        }
                    }
                }
            }

            pictureBoxScene.Refresh();
        }

        static Point SetPoint(PictureBox pb, Point point)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(point.X * pX), (int)(point.Y * pY));
        }

        private void pictureBoxPalette_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = SetPoint(pictureBoxPalette, e.Location);
            buttonColor.BackColor = ((Bitmap)pictureBoxPalette.Image).GetPixel(point.X, point.Y);
            newColor = buttonColor.BackColor;
            pen.Color = buttonColor.BackColor;
        }

        private void pictureBoxScene_Click(object sender, EventArgs e)
        {
            pictureBoxScene.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Data(*.data) | *.data | (*.*|*.*)";
                
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    IFormatter formatter = new BinaryFormatter();

                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        formatter.Serialize(fs, _shapes);
                        formatter.Serialize(fs, this.BackColor);
                    }
                }
            }
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Image(*.jpeg) | *.jpeg | (*.*|*.*)";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (Bitmap bm = new Bitmap(pictureBoxScene.Width, pictureBoxScene.Height))
                    {
                        pictureBoxScene.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, pictureBoxScene.Width, pictureBoxScene.Height));
                        bm.Save(sfd.FileName);
                    }
                }
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    IFormatter formatter = new BinaryFormatter();

                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                    {
                        _shapes = (List<Shape>)formatter.Deserialize(fs);
                        this.BackColor = (Color)formatter.Deserialize(fs);
                    }
                }
            }

            Invalidate();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            for (int s = _shapes.Count() - 1; s >= 0; s--)
                _shapes.RemoveAt(s);

            graphics.Clear(Color.Transparent);
            buttonColor.BackColor = SystemColors.Control;
            this.BackColor = Color.White;
            pen.Color = Color.Black;
            pen = new Pen(Color.Black, 1);

            Invalidate();
        }

        private void buttonBackground_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
                this.BackColor = cd.Color;
        }

        public void DrawRectangle(Color colorBorder, Color colorFill, int x, int y, int width, int height)
        {
            if(graphicsDraw != null)
            {
                using (var brush = new SolidBrush(colorFill))
                {
                    graphicsDraw.FillRectangle(brush, x, y, width, height);
                }

                using (var pen = new Pen(colorBorder, 3))
                {
                    graphicsDraw.DrawRectangle(pen, x, y, width, height);
                }
            }      
        }

        public void DrawEllipse(Color colorBorder, Color colorFill, int x, int y, int radius1, int radius2)
        {
            if (graphicsDraw != null)
            {
                using (var brush = new SolidBrush(colorFill))
                {
                    graphicsDraw.FillEllipse(brush, x, y, radius1, radius2);
                }

                using (var pen = new Pen(colorBorder, 3))
                {
                    graphicsDraw.DrawEllipse(pen, x, y, radius1, radius2);
                }
            }
        }

        public void DrawTriangle(Color colorBorder, Color colorFill, int x, int y, int width, int height, Point[] points)
        {
            points[0] = new Point() { X = x, Y = y + height };
            points[1] = new Point() { X = x + (width / 2), Y = y };
            points[2] = new Point() { X = x + width, Y = y + height };

            if (graphicsDraw != null)
            {
                using (var brush = new SolidBrush(colorFill))
                {
                    graphicsDraw.FillPolygon(brush, points);
                }

                using (var pen = new Pen(colorBorder, 3))
                {
                    graphicsDraw.DrawPolygon(pen, points);
                }
            }
        }

        public void DrawLine(Color colorBorder, Color colorFill, int x, int y, int width, int height, Point first, Point last)
        {
            if (graphicsDraw != null)
            {
                using (var pen = new Pen(colorBorder, 3))
                {
                    graphicsDraw.DrawLine(pen, first, last);
                }
            }
        }
    }
}