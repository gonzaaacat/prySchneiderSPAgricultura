using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prySchneiderSP1
{
    public partial class frmLocalidad : Form
    {
        public frmLocalidad()
        {
            InitializeComponent();
        }

        private void frmLocalidad_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearLocalidad_Click(object sender, EventArgs e)
        {
            File.Create("./localidad.txt");
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TextWriter Escribir = new StreamWriter("./localidad.txt", true);

            Escribir.WriteLine(Convert.ToString(txtIdentificador.Text + " " + txtLocalidad.Text));
            Escribir.Close();


            MessageBox.Show("La localidad se guardo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtIdentificador.Text = "";
            txtLocalidad.Text = "";
            txtLocalidad.Focus();
        }

        private void txtLocalidad_TextChanged(object sender, EventArgs e)
        {
            if (txtLocalidad.Text != "")
            {
                btnAceptar.Enabled = true;
              
            }
        }
    }
}
