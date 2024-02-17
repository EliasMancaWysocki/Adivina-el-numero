using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adivina_el_número
{
    public partial class FrmLoader : Form
    {
        public FrmLoader()
        {
            InitializeComponent();
        }

        private void FrmLoader_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Animation.Start();
            Center();
        }

        // Function
        private void Center()
        {
            int x = (Width - 15 - lblPorcentaje.Width) / 2;
            lblPorcentaje.Location = new Point(x, 125);
        }

        // Events
        private void Animation_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar.Value += 1;
            lblPorcentaje.Text = $"{progressBar.Value.ToString()}%";
            if (progressBar.Value == 100)
            {
                Animation.Stop();
                HideAnimation.Start();
            }
        }

        private void Hide_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 1;
            if (this.Opacity == 0)
            {
                HideAnimation.Stop();
                FrmAnswer answer = new FrmAnswer();
                answer.Show();
                this.Hide();
            }

        }
    }
}
