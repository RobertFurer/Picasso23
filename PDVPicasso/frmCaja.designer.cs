namespace PDVPicasso
{
    partial class frmCaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvList = new System.Windows.Forms.ListView();
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PUnitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbltotalprod = new System.Windows.Forms.Label();
            this.keyboardcontrol1 = new KeyboardClassLibrary.Keyboardcontrol();
            this.txtcodigobarras = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.vistaButtonGuardar = new VistaButton();
            this.btnok = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvList
            // 
            this.lvList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Descripcion,
            this.PUnitario,
            this.Cantidad,
            this.Total});
            this.lvList.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.Location = new System.Drawing.Point(68, 63);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(769, 355);
            this.lvList.TabIndex = 2;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            // 
            // Descripcion
            // 
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.Width = 245;
            // 
            // PUnitario
            // 
            this.PUnitario.Text = "PUnitario";
            this.PUnitario.Width = 115;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            // 
            // Total
            // 
            this.Total.Text = "Total";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.White;
            this.lbltotal.Location = new System.Drawing.Point(843, 379);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(89, 39);
            this.lbltotal.TabIndex = 3;
            this.lbltotal.Text = "Total:";
            // 
            // lbltotalprod
            // 
            this.lbltotalprod.AutoSize = true;
            this.lbltotalprod.Font = new System.Drawing.Font("Calibri", 24F);
            this.lbltotalprod.ForeColor = System.Drawing.Color.White;
            this.lbltotalprod.Location = new System.Drawing.Point(952, 379);
            this.lbltotalprod.Name = "lbltotalprod";
            this.lbltotalprod.Size = new System.Drawing.Size(89, 39);
            this.lbltotalprod.TabIndex = 4;
            this.lbltotalprod.Text = "00.00";
            // 
            // keyboardcontrol1
            // 
            this.keyboardcontrol1.KeyboardType = KeyboardClassLibrary.BoW.Standard;
            this.keyboardcontrol1.Location = new System.Drawing.Point(68, 436);
            this.keyboardcontrol1.Name = "keyboardcontrol1";
            this.keyboardcontrol1.Size = new System.Drawing.Size(993, 282);
            this.keyboardcontrol1.TabIndex = 6;
            this.keyboardcontrol1.UserKeyPressed += new KeyboardClassLibrary.KeyboardDelegate(this.keyboardcontrol1_UserKeyPressed);
            this.keyboardcontrol1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.keyboardcontrol1_MouseClick);
            // 
            // txtcodigobarras
            // 
            this.txtcodigobarras.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigobarras.Location = new System.Drawing.Point(128, 19);
            this.txtcodigobarras.Name = "txtcodigobarras";
            this.txtcodigobarras.Size = new System.Drawing.Size(354, 37);
            this.txtcodigobarras.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(34, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(88, 29);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Codigo:";
            // 
            // vistaButtonGuardar
            // 
            this.vistaButtonGuardar.BackColor = System.Drawing.Color.Transparent;
            this.vistaButtonGuardar.BaseColor = System.Drawing.Color.Crimson;
            this.vistaButtonGuardar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.vistaButtonGuardar.ButtonText = "LISTO!";
            this.vistaButtonGuardar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaButtonGuardar.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(223)))));
            this.vistaButtonGuardar.Location = new System.Drawing.Point(850, 305);
            this.vistaButtonGuardar.Name = "vistaButtonGuardar";
            this.vistaButtonGuardar.Size = new System.Drawing.Size(138, 48);
            this.vistaButtonGuardar.TabIndex = 12;
            this.vistaButtonGuardar.Tag2 = "";
            this.vistaButtonGuardar.Click += new System.EventHandler(this.vistaButtonGuardar_Click);
            // 
            // btnok
            // 
            this.btnok.AutoEllipsis = true;
            this.btnok.BackColor = System.Drawing.Color.MediumBlue;
            this.btnok.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.White;
            this.btnok.Location = new System.Drawing.Point(840, 22);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(118, 37);
            this.btnok.TabIndex = 13;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Calibri", 18F);
            this.txtCantidad.Location = new System.Drawing.Point(642, 19);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(136, 37);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.CursorChanged += new System.EventHandler(this.txtCantidad_CursorChanged);
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(506, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cantidad";
            // 
            // frmCaja
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1171, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.vistaButtonGuardar);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtcodigobarras);
            this.Controls.Add(this.keyboardcontrol1);
            this.Controls.Add(this.lbltotalprod);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lvList);
            this.Name = "frmCaja";
            this.Text = "frmCaja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.ColumnHeader PUnitario;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbltotalprod;
        private KeyboardClassLibrary.Keyboardcontrol keyboardcontrol1;
        private System.Windows.Forms.TextBox txtcodigobarras;
        private System.Windows.Forms.Label lblCodigo;
        private VistaButton vistaButtonGuardar;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
    }
}