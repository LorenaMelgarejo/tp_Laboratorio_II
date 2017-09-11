using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calcu;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbOperacion.Items.Add("*");
            //Console.ReadKey();

            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperacion.Text = "";
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero Nv1 = new Numero(this.txtNumero1.Text);
            Numero Nv2 = new Numero(this.txtNumero2.Text);

            this.lblResultado.Text =Calculadora.operar(Nv1, Nv2, cmbOperacion.Text).ToString();
            this.lblResultado.Visible = true;

           
       
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
