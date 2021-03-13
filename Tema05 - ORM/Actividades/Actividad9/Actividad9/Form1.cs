using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad9
{
    public partial class Form1 : Form
    {
        const string cadenaConexion = "Initial catalog = tienda;Data Source = DESKTOP-S65ABNK; Integrated Security=SSPI";

        public Form1()
        {
            InitializeComponent();
            cbFabricantes.DataSource = ConsultarFabricantes();
        }

        private void btnConsultarProductos_Click(object sender, EventArgs e)
        {
            List<Producto> listaProductos = new List<Producto>();
            listaProductos = ConsultarProductos();
            lstboxProductos.DataSource = listaProductos;
        }

        private void btnConsultarFabricantes_Click(object sender, EventArgs e)
        {
            List<Fabricante> listaFabricantes = new List<Fabricante>();
            listaFabricantes = ConsultarFabricantes();
            lstboxFabricantes.DataSource = listaFabricantes;
        }

        private void btnInsertarProducto_Click(object sender, EventArgs e)
        {
            Producto producto;
            int codigo = -1;
            string nombre;
            double precio;
            int codigoFabricante;
            Fabricante fabricanteSeleccionado;

            nombre = txtNombre.Text;
            double.TryParse(txtPrecio.Text, out precio);
            fabricanteSeleccionado = (Fabricante)cbFabricantes.SelectedItem;
            codigoFabricante = fabricanteSeleccionado.Codigo;

            producto = new Producto(codigo, nombre, precio, codigoFabricante);

            InsertarProducto(producto);
        }

        private void btnInsertarFabricante_Click(object sender, EventArgs e)
        {
            Fabricante fabricante;
            int codigo = -1;
            string nombre;

            nombre = txtNombreFabricante.Text;

            fabricante = new Fabricante(codigo, nombre);

            InsertarFabricante(fabricante);
        }

        private void btnBorrarFabricante_Click(object sender, EventArgs e)
        {
            Fabricante fabricanteABorrar;

            fabricanteABorrar = (Fabricante)lstboxFabricantes.SelectedItem;

            BorrarFabricante(fabricanteABorrar);
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            Producto producto;
            double precio;
            int codigo_fabricante;
            Fabricante fabricante_seleccionado;

            producto = (Producto)lstboxProductos.SelectedItem;
            producto.Nombre = txtNombre.Text;
            double.TryParse(txtPrecio.Text, out precio);
            fabricante_seleccionado = (Fabricante)cbFabricantes.SelectedItem;
            codigo_fabricante = fabricante_seleccionado.Codigo;
            producto.Precio = precio;
            producto.Nombre = txtNombre.Text;
            producto.Codigo_Fabricante = codigo_fabricante;

            ActualizarProducto(producto);
        }

        private void btnActualizarFabricante_Click(object sender, EventArgs e)
        {
            Fabricante fabricante;
            fabricante = (Fabricante)lstboxFabricantes.SelectedItem;
            fabricante.Nombre = txtNombreFabricante.Text;

            ActualizarFabricante(fabricante);
        }

        private void lstboxFabricantes_DoubleClick(object sender, EventArgs e)
        {
            Fabricante fabricante;
            fabricante = (Fabricante)lstboxFabricantes.SelectedItem;
            txtNombreFabricante.Text = fabricante.Nombre;
        }

        private void lstboxProductos_DoubleClick(object sender, EventArgs e)
        {
            Producto producto;
            Fabricante fabricante_producto;

            producto = (Producto)lstboxProductos.SelectedItem;
            txtNombre.Text = producto.Nombre;
            txtPrecio.Text = producto.Precio.ToString();
            fabricante_producto = ConsultarFabricanteByProducto(producto);
            cbFabricantes.SelectedIndex = 2;
        }

        public List<Producto> ConsultarProductos()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = @"SELECT * FROM Producto";
                List<Producto> listaProductos = (List<Producto>)db.Query<Producto>(consulta);
                return listaProductos;
            }
        }

        public List<Producto> ConsultarProductosByFabricante(Fabricante fabricante)
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = @"SELECT * FROM Producto WHERE Codigo_Fabricante = @Codigo";
                List<Producto> listaProductos = (List<Producto>)db.Query<Producto>(consulta, fabricante);
                return listaProductos;
            }
        }

        public List<Fabricante> ConsultarFabricantes()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = @"SELECT * FROM Fabricante";
                List<Fabricante> listaFabricantes = (List<Fabricante>)db.Query<Fabricante>(consulta);
                return listaFabricantes;
            }
        }

        public Fabricante ConsultarFabricanteByProducto(Producto producto)
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = @"SELECT * FROM Fabricante WHERE Codigo = @Codigo_Fabricante";
                Fabricante fabricante = (Fabricante)db.Query<Fabricante>(consulta, producto).First();
                return fabricante;
            }
        }

        public void InsertarProducto(Producto producto)
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = @"INSERT INTO Producto VALUES (@Nombre, @Precio, @Codigo_Fabricante)";
                db.Execute(consulta, producto);
            }
        }

        public void ActualizarProducto(Producto producto)
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = @"UPDATE Producto SET Nombre = @Nombre AND Precio = @Precio AND Codigo_Fabricante = @Codigo_Fabricante WHERE Codigo = @Codigo";
                db.Execute(consulta, producto);
            }
        }

        public void InsertarFabricante(Fabricante fabricante)
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = @"INSERT INTO Fabricante VALUES (@Nombre)";
                db.Execute(consulta, fabricante);
            }
        }

        public void ActualizarFabricante(Fabricante fabricante)
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = @"UPDATE Fabricante SET Nombre = @Nombre WHERE Codigo = @Codigo";
                db.Execute(consulta, fabricante);
            }
        }

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            Producto productoABorrar;

            productoABorrar = (Producto)lstboxProductos.SelectedItem;

            BorrarProducto(productoABorrar);
        }

        public void BorrarProducto(Producto producto)
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = @"DELETE Producto WHERE Codigo = @Codigo";
                db.Execute(consulta, producto);
            }
        }

        public void BorrarProductos(List<Producto> listaProductos)
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                foreach (Producto producto in listaProductos)
                {
                    var consulta = @"DELETE Producto WHERE Codigo = @Codigo";
                    db.Execute(consulta, producto);
                }
            }
        }

        public void BorrarFabricante(Fabricante fabricante)
        {
            List<Producto> listaProductos = ConsultarProductosByFabricante(fabricante);

            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                if (listaProductos.Count > 0)
                {
                    BorrarProductos(listaProductos);
                }
                var consulta = @"DELETE Fabricante WHERE Codigo = @Codigo";
                db.Execute(consulta, fabricante);
            }
        }
    }
}
