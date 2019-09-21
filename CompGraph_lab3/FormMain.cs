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
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new FormEx1(this).Show();
            Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new FormEx2(this).Show();
            Hide();
        }
    }
}
