namespace PDVPicasso.Catalogo
{
    partial class frmReceta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewRecetas = new System.Windows.Forms.ListView();
            this.cmbingredientes = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewingredientes = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ingredientes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPreparacion = new System.Windows.Forms.TextBox();
            this.textBoxpersonas = new System.Windows.Forms.TextBox();
            this.textBoxtiempopreparaacion = new System.Windows.Forms.TextBox();
            this.comboBoxcategoria = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingredientes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preparacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tiempo de Preparacion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numero de Personas: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lista de Recetas";
            // 
            // listViewRecetas
            // 
            this.listViewRecetas.Location = new System.Drawing.Point(25, 69);
            this.listViewRecetas.Name = "listViewRecetas";
            this.listViewRecetas.Size = new System.Drawing.Size(133, 324);
            this.listViewRecetas.TabIndex = 91;
            this.listViewRecetas.UseCompatibleStateImageBehavior = false;
            this.listViewRecetas.View = System.Windows.Forms.View.Details;
            this.listViewRecetas.SelectedIndexChanged += new System.EventHandler(this.listViewRecetas_SelectedIndexChanged);
            this.listViewRecetas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewRecetas_MouseDoubleClick);
            // 
            // cmbingredientes
            // 
            this.cmbingredientes.FormattingEnabled = true;
            this.cmbingredientes.Location = new System.Drawing.Point(180, 106);
            this.cmbingredientes.Name = "cmbingredientes";
            this.cmbingredientes.Size = new System.Drawing.Size(172, 21);
            this.cmbingredientes.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewingredientes
            // 
            this.listViewingredientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Ingredientes});
            this.listViewingredientes.Location = new System.Drawing.Point(180, 149);
            this.listViewingredientes.Name = "listViewingredientes";
            this.listViewingredientes.Size = new System.Drawing.Size(423, 99);
            this.listViewingredientes.TabIndex = 94;
            this.listViewingredientes.UseCompatibleStateImageBehavior = false;
            this.listViewingredientes.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 24;
            // 
            // Ingredientes
            // 
            this.Ingredientes.Text = "Ingredientes";
            this.Ingredientes.Width = 233;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(427, 106);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(75, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cantidad:";
            // 
            // textBoxPreparacion
            // 
            this.textBoxPreparacion.Location = new System.Drawing.Point(180, 277);
            this.textBoxPreparacion.Multiline = true;
            this.textBoxPreparacion.Name = "textBoxPreparacion";
            this.textBoxPreparacion.Size = new System.Drawing.Size(423, 78);
            this.textBoxPreparacion.TabIndex = 7;
            // 
            // textBoxpersonas
            // 
            this.textBoxpersonas.Location = new System.Drawing.Point(303, 365);
            this.textBoxpersonas.Name = "textBoxpersonas";
            this.textBoxpersonas.Size = new System.Drawing.Size(109, 20);
            this.textBoxpersonas.TabIndex = 8;
            // 
            // textBoxtiempopreparaacion
            // 
            this.textBoxtiempopreparaacion.Location = new System.Drawing.Point(317, 422);
            this.textBoxtiempopreparaacion.Name = "textBoxtiempopreparaacion";
            this.textBoxtiempopreparaacion.Size = new System.Drawing.Size(95, 20);
            this.textBoxtiempopreparaacion.TabIndex = 11;
            // 
            // comboBoxcategoria
            // 
            this.comboBoxcategoria.FormattingEnabled = true;
            this.comboBoxcategoria.Items.AddRange(new object[] {
            "Aperitivo",
            "Platillo",
            "Postre",
            "Pastel",
            "Bebida"});
            this.comboBoxcategoria.Location = new System.Drawing.Point(278, 394);
            this.comboBoxcategoria.Name = "comboBoxcategoria";
            this.comboBoxcategoria.Size = new System.Drawing.Size(134, 21);
            this.comboBoxcategoria.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(188, 464);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 35);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar Receta...";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(238, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(470, 394);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(133, 20);
            this.txtprecio.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Precio:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(501, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 35);
            this.button2.TabIndex = 90;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(191, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "label10";
            // 
            // frmReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 511);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.comboBoxcategoria);
            this.Controls.Add(this.textBoxtiempopreparaacion);
            this.Controls.Add(this.textBoxpersonas);
            this.Controls.Add(this.textBoxPreparacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.listViewingredientes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbingredientes);
            this.Controls.Add(this.listViewRecetas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmReceta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libro de Cocina";
            this.Load += new System.EventHandler(this.frmReceta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listViewRecetas;
        private System.Windows.Forms.ComboBox cmbingredientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewingredientes;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPreparacion;
        private System.Windows.Forms.TextBox textBoxpersonas;
        private System.Windows.Forms.TextBox textBoxtiempopreparaacion;
        private System.Windows.Forms.ComboBox comboBoxcategoria;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Ingredientes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
    }
}