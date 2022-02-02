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
    public partial class Form2 : Form
    {
        public int? idEquipos;
        EquiposFutbolTitulos BDtable = null;


        public Form2(int? idEquipos=null)
        {
            InitializeComponent();
            this.idEquipos = idEquipos;

            if(idEquipos != null)
            {
                recogerDat();               
            }

        }



        private void recogerDat()
        {
            using (Actividad1_AccesoADatosEntities baseDatos = new Actividad1_AccesoADatosEntities())
            {
                BDtable = baseDatos.EquiposFutbolTitulos.Find(idEquipos);
                txtNombre.Text = BDtable.NombreEquipo;
                txtChampions.Text = BDtable.Champions.ToString();
                txtLigas.Text = BDtable.Ligas.ToString();
                txtCopasRey.Text = BDtable.CopasDelRey.ToString();
                txtSupercopas.Text = BDtable.Supercopas.ToString();

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (Actividad1_AccesoADatosEntities baseDatos = new Actividad1_AccesoADatosEntities())
            {

                if (idEquipos == null)
                    BDtable = new EquiposFutbolTitulos();
                    BDtable.NombreEquipo = txtNombre.Text;
                    BDtable.Champions = Convert.ToInt32(txtChampions.Text);
                    BDtable.Ligas = Convert.ToInt32(txtLigas.Text);
                    BDtable.CopasDelRey = Convert.ToInt32(txtCopasRey.Text);
                    BDtable.Supercopas = Convert.ToInt32(txtSupercopas.Text);
                
                if(idEquipos == null)
                {
                    baseDatos.EquiposFutbolTitulos.Add(BDtable);
                }
                else
                {
                    baseDatos.Entry(BDtable).State = System.Data.Entity.EntityState.Modified;
                }

                baseDatos.SaveChanges();
                this.Close();


            }


        }
    }
}






  