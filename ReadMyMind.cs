using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adivina_el_número
{
    public partial class ReadMyMind : Form
    {
        public ReadMyMind()
        {
            InitializeComponent();
        }

        private void ReadMyMind_Load(object sender, EventArgs e)
        {
            Center();

        }

        // Functions
        private void Center( )
        {
            int xBtn = (Width - 15 - btnSubmit.Width) / 2;
            btnSubmit.Location = new Point(xBtn, 120);

            int xTxt = (Width - 15 - txtNum.Width) / 2;
            txtNum.Location = new Point(xTxt, 80);

            int xLbl = (Width - 15 - lblTitle.Width) / 2;
            lblTitle.Location = new Point(xLbl, 30);
        }

        // Events
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if( !string.IsNullOrEmpty(txtNum.Text))
            {
                FrmLoader loader = new FrmLoader();
                loader.Show();
                this.Hide();
            }
        }
        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtNum.Text, @"^[0-9]+$"))
            {
                if (Convert.ToInt32(txtNum.Text) < 1 || Convert.ToInt32(txtNum.Text) > 100)
                {
                    txtNum.Text = string.Empty;
                }
            } else
            {
                txtNum.Text = string.Empty;
            }
            

            
        }
    }
}
