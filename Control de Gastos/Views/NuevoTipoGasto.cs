﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Gastos
{
    public partial class NuevoTipoGasto : Form
    {
        SQLiteDAO sqlitedao = new SQLiteDAO();
        public NuevoTipoGasto()
        {
            InitializeComponent();
            tipoGastoEncontradosComboBox.Enabled = false;
        }

        private void lupaBuscarComercio_Click(object sender, EventArgs e)
        {
            populateListBox(sqlitedao.buscarTiposGasto(buscarTipoGastoTextbox.Text));
        }

        private void populateListBox(List<String> resultados) {
            tipoGastoEncontradosComboBox.Items.Clear();
            if (resultados.Count == 0)
            {
                tipoGastoEncontradosComboBox.Text = "Ningún resultado encontrado";
                tipoGastoEncontradosComboBox.Enabled = false;
                return;
            }
            tipoGastoEncontradosComboBox.Text = null;

            foreach (String resultado in resultados)
            {
                tipoGastoEncontradosComboBox.Items.Add(resultado);
            }
            tipoGastoEncontradosComboBox.Text = resultados[0].ToString();
            tipoGastoEncontradosComboBox.Enabled = true;
            newExpenseTypePictureBox.Show();
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
