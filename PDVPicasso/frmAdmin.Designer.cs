namespace PDVPicasso
{
    partial class frmAdmin
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
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnreceta = new System.Windows.Forms.Button();
            this.btnusuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(78, 84);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(117, 55);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnreceta
            // 
            this.btnreceta.Location = new System.Drawing.Point(78, 158);
            this.btnreceta.Name = "btnreceta";
            this.btnreceta.Size = new System.Drawing.Size(117, 55);
            this.btnreceta.TabIndex = 1;
            this.btnreceta.Text = "Receta";
            this.btnreceta.UseVisualStyleBackColor = true;
            this.btnreceta.Click += new System.EventHandler(this.btnreceta_Click);
            // 
            // btnusuario
            // 
            this.btnusuario.Location = new System.Drawing.Point(235, 84);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(99, 55);
            this.btnusuario.TabIndex = 2;
            this.btnusuario.Text = "Usuarios";
            this.btnusuario.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 321);
            this.Controls.Add(this.btnusuario);
            this.Controls.Add(this.btnreceta);
            this.Controls.Add(this.btnInventario);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnreceta;
        private System.Windows.Forms.Button btnusuario;
    }
}