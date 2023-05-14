using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Rectangle = ShapesLibrary.Rectangle;

namespace Basic_Paint_App
{
    public partial class FormRectangle : Form
    {
        private Rectangle _rectangle;

        public Rectangle Rectangle
        {
            get
            {
                return _rectangle;
            }
            set
            {

                _rectangle = value;

                textBoxWidth.Text = Rectangle.Width.ToString();
                textBoxHeight.Text = Rectangle.Height.ToString();
                textBoxX.Text = Rectangle.Location.X.ToString();
                textBoxY.Text = Rectangle.Location.Y.ToString();
                textBoxArea.Text = Rectangle.Area.ToString();

                buttonRectangleColor.BackColor = _rectangle.ColorFill;
            }
        }

        public FormRectangle()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Rectangle.Width = int.Parse(textBoxWidth.Text);
                Rectangle.Height = int.Parse(textBoxHeight.Text);

                if (buttonRectangleColor.BackColor == SystemColors.Control)
                    Rectangle.ColorFill = Color.Transparent;
                else
                {
                    if (buttonRectangleColor.BackColor == Color.White)
                    {
                        Rectangle.ColorBorder = Color.Black;
                        Rectangle.ColorFill = Color.Transparent;
                    }
                    else
                    {
                        Rectangle.ColorBorder = buttonRectangleColor.BackColor;
                        Rectangle.ColorFill = Color.FromArgb(175, buttonRectangleColor.BackColor);
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

        private void buttonRectangleColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
                buttonRectangleColor.BackColor = cd.Color;
        }
    }
}
