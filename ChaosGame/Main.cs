using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChaosGame
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            _imgHeight = pictureBox1.Height;
            _imgWidth = pictureBox1.Width;
            cmbSpeed.DataSource = new List<string> { "Slow", "Medium", "Fast" };
            cmbSpeed.SelectedIndex = 1;
            rbTriangle.Checked = true;
        }

        private int _imgWidth, _imgHeight, _animationSpeed;
        private Color _color = System.Drawing.Color.White;

        /// <summary>
        /// This dictionary contains the values for the animation speed
        /// </summary>
        private Dictionary<string, int> _dictAnimationSpeed = new Dictionary<string, int>() { { "Slow", 5 }, { "Medium", 50 }, { "Fast", 5000 } };

        /// <summary>
        /// This function draws the animation 
        /// </summary>
        public void DrawAnimation(int animationSpeed, int pixel)
        {
            Bitmap bitmap = new(_imgWidth, _imgHeight);
            Shape formPattern = new(_imgWidth, _imgHeight, _color);

            List<PointF> allPoints = new();
            pictureBox1.Image = bitmap;

            //Check which shape is selected
            if (rbTriangle.Checked) allPoints = formPattern.GetAllPoints(pixel, FormPattern.Triangle);
            else if (rbSquare1.Checked) allPoints = formPattern.GetAllPoints(pixel, FormPattern.Square1);
            else if (rbSquare2.Checked) allPoints = formPattern.GetAllPoints(pixel, FormPattern.Square2);
            else if (rbSquare3.Checked) allPoints = formPattern.GetAllPoints(pixel, FormPattern.Square3);
            else if (rbPentagon.Checked) allPoints = formPattern.GetAllPoints(pixel, FormPattern.Pentagon);

            //Animation for drawing the points
            for (int i = 0; i < allPoints.Count; i++)
            {
                //Set pixel for each point
                bitmap.SetPixel((int)allPoints[i].X, (int)allPoints[i].Y, _color);

                //If i modulo animation speed is null then refresh the picturebox
                if (i % animationSpeed == 0) pictureBox1.Refresh();
            }
        }

        /// <summary>
        /// This method is called when the user changes the animation speed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSpeed_SelectedValueChanged(object sender, EventArgs e) => _animationSpeed = _dictAnimationSpeed[cmbSpeed.SelectedItem.ToString()!];

        /// <summary>
        /// This Method calls the DrawAnimation Funktion with the selected speed and pixel, if pixel is null it will use the default value 10_000
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Animate_Click(object sender, EventArgs e) => DrawAnimation(_animationSpeed, string.IsNullOrEmpty(Pixel.Text) ? 10_000 : int.Parse(Pixel.Text));

        /// <summary>
        /// This method is used to check if the user has entered a valid number in the pixel textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pixel_TextChanged(object sender, EventArgs e)
        {
            //If user input is not a number then remove last index from input 
            if (System.Text.RegularExpressions.Regex.IsMatch(Pixel.Text, "[^0-9]"))
                Pixel.Text = Pixel.Text.Remove(Pixel.Text.Length - 1);
        }

        /// <summary>
        /// This method is used to change the color of the drawing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            var a = colorDialog1.Color.A;
            var r = colorDialog1.Color.R;
            var b = colorDialog1.Color.B;
            var g = colorDialog1.Color.G;
            _color = System.Drawing.Color.FromArgb(a, r, g, b);
        }
    }
}