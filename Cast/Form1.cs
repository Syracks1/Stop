using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJa_Click(object sender, EventArgs e)
        {
            var uitkomst = numericUpDown1.Value + numericUpDown2.Value;

            int uitkomstcast = (int)uitkomst;
            label1.Text = uitkomstcast.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
