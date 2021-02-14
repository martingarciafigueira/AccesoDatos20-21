using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad7
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        string miconexion;
        public Form1()
        {
            InitializeComponent();
            miconexion = ConfigurationManager.ConnectionStrings["Actividad7.Properties.Settings.Actividad7ConnectionString"].ConnectionString;
            conexion = new SqlConnection(miconexion);

            conexion.Open();
            cargarComboBoxFabricantes();
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            actualizarProductos();
        }

        private void btnMostrarFabricantes_Click(object sender, EventArgs e)
        {
            actualizarFabricantes();
        }

        private void btnInsertarProducto_Click(object sender, EventArgs e)
        {
            int codigo = 0, codigo_fabricante = 10;
            string nombre;
            float precio;
            string consulta;
            SqlCommand comando;

            consulta = "SELECT MAX(codigo) as codigo from producto";

            comando = new SqlCommand(consulta, conexion);

            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                int.TryParse(registros["codigo"].ToString(), out codigo);
            }

            registros.Close();

            int.TryParse(cbFabricantes.SelectedValue.ToString(), out codigo_fabricante);

            consulta = "INSERT INTO producto VALUES (@Codigo, @Nombre, @Precio, @Codigo_Fabricante)";
            comando = new SqlCommand(consulta, conexion);

            nombre = txtNombre.Text;
            float.TryParse(txtPrecio.Text, out precio);

            comando.Parameters.AddWithValue("@Codigo", codigo + 1);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Precio", precio);
            comando.Parameters.AddWithValue("@Codigo_Fabricante", codigo_fabricante);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            using (adaptador)
            {
                DataTable dtProducto = new DataTable();
                adaptador.Fill(dtProducto);
                adaptador.Update(dtProducto);
            }
        }

        public void cargarComboBoxFabricantes()
        {
            string consulta = "SELECT Codigo, Nombre FROM fabricante";
            SqlCommand comando = new SqlCommand(consulta, conexion);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            using (adaptador)
            {
                DataTable dtProducto = new DataTable();
                adaptador.Fill(dtProducto);

                cbFabricantes.ValueMember = "Codigo";
                cbFabricantes.DisplayMember = "Nombre";
                cbFabricantes.DataSource = dtProducto;
            }
        }

        private void btnInsertarFabricante_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            string nombre;
            string consulta;
            SqlCommand comando;

            consulta = "SELECT MAX(codigo) as codigo from fabricante";

            comando = new SqlCommand(consulta, conexion);

            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                int.TryParse(registros["codigo"].ToString(), out codigo);
            }

            registros.Close();

            consulta = "INSERT INTO fabricante VALUES (@Codigo, @Nombre)";
            comando = new SqlCommand(consulta, conexion);

            nombre = txtNombreFabricante.Text;

            comando.Parameters.AddWithValue("@Codigo", codigo + 1);
            comando.Parameters.AddWithValue("@Nombre", nombre);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            using (adaptador)
            {
                DataTable dtProducto = new DataTable();
                adaptador.Fill(dtProducto);
                adaptador.Update(dtProducto);
            }
        }

        private void btnBorrarProductos_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            string consulta;
            SqlCommand comando;
            bool correcto;

            correcto = int.TryParse(listaProductos.SelectedValue.ToString(), out codigo);

            if (correcto)
            {
                consulta = "DELETE FROM producto WHERE Codigo = @Codigo";
                comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@Codigo", codigo);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                using (adaptador)
                {
                    DataTable dtProducto = new DataTable();
                    adaptador.Fill(dtProducto);
                    adaptador.Update(dtProducto);
                }

                actualizarProductos(); 
            }
        }

        public void actualizarProductos()
        {
            string consulta = "SELECT Codigo, CONCAT(Nombre,' | ',precio) as INFO_PRODUCTO FROM producto";
            SqlCommand comando = new SqlCommand(consulta, conexion);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            using (adaptador)
            {
                DataTable dtProducto = new DataTable();
                adaptador.Fill(dtProducto);

                listaProductos.ValueMember = "codigo";
                listaProductos.DisplayMember = "INFO_PRODUCTO";
                listaProductos.DataSource = dtProducto;
            }
        }

        public void actualizarFabricantes()
        {
            string consulta = "SELECT Codigo, Nombre FROM fabricante";
            SqlCommand comando = new SqlCommand(consulta, conexion);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            using (adaptador)
            {
                DataTable dtProducto = new DataTable();
                adaptador.Fill(dtProducto);

                listaFabricantes.ValueMember = "Codigo";
                listaFabricantes.DisplayMember = "Nombre";
                listaFabricantes.DataSource = dtProducto;
            }
        }

        private void btnBorrarFabricantes_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            string consulta;
            SqlCommand comando;
            bool correcto;
            SqlDataAdapter adaptador;

            correcto = int.TryParse(listaFabricantes.SelectedValue.ToString(), out codigo);

            if (correcto)
            {
                consulta = "DELETE FROM producto WHERE Codigo_Fabricante = @Codigo";

                comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@Codigo", codigo);

                adaptador = new SqlDataAdapter(comando);

                using (adaptador)
                {
                    DataTable dtProducto = new DataTable();
                    adaptador.Fill(dtProducto);
                    adaptador.Update(dtProducto);
                }

                actualizarProductos();

                consulta = "DELETE FROM fabricante WHERE Codigo = @Codigo";

                comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@Codigo", codigo);

                adaptador = new SqlDataAdapter(comando);

                using (adaptador)
                {
                    DataTable dtProducto = new DataTable();
                    adaptador.Fill(dtProducto);
                    adaptador.Update(dtProducto);
                }

                actualizarFabricantes();

            }
        }

        private void listaProductos_DoubleClick(object sender, EventArgs e)
        {
            int codigo = 0;
            string consulta;
            SqlCommand comando;

            int.TryParse(listaProductos.SelectedValue.ToString(), out codigo);

            consulta = "SELECT Nombre, Precio from producto WHERE Codigo=@Codigo";

            comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@Codigo", codigo);

            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                txtNombre.Text = registros["Nombre"].ToString();
                txtPrecio.Text = registros["Precio"].ToString();
            }

            registros.Close();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            string nombre;
            float precio;
            string consulta;
            SqlCommand comando;

            int.TryParse(listaProductos.SelectedValue.ToString(), out codigo);

            consulta = "UPDATE producto SET Nombre=@Nombre, Precio=@Precio WHERE Codigo=@Codigo";
            comando = new SqlCommand(consulta, conexion);

            nombre = txtNombre.Text;
            float.TryParse(txtPrecio.Text, out precio);

            comando.Parameters.AddWithValue("@Codigo", codigo);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Precio", precio);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            using (adaptador)
            {
                DataTable dtProducto = new DataTable();
                adaptador.Fill(dtProducto);
                adaptador.Update(dtProducto);
            }

            actualizarProductos();
        }

        private void listaFabricantes_DoubleClick(object sender, EventArgs e)
        {
            int codigo = 0;
            string consulta;
            SqlCommand comando;

            int.TryParse(listaFabricantes.SelectedValue.ToString(), out codigo);

            consulta = "SELECT Nombre from fabricante WHERE Codigo=@Codigo";

            comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@Codigo", codigo);

            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                txtNombreFabricante.Text = registros["Nombre"].ToString();
            }

            registros.Close();
        }

        private void btnEditarFabricante_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            string nombre;
            string consulta;
            SqlCommand comando;

            int.TryParse(listaFabricantes.SelectedValue.ToString(), out codigo);

            consulta = "UPDATE fabricante SET Nombre=@Nombre WHERE Codigo=@Codigo";
            comando = new SqlCommand(consulta, conexion);

            nombre = txtNombreFabricante.Text;

            comando.Parameters.AddWithValue("@Codigo", codigo);
            comando.Parameters.AddWithValue("@Nombre", nombre);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            using (adaptador)
            {
                DataTable dtProducto = new DataTable();
                adaptador.Fill(dtProducto);
                adaptador.Update(dtProducto);
            }

            actualizarFabricantes();
        }
    }
}
