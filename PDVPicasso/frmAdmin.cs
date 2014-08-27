using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PDVPicasso.Catalogo;

namespace PDVPicasso
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            frmInventario frminv = new frmInventario();
            frminv.Show();
        }

        private void btnreceta_Click(object sender, EventArgs e)
        {
            frmReceta frmReceta = new frmReceta();
            frmReceta.Show();
        }
    }
}
