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
        //private Image StartImage;
        private Image CorrectImage;
        private Bitmap FileImage = null;
        private Dictionary<string, Image> DicOfSelectedFiles;
        private Point prevLocation;
        private Color CorrectColor = Color.Black;
        private Color ColorInXY;
        bool isDown = true;
        Graphics g;

        Form FormMain;
        public FormEx1(Form formMain)
        {
            InitializeComponent();
            FormMain = formMain;

            CorrectImage = DrawingImageByColor(new Bitmap(pictureBoxFloodingArea.Width, pictureBoxFloodingArea.Height), Color.White); 
            g = Graphics.FromImage(CorrectImage);

            pictureBoxFloodingArea.Image = CorrectImage;
            pictureBoxCorrectColor.Image = DrawingImageByColor(new Bitmap(pictureBoxCorrectColor.Width, pictureBoxCorrectColor.Height), CorrectColor);

            DicOfSelectedFiles = new Dictionary<string, Image>();
            DicOfSelectedFiles.Add("нет", null);
        }
        private Bitmap DrawingImageByColor(Image Image, Color color) {
            Bitmap res = new Bitmap(Image);
            for (int x = 0; x < res.Width; x++)
            {
                for (int y = 0; y < res.Height; y++)
                {
                    res.SetPixel(x, y, color);
                }
            }
            return res;
        }

        private void FormEx1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain.Show();
        }

        private void Button_colorDialogEx1_Click(object sender, EventArgs e)
        {
            colorDialogEx1.ShowDialog();
            if (colorDialogEx1.Color != CorrectColor)
            {
                CorrectColor = colorDialogEx1.Color;
                pictureBoxCorrectColor.Image = DrawingImageByColor(pictureBoxCorrectColor.Image, CorrectColor);
            }
        }

        private void PictureBoxFloodingArea_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButtonSelectedBrush.Checked)
            {
                Pen pen = new Pen(CorrectColor);
                SolidBrush solid = new SolidBrush(CorrectColor);
                g.FillEllipse(solid, e.X, e.Y, 5, 5);
                g.DrawEllipse(pen, e.X, e.Y, 5, 5);

                solid.Dispose();
                pen.Dispose();
            }
            else if(radioButtonSelectedFlood.Checked)
                FloodArea(sender, e);
        }
   

        void BrushArea(object sender, MouseEventArgs e)
        {
            if (!isDown)
            {
                if (g != null)
                {
                    g.Dispose();
                }
                g = Graphics.FromImage(CorrectImage);

                g.DrawLine(new Pen(CorrectColor, 8), prevLocation,prevLocation = new Point(e.X, e.Y));
                pictureBoxFloodingArea.Image = CorrectImage;
            }
        }

        void FloodArea(object sender, MouseEventArgs e)
        {
            if (FileImage != null)
            {

            }
            else
            {
                Bitmap FloodingImage = (Bitmap)CorrectImage;
                pictureBoxFloodingArea.DrawToBitmap(FloodingImage, pictureBoxFloodingArea.ClientRectangle);

                if (g != null)
                {
                    g.Dispose();
                }
                g = Graphics.FromImage(FloodingImage);

                Point centerPix = new Point(e.X, e.Y);
                ColorInXY = FloodingImage.GetPixel(centerPix.X, centerPix.Y);
                Point selectedPix = new Point(e.X, e.Y);

                if (ColorInXY.ToArgb() != CorrectColor.ToArgb())
                {
                    RecurAreaDown(FloodingImage, selectedPix.X, selectedPix.Y, ColorInXY);
                    if (selectedPix.Y > 0)
                    {
                        RecurAreaUp(FloodingImage, selectedPix.X, selectedPix.Y - 1, ColorInXY);
                    }
                }
                

                CorrectImage = FloodingImage;
                pictureBoxFloodingArea.Image = CorrectImage;
            }
        }

        void RecurAreaDown(Bitmap image, int x, int y, Color ColorInXY)
        {
            if (y > 1 && image.GetPixel(x, y) == ColorInXY)
            {
                Point LeftWall = RecurAreaL(image, x, y, ColorInXY);
                Point RightWall = RecurAreaR(image, x, y, ColorInXY);
                g.DrawLine(new Pen(CorrectColor), LeftWall, RightWall);

                for (int i = LeftWall.X; i < RightWall.X; i++)
                {
                    RecurAreaDown(image, i, y - 1, ColorInXY);
                    RecurAreaUp(image, i, y + 1, ColorInXY);
                }
                
            }
        }

        void RecurAreaUp(Bitmap image, int x, int y, Color ColorInXY)
        {
            if (y > 0 && y < image.Height - 1 && image.GetPixel(x, y) == ColorInXY)
            {
                Point LeftWall = RecurAreaL(image, x, y, ColorInXY);
                Point RightWall = RecurAreaR(image, x, y, ColorInXY);
                g.DrawLine(new Pen(CorrectColor), LeftWall, RightWall);

                for (int i = LeftWall.X; i < RightWall.X; i++)
                {
                    RecurAreaDown(image, i, y + 1, ColorInXY);
                    RecurAreaUp(image, i, y - 1, ColorInXY);
                }
            }
        }

        Point RecurAreaL(Bitmap image, int x, int y, Color ColorInXY)
        {
            if (x > 1 && image.GetPixel(x, y) == ColorInXY)
            {
                //image.SetPixel(x, y, CorrectColor);
                return RecurAreaL(image, x - 1, y, ColorInXY);
            }
            else
            {
                return new Point(x + 1, y);
            }
        }

        Point RecurAreaR(Bitmap image, int x, int y, Color ColorInXY)
        {
            if (x < image.Width - 1 && image.GetPixel(x, y) == ColorInXY)
            {
                //image.SetPixel(x, y, CorrectColor);
                return RecurAreaR(image, x + 1, y, ColorInXY);
            }
            else
            {
                return new Point(x - 1, y);
            }
        }


        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void ComboBoxSelectedFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxSelectedFile.SelectedItem.ToString();
            if (selectedValue == "нет")
            {
                FileImage = null;
            }
            else
            {
                FileImage = new Bitmap(DicOfSelectedFiles[selectedValue]);
            }
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
            if (radioButtonSelectedBrush.Checked)
            {
                BrushArea(sender, e);
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            if (CorrectImage != null)
            {
                CorrectImage.Dispose();
            }
            CorrectImage = DrawingImageByColor(new Bitmap(pictureBoxFloodingArea.Width, pictureBoxFloodingArea.Height), Color.White);
            if (g != null)
            {
                g.Dispose();
            }
            g = Graphics.FromImage(CorrectImage);
            pictureBoxFloodingArea.Image = CorrectImage;
        }

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(openFileDialog.FileName);
                System.IO.FileStream fileStream = fileInfo.OpenRead();
                FileImage = new Bitmap(Image.FromStream(fileStream));
                int index = comboBoxSelectedFile.Items.Add(openFileDialog.FileName.Split('\\').Last());
                DicOfSelectedFiles.Add(comboBoxSelectedFile.Items[index].ToString(), FileImage);
                comboBoxSelectedFile.SelectedIndex = index;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message,"");
            }
        }
    }
}
