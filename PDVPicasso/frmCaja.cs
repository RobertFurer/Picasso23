using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Roberlibrary;

namespace PDVPicasso
{
    public class Venta1a1
    {
        public Producto Prod;
        public Receta Rec;
        public decimal cantidad;
        public bool esProducto;
    }
    public partial class frmCaja : Form
    {
        List<Venta1a1> listaVenta1a1 = new List<Venta1a1>();
        IEnumerable<Producto> allProducts = null;
        IEnumerable<Receta> allReceta = null;

        public frmCaja()
        {
            InitializeComponent();
        }
        private void keyboardcontrol1_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void keyboardcontrol1_UserKeyPressed(object sender, KeyboardClassLibrary.KeyboardEventArgs e)
        {
            SendKeys.Send(e.KeyboardKeyPressed);
        }
        private void LimpiaTextos()
        {
            txtcodigobarras.Text = "";
            txtCantidad.Text = "";
            txtcodigobarras.Focus();
        }
        private void btnok_Click(object sender, EventArgs e)
        {
            Venta1a1 v1 = new Venta1a1();
            v1.esProducto = false;
            Decimal PrecioUnitario = 0;
            ListViewItem item1 = null;
            try
            {
                txtcodigobarras.Enabled = true;
                Producto ProdToAdd = allProducts.Where(a => a.Nombre.Equals(txtcodigobarras.Text)).FirstOrDefault();
                Receta RecToAdd = allReceta.Where(a => a.Nombre.Equals(txtcodigobarras.Text)).FirstOrDefault();
                PrecioUnitario = ProdToAdd != null ? (Decimal)ProdToAdd.PrecioUnitario : (Decimal)RecToAdd.Precio;
                Decimal cantidad = Decimal.Parse(txtCantidad.Text.Trim());
                Decimal importe = cantidad * PrecioUnitario;
                Decimal totalticket = importe + Decimal.Parse(lbltotalprod.Text);

                if (ProdToAdd != null)
                {
                    v1.esProducto = true;
                    v1.Prod = ProdToAdd;
                }
                else
                    v1.Rec = RecToAdd;

                v1.cantidad = cantidad;

                listaVenta1a1.Add(v1);

                //Design
                lbltotalprod.Text = totalticket.ToString("#.##");

                if (v1.esProducto)
                    item1 = new ListViewItem(ProdToAdd.Nombre, 0);
                else
                    item1 = new ListViewItem(RecToAdd.Nombre, 0);

                item1.Checked = true;
                item1.SubItems.Add(PrecioUnitario.ToString("#.##"));
                item1.SubItems.Add(cantidad.ToString());
                item1.SubItems.Add(importe.ToString("#.##"));
                lvList.Items.Add(item1);
                LimpiaTextos();
            }
            catch (Exception ex)
            {
                //try catch vacio en caso de no encontrar producto o codigo
            }
        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }
        private void frmCaja_Load(object sender, EventArgs e)
        {
            allProducts = RB.TodosProductos();
            allReceta = RB.TodasRecetas();
            this.txtcodigobarras.AutoCompleteCustomSource.AddRange(allProducts.Where(b => b.VistaPublico.Equals(true)).Select(a => a.Nombre).ToArray());
            this.txtcodigobarras.AutoCompleteCustomSource.AddRange(allReceta.Select(a => a.Nombre).ToArray());
            txtcodigobarras.Text = "";
            txtCantidad.Text = "";
        }
        private void txtCantidad_CursorChanged(object sender, EventArgs e)
        {
        }
        private void vistaButtonGuardar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int idf = r.Next();
             int idV = RB.VentaMaxId();
            for (int i = 0; i < listaVenta1a1.Count; i++)
            {
                idV++;
                Venta ve = new Venta();
                ve.id = idV;
                ve.folio = idf.ToString();
                ve.cantidad = listaVenta1a1[i].cantidad;
                if (listaVenta1a1[i].esProducto)
                {
                    ve.id_producto = listaVenta1a1[i].Prod.id;
                    ve.total = listaVenta1a1[i].cantidad * listaVenta1a1[i].Prod.PrecioUnitario;
                }
                else
                {
                    ve.id_receta = listaVenta1a1[i].Rec.id;
                    ve.total = listaVenta1a1[i].cantidad * listaVenta1a1[i].Rec.Precio;
                }
                ve.fecha = DateTime.Now;
                PDVEntities p = new PDVEntities();
                p.AddToVenta(ve);
                p.SaveChanges();
                p.Dispose();
            }
            //Afecta Inventario
            for (int i = 0; i < listaVenta1a1.Count; i++)
            {
                if (listaVenta1a1[i].esProducto)
                {
                    RB.RestaToInventario1N(listaVenta1a1[i].Prod.id, listaVenta1a1[i].cantidad);
                }
                else
                {
                    List<Producto> LInvent = new List<Producto>();
                    Int64 idRec = Convert.ToInt64(listaVenta1a1[i].Rec.id_rec);
                    IEnumerable<Receta> rec = allReceta.Where(b => b.id_rec == idRec);
                    foreach (Receta item in rec)
                    {
                        Producto produFind = allProducts.Where(a => a.id.Equals(item.id_producto)).FirstOrDefault();
                        Int64 id = (Int64)produFind.id;
                        Decimal cant = (Int64)item.Cantidad;
                        RB.RestaToInventario(id, cant);
                    }
                }
            }
            lvList.Items.Clear();
            LimpiaTextos();
        }
    }
}
