using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace pryAccesoBaseDatos
{
    internal class clsAccesoDatos
    {
        public string EstadoConexion;
        public string Errores;
        public string DatosExtraidos;

        OleDbConnection conexionBD;
        public string rutaArchivo;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        OleDbDataAdapter adaptadorDS;
        DataSet objDataSet = new DataSet();

        public void ConectarBaseDatos()
        {
            try
            {
                if (rutaArchivo == null)
                {
                    rutaArchivo = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ../../Bases/EL_CLUB.accdb";
                }
                else
                {
                    rutaArchivo = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + rutaArchivo;
                }
                

                conexionBD = new OleDbConnection();

                conexionBD.ConnectionString = rutaArchivo;

                conexionBD.Open();

                EstadoConexion = "Conectado a la base " + conexionBD.DataSource;
            }
            catch (Exception exepcion)
            {
                EstadoConexion = "Error en la conexión." + exepcion.Message;
            }

        }

        public void ConectarBaseNeptuno(Label Datos)
        {

            OleDbDataReader objDataReader;
            try
            {
                if (rutaArchivo == null)
                {
                    rutaArchivo = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ../../Bases/NEPTUNO.accdb";
                }
                else
                {
                    rutaArchivo = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + rutaArchivo;
                }
                conexionBD = new OleDbConnection();

                conexionBD.ConnectionString = rutaArchivo;

                conexionBD.Open();

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "SELECT [Detalles de pedidos].IdPedido, [Detalles de pedidos].IdProducto, Productos.NombreProducto\r\nFROM Productos INNER JOIN [Detalles de pedidos] ON Productos.[IdProducto] = [Detalles de pedidos].[IdProducto];";

                objDataReader = comandoBD.ExecuteReader();

                if (objDataReader.HasRows)
                {
                    while (objDataReader.Read())
                    {
                        Datos.Text = Datos.Text + " - " + objDataReader[0] + "-" + objDataReader[1] + "\n";  //PEDIR LA CANT JUST DE COLUMNAS
                    }
                }
            }
            catch(Exception exepcion)
            {
                MessageBox.Show(exepcion.Message);
            }
        }

        public void TraerDatos(DataGridView grilla)
        {
            try
            {
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "SOCIOS";

                lectorBD = comandoBD.ExecuteReader();

                grilla.Columns.Add("Nombre", "Nombre");
                grilla.Columns.Add("Apellido", "Apellido");
                grilla.Columns.Add("Puntaje", "Puntaje");

                while (lectorBD.Read())
                {
                    //DatosExtraidos += lectorBD[7] + "\n";
                    grilla.Rows.Add(lectorBD[1], lectorBD[2], lectorBD[7]);

                }
            }
            catch (Exception ex)
            {
                Errores = ex.Message;
            }

        }

        public void TraerDatosDataSet(DataGridView grilla)
        {
            try
            {
                ConectarBaseDatos();
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "SOCIOS";

                adaptadorDS = new OleDbDataAdapter(comandoBD);
                adaptadorDS.Fill(objDataSet, "SOCIOS");

                if (objDataSet.Tables["SOCIOS"].Rows.Count > 0)
                {
                    grilla.Columns.Add("ID", "ID");
                    grilla.Columns.Add("Nombre", "Nombre");
                    grilla.Columns.Add("Apellido", "Apellido");

                    foreach (DataRow fila in objDataSet.Tables[0].Rows)
                    {
                        //DatosExtraidos += fila[1] + "\n";

                        grilla.Rows.Add(fila[0], fila[1], fila[2]);
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            

        }


        public void RegistrarDatosDataSet(string nombre)
        {
            try
            {
                //ConectarBaseDatos();
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "SOCIOS";

                adaptadorDS = new OleDbDataAdapter(comandoBD);
                adaptadorDS.Fill(objDataSet, "SOCIOS");

                DataTable tablaGrabar = objDataSet.Tables[0];
                DataRow filaGrabar = tablaGrabar.NewRow();
                filaGrabar[1] = nombre;
                tablaGrabar.Rows.Add(filaGrabar);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorDS);
                adaptadorDS.Update(objDataSet);
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
