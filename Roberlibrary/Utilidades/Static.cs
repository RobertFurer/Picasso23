using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Roberlibrary
{
    public static class Static
    {
        public static string ToUM(this string str)
        {
            string minUM = string.Empty;
            switch (str.ToUpper())
            {
                case "KG":
                    minUM= "g";
                    break;
                case "L":
                    minUM = "ml";
                    break;
                case "PZA":
                    minUM = "";
                    break;
                default:

                    break;
            }
            return minUM;
        }
        public static void KeyPress(object sender, KeyPressEventArgs e)
        {

            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                }
            if (e.KeyChar == 46)
            {
                e.Handled = false;
            }
        }
        public static Int32 ToNumeric(this string i)
        {
            Int32 result;
            try
            {
                result = Convert.ToInt32(i);
            }
            catch (Exception ex)
            {
                return 0;
            }
            return result;
        }
        public static void LimpiaTextbox(Control.ControlCollection c)
        {
            for (int i = 0; i < c.Count; i++)
            {
                if (c[i].GetType().Name == "TextBox")
                { c[i].Text = string.Empty; }
            }
        }
        public static void ControlsDisabled(Control.ControlCollection c)
        {
            for (int i = 0; i < c.Count; i++)
            {
                c[i].Enabled = false;
                //if (c[i].GetType().Name == "TextBox")
                //{ c[i].Text = string.Empty; }
            }
        } 
        public static void BorradoCorrectamente()
        {
            MessageBox.Show(MsgString.BorradoCorrectamente, MsgString.MsgTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void GuardadoCorrectamente()
        {
            MessageBox.Show(MsgString.GuardadoCorrectamente, MsgString.MsgTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void EsUnidadValida(this string str)
        {
            List<string> result =  MsgString.UMMaximas.Where(a => a.Equals(str)).ToList();
            if (result.Count == 0)
            { throw new Exception(MsgString.MsgUMNoValido); }

        }
    }
    public static class MsgString
    {
         public static string MsgUMNoValido = "La Unidad de Medida no es valida.";
         public static string BorradoCorrectamente = "Borrado Correctamente";
         public static string GuardadoCorrectamente = "Guardado Correctamente";
        public static string MsgTitulo = "Mensaje del Sistema";
        public static string[] UMMaximas = new string[] { "KG", "L","PZA" };
        public static string[] UserType = new string[] { "CAJERO", "ADMINISTRADOR" };
    }
}
