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
    public partial class FormEx2 : Form
    {
        Form FormMain;
        public FormEx2(Form formMain)
        {
            InitializeComponent();
            FormMain = formMain;
        }

        private void FormEx2_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain.Show();
        }
    }
}
