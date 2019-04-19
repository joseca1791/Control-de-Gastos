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

        public AgregarNuevoTipoGastoOComercio()
        {
            InitializeComponent();
        }

        public AgregarNuevoTipoGastoOComercio(Gastos form)
        {
            InitializeComponent();
            original = form;
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
                sqlitedao.guardarTiposGasto(elementoTextBox.Text);
                    MessageBox.Show("Elemento agregado correctamente");
                    original.emptyTipoGastoCombobox();
                    original.fillTipoGastoCombobox();
                this.Close();
                }
                catch {
                    MessageBox.Show("Hubo un error en la insercion!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
            }
        }
    }
}
