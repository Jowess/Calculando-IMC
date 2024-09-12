using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Using System.Decimal;

namespace Calculo_IMC
{
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();
        }

       

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
             
          double n1,n2, soma = 0;

           

            n1 = Convert.ToDouble(txtAltura.Text);
            n2 = Convert.ToDouble(txtPeso.Text);

            soma = n2 / (n1 * n1);

            txtResult.Text = soma.ToString();


        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
           
          

        }

       
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtAltura.Clear();
            txtResult.Clear();
        }

      


        private void txtAltura_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

}
