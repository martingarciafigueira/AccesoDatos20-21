
namespace Tarea03_ABD
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
            this.listPrdocutos = new System.Windows.Forms.ListBox();
            this.btnMostrarProductos = new System.Windows.Forms.Button();
            this.listFabricantes = new System.Windows.Forms.ListBox();
            this.btnFabricantes = new System.Windows.Forms.Button();
            this.gpProducto = new System.Windows.Forms.GroupBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.gpFabricante = new System.Windows.Forms.GroupBox();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.rdNombreProducto = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.rdNombreFabricante = new System.Windows.Forms.RadioButton();
            this.btnBorrarProdu = new System.Windows.Forms.Button();
            this.btnBorrarFabri = new System.Windows.Forms.Button();
            this.gpProducto.SuspendLayout();
            this.gpFabricante.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPrdocutos
            // 
            this.listPrdocutos.FormattingEnabled = true;
            this.listPrdocutos.Location = new System.Drawing.Point(100, 12);
            this.listPrdocutos.Name = "listPrdocutos";
            this.listPrdocutos.Size = new System.Drawing.Size(265, 225);
            this.listPrdocutos.TabIndex = 0;
            // 
            // btnMostrarProductos
            // 
            this.btnMostrarProductos.Location = new System.Drawing.Point(164, 244);
            this.btnMostrarProductos.Name = "btnMostrarProductos";
            this.btnMostrarProductos.Size = new System.Drawing.Size(123, 23);
            this.btnMostrarProductos.TabIndex = 1;
            this.btnMostrarProductos.Text = "Actualizar Productos";
            this.btnMostrarProductos.UseVisualStyleBackColor = true;
            this.btnMostrarProductos.Click += new System.EventHandler(this.btnMostrarProductos_Click);
            // 
            // listFabricantes
            // 
            this.listFabricantes.FormattingEnabled = true;
            this.listFabricantes.Location = new System.Drawing.Point(682, 12);
            this.listFabricantes.Name = "listFabricantes";
            this.listFabricantes.Size = new System.Drawing.Size(164, 225);
            this.listFabricantes.TabIndex = 2;
            // 
            // btnFabricantes
            // 
            this.btnFabricantes.Location = new System.Drawing.Point(705, 243);
            this.btnFabricantes.Name = "btnFabricantes";
            this.btnFabricantes.Size = new System.Drawing.Size(121, 25);
            this.btnFabricantes.TabIndex = 3;
            this.btnFabricantes.Text = "Actualizar Fabricantes";
            this.btnFabricantes.UseVisualStyleBackColor = true;
            this.btnFabricantes.Click += new System.EventHandler(this.btnFabricantes_Click);
            // 
            // gpProducto
            // 
            this.gpProducto.Controls.Add(this.txtProducto);
            this.gpProducto.Location = new System.Drawing.Point(19, 50);
            this.gpProducto.Name = "gpProducto";
            this.gpProducto.Size = new System.Drawing.Size(265, 74);
            this.gpProducto.TabIndex = 4;
            this.gpProducto.TabStop = false;
            this.gpProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(24, 32);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(208, 20);
            this.txtProducto.TabIndex = 0;
            // 
            // gpFabricante
            // 
            this.gpFabricante.Controls.Add(this.txtFabricante);
            this.gpFabricante.Location = new System.Drawing.Point(338, 50);
            this.gpFabricante.Name = "gpFabricante";
            this.gpFabricante.Size = new System.Drawing.Size(265, 74);
            this.gpFabricante.TabIndex = 5;
            this.gpFabricante.TabStop = false;
            this.gpFabricante.Text = "Fabricante";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Enabled = false;
            this.txtFabricante.Location = new System.Drawing.Point(34, 32);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(208, 20);
            this.txtFabricante.TabIndex = 1;
            // 
            // rdNombreProducto
            // 
            this.rdNombreProducto.AutoSize = true;
            this.rdNombreProducto.Location = new System.Drawing.Point(102, 27);
            this.rdNombreProducto.Name = "rdNombreProducto";
            this.rdNombreProducto.Size = new System.Drawing.Size(104, 17);
            this.rdNombreProducto.TabIndex = 6;
            this.rdNombreProducto.TabStop = true;
            this.rdNombreProducto.Text = "Buscar Producto";
            this.rdNombreProducto.UseVisualStyleBackColor = true;
            this.rdNombreProducto.CheckedChanged += new System.EventHandler(this.rdNombreProducto_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.txtResultado);
            this.groupBox3.Controls.Add(this.rdNombreFabricante);
            this.groupBox3.Controls.Add(this.gpFabricante);
            this.groupBox3.Controls.Add(this.gpProducto);
            this.groupBox3.Controls.Add(this.rdNombreProducto);
            this.groupBox3.Location = new System.Drawing.Point(177, 322);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(631, 240);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(273, 198);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(83, 157);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(444, 20);
            this.txtResultado.TabIndex = 9;
            // 
            // rdNombreFabricante
            // 
            this.rdNombreFabricante.AutoSize = true;
            this.rdNombreFabricante.Location = new System.Drawing.Point(417, 27);
            this.rdNombreFabricante.Name = "rdNombreFabricante";
            this.rdNombreFabricante.Size = new System.Drawing.Size(111, 17);
            this.rdNombreFabricante.TabIndex = 8;
            this.rdNombreFabricante.TabStop = true;
            this.rdNombreFabricante.Text = "Buscar Fabricante";
            this.rdNombreFabricante.UseVisualStyleBackColor = true;
            this.rdNombreFabricante.CheckedChanged += new System.EventHandler(this.rdNombreFabricante_CheckedChanged);
            // 
            // btnBorrarProdu
            // 
            this.btnBorrarProdu.Location = new System.Drawing.Point(164, 273);
            this.btnBorrarProdu.Name = "btnBorrarProdu";
            this.btnBorrarProdu.Size = new System.Drawing.Size(123, 23);
            this.btnBorrarProdu.TabIndex = 9;
            this.btnBorrarProdu.Text = "Borrar Productos";
            this.btnBorrarProdu.UseVisualStyleBackColor = true;
            this.btnBorrarProdu.Click += new System.EventHandler(this.btnBorrarProdu_Click);
            // 
            // btnBorrarFabri
            // 
            this.btnBorrarFabri.Location = new System.Drawing.Point(703, 273);
            this.btnBorrarFabri.Name = "btnBorrarFabri";
            this.btnBorrarFabri.Size = new System.Drawing.Size(123, 23);
            this.btnBorrarFabri.TabIndex = 10;
            this.btnBorrarFabri.Text = "Borrar Fabricantes";
            this.btnBorrarFabri.UseVisualStyleBackColor = true;
            this.btnBorrarFabri.Click += new System.EventHandler(this.btnBorrarFabri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 588);
            this.Controls.Add(this.btnBorrarFabri);
            this.Controls.Add(this.btnBorrarProdu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnFabricantes);
            this.Controls.Add(this.listFabricantes);
            this.Controls.Add(this.btnMostrarProductos);
            this.Controls.Add(this.listPrdocutos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpProducto.ResumeLayout(false);
            this.gpProducto.PerformLayout();
            this.gpFabricante.ResumeLayout(false);
            this.gpFabricante.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listPrdocutos;
        private System.Windows.Forms.Button btnMostrarProductos;
        private System.Windows.Forms.ListBox listFabricantes;
        private System.Windows.Forms.Button btnFabricantes;
        private System.Windows.Forms.GroupBox gpProducto;
        private System.Windows.Forms.GroupBox gpFabricante;
        private System.Windows.Forms.RadioButton rdNombreProducto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.RadioButton rdNombreFabricante;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBorrarProdu;
        private System.Windows.Forms.Button btnBorrarFabri;
    }
}

