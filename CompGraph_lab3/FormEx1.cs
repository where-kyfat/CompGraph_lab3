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
    }
}
