using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1ºActividadADATconEntity.BBDD;

namespace _1ºActividadADATconEntity
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }


        private void CargarDatos()
        {
            using (Actividad1_AccesoADatosEntities db = new Actividad1_AccesoADatosEntities())
            {

                var datosSelect = from datos in db.EquiposFutbolTitulos
                                  select datos;
                dataGridView1.DataSource = datosSelect.ToList();

            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            using(Actividad1_AccesoADatosEntities baseDatos = new Actividad1_AccesoADatosEntities())
            {

                EquiposFutbolTitulos miTabla = new EquiposFutbolTitulos();
                miTabla.NombreEquipo = txtNombre.Text;
                miTabla.Champions = Convert.ToInt32(txtChampions.Text);
                miTabla.Ligas = Convert.ToInt32(txtLigas.Text);
                miTabla.CopasDelRey = Convert.ToInt32(txtCopasRey.Text);
                miTabla.Supercopas = Convert.ToInt32(txtSupercopas.Text);
                baseDatos.EquiposFutbolTitulos.Add(miTabla);
                baseDatos.SaveChanges();
                CargarDatos();

            }
        }

        ////////////////
        ////////////////
        //PARTA DEL BOTON DE EDITAR
        ////////////////
        ////////////////

        private int? getid()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
                //MessageBox.Show("Hubo un ERROR intentelo de nuevo");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? idEquipos = getid();

            if (idEquipos != null)
            {
                Form2 tabla = new Form2(idEquipos);
                tabla.ShowDialog();
                CargarDatos();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? idEquipos = getid();

            if (idEquipos != null)
            {
                using (Actividad1_AccesoADatosEntities baseDatos = new Actividad1_AccesoADatosEntities())
                {
                    EquiposFutbolTitulos sutabla = baseDatos.EquiposFutbolTitulos.Find(idEquipos);
                    baseDatos.EquiposFutbolTitulos.Remove(sutabla);
                    baseDatos.SaveChanges();
                }
                CargarDatos();
            }
        }
    }
}
