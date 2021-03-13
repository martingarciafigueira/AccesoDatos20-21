
namespace Actividad9
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
            this.btnConsultarProductos = new System.Windows.Forms.Button();
            this.lstboxProductos = new System.Windows.Forms.ListBox();
            this.lstboxFabricantes = new System.Windows.Forms.ListBox();
            this.btnConsultarFabricantes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFabricantes = new System.Windows.Forms.ComboBox();
            this.btnInsertarProducto = new System.Windows.Forms.Button();
            this.btnInsertarFabricante = new System.Windows.Forms.Button();
            this.txtNombreFabricante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBorrarProducto = new System.Windows.Forms.Button();
            this.btnBorrarFabricante = new System.Windows.Forms.Button();
            this.btnActualizarFabricante = new System.Windows.Forms.Button();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultarProductos
            // 
            this.btnConsultarProductos.Location = new System.Drawing.Point(80, 204);
            this.btnConsultarProductos.Name = "btnConsultarProductos";
            this.btnConsultarProductos.Size = new System.Drawing.Size(75, 41);
            this.btnConsultarProductos.TabIndex = 0;
            this.btnConsultarProductos.Text = "Consultar productos";
            this.btnConsultarProductos.UseVisualStyleBackColor = true;
            this.btnConsultarProductos.Click += new System.EventHandler(this.btnConsultarProductos_Click);
            // 
            // lstboxProductos
            // 
            this.lstboxProductos.FormattingEnabled = true;
            this.lstboxProductos.Location = new System.Drawing.Point(57, 41);
            this.lstboxProductos.Name = "lstboxProductos";
            this.lstboxProductos.Size = new System.Drawing.Size(302, 147);
            this.lstboxProductos.TabIndex = 1;
            this.lstboxProductos.DoubleClick += new System.EventHandler(this.lstboxProductos_DoubleClick);
            // 
            // lstboxFabricantes
            // 
            this.lstboxFabricantes.FormattingEnabled = true;
            this.lstboxFabricantes.Location = new System.Drawing.Point(57, 271);
            this.lstboxFabricantes.Name = "lstboxFabricantes";
            this.lstboxFabricantes.Size = new System.Drawing.Size(302, 147);
            this.lstboxFabricantes.TabIndex = 3;
            this.lstboxFabricantes.DoubleClick += new System.EventHandler(this.lstboxFabricantes_DoubleClick);
            // 
            // btnConsultarFabricantes
            // 
            this.btnConsultarFabricantes.Location = new System.Drawing.Point(80, 433);
            this.btnConsultarFabricantes.Name = "btnConsultarFabricantes";
            this.btnConsultarFabricantes.Size = new System.Drawing.Size(75, 41);
            this.btnConsultarFabricantes.TabIndex = 2;
            this.btnConsultarFabricantes.Text = "Consultar fabricantes";
            this.btnConsultarFabricantes.UseVisualStyleBackColor = true;
            this.btnConsultarFabricantes.Click += new System.EventHandler(this.btnConsultarFabricantes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(485, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(485, 96);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(216, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fabricante";
            // 
            // cbFabricantes
            // 
            this.cbFabricantes.FormattingEnabled = true;
            this.cbFabricantes.Location = new System.Drawing.Point(485, 139);
            this.cbFabricantes.Name = "cbFabricantes";
            this.cbFabricantes.Size = new System.Drawing.Size(216, 21);
            this.cbFabricantes.TabIndex = 9;
            // 
            // btnInsertarProducto
            // 
            this.btnInsertarProducto.Location = new System.Drawing.Point(485, 185);
            this.btnInsertarProducto.Name = "btnInsertarProducto";
            this.btnInsertarProducto.Size = new System.Drawing.Size(75, 41);
            this.btnInsertarProducto.TabIndex = 10;
            this.btnInsertarProducto.Text = "Insertar producto";
            this.btnInsertarProducto.UseVisualStyleBackColor = true;
            this.btnInsertarProducto.Click += new System.EventHandler(this.btnInsertarProducto_Click);
            // 
            // btnInsertarFabricante
            // 
            this.btnInsertarFabricante.Location = new System.Drawing.Point(485, 377);
            this.btnInsertarFabricante.Name = "btnInsertarFabricante";
            this.btnInsertarFabricante.Size = new System.Drawing.Size(75, 41);
            this.btnInsertarFabricante.TabIndex = 17;
            this.btnInsertarFabricante.Text = "Insertar fabricante";
            this.btnInsertarFabricante.UseVisualStyleBackColor = true;
            this.btnInsertarFabricante.Click += new System.EventHandler(this.btnInsertarFabricante_Click);
            // 
            // txtNombreFabricante
            // 
            this.txtNombreFabricante.Location = new System.Drawing.Point(485, 327);
            this.txtNombreFabricante.Name = "txtNombreFabricante";
            this.txtNombreFabricante.Size = new System.Drawing.Size(216, 20);
            this.txtNombreFabricante.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre";
            // 
            // btnBorrarProducto
            // 
            this.btnBorrarProducto.Location = new System.Drawing.Point(219, 204);
            this.btnBorrarProducto.Name = "btnBorrarProducto";
            this.btnBorrarProducto.Size = new System.Drawing.Size(75, 41);
            this.btnBorrarProducto.TabIndex = 18;
            this.btnBorrarProducto.Text = "Borrar producto";
            this.btnBorrarProducto.UseVisualStyleBackColor = true;
            this.btnBorrarProducto.Click += new System.EventHandler(this.btnBorrarProducto_Click);
            // 
            // btnBorrarFabricante
            // 
            this.btnBorrarFabricante.Location = new System.Drawing.Point(219, 433);
            this.btnBorrarFabricante.Name = "btnBorrarFabricante";
            this.btnBorrarFabricante.Size = new System.Drawing.Size(75, 41);
            this.btnBorrarFabricante.TabIndex = 19;
            this.btnBorrarFabricante.Text = "Borrar fabricante";
            this.btnBorrarFabricante.UseVisualStyleBackColor = true;
            this.btnBorrarFabricante.Click += new System.EventHandler(this.btnBorrarFabricante_Click);
            // 
            // btnActualizarFabricante
            // 
            this.btnActualizarFabricante.Location = new System.Drawing.Point(626, 377);
            this.btnActualizarFabricante.Name = "btnActualizarFabricante";
            this.btnActualizarFabricante.Size = new System.Drawing.Size(75, 41);
            this.btnActualizarFabricante.TabIndex = 20;
            this.btnActualizarFabricante.Text = "Actualizar fabricante";
            this.btnActualizarFabricante.UseVisualStyleBackColor = true;
            this.btnActualizarFabricante.Click += new System.EventHandler(this.btnActualizarFabricante_Click);
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.Location = new System.Drawing.Point(626, 185);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(75, 41);
            this.btnActualizarProducto.TabIndex = 21;
            this.btnActualizarProducto.Text = "Actualizar producto";
            this.btnActualizarProducto.UseVisualStyleBackColor = true;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 501);
            this.Controls.Add(this.btnActualizarProducto);
            this.Controls.Add(this.btnActualizarFabricante);
            this.Controls.Add(this.btnBorrarFabricante);
            this.Controls.Add(this.btnBorrarProducto);
            this.Controls.Add(this.btnInsertarFabricante);
            this.Controls.Add(this.txtNombreFabricante);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnInsertarProducto);
            this.Controls.Add(this.cbFabricantes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstboxFabricantes);
            this.Controls.Add(this.btnConsultarFabricantes);
            this.Controls.Add(this.lstboxProductos);
            this.Controls.Add(this.btnConsultarProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarProductos;
        private System.Windows.Forms.ListBox lstboxProductos;
        private System.Windows.Forms.ListBox lstboxFabricantes;
        private System.Windows.Forms.Button btnConsultarFabricantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFabricantes;
        private System.Windows.Forms.Button btnInsertarProducto;
        private System.Windows.Forms.Button btnInsertarFabricante;
        private System.Windows.Forms.TextBox txtNombreFabricante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBorrarProducto;
        private System.Windows.Forms.Button btnBorrarFabricante;
        private System.Windows.Forms.Button btnActualizarFabricante;
        private System.Windows.Forms.Button btnActualizarProducto;
    }
}

