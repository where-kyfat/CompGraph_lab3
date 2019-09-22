using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CompGraph_lab3
{
    public partial class FormEx1 : Form
    {
        private Image StartImage;
        private Point prevLocation;
        bool isDown = true;
        Graphics g;

        Form FormMain;
        short SelectedTypeOfPainting = 0;
        public FormEx1(Form formMain)
        {
            InitializeComponent();
            FormMain = formMain;
            Bitmap pictureBoxImage = new Bitmap(pictureBoxFloodingArea.Width, pictureBoxFloodingArea.Height);
            DrawingEmptyImage(pictureBoxImage);
            pictureBoxFloodingArea.Image = pictureBoxImage;
            g = pictureBoxFloodingArea.CreateGraphics();
            StartImage = pictureBoxImage;
        }
        private void DrawingEmptyImage(Bitmap EmptyImage) {
            //Bitmap EmptyImage = new Bitmap(pictureBoxFloodingArea.Width, pictureBoxFloodingArea.Height);
            for (int x = 0; x < EmptyImage.Width; x++)
            {
                for (int y = 0; y < EmptyImage.Height; y++)
                {
                    EmptyImage.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            }
        }

        private void FormEx1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain.Show();
        }

        private void Button_colorDialogEx1_Click(object sender, EventArgs e)
        {
            colorDialogEx1.ShowDialog();
        }

        private void PictureBoxFloodingArea_MouseClick(object sender, MouseEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            SolidBrush solid = new SolidBrush(Color.Black);
            g.FillEllipse(solid, e.X, e.Y, 5, 5);
            g.DrawEllipse(pen, e.X, e.Y, 5, 5);

            solid.Dispose();
            pen.Dispose();
        }
   
        



        void BrushArea(object sender, MouseEventArgs e)
        {
            
            Bitmap pixels = new Bitmap(pictureBoxFloodingArea.Image);
            if (isDown == false)
            {
                
                g.DrawLine(new Pen(Color.Black,4), prevLocation,prevLocation = new Point(e.X, e.Y));
                //pictureBoxFloodingArea.Image = pixels;
            }
        }

        void FloodArea(object sender, MouseEventArgs e)
        {

        }

        private void RadioButtonSelectedBrush_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void RadioButtonSelected_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void ComboBoxSelectedFile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PictureBoxFloodingArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isDown = false;
                prevLocation = e.Location;
        }

        private void PictureBoxFloodingArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isDown = true;
        }

        private void PictureBoxFloodingArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (SelectedTypeOfPainting == 0)
            {
                BrushArea(sender, e);
            }
            else
                FloodArea(sender, e);
        }
    }
}
