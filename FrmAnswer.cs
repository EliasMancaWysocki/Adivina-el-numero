using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Adivina_el_número
{
    public partial class FrmAnswer : Form
    {
        public FrmAnswer()
        {
            InitializeComponent();
        }

        private void FrmAnswer_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int num = 0;
            num += 1;

            Console.WriteLine(num);

            if (num == 1000)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                Application.Exit();
            }
        }
    }
}
