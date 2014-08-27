using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using Roberlibrary;

namespace PDVPicasso.Catalogo
{
    public partial class frmReceta : Form
    {
        List<Producto> ListaProd = new List<Producto>();
        List<decimal> listCant = new List<decimal>();
        Int32 idreceta = 0;
        public frmReceta()
        {
            InitializeComponent();
        }
        private void frmReceta_Load(object sender, EventArgs e)
        {
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Static.KeyPress);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Static.KeyPress);
            LimpiarActualiza();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PDVEntities p = new PDVEntities();
            Int32 id = Convert.ToInt32(cmbingredientes.Text.Split(' ')[0]);
            Producto ProdToAdd = (Producto)p.Producto.Where(c => c.id == id).FirstOrDefault();
            ProdToAdd.UnidadMedida = ProdToAdd.UnidadMedida.ToUM();
            ListaProd.Add(ProdToAdd);
            ListViewItem item1 = new ListViewItem(ProdToAdd.id.ToString(), 0);
            item1.Checked = true;
            string descripcion = txtCantidad.Text + " " + ProdToAdd.UnidadMedida.ToLower() + " de " + ProdToAdd.Nombre;
            item1.SubItems.Add(descripcion);
            listViewingredientes.Items.Add(item1);
            Decimal cantidad = 0;
            if (!String.IsNullOrEmpty(txtCantidad.Text))
            {
                cantidad = Decimal.Parse(txtCantidad.Text);
                listCant.Add(cantidad);
            }
            txtCantidad.Text = "";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Random r = new Random();
                int id_rec  = r.Next();
                Int32 iii = 0;
                idreceta = label10.Text.ToNumeric();
                foreach (var item in ListaProd)
                {
                    Receta rec = new Receta();
                    rec.id = idreceta;
                    rec.id_rec = id_rec;
                    rec.Nombre = txtNombre.Text;
                    rec.Precio = Decimal.Parse(txtprecio.Text);
                    rec.NumeroPersonas = textBoxpersonas.Text;
                    rec.Categoria = comboBoxcategoria.Text;
                    rec.Preparacion = textBoxPreparacion.Text;
                    rec.TiempoPreparacion = textBoxtiempopreparaacion.Text;
                    rec.id_producto = item.id;
                    rec.Cantidad = listCant[iii];
                    PDVEntities p = new PDVEntities();
                    p.AddToReceta(rec);
                    p.SaveChanges();
                    iii++;
                    idreceta++;
                }
                Static.GuardadoCorrectamente();
                LimpiarActualiza();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 

        private void listViewRecetas_MouseDoubleClick(object sender, MouseEventArgs e)
        { 
            Static.ControlsDisabled(this.Controls);
            listViewRecetas.Enabled = true;
            btnGuardar.Enabled = false;
            listViewingredientes.Items.Clear();
            string busqueda = listViewRecetas.FocusedItem.Text;   
            PDVEntities p = new PDVEntities();
            var res = from aa in p.Receta
                      join cc in p.Producto on aa.id_producto equals cc.id
                      where aa.Nombre.Equals(busqueda)
                      select new { aa.Nombre,aa.NumeroPersonas,aa.Precio,aa.Preparacion, aa.TiempoPreparacion,aa.Categoria,aa.Cantidad,NombreProducto = cc.Nombre,cc.UnidadMedida };
            foreach (var item in res)
            {
                txtNombre.Text = item.Nombre;
                 txtprecio.Text = item.Precio.ToString();
                textBoxpersonas.Text = item.NumeroPersonas;
                comboBoxcategoria.Text = item.Categoria;
                textBoxtiempopreparaacion.Text = item.TiempoPreparacion;
                ListViewItem item1 = new ListViewItem(" ", 0);
                item1.Checked = true;
                item1.SubItems.Add(item.Cantidad.ToString() + "  " + item.UnidadMedida.ToUM() + " de  " + item.NombreProducto);
                listViewingredientes.Items.Add(item1);
            }
            btnGuardar.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        } 
        private void listViewRecetas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LimpiarActualiza()
        {
            listViewRecetas.Items.Clear();
            listViewingredientes.Items.Clear();
            Static.LimpiaTextbox(this.Controls);
            cmbingredientes.Items.Clear();
            var AllProd = Roberlibrary.RB.TodosProductos();
            label10.Text =   (RB.RecetaMaxId() + 1).ToString();

            PDVEntities db = new PDVEntities();
            var res0 = (from user in db.Receta
                        group user by user.Nombre into g
                        select g);

            this.listViewRecetas.Columns.Add(new ColumnHeader());
            this.listViewRecetas.Columns[0].Text = "Recetas";
            this.listViewRecetas.Columns[0].Width = 100;
            ListViewItem listViewItem = null;
            foreach (var item in res0)
            {
                listViewItem = new ListViewItem(new string[] { item.Key }, -1, Color.Empty, Color.Empty, new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((System.Byte)(0))));
                listViewRecetas.Items.Add(listViewItem);
            }
            foreach (var item in AllProd)
            {
                cmbingredientes.Items.Add(item.id.ToString() + " " + item.Nombre);
            }

        }

    }
}
