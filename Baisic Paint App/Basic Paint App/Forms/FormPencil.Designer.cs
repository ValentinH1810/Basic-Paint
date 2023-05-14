
namespace Basic_Paint_App
{
    partial class FormPencil
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
            this.labelThickness = new System.Windows.Forms.Label();
            this.comboBoxThickness = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPencilColor = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelThickness
            // 
            this.labelThickness.AutoSize = true;
            this.labelThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThickness.Location = new System.Drawing.Point(40, 36);
            this.labelThickness.Name = "labelThickness";
            this.labelThickness.Size = new System.Drawing.Size(97, 25);
            this.labelThickness.TabIndex = 1;
            this.labelThickness.Text = "Tickness:";
            // 
            // comboBoxThickness
            // 
            this.comboBoxThickness.FormattingEnabled = true;
            this.comboBoxThickness.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxThickness.Location = new System.Drawing.Point(143, 37);
            this.comboBoxThickness.Name = "comboBoxThickness";
            this.comboBoxThickness.Size = new System.Drawing.Size(121, 24);
            this.comboBoxThickness.TabIndex = 2;
            this.comboBoxThickness.SelectedIndexChanged += new System.EventHandler(this.comboBoxThickness_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Color:";
            // 
            // buttonPencilColor
            // 
            this.buttonPencilColor.Location = new System.Drawing.Point(143, 84);
            this.buttonPencilColor.Name = "buttonPencilColor";
            this.buttonPencilColor.Size = new System.Drawing.Size(121, 25);
            this.buttonPencilColor.TabIndex = 4;
            this.buttonPencilColor.UseVisualStyleBackColor = true;
            this.buttonPencilColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(58, 143);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(82, 34);
            this.buttonCancel.TabIndex = 31;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(173, 143);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 34);
            this.buttonOK.TabIndex = 30;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormPencil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 202);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonPencilColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxThickness);
            this.Controls.Add(this.labelThickness);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPencil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pencil Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelThickness;
        private System.Windows.Forms.ComboBox comboBoxThickness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPencilColor;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}