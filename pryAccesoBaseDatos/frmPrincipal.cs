using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAccesoBaseDatos
{
    public partial class frmPrincipal : Form
    {
        clsAccesoDatos objAccesoBD;

        public frmPrincipal()
        {
            InitializeComponent();
            objAccesoBD = new clsAccesoDatos();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            objAccesoBD.ConectarBaseDatos();

            lblEstadoConexion.Text = objAccesoBD.EstadoConexion;

            //MessageBox.Show(objAccesoBD.EstadoConexion);


        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            objAccesoBD.TraerDatos(dgvSocios);

            lblDatos.Text = objAccesoBD.DatosExtraidos;

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            objAccesoBD.TraerDatosDataSet(dgvSocios);

            if (txtNombre.Text != "")
            {
                objAccesoBD.RegistrarDatosDataSet(txtNombre.Text);
            }


        }

        private void btnAbrirOtroForm_Click(object sender, EventArgs e)
        {
            frmBases ventana = new frmBases();
            ventana.ShowDialog();
        }

        private void btnCargarChart_Click(object sender, EventArgs e)
        {
            objAccesoBD.ConectarBaseNeptuno(lblDatos);

            
        }
    }
}
