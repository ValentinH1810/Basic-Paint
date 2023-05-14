
namespace Basic_Paint_App
{
    partial class FormTriangle
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
            this.labelCoordinates = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonTriangleColor = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxMiddlePoint = new System.Windows.Forms.TextBox();
            this.labelMiddlePoint = new System.Windows.Forms.Label();
            this.textBoxFirstPoint = new System.Windows.Forms.TextBox();
            this.labelFirstPoint = new System.Windows.Forms.Label();
            this.textBoxEndPoint = new System.Windows.Forms.TextBox();
            this.labelEndPoint = new System.Windows.Forms.Label();
            this.textBoxSide = new System.Windows.Forms.TextBox();
            this.labelSide = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCoordinates
            // 
            this.labelCoordinates.AutoSize = true;
            this.labelCoordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoordinates.Location = new System.Drawing.Point(23, 23);
            this.labelCoordinates.Name = "labelCoordinates";
            this.labelCoordinates.Size = new System.Drawing.Size(124, 25);
            this.labelCoordinates.TabIndex = 29;
            this.labelCoordinates.Text = "Coordinates:";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxArea.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxArea.Location = new System.Drawing.Point(230, 246);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.ReadOnly = true;
            this.textBoxArea.Size = new System.Drawing.Size(121, 30);
            this.textBoxArea.TabIndex = 28;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArea.Location = new System.Drawing.Point(225, 218);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(60, 25);
            this.labelArea.TabIndex = 27;
            this.labelArea.Text = "Area:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColor.Location = new System.Drawing.Point(23, 313);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(65, 25);
            this.labelColor.TabIndex = 26;
            this.labelColor.Text = "Color:";
            // 
            // buttonTriangleColor
            // 
            this.buttonTriangleColor.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTriangleColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonTriangleColor.Location = new System.Drawing.Point(28, 340);
            this.buttonTriangleColor.Name = "buttonTriangleColor";
            this.buttonTriangleColor.Size = new System.Drawing.Size(121, 35);
            this.buttonTriangleColor.TabIndex = 25;
            this.buttonTriangleColor.UseVisualStyleBackColor = false;
            this.buttonTriangleColor.Click += new System.EventHandler(this.buttonTriangleColor_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(175, 341);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 34);
            this.buttonCancel.TabIndex = 24;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(276, 341);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 34);
            this.buttonOK.TabIndex = 23;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxMiddlePoint
            // 
            this.textBoxMiddlePoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMiddlePoint.Location = new System.Drawing.Point(28, 170);
            this.textBoxMiddlePoint.Name = "textBoxMiddlePoint";
            this.textBoxMiddlePoint.ReadOnly = true;
            this.textBoxMiddlePoint.Size = new System.Drawing.Size(172, 30);
            this.textBoxMiddlePoint.TabIndex = 22;
            // 
            // labelMiddlePoint
            // 
            this.labelMiddlePoint.AutoSize = true;
            this.labelMiddlePoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddlePoint.Location = new System.Drawing.Point(23, 142);
            this.labelMiddlePoint.Name = "labelMiddlePoint";
            this.labelMiddlePoint.Size = new System.Drawing.Size(123, 25);
            this.labelMiddlePoint.TabIndex = 21;
            this.labelMiddlePoint.Text = "Middle point:";
            // 
            // textBoxFirstPoint
            // 
            this.textBoxFirstPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstPoint.Location = new System.Drawing.Point(28, 94);
            this.textBoxFirstPoint.Name = "textBoxFirstPoint";
            this.textBoxFirstPoint.ReadOnly = true;
            this.textBoxFirstPoint.Size = new System.Drawing.Size(172, 30);
            this.textBoxFirstPoint.TabIndex = 20;
            // 
            // labelFirstPoint
            // 
            this.labelFirstPoint.AutoSize = true;
            this.labelFirstPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstPoint.Location = new System.Drawing.Point(23, 66);
            this.labelFirstPoint.Name = "labelFirstPoint";
            this.labelFirstPoint.Size = new System.Drawing.Size(102, 25);
            this.labelFirstPoint.TabIndex = 19;
            this.labelFirstPoint.Text = "First point:";
            // 
            // textBoxEndPoint
            // 
            this.textBoxEndPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEndPoint.Location = new System.Drawing.Point(28, 246);
            this.textBoxEndPoint.Name = "textBoxEndPoint";
            this.textBoxEndPoint.ReadOnly = true;
            this.textBoxEndPoint.Size = new System.Drawing.Size(172, 30);
            this.textBoxEndPoint.TabIndex = 35;
            // 
            // labelEndPoint
            // 
            this.labelEndPoint.AutoSize = true;
            this.labelEndPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEndPoint.Location = new System.Drawing.Point(23, 218);
            this.labelEndPoint.Name = "labelEndPoint";
            this.labelEndPoint.Size = new System.Drawing.Size(100, 25);
            this.labelEndPoint.TabIndex = 34;
            this.labelEndPoint.Text = "End point:";
            // 
            // textBoxSide
            // 
            this.textBoxSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSide.Location = new System.Drawing.Point(230, 94);
            this.textBoxSide.Name = "textBoxSide";
            this.textBoxSide.Size = new System.Drawing.Size(121, 30);
            this.textBoxSide.TabIndex = 37;
            // 
            // labelSide
            // 
            this.labelSide.AutoSize = true;
            this.labelSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSide.Location = new System.Drawing.Point(225, 66);
            this.labelSide.Name = "labelSide";
            this.labelSide.Size = new System.Drawing.Size(58, 25);
            this.labelSide.TabIndex = 36;
            this.labelSide.Text = "Side:";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHeight.Location = new System.Drawing.Point(230, 170);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(121, 30);
            this.textBoxHeight.TabIndex = 39;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeight.Location = new System.Drawing.Point(225, 142);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(74, 25);
            this.labelHeight.TabIndex = 38;
            this.labelHeight.Text = "Height:";
            // 
            // FormTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 399);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.textBoxSide);
            this.Controls.Add(this.labelSide);
            this.Controls.Add(this.textBoxEndPoint);
            this.Controls.Add(this.labelEndPoint);
            this.Controls.Add(this.labelCoordinates);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.buttonTriangleColor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxMiddlePoint);
            this.Controls.Add(this.labelMiddlePoint);
            this.Controls.Add(this.textBoxFirstPoint);
            this.Controls.Add(this.labelFirstPoint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTriangle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Triangle Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCoordinates;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonTriangleColor;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxMiddlePoint;
        private System.Windows.Forms.Label labelMiddlePoint;
        private System.Windows.Forms.TextBox textBoxFirstPoint;
        private System.Windows.Forms.Label labelFirstPoint;
        private System.Windows.Forms.TextBox textBoxEndPoint;
        private System.Windows.Forms.Label labelEndPoint;
        private System.Windows.Forms.TextBox textBoxSide;
        private System.Windows.Forms.Label labelSide;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelHeight;
    }
}