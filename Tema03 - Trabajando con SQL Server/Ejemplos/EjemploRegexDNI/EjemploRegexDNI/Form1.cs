using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EjemploRegexDNI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validado = false;
            validado = Regex.Match(txtDNI.Text, @"^[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][A-Z]$").Success;

            if (validado)
            {
                MessageBox.Show("El formato del DNI es correcto");
            }
            else
            {
                MessageBox.Show("El formato del DNI es incorrecto");
            }
        }
    }
}
