
namespace Basic_Paint_App
{
    partial class FormScene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScene));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonBackground = new System.Windows.Forms.Button();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxPalette = new System.Windows.Forms.PictureBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.pictureBoxEraser = new System.Windows.Forms.PictureBox();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.pictureBoxCursor = new System.Windows.Forms.PictureBox();
            this.pictureBoxPencil = new System.Windows.Forms.PictureBox();
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            this.pictureBoxRectangle = new System.Windows.Forms.PictureBox();
            this.pictureBoxTriangle = new System.Windows.Forms.PictureBox();
            this.pictureBoxEllipse = new System.Windows.Forms.PictureBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.pictureBoxScene = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEraser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPencil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTriangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEllipse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScene)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.buttonOpen);
            this.panel1.Controls.Add(this.buttonBackground);
            this.panel1.Controls.Add(this.buttonSaveImage);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.pictureBoxEraser);
            this.panel1.Controls.Add(this.buttonColor);
            this.panel1.Controls.Add(this.buttonSaveData);
            this.panel1.Controls.Add(this.pictureBoxColor);
            this.panel1.Controls.Add(this.pictureBoxCursor);
            this.panel1.Controls.Add(this.pictureBoxPencil);
            this.panel1.Controls.Add(this.pictureBoxLine);
            this.panel1.Controls.Add(this.pictureBoxRectangle);
            this.panel1.Controls.Add(this.pictureBoxTriangle);
            this.panel1.Controls.Add(this.pictureBoxEllipse);
            this.panel1.Controls.Add(this.panelButtons);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1537, 153);
            this.panel1.TabIndex = 0;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Location = new System.Drawing.Point(12, 82);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(123, 49);
            this.buttonOpen.TabIndex = 3;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonBackground
            // 
            this.buttonBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackground.Location = new System.Drawing.Point(667, 17);
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.Size = new System.Drawing.Size(127, 49);
            this.buttonBackground.TabIndex = 5;
            this.buttonBackground.Text = "Background";
            this.buttonBackground.UseVisualStyleBackColor = true;
            this.buttonBackground.Click += new System.EventHandler(this.buttonBackground_Click);
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSaveImage.Location = new System.Drawing.Point(141, 23);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(127, 49);
            this.buttonSaveImage.TabIndex = 2;
            this.buttonSaveImage.Text = "Save image";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.pictureBoxPalette);
            this.panel2.Location = new System.Drawing.Point(281, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 129);
            this.panel2.TabIndex = 2;
            // 
            // pictureBoxPalette
            // 
            this.pictureBoxPalette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPalette.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPalette.Image")));
            this.pictureBoxPalette.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxPalette.Name = "pictureBoxPalette";
            this.pictureBoxPalette.Size = new System.Drawing.Size(349, 106);
            this.pictureBoxPalette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPalette.TabIndex = 1;
            this.pictureBoxPalette.TabStop = false;
            this.pictureBoxPalette.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPalette_MouseClick);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(141, 82);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(127, 49);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // pictureBoxEraser
            // 
            this.pictureBoxEraser.BackColor = System.Drawing.Color.White;
            this.pictureBoxEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEraser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEraser.Image")));
            this.pictureBoxEraser.Location = new System.Drawing.Point(1345, 40);
            this.pictureBoxEraser.Name = "pictureBoxEraser";
            this.pictureBoxEraser.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxEraser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEraser.TabIndex = 5;
            this.pictureBoxEraser.TabStop = false;
            this.pictureBoxEraser.Click += new System.EventHandler(this.pictureBoxEraser_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.SystemColors.Control;
            this.buttonColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonColor.Location = new System.Drawing.Point(704, 80);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(55, 55);
            this.buttonColor.TabIndex = 6;
            this.buttonColor.UseVisualStyleBackColor = false;
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveData.Location = new System.Drawing.Point(12, 23);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(123, 49);
            this.buttonSaveData.TabIndex = 1;
            this.buttonSaveData.Text = "Save data";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.BackColor = System.Drawing.Color.White;
            this.pictureBoxColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxColor.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxColor.Image")));
            this.pictureBoxColor.Location = new System.Drawing.Point(1259, 40);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxColor.TabIndex = 1;
            this.pictureBoxColor.TabStop = false;
            this.pictureBoxColor.Click += new System.EventHandler(this.pictureBoxColor_Click);
            // 
            // pictureBoxCursor
            // 
            this.pictureBoxCursor.BackColor = System.Drawing.Color.White;
            this.pictureBoxCursor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCursor.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCursor.Image")));
            this.pictureBoxCursor.Location = new System.Drawing.Point(1431, 40);
            this.pictureBoxCursor.Name = "pictureBoxCursor";
            this.pictureBoxCursor.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxCursor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCursor.TabIndex = 3;
            this.pictureBoxCursor.TabStop = false;
            this.pictureBoxCursor.Click += new System.EventHandler(this.pictureBoxCursor_Click);
            // 
            // pictureBoxPencil
            // 
            this.pictureBoxPencil.BackColor = System.Drawing.Color.White;
            this.pictureBoxPencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPencil.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPencil.Image")));
            this.pictureBoxPencil.Location = new System.Drawing.Point(1173, 40);
            this.pictureBoxPencil.Name = "pictureBoxPencil";
            this.pictureBoxPencil.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxPencil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPencil.TabIndex = 4;
            this.pictureBoxPencil.TabStop = false;
            this.pictureBoxPencil.Click += new System.EventHandler(this.pictureBoxPencil_Click);
            this.pictureBoxPencil.DoubleClick += new System.EventHandler(this.pictureBoxPencil_DoubleClick);
            // 
            // pictureBoxLine
            // 
            this.pictureBoxLine.BackColor = System.Drawing.Color.White;
            this.pictureBoxLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLine.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLine.Image")));
            this.pictureBoxLine.Location = new System.Drawing.Point(1087, 40);
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLine.TabIndex = 2;
            this.pictureBoxLine.TabStop = false;
            this.pictureBoxLine.Click += new System.EventHandler(this.pictureBoxLine_Click);
            // 
            // pictureBoxRectangle
            // 
            this.pictureBoxRectangle.BackColor = System.Drawing.Color.White;
            this.pictureBoxRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRectangle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRectangle.Image")));
            this.pictureBoxRectangle.Location = new System.Drawing.Point(826, 40);
            this.pictureBoxRectangle.Name = "pictureBoxRectangle";
            this.pictureBoxRectangle.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxRectangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRectangle.TabIndex = 2;
            this.pictureBoxRectangle.TabStop = false;
            this.pictureBoxRectangle.Click += new System.EventHandler(this.pictureBoxRectangle_Click);
            // 
            // pictureBoxTriangle
            // 
            this.pictureBoxTriangle.BackColor = System.Drawing.Color.White;
            this.pictureBoxTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTriangle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTriangle.Image")));
            this.pictureBoxTriangle.Location = new System.Drawing.Point(1000, 40);
            this.pictureBoxTriangle.Name = "pictureBoxTriangle";
            this.pictureBoxTriangle.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxTriangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTriangle.TabIndex = 2;
            this.pictureBoxTriangle.TabStop = false;
            this.pictureBoxTriangle.Click += new System.EventHandler(this.pictureBoxTriangle_Click);
            // 
            // pictureBoxEllipse
            // 
            this.pictureBoxEllipse.BackColor = System.Drawing.Color.White;
            this.pictureBoxEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEllipse.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEllipse.Image")));
            this.pictureBoxEllipse.Location = new System.Drawing.Point(913, 40);
            this.pictureBoxEllipse.Name = "pictureBoxEllipse";
            this.pictureBoxEllipse.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxEllipse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEllipse.TabIndex = 2;
            this.pictureBoxEllipse.TabStop = false;
            this.pictureBoxEllipse.Click += new System.EventHandler(this.pictureBoxEllipse_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.Silver;
            this.panelButtons.Location = new System.Drawing.Point(810, 27);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(711, 99);
            this.panelButtons.TabIndex = 1;
            // 
            // pictureBoxScene
            // 
            this.pictureBoxScene.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxScene.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxScene.Name = "pictureBoxScene";
            this.pictureBoxScene.Size = new System.Drawing.Size(1537, 717);
            this.pictureBoxScene.TabIndex = 1;
            this.pictureBoxScene.TabStop = false;
            this.pictureBoxScene.Click += new System.EventHandler(this.pictureBoxScene_Click);
            this.pictureBoxScene.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxScene_MouseDoubleClick);
            this.pictureBoxScene.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxScene_MouseDown);
            this.pictureBoxScene.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxScene_MouseMove);
            this.pictureBoxScene.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxScene_MouseUp);
            // 
            // FormScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1537, 717);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxScene);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormScene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Paint";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormScene_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEraser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPencil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTriangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEllipse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScene)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLine;
        private System.Windows.Forms.PictureBox pictureBoxRectangle;
        private System.Windows.Forms.PictureBox pictureBoxTriangle;
        private System.Windows.Forms.PictureBox pictureBoxEllipse;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.PictureBox pictureBoxCursor;
        private System.Windows.Forms.PictureBox pictureBoxPencil;
        private System.Windows.Forms.PictureBox pictureBoxEraser;
        private System.Windows.Forms.PictureBox pictureBoxPalette;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.PictureBox pictureBoxScene;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonBackground;
    }
}

