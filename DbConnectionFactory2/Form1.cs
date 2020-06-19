using Oracle.DataAccess.Client;
using SampleBE;
using SampleBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DbConnectionFactory2
{
    public partial class Form1 : Form
    {
        PerfilClienteBL perCliBL;

        public Form1()
        {
            try
            {
                InitializeComponent();
                InitMyComponents();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void InitMyComponents()
        {
            this.perCliBL = new PerfilClienteBL();
        }

        private void BindGrid()
        {
            gvFilesOnServer.AutoGenerateColumns = false;

            //create the column programatically
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn colFileName = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "CodPerfilN",
                HeaderText = "Cod. Perfil",
                DataPropertyName = "CodPerfilN", // Tell the column which property of FileName it should use
                ValueType = typeof(Int32)
            };

            gvFilesOnServer.Columns.Add(colFileName);

            cell = new DataGridViewTextBoxCell();
            colFileName = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "DesPerfil",
                HeaderText = "Descripcion Perfil",
                DataPropertyName = "DesPerfil", // Tell the column which property of FileName it should use
                ValueType = typeof(String)
            };

            gvFilesOnServer.Columns.Add(colFileName);

            cell = new DataGridViewTextBoxCell();
            colFileName = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "CodRegistroN",
                HeaderText = "Cod.Registro",
                DataPropertyName = "CodRegistroN", // Tell the column which property of FileName it should use
                ValueType = typeof(Decimal)
            };

            gvFilesOnServer.Columns.Add(colFileName);

            cell = new DataGridViewTextBoxCell();
            colFileName = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "codEstadoN",
                HeaderText = "Estado",
                DataPropertyName = "codEstadoN", // Tell the column which property of FileName it should use
                ValueType = typeof(Int32)
            };

            gvFilesOnServer.Columns.Add(colFileName);

            var filelist = perCliBL.LoadProfile();
            var filenamesList = new BindingList<PerfilClienteBE>(filelist); // <-- BindingList  Convierte a una lista

            //Bind BindingList directly to the DataGrid, no need of BindingSource
            gvFilesOnServer.DataSource = filenamesList;
        }

        private void butDo_Click(object sender, EventArgs e)
        {
            try
            {
                // perCliBL.LoadProfile();
                BindGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void butOutParam_Click(object sender, EventArgs e)
        {
            using (OracleConnection objConn = new OracleConnection("Data Source=pruebas3; User ID=mytest; Password=oracle"))
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "Pruebas_varias.suma";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("p1", OracleDbType.Int32).Value = 20;
                objCmd.Parameters.Add("p2", OracleDbType.Int32).Value = 20;
                objCmd.Parameters.Add("p3", OracleDbType.Int32).Direction = ParameterDirection.Output;
                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                    // int res = Convert.ToInt32(objCmd.Parameters["pout_count"].Value);
                    int  res = int.Parse(  objCmd.Parameters["p3"].Value.ToString());
                    string scrap = string.Format("Resultado de la suma {0}", res);
                    // System.Console.WriteLine("Resultado de la sma {0}", objCmd.Parameters["pout_count"].Value);
                    System.Console.WriteLine(scrap);
                    txtOutput.Text = scrap;

                }
                catch (Exception ex)
                {
                    // System.Console.WriteLine("Exception: {0}", ex.ToString());
                    string err = string.Format("Exception: {0}", ex.ToString());
                    System.Console.WriteLine(err);
                    MessageBox.Show(err);
                    
                }
                objConn.Close();
            }
        }
    }
}
