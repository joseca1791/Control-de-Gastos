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
using System.Xml;
using System.Globalization;
using Control_de_Gastos.Controllers;
using System.Net;
using System.Net.Sockets;

namespace Control_de_Gastos
{
    public partial class Gastos : Form
    {
        PrincipalController principalController = new PrincipalController();
        NuevoComercio nuevoComerio;
        NuevoTipoGasto nuevoTipoGasto;
        public Gastos()
        {
            InitializeComponent();
            tipoCambioPanel.Hide();
            fillTipoGastoCombobox();
            fillComercioCombobox();
            panelReporte.Hide();
            fechaPicker.MaxDate = DateTime.Today;
        }


        public void fillTipoGastoCombobox()
        {
            var list=principalController.llenarTipodeGasto(this);
            foreach(var element in list)
            {
                tipoGastoComboBox.Items.Add(element);
            }
            tipoGastoComboBox.Text = list[0];
        }

        public void emptyTipoGastoCombobox()
        {
            tipoGastoComboBox.Items.Clear();
        }

        public void emptyComercioCombobox()
        {
            comercioComboBox.Items.Clear();
        }

        public void fillComercioCombobox()
        {
            var list = principalController.llenarComercios(this);
            foreach (var element in list)
            {
                comercioComboBox.Items.Add(element);
            }
            comercioComboBox.Text = list[0];
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cantidadBox.Maximum = 1000000000000000000;
            cantidadBox.Minimum = 1;
        }

        private void registrarGasto_Click(object sender, EventArgs e)
        {
            if (gastosPorIngresarGridView.Rows.Count != 0) { 
            DataTable dt = new DataTable();
            dt.Columns.Add(gastosPorIngresarGridView.Columns[0].ToString());
            dt.Columns.Add(gastosPorIngresarGridView.Columns[1].ToString());
            dt.Columns.Add(gastosPorIngresarGridView.Columns[2].ToString());
            dt.Columns.Add(gastosPorIngresarGridView.Columns[3].ToString());
            var numeroDeGastosPorIngresar = gastosPorIngresarGridView.Rows.Count;
            foreach (DataGridViewRow row in gastosPorIngresarGridView.Rows)
            {
                    decimal cantidad = decimal.Parse(row.Cells[3].Value.ToString());
                    cantidad = decimal.Round(cantidad, 2);
                    if (dolaresRadioButton.Checked)
                {
                    cantidad = decimal.Parse(totalDolaresTextBox.Text);
                    decimal.Round(cantidad, 2);
                }
                ingresarGasto(row.Cells[0].Value.ToString().Trim(), row.Cells[1].Value.ToString().Trim(), row.Cells[2].Value.ToString().Trim(), cantidad);
            }
                MessageBox.Show("Total de gastos agregados: "+numeroDeGastosPorIngresar,"Ingresar Gastos",MessageBoxButtons.OK,MessageBoxIcon.Information);
                reestablecerElementos();
            }
            else { MessageBox.Show("No ingresó ningún elemento en la lista!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ingresarGasto(String fecha,string tipoGasto, string comercio, decimal cantidad) {
            principalController.registrarGasto(fecha,tipoGasto,comercio,cantidad);
        }

        private void reestablecerElementos()
        {
            tipoGastoComboBox.SelectedIndex = 0;
            comercioComboBox.SelectedIndex = 0;
            cantidadBox.Value = cantidadBox.Minimum;
            gastosPorIngresarGridView.Rows.Clear();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPrincipal.Hide();
            panelReporte.Show();
            reporteGridView.DataSource = principalController.generarReporte();
            reporteGridView.Columns[2].Width = 407;
        }

        private void agregarNuevoTipoGastoImage_Click(object sender, EventArgs e)
        {
            nuevoTipoGasto = new NuevoTipoGasto(this);
            nuevoTipoGasto.StartPosition = FormStartPosition.CenterScreen;
            nuevoTipoGasto.Show();
        }

        private void agregarNuevoComercioImage_Click(object sender, EventArgs e)
        {
            nuevoComerio = new NuevoComercio(this);
            nuevoComerio.StartPosition = FormStartPosition.CenterScreen;
            nuevoComerio.Show();
        }

        private async void dolaresRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (dolaresRadioButton.Checked) { 
            tipoCambioPanel.Show();
            DateTime fechaPrueba = fechaPicker.Value;
            await callWebServiceAsync(fechaPrueba.ToString("dd/MM/yyyy"));
            totalDolaresTextBox.Text = (decimal.Parse(tipoCambioTextBox.Text) * cantidadBox.Value).ToString();
            }
        }


        private void colonesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            tipoCambioPanel.Hide();
        }

        private async Task callWebServiceAsync(String fechaInicio)
        {
            //No enviar el nombre completo de la maquina, combinar el nombre
            var primeraDivision = System.Environment.MachineName.Substring(3);
            var segundaDivision = System.Environment.MachineName.Substring(4);
            var nombre = segundaDivision + primeraDivision + "MACH1";
            BCCR.wsIndicadoresEconomicosSoapClient bccrws = new BCCR.wsIndicadoresEconomicosSoapClient();
            DataSet ds = new DataSet();
            ds = await Task.Run(() => bccrws.ObtenerIndicadoresEconomicos("318", fechaInicio, fechaInicio, nombre, "N"));
            Console.WriteLine(ds);
            var tipoCambio = Convert.ToDecimal(ds.Tables[0].Rows[0].ItemArray[2]);
            tipoCambio = Math.Round(tipoCambio,2);
            tipoCambioTextBox.Text = tipoCambio.ToString();
        }

        private async void fechaPicker_ValueChanged(object sender, EventArgs e)
        {
            if (dolaresRadioButton.Checked) {
                DateTime fecha = fechaPicker.Value;
                await callWebServiceAsync(fecha.ToString("dd/MM/yyyy"));
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelReporte.Hide();
            panelPrincipal.Show();
        }

        private void cantidadBox_ValueChanged(object sender, EventArgs e)
        {
            if (dolaresRadioButton.Checked) { 
            totalDolaresTextBox.Text = (decimal.Parse(tipoCambioTextBox.Text) * cantidadBox.Value).ToString();
            }
        }

        private void tipoCambioTextBox_TextChanged(object sender, EventArgs e)
        {
            if (dolaresRadioButton.Checked)
            {
                totalDolaresTextBox.Text = (decimal.Parse(tipoCambioTextBox.Text) * cantidadBox.Value).ToString();
            }
        }

        private void agregarAListaBoton_Click(object sender, EventArgs e)
        {
            if (colonesRadioButton.Checked && cantidadBox.Value != 1)
            {
                gastosPorIngresarGridView.Rows.Add(fechaPicker.Value.ToShortDateString(), tipoGastoComboBox.SelectedItem, comercioComboBox.SelectedItem, cantidadBox.Value);
                return;
            }
            else
            {
                if (colonesRadioButton.Checked) { 
                MessageBox.Show("Debe agregar un monto por más de 1 colón!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
            }
            if (dolaresRadioButton.Checked && String.IsNullOrEmpty(totalDolaresTextBox.Text)==false)
            {
                gastosPorIngresarGridView.Rows.Add(fechaPicker.Value.ToShortDateString(), tipoGastoComboBox.SelectedItem, comercioComboBox.SelectedItem, totalDolaresTextBox.Text);
                return;
            }
            else
            {
                MessageBox.Show("Aun se está recopilando el tipo de cambio, espere por favor.", "Tipo de Cambio - BCCR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void limpiarGastosBoton_Click(object sender, EventArgs e)
        {
            gastosPorIngresarGridView.Rows.Clear();
        }
    }
}
