using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Roberlibrary;
using PDVPicasso.Catalogo;

namespace PDVPicasso
{
    public partial class frmInicio : Form
    {
        private bool showkey = true;
        public frmInicio()
        {
            InitializeComponent();
        }

        private void vistaButtonGuardar_Click(object sender, EventArgs e)
        {
            var res = Roberlibrary.RB.TodosUsuarios();
            Usuario a = (Usuario)res.Where(z => z.nombre == comboBox1.Text &&
                z.pwd == textBox1.Text).FirstOrDefault();
            if (a != null)
            {
                switch (a.tipo)
                {
                    case "ADMINISTRADOR":
                        frmAdmin fr = new frmAdmin();
                        fr.Show();
                        this.Hide();
                        break;
                    case "CAJERO":
                        frmCaja FC = new frmCaja();
                        FC.Show();
                        this.Hide();
                        break;
                    default:
                        break;
                }
            }
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {
            try
            {
                var res = Roberlibrary.RB.TodosUsuarios();
                foreach (var item in res)
                {
                    comboBox1.Items.Add(item.nombre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (showkey)
            {
                showkey = false;
                keyboardcontrol1.Visible = false;
            }
            else
            {
                showkey = true;
                keyboardcontrol1.Visible = true;
            }
        }
    }
}
