using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roberlibrary
{
    public static class RB
    {
        public static void RestaToInventario(Int64 id, Decimal Value)
        {
            using (PDVEntities pdv = new PDVEntities())
            {
                Producto Prod = pdv.Producto.Where(a => a.id.Equals(id)).FirstOrDefault();
                Decimal TotalExistencia = ((Decimal)Prod.Existencia * 1000);
                Decimal TotalFinal = (TotalExistencia - Value) / 1000;
                Prod.Existencia = TotalFinal;
                pdv.SaveChanges();
            }
        } 
        public static void RestaToInventario1N(Int64 id, Decimal Value)
        {
            using (PDVEntities pdv = new PDVEntities())
            {
                Producto Prod = pdv.Producto.Where(a => a.id.Equals(id)).FirstOrDefault();
                Decimal TotalFinal = ((Decimal)Prod.Existencia - Value);
                Prod.Existencia = TotalFinal;
                pdv.SaveChanges();
            }
        }
        public static List<Producto> ConsultaInventario()
        {
            List<Producto> ProdInventario = new List<Producto>();
            using (PDVEntities pdv = new PDVEntities())
            {
                ProdInventario = (pdv.Producto.Where(a => (a.Existencia - a.StockMinimo) <= 0)).ToList();
            }
            return ProdInventario;
        }
        public static IEnumerable<Usuario> TodosUsuarios()
        {
            PDVEntities db = new PDVEntities();
            IEnumerable<Usuario> res = (from user in db.Usuario
                                        select user).AsEnumerable();
            return res;
        }
        public static IEnumerable<Producto> TodosProductos()
        {
            PDVEntities db = new PDVEntities();
            IEnumerable<Producto> res = (from user in db.Producto
                                         select user).AsEnumerable();
            return res;
        }
        public static IEnumerable<Receta> TodasRecetas()
        {
            PDVEntities db = new PDVEntities();
            IEnumerable<Receta> res = (from user in db.Receta
                                       select user).AsEnumerable();
            return res;
        }
        public static Int32 RecetaMaxId()
        {
            PDVEntities db = new PDVEntities();
            var res = db.Receta.Max(u => u.id);
            return Convert.ToInt32(res);
        }
        public static Int32 VentaMaxId()
        {
            PDVEntities db = new PDVEntities();
            var res = db.Venta.Max(u => u.id);
            return Convert.ToInt32(res);
        }

    }  
}
