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
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }
        private void frmInventario_Load(object sender, EventArgs e)
        {
            this.txtstockminimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Static.KeyPress);
            this.txtstockmaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Static.KeyPress);
            this.txtCapacidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Static.KeyPress);
            this.txtExistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Static.KeyPress);
            this.txtPrecioUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Static.KeyPress);
            comboBoxUM.Items.AddRange(MsgString.UMMaximas);
            actualizaGrid();
        }
        public void actualizaGrid()
        {
            var res = RB.TodosProductos();
            dataGridView1.DataSource = res;
            foreach (var item in res)
            {
                label8.Text = (item.id + 1).ToString();
            }
        } 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool exist = false;
                comboBoxUM.Text.EsUnidadValida();
                Producto prod = new Producto();
                PDVEntities p = new PDVEntities();
                prod = p.Producto.Where(a => a.Nombre== txtnombre.Text.Trim()).FirstOrDefault();
                if (prod != null)
                    exist = true; 
                else
                    prod = new Producto();
                
                prod.id = label8.Text.ToNumeric();
                prod.Nombre = txtnombre.Text;
                prod.Descripcion = txtdescrip.Text;
                prod.CodigoBarras = txtcodigo.Text;
                prod.StockMinimo = Decimal.Parse(txtstockminimo.Text);
                prod.StockMaximo = Decimal.Parse(txtstockmaximo.Text);
                prod.Existencia = Decimal.Parse(txtExistencia.Text);
                prod.Capacidad = Decimal.Parse(txtCapacidad.Text);
                prod.PrecioUnitario = Decimal.Parse(txtPrecioUnitario.Text);
                prod.UnidadMedida = comboBoxUM.Text;
                prod.VistaPublico = checkBox1.Checked ? true : false;
                if (!exist)
                { p.AddToProducto(prod); }
                p.SaveChanges();
                Static.GuardadoCorrectamente();
                Static.LimpiaTextbox(this.Controls);
                checkBox1.Checked = false;
                actualizaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            Int32 indice = Convert.ToInt32(fila.Cells["id"].Value);
            IEnumerable<Producto> res = Roberlibrary.RB.TodosProductos();
            var query = (from aa in res
                         where aa.id == indice
                         select aa).FirstOrDefault();

            label8.Text = query.id.ToString();
            txtnombre.Text = query.Nombre;
            txtdescrip.Text = query.Descripcion;
            txtcodigo.Text = query.CodigoBarras;
            txtstockminimo.Text = query.StockMinimo.ToString();
            txtstockmaximo.Text = query.StockMaximo.ToString();
            txtExistencia.Text = query.Existencia.ToString();
            txtCapacidad.Text = query.Capacidad.ToString();
            txtPrecioUnitario.Text = query.PrecioUnitario.ToString();
            comboBoxUM.Text = query.UnidadMedida;
            checkBox1.Checked = query.VistaPublico.Value ? checkBox1.Checked = true : checkBox1.Checked = false;
            }
            catch (Exception ex)
            {
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Static.LimpiaTextbox(this.Controls);
            checkBox1.Checked = false;
            actualizaGrid();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 indice = label8.Text.ToNumeric();
                PDVEntities p = new PDVEntities();
                Producto a = (Producto)p.Producto.Where(z => z.id == indice).FirstOrDefault();
                p.DeleteObject(a);
                p.SaveChanges();
                Static.BorradoCorrectamente();
                Static.LimpiaTextbox(this.Controls);
                checkBox1.Checked = false;
                actualizaGrid();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
