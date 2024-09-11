using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_IMC
{
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmIMC_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, soma = 0;

            n1 = Convert.ToDouble(txtAltura.Text);
            n2 = Convert.ToDouble(txtPeso.Text);

            soma = n1 + n2;

            txtResult.Text = soma.ToString();


        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
           
          

        }
    }
}
