
namespace Basic_Paint_App
{
    partial class FormRectangle
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
            this.labelWidth = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonRectangleColor = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelCoordinates = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWidth.Location = new System.Drawing.Point(23, 156);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(69, 25);
            this.labelWidth.TabIndex = 0;
            this.labelWidth.Text = "Width:";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWidth.Location = new System.Drawing.Point(28, 184);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(121, 30);
            this.textBoxWidth.TabIndex = 1;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHeight.Location = new System.Drawing.Point(28, 269);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(121, 30);
            this.textBoxHeight.TabIndex = 3;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeight.Location = new System.Drawing.Point(23, 241);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(74, 25);
            this.labelHeight.TabIndex = 2;
            this.labelHeight.Text = "Height:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColor.Location = new System.Drawing.Point(225, 241);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(65, 25);
            this.labelColor.TabIndex = 11;
            this.labelColor.Text = "Color:";
            // 
            // buttonRectangleColor
            // 
            this.buttonRectangleColor.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRectangleColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRectangleColor.Location = new System.Drawing.Point(230, 267);
            this.buttonRectangleColor.Name = "buttonRectangleColor";
            this.buttonRectangleColor.Size = new System.Drawing.Size(121, 35);
            this.buttonRectangleColor.TabIndex = 10;
            this.buttonRectangleColor.UseVisualStyleBackColor = false;
            this.buttonRectangleColor.Click += new System.EventHandler(this.buttonRectangleColor_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(175, 340);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 34);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(276, 340);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 34);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxArea
            // 
            this.textBoxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxArea.Location = new System.Drawing.Point(230, 184);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.ReadOnly = true;
            this.textBoxArea.Size = new System.Drawing.Size(121, 30);
            this.textBoxArea.TabIndex = 13;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArea.Location = new System.Drawing.Point(225, 156);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(60, 25);
            this.labelArea.TabIndex = 12;
            this.labelArea.Text = "Area:";
            // 
            // labelCoordinates
            // 
            this.labelCoordinates.AutoSize = true;
            this.labelCoordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoordinates.Location = new System.Drawing.Point(23, 22);
            this.labelCoordinates.Name = "labelCoordinates";
            this.labelCoordinates.Size = new System.Drawing.Size(124, 25);
            this.labelCoordinates.TabIndex = 14;
            this.labelCoordinates.Text = "Coordinates:";
            // 
            // textBoxY
            // 
            this.textBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxY.Location = new System.Drawing.Point(219, 66);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(121, 30);
            this.textBoxY.TabIndex = 18;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.Location = new System.Drawing.Point(195, 69);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(31, 25);
            this.labelY.TabIndex = 17;
            this.labelY.Text = "Y:";
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX.Location = new System.Drawing.Point(49, 66);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(121, 30);
            this.textBoxX.TabIndex = 16;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(23, 69);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(32, 25);
            this.labelX.TabIndex = 15;
            this.labelX.Text = "X:";
            // 
            // FormRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 399);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelCoordinates);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.buttonRectangleColor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.labelWidth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRectangle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rectangle Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonRectangleColor;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelCoordinates;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelX;
    }
}