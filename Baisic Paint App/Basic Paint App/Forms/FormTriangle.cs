using System;
using System.Drawing;
using System.Windows.Forms;

using Triangle = ShapesLibrary.Triangle;

namespace Basic_Paint_App
{
    public partial class FormTriangle : Form
    {
        private Triangle _triangle;

        public Triangle Triangle
        {
            get
            {
                return _triangle;
            }
            set
            {
                _triangle = value;

                textBoxSide.Text = Triangle.Width.ToString();
                textBoxHeight.Text = Triangle.Height.ToString();
                textBoxFirstPoint.Text = Triangle.points[0].ToString();
                textBoxMiddlePoint.Text = Triangle.points[1].ToString();
                textBoxEndPoint.Text = Triangle.points[2].ToString();
                textBoxArea.Text = Triangle.Area.ToString();

                buttonTriangleColor.BackColor = _triangle.ColorFill;
            }
        }
        public FormTriangle()
        {
            InitializeComponent();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Triangle.Width = int.Parse(textBoxSide.Text);
                Triangle.Height = int.Parse(textBoxHeight.Text);

                if (buttonTriangleColor.BackColor == SystemColors.Control)
                    Triangle.ColorFill = Color.Transparent;
                else
                {
                    if (buttonTriangleColor.BackColor == Color.White)
                    {
                        Triangle.ColorBorder = Color.Black;
                        Triangle.ColorFill = Color.Transparent;
                    }
                    else
                    {
                        Triangle.ColorBorder = buttonTriangleColor.BackColor;
                        Triangle.ColorFill = Color.FromArgb(175, buttonTriangleColor.BackColor);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonTriangleColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
                buttonTriangleColor.BackColor = cd.Color;
        }
    }
}
