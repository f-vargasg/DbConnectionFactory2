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
    }
}
