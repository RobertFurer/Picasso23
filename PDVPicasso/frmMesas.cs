using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;


namespace PDVPicasso
{
    public partial class frmMesas : Form
    {

        DataSet ds = new DataSet();
        string folio = "";
        public frmMesas(string folio)
        {
            this.folio = folio;
        }
        private void getmesa()
        { 
        }

        private void txtactualiza(object sender, EventArgs e)
        { 
            this.Close();
        }
        private void frmMesas_Load(object sender, EventArgs e)
        {
            int mesa = 0;
            bool bitx = false;
            bool bity = false;
            Int32 contadorx = 0;
            Int32 contadory = 0;
            int contadordemesas = 0;
            for (int x = 0; x < 10; x++)
            {
                if (bitx)
                {
                    contadorx = contadorx + 160;
                }
                bitx = true;
                bity = true;
                contadory = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (bity)
                    {
                        contadory = contadory + 60;
                    }
                    VistaButton vbmesa2 = new VistaButton();
                    this.SuspendLayout();
                    vbmesa2.BackColor = System.Drawing.Color.Transparent;
                    vbmesa2.ButtonColor = System.Drawing.Color.Blue;
                    contadordemesas++;
                    vbmesa2.ButtonText = "Mesa " + contadordemesas.ToString();
                    vbmesa2.CornerRadius = 0;
                    vbmesa2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    vbmesa2.GlowColor = System.Drawing.Color.FromName("Blue");
                    vbmesa2.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(223)))));
                    vbmesa2.Location = new System.Drawing.Point(40 + contadorx, 30 + contadory);
                    vbmesa2.Name = "vbmesa2";
                    vbmesa2.Size = new System.Drawing.Size(136, 40);
                    vbmesa2.TabIndex = 1;
                    vbmesa2.Tag2 = "";
                    vbmesa2.Click += new System.EventHandler(this.txtactualiza);
                    this.Controls.Add(vbmesa2);
                    if (mesa == contadordemesas)
                    {
                        break;
                    }
                }
                if (mesa == contadordemesas)
                {
                    break;
                }
            }
        }
    }
}
