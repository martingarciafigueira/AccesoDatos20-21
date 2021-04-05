using Dapper;
using MariñoFidalgoMarcos_Tarea05.Entidades;
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

namespace MariñoFidalgoMarcos_Tarea05
{


    public partial class Form1 : Form
    {
        const string CadenaConexion = "Initial Catalog=master;Data Source=localhost;Integrated Security=SSPI;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Mapeo de la tabla Futbolistas
            ConsultarFutbolistas(listFutbolistas, listBuscarEquipo, cmbJugadoresDorsales);
            //Mapeo de la tabla Equipos
            ConsultarEquipos(listEquipos, cmbBuscarPorEquipos, cmbEquiposPuntos);


        }




        //Agregar Equipo
        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            Equipo equipo = new Equipo(tbAEquipoCodigo.Text, tbAEquipoNombre.Text, tbAEquipoPais.Text, Int32.Parse(tbAEquipoGoles.Text), Int32.Parse(tbAEquipoPuntos.Text), tbAEquipoPJ.Text, Int32.Parse(tbAEquipoPG.Text), Int32.Parse(tbAEquipoPE.Text), Int32.Parse(tbAEquipoPP.Text), tbAEquipoEstadio.Text, tbAEquipoCiudad.Text);

            AñadirEquipo(equipo);
        }

        //Eliminar Equipo
        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            Equipo equipo = new Equipo();
            equipo.Codigo = tbEEquipoCodigo.Text;
            EliminarEquipo(equipo);

        }

        //Agregar Futbolista
        private void btnAgregarFutbolista_Click(object sender, EventArgs e)
        {
            Futbolista futbolista = new Futbolista(tbAFutbolistaCodigo.Text, tbAFutbolistaNombre.Text, tbAFutbolistaEquipo.Text, tbAFutbolistaCodigoEquipo.Text, tbAFutbolistaPosicion.Text, Int32.Parse(tbAFutbolistaEdad.Text), Int32.Parse(tbAFutbolistaGoles.Text), Int32.Parse(tbAFutbolistaTA.Text), Int32.Parse(tbAFutbolistaTR.Text), Int32.Parse(tbAFutbolistaMinutos.Text), tbAFutbolistaPrecioMercado.Text, Int32.Parse(tbAFutbolistaDorsal.Text), Int32.Parse(tbAFutbolistaPeso.Text));

            AñadirFutbolista(futbolista);

        }

        //Eliminar Futbolista
        private void btnEliminarFutbolista_Click(object sender, EventArgs e)
        {
            Futbolista futbolista = new Futbolista();
            futbolista.Codigo = tbEFutbolistaCodigo.Text;
            EliminarFutbolista(futbolista);
        }

        //ObtenerFutbolistasPorEquipo
        private void btnBuscarPorEquipo_Click(object sender, EventArgs e)
        {
            Equipo equipo = new Equipo();
            equipo.Nombre = cmbBuscarPorEquipos.SelectedItem.ToString();

            foreach (var item in ObtenerFutbolistaPorEquipo(equipo))
            {
                listFutbolistasPorEquipo.Items.Add(item.datosFutbolista());
            }
        }

        //ObtenerEquipoDeFutbolista
        private void btnBuscarPorFutbolista_Click(object sender, EventArgs e)
        {
            Futbolista futbolista = new Futbolista();
            Equipo equipo = new Equipo();

            string[] codigoSplit = listBuscarEquipo.SelectedItem.ToString().Split('/');

            futbolista.CodigoEquipo = codigoSplit[0];

            equipo = ObtenerEquipoDeFutbolista(futbolista);

            tbNombreEquipo.Text = equipo.Nombre;
        }

        private void cmbJugadoresDorsales_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] codigoSplit = cmbJugadoresDorsales.SelectedItem.ToString().Split('/');
            tbDorsalJugador.Text = ObtenerDorsalJugador(codigoSplit[0]).ToString();
        }

        //Modificar Futbolista
        private void btnModificarDorsalFutbolista_Click(object sender, EventArgs e)
        {
            string[] codigoSplit = cmbJugadoresDorsales.SelectedItem.ToString().Split('/');
            Futbolista futbolista = new Futbolista();
            futbolista.Codigo = codigoSplit[0];
            futbolista.Dorsal = Int32.Parse(tbDorsalJugador.Text);

            ModificarDorsalFutbolista(futbolista);
        }

        private void cmbEquiposPuntos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] codigoSplit = cmbEquiposPuntos.SelectedItem.ToString().Split('/');
            tbPuntosEquipo.Text = ObtenertPuntosEquipo(codigoSplit[0]).ToString();
        }

        //Modificar Equipo
        private void btnModificarEquipo_Click(object sender, EventArgs e)
        {
            string[] codigoSplit = cmbEquiposPuntos.SelectedItem.ToString().Split('/');
            Equipo equipo = new Equipo();
            equipo.Codigo = codigoSplit[0];
            equipo.Puntos = Int32.Parse(tbPuntosEquipo.Text);
            ModificarPuntosEquipo(equipo);
        }

        private static void ConsultarFutbolistas(ListBox listBox, ListBox listBox1, ComboBox comboBox)
        {

            using (IDbConnection db = new SqlConnection(CadenaConexion))
            {

                var consulta = @"SELECT * From Futbolistas";

                List<Futbolista> listaFutbolistas = (List<Futbolista>)db.Query<Futbolista>(consulta);

                foreach (var item in listaFutbolistas)
                {
                    listBox.Items.Add(item.ToString());
                    listBox1.Items.Add(item.futbolistaEquipo());
                    comboBox.Items.Add(item.datosFutbolista());
                }
            }

        }

        private static void ConsultarEquipos(ListBox listBox, ComboBox comboBox, ComboBox comboBox1)
        {
            using (IDbConnection db = new SqlConnection(CadenaConexion))
            {

                var consulta = @"SELECT * From Equipos";

                List<Equipo> listaEquipos = (List<Equipo>)db.Query<Equipo>(consulta);

                foreach (var item in listaEquipos)
                {
                    listBox.Items.Add(item.ToString());
                    comboBox.Items.Add(item.Nombre);
                    comboBox1.Items.Add(item.equipos());
                }
            }

        }
        private static void AñadirEquipo(Equipo equipo)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(CadenaConexion))
                {
                    var consulta = $@"INSERT INTO Equipos  VALUES(@Codigo,@Nombre,@Pais,@Goles,@Puntos,@PJ,@PG,@PE,@PP,@Estadio,@Ciudad);";
                    db.Execute(consulta, equipo);
                }
                MessageBox.Show("Equipo Agregado");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
           
        }

        private static void AñadirFutbolista(Futbolista futbolista)
        {

            try
            {
                using (IDbConnection db = new SqlConnection(CadenaConexion))
                {
                    var consulta = $@"INSERT INTO Futbolistas VALUES(@Codigo,@NOmbre,@Equipo,@CodigoEquipo,@Posicion,@Edad,@Goles,@TA,@TR,@Minutos,@PrecioMercado,@Dorsal,@Peso)";
                    db.Execute(consulta, futbolista);
                }
                MessageBox.Show("Futbolista Agregado");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString()); 
            }
            
            
        }

        private static void EliminarEquipo(Equipo equipo)
        {


            using (IDbConnection db = new SqlConnection(CadenaConexion))
            {
                var consulta = $@"DELETE FROM Equipos WHERE Codigo = @Codigo";
                db.Execute(consulta, equipo);
            }
            MessageBox.Show("Equipo Eliminado");
        }

        private static void EliminarFutbolista(Futbolista futbolista)
        {


            using (IDbConnection db = new SqlConnection(CadenaConexion))
            {
                var consulta = $@"DELETE FROM Futbolistas WHERE Codigo = @Codigo";
                db.Execute(consulta, futbolista);
            }
            MessageBox.Show("Futbolista Eliminado");
        }

        private static List<Futbolista> ObtenerFutbolistaPorEquipo(Equipo team)
        {
            List<Futbolista> listaFutbolista = new List<Futbolista>();

            var consulta = @"Select * from Futbolistas where Equipo = @Nombre";

            using (IDbConnection db = new SqlConnection(CadenaConexion))
            {

                listaFutbolista = (List<Futbolista>)db.Query<Futbolista>(consulta, team);

            }

            return listaFutbolista;
        }

        private static Equipo ObtenerEquipoDeFutbolista(Futbolista player)
        {
            Equipo equipo = new Equipo();
            List<Equipo> equipos = new List<Equipo>();

            using (IDbConnection db = new SqlConnection(CadenaConexion))
            {
                var consulta = $@"Select * from Equipos where Codigo = @CodigoEquipo";
                equipos = (List<Equipo>)db.Query<Equipo>(consulta, player);

            }

            equipo = equipos[0];

            return equipo;
        }

        private static int ObtenerDorsalJugador(string codigoJugador)
        {

            int dorsal = 0;

            using (IDbConnection db = new SqlConnection(CadenaConexion))
            {

                var consulta = $@"Select Dorsal from Futbolistas where Codigo LIKE '" + codigoJugador + "'";
                List<Futbolista> futbolistas = (List<Futbolista>)db.Query<Futbolista>(consulta);

                foreach (var item in futbolistas)
                {
                    dorsal = item.Dorsal;
                    break;
                }

            }

            return dorsal;
        }

        private static void ModificarDorsalFutbolista(Futbolista futbolista)
        {
            using (IDbConnection db = new SqlConnection(CadenaConexion))
            {
                var consulta = $@"UPDATE Futbolistas SET Dorsal = @Dorsal where Codigo = @Codigo";
                db.Execute(consulta, futbolista);
            }
            MessageBox.Show("Dorsal Modificada");
        }

        private static int ObtenertPuntosEquipo(string codigoEquipo)
        {
            int puntos = 0;

            using (IDbConnection db = new SqlConnection(CadenaConexion))
            {
                var consulta = $@"Select Puntos from Equipos where Codigo LIKE '" + codigoEquipo + "'";
                List<Equipo> equipos = (List<Equipo>)db.Query<Equipo>(consulta);

                foreach (var item in equipos)
                {
                    puntos = item.Puntos;
                    break;
                }
            }

            return puntos;

        }

        private static void ModificarPuntosEquipo(Equipo equipo)
        {
            using (IDbConnection db = new SqlConnection(CadenaConexion))
            {
                var consulta = $@"UPDATE Equipos SET Puntos = @Puntos where Codigo = @Codigo";
                db.Execute(consulta, equipo);
            }
            MessageBox.Show("Puntos Modificados");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


    }
}
