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

namespace Actividad6
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        public Form1()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Actividad6.Properties.Settings.tiendaConnectionString"].ConnectionString;
            conexion = new SqlConnection(connectionString);

            conexion.Open();
        }

        private void btnCargarProductos_Click(object sender, EventArgs e)
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
    }
}
