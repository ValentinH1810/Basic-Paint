using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ellipse = ShapesLibrary.Ellipse;

namespace Basic_Paint_App
{
    public partial class FormEllipse : Form
    {
        private Ellipse _ellipse;

        public Ellipse Ellipse
        {
            get
            {
                return _ellipse;
            }
            set
            {

                _ellipse = value;

                textBoxRadius1.Text = Ellipse.Radius1.ToString();
                textBoxRadius2.Text = Ellipse.Radius2.ToString();
                textBoxX.Text = Ellipse.Location.X.ToString();
                textBoxY.Text = Ellipse.Location.Y.ToString();
                textBoxArea.Text = Ellipse.Area.ToString();

                buttonEllipseColor.BackColor = _ellipse.ColorFill;
            }
        }
        public FormEllipse()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Ellipse.Radius1 = int.Parse(textBoxRadius1.Text);
                Ellipse.Radius2 = int.Parse(textBoxRadius2.Text);

                if (buttonEllipseColor.BackColor == SystemColors.Control)
                    Ellipse.ColorFill = Color.Transparent;
                else
                {
                    if (buttonEllipseColor.BackColor == Color.White)
                    {
                        Ellipse.ColorBorder = Color.Black;
                        Ellipse.ColorFill = Color.Transparent;
                    }
                    else
                    {
                        Ellipse.ColorBorder = buttonEllipseColor.BackColor;
                        Ellipse.ColorFill = Color.FromArgb(175, buttonEllipseColor.BackColor);
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

        private void buttonEllipseColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
                buttonEllipseColor.BackColor = cd.Color;
        }
    }
}
