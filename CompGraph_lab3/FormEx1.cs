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
