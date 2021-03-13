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

namespace EjemploConexionDapper
{
    public partial class Form1 : Form
    {
        const string cadenaConexion = "Initial catalog = tienda;Data Source = DESKTOP-S65ABNK; Integrated Security=SSPI";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarFabricantes();
        }

        public void ConsultarFabricantes()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = @"SELECT * FROM FABRICANTE";
                List<Fabricante> listaFabricantes = (List<Fabricante>) db.Query<Fabricante>(consulta);
                listBox1.DataSource = listaFabricantes;
            }
        }

        public void ConsultarProductos()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = @"SELECT * FROM PRODUCTO";
                List<Producto> listaProductos = (List<Producto>)db.Query<Producto>(consulta);
                listBox2.DataSource = listaProductos;
            }
        }

        public void ConsultarProductosFabricantes()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = @"SELECT P.* FROM FABRICANTE F INNER JOIN PRODUCTO P ON F.CODIGO = P.CODIGO_FABRICANTE";
                List<Producto> listaProductos = (List<Producto>)db.Query<Producto>(consulta);
                listBox3.DataSource = listaProductos;
            }
        }

        public void InsertarProducto(string nombre, double precio, int codigo_fabricante)
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = "INSERT INTO Producto VALUES ('" + nombre + "'," + precio + "," + codigo_fabricante + ")";
                db.Execute(consulta);
            }
        }

        public void InsertarProductoDeFabricante(string nombre, double precio, string nombre_fabricante)
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                //Primera consulta para saber el código
                var consulta = @"SELECT Codigo from fabricante WHERE nombre = '" + nombre_fabricante + "'";
                int idCodigo = db.Query<int>(consulta).First();

                //Segunda consulta para insertar el producto
                consulta = "INSERT INTO Producto VALUES ('" + nombre + "'," + precio + "," + idCodigo + ")";
                db.Execute(consulta);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarProductos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultarProductosFabricantes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nombre;
            double precio;
            int codigo_fabricante;

            nombre = textBox2.Text;
            double.TryParse(textBox3.Text, out precio);
            int.TryParse(textBox4.Text, out codigo_fabricante);

            InsertarProducto(nombre, precio, codigo_fabricante);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string nombre, nombre_fabricante;
            double precio;

            nombre = textBox1.Text;
            double.TryParse(textBox5.Text, out precio);
            nombre_fabricante = textBox6.Text;

            InsertarProductoDeFabricante(nombre, precio, nombre_fabricante);
        }
    }
}
