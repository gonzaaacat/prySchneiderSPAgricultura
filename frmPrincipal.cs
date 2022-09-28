using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySchneiderSP1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalidad frmLoc = new frmLocalidad();
            frmLoc.ShowDialog();
        }

        private void producciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducción frmCant = new frmProducción();
            frmCant.ShowDialog();
        }

        private void cultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCultivos frmCult = new frmCultivos();
            frmCult.ShowDialog();
        }
    }
}
