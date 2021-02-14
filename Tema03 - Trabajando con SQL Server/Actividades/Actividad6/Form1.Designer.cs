
namespace Actividad6
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaProductos = new System.Windows.Forms.ListBox();
            this.btnCargarProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaProductos
            // 
            this.listaProductos.FormattingEnabled = true;
            this.listaProductos.Location = new System.Drawing.Point(245, 93);
            this.listaProductos.Name = "listaProductos";
            this.listaProductos.Size = new System.Drawing.Size(217, 225);
            this.listaProductos.TabIndex = 0;
            // 
            // btnCargarProductos
            // 
            this.btnCargarProductos.Location = new System.Drawing.Point(302, 354);
            this.btnCargarProductos.Name = "btnCargarProductos";
            this.btnCargarProductos.Size = new System.Drawing.Size(106, 23);
            this.btnCargarProductos.TabIndex = 1;
            this.btnCargarProductos.Text = "Cargar productos";
            this.btnCargarProductos.UseVisualStyleBackColor = true;
            this.btnCargarProductos.Click += new System.EventHandler(this.btnCargarProductos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargarProductos);
            this.Controls.Add(this.listaProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaProductos;
        private System.Windows.Forms.Button btnCargarProductos;
    }
}

