
namespace Actividad7
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
            this.listaFabricantes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBorrarFabricantes = new System.Windows.Forms.Button();
            this.btnBorrarProductos = new System.Windows.Forms.Button();
            this.btnMostrarFabricantes = new System.Windows.Forms.Button();
            this.btnMostrarProductos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFabricantes = new System.Windows.Forms.ComboBox();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnInsertarProducto = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEditarFabricante = new System.Windows.Forms.Button();
            this.btnInsertarFabricante = new System.Windows.Forms.Button();
            this.txtNombreFabricante = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaProductos
            // 
            this.listaProductos.FormattingEnabled = true;
            this.listaProductos.Location = new System.Drawing.Point(29, 52);
            this.listaProductos.Name = "listaProductos";
            this.listaProductos.Size = new System.Drawing.Size(206, 212);
            this.listaProductos.TabIndex = 0;
            this.listaProductos.DoubleClick += new System.EventHandler(this.listaProductos_DoubleClick);
            // 
            // listaFabricantes
            // 
            this.listaFabricantes.FormattingEnabled = true;
            this.listaFabricantes.Location = new System.Drawing.Point(278, 52);
            this.listaFabricantes.Name = "listaFabricantes";
            this.listaFabricantes.Size = new System.Drawing.Size(246, 212);
            this.listaFabricantes.TabIndex = 1;
            this.listaFabricantes.DoubleClick += new System.EventHandler(this.listaFabricantes_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBorrarFabricantes);
            this.groupBox1.Controls.Add(this.btnBorrarProductos);
            this.groupBox1.Controls.Add(this.btnMostrarFabricantes);
            this.groupBox1.Controls.Add(this.btnMostrarProductos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listaProductos);
            this.groupBox1.Controls.Add(this.listaFabricantes);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 384);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar datos";
            // 
            // btnBorrarFabricantes
            // 
            this.btnBorrarFabricantes.Location = new System.Drawing.Point(362, 335);
            this.btnBorrarFabricantes.Name = "btnBorrarFabricantes";
            this.btnBorrarFabricantes.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarFabricantes.TabIndex = 7;
            this.btnBorrarFabricantes.Text = "Borrar";
            this.btnBorrarFabricantes.UseVisualStyleBackColor = true;
            this.btnBorrarFabricantes.Click += new System.EventHandler(this.btnBorrarFabricantes_Click);
            // 
            // btnBorrarProductos
            // 
            this.btnBorrarProductos.Location = new System.Drawing.Point(91, 335);
            this.btnBorrarProductos.Name = "btnBorrarProductos";
            this.btnBorrarProductos.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarProductos.TabIndex = 6;
            this.btnBorrarProductos.Text = "Borrar";
            this.btnBorrarProductos.UseVisualStyleBackColor = true;
            this.btnBorrarProductos.Click += new System.EventHandler(this.btnBorrarProductos_Click);
            // 
            // btnMostrarFabricantes
            // 
            this.btnMostrarFabricantes.Location = new System.Drawing.Point(362, 290);
            this.btnMostrarFabricantes.Name = "btnMostrarFabricantes";
            this.btnMostrarFabricantes.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarFabricantes.TabIndex = 5;
            this.btnMostrarFabricantes.Text = "Actualizar";
            this.btnMostrarFabricantes.UseVisualStyleBackColor = true;
            this.btnMostrarFabricantes.Click += new System.EventHandler(this.btnMostrarFabricantes_Click);
            // 
            // btnMostrarProductos
            // 
            this.btnMostrarProductos.Location = new System.Drawing.Point(91, 290);
            this.btnMostrarProductos.Name = "btnMostrarProductos";
            this.btnMostrarProductos.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarProductos.TabIndex = 4;
            this.btnMostrarProductos.Text = "Actualizar";
            this.btnMostrarProductos.UseVisualStyleBackColor = true;
            this.btnMostrarProductos.Click += new System.EventHandler(this.btnMostrarProductos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fabricantes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Productos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbFabricantes);
            this.groupBox2.Controls.Add(this.btnEditarProducto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.btnInsertarProducto);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(639, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 384);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insertar productos";
            // 
            // cbFabricantes
            // 
            this.cbFabricantes.FormattingEnabled = true;
            this.cbFabricantes.Location = new System.Drawing.Point(103, 218);
            this.cbFabricantes.Name = "cbFabricantes";
            this.cbFabricantes.Size = new System.Drawing.Size(121, 21);
            this.cbFabricantes.TabIndex = 5;
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Location = new System.Drawing.Point(103, 335);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEditarProducto.TabIndex = 8;
            this.btnEditarProducto.Text = "Editar";
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fabricante";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(103, 163);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // btnInsertarProducto
            // 
            this.btnInsertarProducto.Location = new System.Drawing.Point(88, 290);
            this.btnInsertarProducto.Name = "btnInsertarProducto";
            this.btnInsertarProducto.Size = new System.Drawing.Size(107, 23);
            this.btnInsertarProducto.TabIndex = 5;
            this.btnInsertarProducto.Text = "Insertar producto";
            this.btnInsertarProducto.UseVisualStyleBackColor = true;
            this.btnInsertarProducto.Click += new System.EventHandler(this.btnInsertarProducto_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 106);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEditarFabricante);
            this.groupBox3.Controls.Add(this.btnInsertarFabricante);
            this.groupBox3.Controls.Add(this.txtNombreFabricante);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(995, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 384);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insertar fabricantes";
            // 
            // btnEditarFabricante
            // 
            this.btnEditarFabricante.Location = new System.Drawing.Point(111, 335);
            this.btnEditarFabricante.Name = "btnEditarFabricante";
            this.btnEditarFabricante.Size = new System.Drawing.Size(75, 23);
            this.btnEditarFabricante.TabIndex = 9;
            this.btnEditarFabricante.Text = "Editar";
            this.btnEditarFabricante.UseVisualStyleBackColor = true;
            this.btnEditarFabricante.Click += new System.EventHandler(this.btnEditarFabricante_Click);
            // 
            // btnInsertarFabricante
            // 
            this.btnInsertarFabricante.Location = new System.Drawing.Point(92, 287);
            this.btnInsertarFabricante.Name = "btnInsertarFabricante";
            this.btnInsertarFabricante.Size = new System.Drawing.Size(107, 23);
            this.btnInsertarFabricante.TabIndex = 11;
            this.btnInsertarFabricante.Text = "Insertar fabricante";
            this.btnInsertarFabricante.UseVisualStyleBackColor = true;
            this.btnInsertarFabricante.Click += new System.EventHandler(this.btnInsertarFabricante_Click);
            // 
            // txtNombreFabricante
            // 
            this.txtNombreFabricante.Location = new System.Drawing.Point(99, 159);
            this.txtNombreFabricante.Name = "txtNombreFabricante";
            this.txtNombreFabricante.Size = new System.Drawing.Size(100, 20);
            this.txtNombreFabricante.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 640);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaProductos;
        private System.Windows.Forms.ListBox listaFabricantes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarFabricantes;
        private System.Windows.Forms.Button btnMostrarProductos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnInsertarProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFabricantes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInsertarFabricante;
        private System.Windows.Forms.TextBox txtNombreFabricante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBorrarFabricantes;
        private System.Windows.Forms.Button btnBorrarProductos;
        private System.Windows.Forms.Button btnEditarFabricante;
        private System.Windows.Forms.Button btnEditarProducto;
    }
}

