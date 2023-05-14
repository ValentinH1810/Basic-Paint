
namespace Basic_Paint_App
{
    partial class FormEllipse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelCoordinates = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxRadius2 = new System.Windows.Forms.TextBox();
            this.labelRadius2 = new System.Windows.Forms.Label();
            this.textBoxRadius1 = new System.Windows.Forms.TextBox();
            this.labelRadius1 = new System.Windows.Forms.Label();
            this.buttonEllipseColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxY
            // 
            this.textBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxY.Location = new System.Drawing.Point(220, 68);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(121, 30);
            this.textBoxY.TabIndex = 23;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.Location = new System.Drawing.Point(196, 71);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(31, 25);
            this.labelY.TabIndex = 22;
            this.labelY.Text = "Y:";
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX.Location = new System.Drawing.Point(50, 68);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(121, 30);
            this.textBoxX.TabIndex = 21;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(24, 71);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(32, 25);
            this.labelX.TabIndex = 20;
            this.labelX.Text = "X:";
            // 
            // labelCoordinates
            // 
            this.labelCoordinates.AutoSize = true;
            this.labelCoordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoordinates.Location = new System.Drawing.Point(24, 24);
            this.labelCoordinates.Name = "labelCoordinates";
            this.labelCoordinates.Size = new System.Drawing.Size(124, 25);
            this.labelCoordinates.TabIndex = 19;
            this.labelCoordinates.Text = "Coordinates:";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxArea.Location = new System.Drawing.Point(231, 188);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.ReadOnly = true;
            this.textBoxArea.Size = new System.Drawing.Size(121, 30);
            this.textBoxArea.TabIndex = 33;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArea.Location = new System.Drawing.Point(226, 160);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(60, 25);
            this.labelArea.TabIndex = 32;
            this.labelArea.Text = "Area:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColor.Location = new System.Drawing.Point(226, 245);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(65, 25);
            this.labelColor.TabIndex = 31;
            this.labelColor.Text = "Color:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(176, 344);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(82, 34);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(277, 344);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 34);
            this.buttonOK.TabIndex = 28;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxRadius2
            // 
            this.textBoxRadius2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRadius2.Location = new System.Drawing.Point(29, 273);
            this.textBoxRadius2.Name = "textBoxRadius2";
            this.textBoxRadius2.Size = new System.Drawing.Size(121, 30);
            this.textBoxRadius2.TabIndex = 27;
            // 
            // labelRadius2
            // 
            this.labelRadius2.AutoSize = true;
            this.labelRadius2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRadius2.Location = new System.Drawing.Point(24, 245);
            this.labelRadius2.Name = "labelRadius2";
            this.labelRadius2.Size = new System.Drawing.Size(94, 25);
            this.labelRadius2.TabIndex = 26;
            this.labelRadius2.Text = "Radius 2:";
            // 
            // textBoxRadius1
            // 
            this.textBoxRadius1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRadius1.Location = new System.Drawing.Point(29, 188);
            this.textBoxRadius1.Name = "textBoxRadius1";
            this.textBoxRadius1.Size = new System.Drawing.Size(121, 30);
            this.textBoxRadius1.TabIndex = 25;
            // 
            // labelRadius1
            // 
            this.labelRadius1.AutoSize = true;
            this.labelRadius1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRadius1.Location = new System.Drawing.Point(24, 160);
            this.labelRadius1.Name = "labelRadius1";
            this.labelRadius1.Size = new System.Drawing.Size(94, 25);
            this.labelRadius1.TabIndex = 24;
            this.labelRadius1.Text = "Radius 1:";
            // 
            // buttonEllipseColor
            // 
            this.buttonEllipseColor.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEllipseColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEllipseColor.Location = new System.Drawing.Point(231, 271);
            this.buttonEllipseColor.Name = "buttonEllipseColor";
            this.buttonEllipseColor.Size = new System.Drawing.Size(121, 35);
            this.buttonEllipseColor.TabIndex = 34;
            this.buttonEllipseColor.UseVisualStyleBackColor = false;
            this.buttonEllipseColor.Click += new System.EventHandler(this.buttonEllipseColor_Click);
            // 
            // FormEllipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 399);
            this.Controls.Add(this.buttonEllipseColor);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxRadius2);
            this.Controls.Add(this.labelRadius2);
            this.Controls.Add(this.textBoxRadius1);
            this.Controls.Add(this.labelRadius1);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelCoordinates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEllipse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ellipse Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelCoordinates;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxRadius2;
        private System.Windows.Forms.Label labelRadius2;
        private System.Windows.Forms.TextBox textBoxRadius1;
        private System.Windows.Forms.Label labelRadius1;
        private System.Windows.Forms.Button buttonEllipseColor;
    }
}