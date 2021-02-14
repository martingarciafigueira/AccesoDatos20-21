using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Actividad1
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion = new SqlConnection(@"server=DESKTOP-S65ABNK\BD_MONTECASTELO; database=BDMontecastelo; integrated security = true");

            conexion.Open();
            MessageBox.Show("Se ha realizado la conexión!");
            conexion.Close();
            MessageBox.Show("Se ha realizado la desconexión!");

        }
    }
}
