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
    public partial class AgregarNuevoTipoGastoOComercio : Form
    {
        SQLiteDAO sqlitedao = new SQLiteDAO();
        Gastos original;
        int tipo;

        public AgregarNuevoTipoGastoOComercio()
        {
            InitializeComponent();
        }

        public AgregarNuevoTipoGastoOComercio(Gastos form,int _tipo)
        {
            InitializeComponent();
            original = form;
            tipo = _tipo;
        }

        private void closeAgrNueTipGasOComForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarPictureBox_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea guardar este nuevo elemento?",
    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try {
                    if (tipo == 1) { 
                        sqlitedao.guardarTiposGasto(elementoTextBox.Text.Trim());
                        MessageBox.Show("Elemento agregado correctamente");
                        original.emptyTipoGastoCombobox();
                        original.fillTipoGastoCombobox();
                        original.tipoGastoComboBox.Text = elementoTextBox.Text;
                        this.Close();
                    }
                    else
                    {
                        sqlitedao.guardarComercio(elementoTextBox.Text.Trim());
                        MessageBox.Show("Elemento agregado correctamente");
                        original.emptyComercioCombobox();
                        original.fillComercioCombobox();
                        original.comercioComboBox.Text = elementoTextBox.Text;
                        this.Close();
                    }
                }
                catch {
                    MessageBox.Show("Hubo un error en la insercion!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
            }
        }
    }
}
