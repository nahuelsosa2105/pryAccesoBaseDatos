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
    public partial class frmBases : Form
    {
        public frmBases()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            clsAccesoDatos objAccesoBD = new clsAccesoDatos();

            ofdAbrirArchivos.ShowDialog();

            objAccesoBD.rutaArchivo = ofdAbrirArchivos.FileName;

            objAccesoBD.ConectarBaseDatos();

            lblBase.Text = objAccesoBD.EstadoConexion;
        }
    }
}
