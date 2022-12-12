namespace ChaosGame
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Animate = new System.Windows.Forms.Button();
            this.cmbSpeed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pixel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.rbSquare1 = new System.Windows.Forms.RadioButton();
            this.rbPentagon = new System.Windows.Forms.RadioButton();
            this.rbSquare2 = new System.Windows.Forms.RadioButton();
            this.rbSquare3 = new System.Windows.Forms.RadioButton();
            this.Color = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(130, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(741, 552);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Animate
            // 
            this.Animate.BackColor = System.Drawing.Color.White;
            this.Animate.ForeColor = System.Drawing.Color.Black;
            this.Animate.Location = new System.Drawing.Point(11, 357);
            this.Animate.Margin = new System.Windows.Forms.Padding(2);
            this.Animate.Name = "Animate";
            this.Animate.Size = new System.Drawing.Size(103, 24);
            this.Animate.TabIndex = 1;
            this.Animate.Text = "Animate";
            this.Animate.UseVisualStyleBackColor = false;
            this.Animate.Click += new System.EventHandler(this.Animate_Click);
            // 
            // cmbSpeed
            // 
            this.cmbSpeed.FormattingEnabled = true;
            this.cmbSpeed.Location = new System.Drawing.Point(11, 29);
            this.cmbSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSpeed.Name = "cmbSpeed";
            this.cmbSpeed.Size = new System.Drawing.Size(103, 23);
            this.cmbSpeed.TabIndex = 2;
            this.cmbSpeed.SelectedValueChanged += new System.EventHandler(this.cmbSpeed_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Speed";
            // 
            // Pixel
            // 
            this.Pixel.Location = new System.Drawing.Point(11, 80);
            this.Pixel.Margin = new System.Windows.Forms.Padding(2);
            this.Pixel.Name = "Pixel";
            this.Pixel.Size = new System.Drawing.Size(103, 23);
            this.Pixel.TabIndex = 4;
            this.Pixel.TextChanged += new System.EventHandler(this.Pixel_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pixel";
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.ForeColor = System.Drawing.Color.White;
            this.rbTriangle.Location = new System.Drawing.Point(11, 124);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(66, 19);
            this.rbTriangle.TabIndex = 6;
            this.rbTriangle.TabStop = true;
            this.rbTriangle.Text = "Triangle";
            this.rbTriangle.UseVisualStyleBackColor = true;
            // 
            // rbSquare1
            // 
            this.rbSquare1.AutoSize = true;
            this.rbSquare1.ForeColor = System.Drawing.Color.White;
            this.rbSquare1.Location = new System.Drawing.Point(11, 158);
            this.rbSquare1.Name = "rbSquare1";
            this.rbSquare1.Size = new System.Drawing.Size(67, 19);
            this.rbSquare1.TabIndex = 7;
            this.rbSquare1.TabStop = true;
            this.rbSquare1.Text = "Square1";
            this.rbSquare1.UseVisualStyleBackColor = true;
            // 
            // rbPentagon
            // 
            this.rbPentagon.AutoSize = true;
            this.rbPentagon.ForeColor = System.Drawing.Color.White;
            this.rbPentagon.Location = new System.Drawing.Point(11, 268);
            this.rbPentagon.Name = "rbPentagon";
            this.rbPentagon.Size = new System.Drawing.Size(76, 19);
            this.rbPentagon.TabIndex = 8;
            this.rbPentagon.TabStop = true;
            this.rbPentagon.Text = "Pentagon";
            this.rbPentagon.UseVisualStyleBackColor = true;
            // 
            // rbSquare2
            // 
            this.rbSquare2.AutoSize = true;
            this.rbSquare2.ForeColor = System.Drawing.Color.White;
            this.rbSquare2.Location = new System.Drawing.Point(11, 194);
            this.rbSquare2.Name = "rbSquare2";
            this.rbSquare2.Size = new System.Drawing.Size(70, 19);
            this.rbSquare2.TabIndex = 9;
            this.rbSquare2.TabStop = true;
            this.rbSquare2.Text = "Square 2";
            this.rbSquare2.UseVisualStyleBackColor = true;
            // 
            // rbSquare3
            // 
            this.rbSquare3.AutoSize = true;
            this.rbSquare3.ForeColor = System.Drawing.Color.White;
            this.rbSquare3.Location = new System.Drawing.Point(11, 232);
            this.rbSquare3.Name = "rbSquare3";
            this.rbSquare3.Size = new System.Drawing.Size(70, 19);
            this.rbSquare3.TabIndex = 10;
            this.rbSquare3.TabStop = true;
            this.rbSquare3.Text = "Square 3";
            this.rbSquare3.UseVisualStyleBackColor = true;
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(11, 316);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(103, 23);
            this.Color.TabIndex = 11;
            this.Color.Text = "Change color";
            this.Color.UseVisualStyleBackColor = true;
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(882, 572);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.rbSquare3);
            this.Controls.Add(this.rbSquare2);
            this.Controls.Add(this.rbPentagon);
            this.Controls.Add(this.rbSquare1);
            this.Controls.Add(this.rbTriangle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pixel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSpeed);
            this.Controls.Add(this.Animate);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main";
            this.Text = "Chaos Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button Animate;
        private ComboBox cmbSpeed;
        private Label label1;
        private TextBox Pixel;
        private Label label2;
        private RadioButton rbTriangle;
        private RadioButton rbSquare1;
        private RadioButton rbPentagon;
        private RadioButton rbSquare2;
        private RadioButton rbSquare3;
        private Button Color;
        private ColorDialog colorDialog1;
    }
}