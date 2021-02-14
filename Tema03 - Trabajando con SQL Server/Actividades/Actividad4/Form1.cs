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
using System.Configuration;

namespace Actividad4
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        string miconexion;
        public Form1()
        {
            InitializeComponent();
            miconexion = ConfigurationManager.ConnectionStrings["Actividad4.Properties.Settings.Actividad4ConnectionString"].ConnectionString;
            conexion = new SqlConnection(miconexion);

            conexion.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
