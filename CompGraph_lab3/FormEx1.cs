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
        private Image FileImage = null;
        private Dictionary<string, Image> DicOfSelectedFiles;
        private Point prevLocation;
        private Color CorrectColor = Color.Black;
        bool isDown = true;
        Graphics g;

        Form FormMain;
        public FormEx1(Form formMain)
        {
            InitializeComponent();
            FormMain = formMain;

            pictureBoxFloodingArea.Image = DrawingImageByColor(new Bitmap(pictureBoxFloodingArea.Width, pictureBoxFloodingArea.Height), Color.White); 
            g = pictureBoxFloodingArea.CreateGraphics();
            StartImage = pictureBoxFloodingArea.Image;
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
            Pen pen = new Pen(CorrectColor);
            SolidBrush solid = new SolidBrush(CorrectColor);
            g.FillEllipse(solid, e.X, e.Y, 5, 5);
            g.DrawEllipse(pen, e.X, e.Y, 5, 5);

            solid.Dispose();
            pen.Dispose();
        }
   

        void BrushArea(object sender, MouseEventArgs e)
        {
            if (!isDown)
            {  
                g.DrawLine(new Pen(CorrectColor,4), prevLocation,prevLocation = new Point(e.X, e.Y));
            }
        }

        void FloodArea(object sender, MouseEventArgs e)
        {
            if (FileImage != null)
            {

            }
            else
            {

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
                FileImage = DicOfSelectedFiles[selectedValue];
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
            else
                FloodArea(sender, e);
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            pictureBoxFloodingArea.Image = StartImage;
        }

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(openFileDialog.FileName);
                System.IO.FileStream fileStream = fileInfo.OpenRead();
                FileImage = Image.FromStream(fileStream);
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
