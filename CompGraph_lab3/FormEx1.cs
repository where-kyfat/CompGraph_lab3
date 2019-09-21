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
        Form FormMain;
        short SelectedTypeOfPainting = 0;
        public FormEx1(Form formMain)
        {
            InitializeComponent();
            FormMain = formMain;
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
            if (SelectedTypeOfPainting == 0)
            {
                BrushArea(sender, e);
            }
            else
                FloodArea(sender, e);
        }

        void BrushArea(object sender, MouseEventArgs e)
        {

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
    }
}
