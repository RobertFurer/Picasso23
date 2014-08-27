using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Roberlibrary;

namespace PDVPicasso.Catalogo
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cmbtipo.Items.AddRange(MsgString.UserType);
            actualizagrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusu.Text != "" && txtpwd.Text != "")
            {
                try
                {
                    Usuario u = new Usuario();
                    u.id = Int32.Parse(label4.Text);
                    u.nombre = txtusu.Text;
                    u.pwd = txtpwd.Text;
                    u.tipo = cmbtipo.Text;
                    PDVEntities p = new PDVEntities();
                    p.AddToUsuario(u);
                    p.SaveChanges();
                    Static.GuardadoCorrectamente();
                    limpia();
                    actualizagrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar Datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void limpia()
        {
            txtusu.Text = "";
            txtpwd.Text = "";
            actualizagrid();
        }
        public void actualizagrid()
        {
            var res = Roberlibrary.RB.TodosUsuarios();
            dataGridView1.DataSource = res;
            foreach (var item in res)
            {
                label4.Text = (item.id + 1).ToString(); ;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            Int32 indice = Convert.ToInt32(fila.Cells["id"].Value);
            IEnumerable<Usuario> res = Roberlibrary.RB.TodosUsuarios();

            var query = (from aa in res
                         where aa.id == indice
                         select aa).FirstOrDefault();

            label4.Text = query.id.ToString();
            txtusu.Text = query.nombre;
            txtpwd.Text = query.pwd;
            cmbtipo.Text = query.tipo;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpia();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 indice =  Int32.Parse(label4.Text);
                PDVEntities p = new PDVEntities();
                Usuario a = (Usuario)p.Usuario.Where(z => z.id == indice).FirstOrDefault();
                p.DeleteObject(a);
                p.SaveChanges();
                MessageBox.Show("Borrado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizagrid();
                limpia();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
