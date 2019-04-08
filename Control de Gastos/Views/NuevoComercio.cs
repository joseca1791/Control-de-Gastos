using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Control_de_Gastos
{
    public partial class NuevoComercio : Form
    {
        SQLiteDAO sqlitedao = new SQLiteDAO();
        public NuevoComercio()
        {
            InitializeComponent();
            comEncontradosComboBox.Enabled = false;
        }

        private void lupaBuscarComercio_Click(object sender, EventArgs e)
        {
            populateListBox(sqlitedao.buscarComercio(buscarComercioTextbox.Text));
        }

        private void populateListBox(List<String> resultados)
        {
            comEncontradosComboBox.Items.Clear();
            if (resultados.Count == 0)
            {
                return;
            }
            foreach (String resultado in resultados)
            {
                comEncontradosComboBox.Items.Add(resultado);
            }
            comEncontradosComboBox.Text = resultados[0].ToString();
            comEncontradosComboBox.Enabled = true;
            addCommerceTypePictureBox.Show();
            lupaBuscarComercio.Left = 60;
        }

        private void newExpenseTypePictureBox_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que el tipo de gasto no está entre las opciones anteriores?",
                "Agregar nuevo tipo de gasto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AgregarNuevoTipoGastoOComercio nuevo = new AgregarNuevoTipoGastoOComercio();
                nuevo.Show();
                nuevo.StartPosition = FormStartPosition.CenterScreen;
                this.Close();
            }
        }
    }
}
