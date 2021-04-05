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

namespace Tarea03_ABD
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        public Form1()
        {
            InitializeComponent();
            conexion = new SqlConnection(@"server=DESKTOP-9EUFT97; database=tienda; integrated security=true");
            conexion.Open();
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            LimpiarList(listPrdocutos);
            ActualizarProducto();
        }

        private void ActualizarProducto()
        {
            string consulta = "SELECT nombre, precio from producto";

            SqlCommand comando = new SqlCommand(consulta, conexion);

            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                listPrdocutos.Items.Add((registros["nombre"].ToString()));
            }

            registros.Close();
        }

        private void LimpiarList(ListBox list)
        {
            list.Items.Clear();
        }

        private void btnFabricantes_Click(object sender, EventArgs e)
        {
            LimpiarList(listFabricantes);
            ActualizarFabricantes();
        }

        private void ActualizarFabricantes()
        {
            string consulta = "SELECT nombre from fabricante";

            SqlCommand comando = new SqlCommand(consulta, conexion);

            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                listFabricantes.Items.Add(registros["nombre"].ToString());
            }

            registros.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string consulta;
            SqlCommand comando;

            if (rdNombreFabricante.Checked == true)
            {
               
                consulta = "SELECT nombre, codigo from fabricante where nombre = @nombre";
                comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@nombre", txtFabricante.Text);

                SqlDataReader registros = comando.ExecuteReader();


                while (registros.Read())
                {
                    txtResultado.Text = ("Nombre : "+registros["nombre"].ToString() + "  Codigo : "+ registros["codigo"].ToString());
                }

                registros.Close();
            }

            if(rdNombreProducto.Checked == true)
            {
                consulta = "SELECT nombre, precio, codigo_fabricante from producto where nombre = @nombre";
                comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@nombre", txtProducto.Text);

                SqlDataReader registros = comando.ExecuteReader();


                while (registros.Read())
                {
                    txtResultado.Text = ("Nombre : " + registros["nombre"].ToString() + "  Precio : " + registros["precio"].ToString() + "  Codigo Producto : " + registros["codigo_fabricante"].ToString());
                }

                registros.Close();
            }
        }

        private void rdNombreProducto_CheckedChanged(object sender, EventArgs e)
        {
            txtFabricante.Enabled = false;
            txtProducto.Enabled = true;
        }

        private void rdNombreFabricante_CheckedChanged(object sender, EventArgs e)
        {
            txtProducto.Enabled = false;
            txtFabricante.Enabled = true;
        }

        private void btnBorrarProdu_Click(object sender, EventArgs e)
        {
            if(listPrdocutos.SelectedIndex == -1)
            {
                MessageBox.Show("No ha elegido");
            }
            else
            {
                
                string consulta;
                SqlCommand comando;
                int codigo = ConseguirCodigoProducto();
        
                    consulta = "Delete from producto where codigo = @codigo";
                    comando = new SqlCommand(consulta, conexion);

                    comando.Parameters.AddWithValue("@codigo", codigo);

                    SqlDataReader registros = comando.ExecuteReader();

                    registros.Close();

                    LimpiarList(listPrdocutos);
                    ActualizarProducto();
                    
            }
           
        }

        private int ConseguirCodigoProducto()
        {
            int codigo=0;
            string consulta;
            SqlCommand comando;

            consulta = "Select codigo from producto where nombre = @nombre";
            comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@nombre", listPrdocutos.SelectedItem.ToString());

            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                int.TryParse(registros["codigo"].ToString(), out codigo);
            }

            registros.Close();
            return codigo;
        }

        private void btnBorrarFabri_Click(object sender, EventArgs e)
        {
            if (listFabricantes.SelectedIndex == -1)
            {
                MessageBox.Show("No ha elegido");
            }
            else
            {
               
                int codigoFabricante = ConseguirCodigoFabricante();
                MessageBox.Show(codigoFabricante.ToString());

                BorrarProductosAsociados(codigoFabricante);
                BorrarFabricante(codigoFabricante);

                //consulta = "Delete from producto where codigo = @codigo";
                //comando = new SqlCommand(consulta, conexion);

                //comando.Parameters.AddWithValue("@codigo", listPrdocutos.SelectedIndex + 1);

                //SqlDataReader registros = comando.ExecuteReader();

                //registros.Close();

                //LimpiarList(listPrdocutos);
                //ActualizarProducto();
            }
        }

        private void BorrarFabricante(int codigoFabricante)
        {
            string consulta;
            SqlCommand comando;

            consulta = "Delete from fabricante where codigo = @codigo";
            comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@codigo", codigoFabricante);

            SqlDataReader registros = comando.ExecuteReader();

            registros.Close();

            LimpiarList(listFabricantes);
            ActualizarFabricantes();
        }

        private void BorrarProductosAsociados(int codigofabri)
        {
            string consulta;
            SqlCommand comando;

            consulta = "Delete from producto where codigo_fabricante = @codigo";
            comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@codigo", codigofabri);

            SqlDataReader registros = comando.ExecuteReader();

            registros.Close();

            LimpiarList(listPrdocutos);
            ActualizarProducto();
        }

        private int ConseguirCodigoFabricante()
        {
            int codigo = 0;
            string consulta;
            SqlCommand comando;

            consulta = "Select codigo from fabricante where nombre = @nombre";
            comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@nombre", listFabricantes.SelectedItem.ToString());

            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                int.TryParse(registros["codigo"].ToString(), out codigo);
            }

            registros.Close();
            return codigo;
        }
    }
}
