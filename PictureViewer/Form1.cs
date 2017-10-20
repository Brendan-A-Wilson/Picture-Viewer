using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Closes the application form.
            this.Close();
        }

        private void Backgroundbutton_Click(object sender, EventArgs e)
        {
            /* Shows the color dialog box. If the user clicks on a color and then clicks Ok,
            then the color of the background will change.
            */
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
               
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            // Clears the picture on the screen.
            pictureBox1.Image = null;
        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
            /* If the user clicks on the "show picture" button, then
            a file dialog will be displayed and the user will be able to search for a picture.
            */
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            /* If the user selects the stretched check box, 
            the picture viewer will show the full image.
            and if it is clicked on again the image will go back to normal.
             */
            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }   
        }
    }
}
