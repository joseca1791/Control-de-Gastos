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
        }


        private void fillTipoGastoCombobox()
        {
            var list=principalController.llenarTipodeGasto(this);
            foreach(var element in list)
            {
                tipoGastoComboBox.Items.Add(element);
            }
            tipoGastoComboBox.Text = list[0];
        }

        private void fillComercioCombobox()
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
            // TODO: This line of code loads data into the 'gastosDataSet3.Comercios' table. You can move, or remove it, as needed.
            this.comerciosTableAdapter.Fill(this.gastosDataSet3.Comercios);
            this.comerciosBindingSource.Sort = "nombreComercio";
            // TODO: This line of code loads data into the 'gastosDataSet2.TiposGasto' table. You can move, or remove it, as needed.
            this.tiposGastoTableAdapter1.Fill(this.gastosDataSet2.TiposGasto);
            this.tiposGastoBindingSource1.Sort = "tipo";
            // TODO: This line of code loads data into the 'gastosDataSet1.TiposGasto' table. You can move, or remove it, as needed.
            this.tiposGastoTableAdapter.Fill(this.gastosDataSet1.TiposGasto);
            // TODO: This line of code loads data into the 'gastosDataSet.Tipos' table. You can move, or remove it, as needed.
            cantidadBox.Maximum = 1000000000000000000;
            cantidadBox.Minimum = 1;
        }

        private void registrarGasto_Click(object sender, EventArgs e)
        {
            if (cantidadBox.Value != 1) { 
            String fecha = fechaPicker.Value.ToShortDateString();
            var tipoGasto = tipoGastoComboBox.GetItemText(tipoGastoComboBox.SelectedItem);
            var comercio = comercioComboBox.GetItemText(comercioComboBox.SelectedItem);
            var cantidad = cantidadBox.Value;
                if (dolaresRadioButton.Checked)
                {
                    cantidad = decimal.Parse(textBox1.Text);
                    ingresarGasto(fecha, tipoGasto, comercio, cantidad);
                }
                ingresarGasto(fecha,tipoGasto, comercio, cantidad);
            }
            else { MessageBox.Show("No ingresó una cantidad para el gasto", "Error!", MessageBoxButtons.OK,MessageBoxIcon.Error); }

        }

        private void ingresarGasto(String fecha,string tipoGasto, string comercio, decimal cantidad) {
            //var connectionString = "Data Source=localhost;Initial Catalog=Gastos;Integrated Security=True";
            //using (SqlConnection connection = new SqlConnection(connectionString)) {
            //    SqlCommand command = new SqlCommand(@"Insert into dbo.GastoUnitarioTable values ('"+fecha + "','"+ tipoGasto + "','"+ comercio + "','"+ cantidad+"')",connection);
            //    command.Connection.Open();
            //    command.ExecuteNonQuery();
            //}
            principalController.registrarGasto(fecha,tipoGasto,comercio,cantidad);
            tipoGastoComboBox.SelectedIndex = 0;
            comercioComboBox.SelectedIndex = 0;
            cantidadBox.Value = cantidadBox.Minimum;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            principalController.generarReporte();
            panelPrincipal.Hide();
            panelReporte.Show();

        }

        private void agregarNuevoTipoGastoImage_Click(object sender, EventArgs e)
        {
            nuevoTipoGasto = new NuevoTipoGasto();
            nuevoTipoGasto.StartPosition = FormStartPosition.CenterScreen;
            nuevoTipoGasto.Show();
        }

        private void agregarNuevoComercioImage_Click(object sender, EventArgs e)
        {
            nuevoComerio = new NuevoComercio();
            nuevoComerio.StartPosition = FormStartPosition.CenterScreen;
            nuevoComerio.Show();
        }

        private async void dolaresRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (dolaresRadioButton.Checked) { 
            tipoCambioPanel.Show();
                DateTime fechaPrueba = fechaPicker.Value;
                await callWebServiceAsync(fechaPrueba.ToString("dd/MM/yyyy"));
            }
        }


        private void colonesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            tipoCambioPanel.Hide();
        }

        private async Task callWebServiceAsync(String fechaInicio)
        {
            BCCR.wsIndicadoresEconomicosSoapClient bccrws = new BCCR.wsIndicadoresEconomicosSoapClient();
            DataSet ds = new DataSet();
            ds= await Task.Run(()=>bccrws.ObtenerIndicadoresEconomicos("318", fechaInicio, fechaInicio, "Jose", "N"));
            //ds = bccrws.ObtenerIndicadoresEconomicosAsync("318", fechaInicio, fechaInicio, "Jose", "N");
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
            panelPrincipal.Show();
        }
    }
}
