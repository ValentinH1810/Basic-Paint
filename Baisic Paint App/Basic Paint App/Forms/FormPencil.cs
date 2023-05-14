using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Paint_App
{
    public partial class FormPencil : Form
    {
        public Color penColor;
        public int penThickness;

        public FormPencil(Color color, int thickness)
        {
            penColor = color;
            penThickness = thickness;
            InitializeComponent();
        }

        private void comboBoxThickness_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxThickness.SelectedIndex)
            {
                case 1:
                    penThickness = 1;
                    break;
                case 2:
                    penThickness = 2;
                    break;
                case 3:
                    penThickness = 3;
                    break;
                case 4:
                    penThickness = 4;
                    break;
                case 5:
                    penThickness = 5;
                    break;
                case 6:
                    penThickness = 6;
                    break;
                case 7:
                    penThickness = 7;
                    break;
                case 8:
                    penThickness = 8;
                    break;
                case 9:
                    penThickness = 9;
                    break;
                case 10:
                    penThickness = 10;
                    break;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (buttonPencilColor.BackColor == SystemColors.Control)
                penColor = Color.Black;
            else
                penColor = buttonPencilColor.BackColor;

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
                buttonPencilColor.BackColor = cd.Color;
        }
    }
}
