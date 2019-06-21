using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawIO
{
    public partial class Form1 : Form
    {
        private Graphics tekVierkant;
        private int vierkantJa = 40;

        private Graphics tekCircle;
        private int cir1 = 50;
        private int cir2 = 100;

        private Pen black = new Pen(Color.Black, 10);
        private Pen red = new Pen(Color.Red, 10);

        public Form1()
        {
            InitializeComponent();
        }

        private void vierkant_Click(object sender, EventArgs e)
        {
            tekVierkant.Clear(Color.White);
            vierkantJa += 10;
            tekVierkant.DrawRectangle(black, vierkantJa, vierkantJa, vierkantJa, vierkantJa);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tekVierkant = pictureBoxVier.CreateGraphics();
            tekCircle = pictureBoxCir.CreateGraphics();

            tekVierkant.DrawRectangle(black, vierkantJa, vierkantJa, vierkantJa, vierkantJa);
            tekCircle.DrawEllipse(red, cir1, cir1, cir2, cir2);
        }

        private void cirkel_Click(object sender, EventArgs e)
        {
            tekCircle.Clear(Color.White);
            cir1 += 5;
            cir2 += 10;
            tekCircle.DrawEllipse(red, cir1, cir1, cir2, cir2);
        }
    }
}
