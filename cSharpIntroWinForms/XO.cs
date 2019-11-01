using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms
{
    public partial class XO : Form
    {
        public int Brojac { get; set; }
        public XO()
        {
            InitializeComponent();
        }
        void PromijeniVrijednost(object kliknutiDugmic)
        {
            Button btn = kliknutiDugmic as Button;
            if (btn.Text == "")
            {
                if (Brojac % 2 == 0)
                    btn.Text = "X";
                else
                    btn.Text = "O";
                Brojac++;
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            PromijeniVrijednost(sender);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            PromijeniVrijednost(sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            PromijeniVrijednost(sender);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            PromijeniVrijednost(sender);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            PromijeniVrijednost(sender);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            PromijeniVrijednost(sender);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            PromijeniVrijednost(sender);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            PromijeniVrijednost(sender);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            PromijeniVrijednost(sender);
        }

        private void XO_Load(object sender, EventArgs e)
        {

        }
    }
}
