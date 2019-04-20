using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Gastos
{
    public partial class NuevoComercio : Form
    {
        SQLiteDAO sqlitedao = new SQLiteDAO();
        Gastos original;
        public NuevoComercio()
        {
            InitializeComponent();
            comEncontradosComboBox.Enabled = false;
        }

        public NuevoComercio(Gastos form)
        {
            InitializeComponent();
            comEncontradosComboBox.Enabled = false;
            original = form;
            addCommerceTypePictureBox.Hide();
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
                comEncontradosComboBox.Text = "Ningún resultado encontrado";
                comEncontradosComboBox.Enabled = false;
                addCommerceTypePictureBox.Show();
                lupaBuscarComercio.Left = 60;
                return;
            }
            comEncontradosComboBox.Text = null;

            foreach (String resultado in resultados)
            {
                comEncontradosComboBox.Items.Add(resultado);
            }
            comEncontradosComboBox.Text = resultados[0].ToString();
            comEncontradosComboBox.Enabled = true;
            addCommerceTypePictureBox.Show();
            lupaBuscarComercio.Left = 60;
        }

        private void addCommerceTypePictureBox_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que el comercio no está entre las opciones anteriores?",
                "Agregar nuevo comercio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AgregarNuevoTipoGastoOComercio nuevo = new AgregarNuevoTipoGastoOComercio(original,2);
                nuevo.Show();
                nuevo.StartPosition = FormStartPosition.CenterScreen;
                this.Close();
            }
        }
    }
}
