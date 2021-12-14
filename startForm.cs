using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleApp
{
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            // store no of workers (K)
            Form1 form1 = new Form1(Convert.ToInt32(k_field.Text));
            this.Hide();
            form1.Show();
        }
    }
}
