using System;

namespace Control_de_Gastos
{
    partial class Gastos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gastos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gastosTab = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.digitarGastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaPicker = new System.Windows.Forms.DateTimePicker();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.tipoGastoLabel = new System.Windows.Forms.Label();
            this.comercioLabel = new System.Windows.Forms.Label();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.cantidadBox = new System.Windows.Forms.NumericUpDown();
            this.registrarGasto = new System.Windows.Forms.Button();
            this.agregarNuevoTipoGastoImage = new System.Windows.Forms.PictureBox();
            this.nuevoTipoGastoLabel = new System.Windows.Forms.Label();
            this.agregarNuevoComercioLabel = new System.Windows.Forms.Label();
            this.agregarNuevoComercioImage = new System.Windows.Forms.PictureBox();
            this.botonesDivisasPanel = new System.Windows.Forms.Panel();
            this.dolaresRadioButton = new System.Windows.Forms.RadioButton();
            this.colonesRadioButton = new System.Windows.Forms.RadioButton();
            this.tipoCambioPanel = new System.Windows.Forms.Panel();
            this.totalDolaresTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tipoCambioTextBox = new System.Windows.Forms.TextBox();
            this.tipoCambioLabel = new System.Windows.Forms.Label();
            this.tipoGastoComboBox = new System.Windows.Forms.ComboBox();
            this.comercioComboBox = new System.Windows.Forms.ComboBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.limpiarGastosBoton = new System.Windows.Forms.Button();
            this.agregarAListaBoton = new System.Windows.Forms.Button();
            this.gastosPorIngresarGridView = new System.Windows.Forms.DataGridView();
            this.panelReporte = new System.Windows.Forms.Panel();
            this.reporteGridView = new System.Windows.Forms.DataGridView();
            this.dataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agregarNuevoTipoGastoTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoGasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agregarNuevoTipoGastoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agregarNuevoComercioImage)).BeginInit();
            this.botonesDivisasPanel.SuspendLayout();
            this.tipoCambioPanel.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gastosPorIngresarGridView)).BeginInit();
            this.panelReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reporteGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gastosTab,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gastosTab
            // 
            this.gastosTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.digitarGastosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.gastosTab.Name = "gastosTab";
            this.gastosTab.Size = new System.Drawing.Size(54, 20);
            this.gastosTab.Text = "Gastos";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItem1.Text = "Principal";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // digitarGastosToolStripMenuItem
            // 
            this.digitarGastosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("digitarGastosToolStripMenuItem.Image")));
            this.digitarGastosToolStripMenuItem.Name = "digitarGastosToolStripMenuItem";
            this.digitarGastosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.digitarGastosToolStripMenuItem.Text = "Editar Gastos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarReporteToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reportToolStripMenuItem.Text = "Reporte";
            // 
            // generarReporteToolStripMenuItem
            // 
            this.generarReporteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("generarReporteToolStripMenuItem.Image")));
            this.generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            this.generarReporteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.generarReporteToolStripMenuItem.Text = "Generar Reporte";
            this.generarReporteToolStripMenuItem.Click += new System.EventHandler(this.generarReporteToolStripMenuItem_Click);
            // 
            // fechaPicker
            // 
            this.fechaPicker.Location = new System.Drawing.Point(80, 20);
            this.fechaPicker.MaxDate = new System.DateTime(2019, 4, 13, 0, 0, 0, 0);
            this.fechaPicker.Name = "fechaPicker";
            this.fechaPicker.Size = new System.Drawing.Size(200, 20);
            this.fechaPicker.TabIndex = 1;
            this.fechaPicker.Value = new System.DateTime(2019, 3, 16, 0, 0, 0, 0);
            this.fechaPicker.ValueChanged += new System.EventHandler(this.fechaPicker_ValueChanged);
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaLabel.Location = new System.Drawing.Point(15, 21);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(59, 20);
            this.fechaLabel.TabIndex = 2;
            this.fechaLabel.Text = "Fecha";
            // 
            // tipoGastoLabel
            // 
            this.tipoGastoLabel.AutoSize = true;
            this.tipoGastoLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoGastoLabel.Location = new System.Drawing.Point(15, 128);
            this.tipoGastoLabel.Name = "tipoGastoLabel";
            this.tipoGastoLabel.Size = new System.Drawing.Size(122, 20);
            this.tipoGastoLabel.TabIndex = 3;
            this.tipoGastoLabel.Text = "Tipo de Gasto";
            // 
            // comercioLabel
            // 
            this.comercioLabel.AutoSize = true;
            this.comercioLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comercioLabel.Location = new System.Drawing.Point(364, 128);
            this.comercioLabel.Name = "comercioLabel";
            this.comercioLabel.Size = new System.Drawing.Size(86, 20);
            this.comercioLabel.TabIndex = 4;
            this.comercioLabel.Text = "Comercio";
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadLabel.Location = new System.Drawing.Point(675, 153);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(61, 20);
            this.cantidadLabel.TabIndex = 5;
            this.cantidadLabel.Text = "Monto";
            // 
            // cantidadBox
            // 
            this.cantidadBox.DecimalPlaces = 2;
            this.cantidadBox.Location = new System.Drawing.Point(886, 157);
            this.cantidadBox.Name = "cantidadBox";
            this.cantidadBox.Size = new System.Drawing.Size(113, 20);
            this.cantidadBox.TabIndex = 8;
            this.cantidadBox.ValueChanged += new System.EventHandler(this.cantidadBox_ValueChanged);
            // 
            // registrarGasto
            // 
            this.registrarGasto.BackColor = System.Drawing.Color.DarkGreen;
            this.registrarGasto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarGasto.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarGasto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registrarGasto.Location = new System.Drawing.Point(794, 673);
            this.registrarGasto.Name = "registrarGasto";
            this.registrarGasto.Size = new System.Drawing.Size(208, 39);
            this.registrarGasto.TabIndex = 9;
            this.registrarGasto.Text = "Registrar Gastos";
            this.registrarGasto.UseVisualStyleBackColor = false;
            this.registrarGasto.Click += new System.EventHandler(this.registrarGasto_Click);
            // 
            // agregarNuevoTipoGastoImage
            // 
            this.agregarNuevoTipoGastoImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarNuevoTipoGastoImage.Image = ((System.Drawing.Image)(resources.GetObject("agregarNuevoTipoGastoImage.Image")));
            this.agregarNuevoTipoGastoImage.Location = new System.Drawing.Point(179, 154);
            this.agregarNuevoTipoGastoImage.Name = "agregarNuevoTipoGastoImage";
            this.agregarNuevoTipoGastoImage.Size = new System.Drawing.Size(32, 32);
            this.agregarNuevoTipoGastoImage.TabIndex = 12;
            this.agregarNuevoTipoGastoImage.TabStop = false;
            this.agregarNuevoTipoGastoTooltip.SetToolTip(this.agregarNuevoTipoGastoImage, "Agregar un buscar un tipo de gasto que no está en la lista");
            this.agregarNuevoTipoGastoImage.Click += new System.EventHandler(this.agregarNuevoTipoGastoImage_Click);
            // 
            // nuevoTipoGastoLabel
            // 
            this.nuevoTipoGastoLabel.AutoSize = true;
            this.nuevoTipoGastoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nuevoTipoGastoLabel.Location = new System.Drawing.Point(19, 162);
            this.nuevoTipoGastoLabel.Name = "nuevoTipoGastoLabel";
            this.nuevoTipoGastoLabel.Size = new System.Drawing.Size(154, 15);
            this.nuevoTipoGastoLabel.TabIndex = 13;
            this.nuevoTipoGastoLabel.Text = "Buscar o agregar tipo de gasto";
            // 
            // agregarNuevoComercioLabel
            // 
            this.agregarNuevoComercioLabel.AutoSize = true;
            this.agregarNuevoComercioLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.agregarNuevoComercioLabel.Location = new System.Drawing.Point(365, 157);
            this.agregarNuevoComercioLabel.Name = "agregarNuevoComercioLabel";
            this.agregarNuevoComercioLabel.Size = new System.Drawing.Size(136, 15);
            this.agregarNuevoComercioLabel.TabIndex = 14;
            this.agregarNuevoComercioLabel.Text = "Buscar o agregar comercio";
            // 
            // agregarNuevoComercioImage
            // 
            this.agregarNuevoComercioImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarNuevoComercioImage.Image = ((System.Drawing.Image)(resources.GetObject("agregarNuevoComercioImage.Image")));
            this.agregarNuevoComercioImage.Location = new System.Drawing.Point(507, 153);
            this.agregarNuevoComercioImage.Name = "agregarNuevoComercioImage";
            this.agregarNuevoComercioImage.Size = new System.Drawing.Size(32, 32);
            this.agregarNuevoComercioImage.TabIndex = 15;
            this.agregarNuevoComercioImage.TabStop = false;
            this.agregarNuevoTipoGastoTooltip.SetToolTip(this.agregarNuevoComercioImage, "Agregar o buscar un comercio que no está en la lista");
            this.agregarNuevoComercioImage.Click += new System.EventHandler(this.agregarNuevoComercioImage_Click);
            // 
            // botonesDivisasPanel
            // 
            this.botonesDivisasPanel.Controls.Add(this.dolaresRadioButton);
            this.botonesDivisasPanel.Controls.Add(this.colonesRadioButton);
            this.botonesDivisasPanel.Location = new System.Drawing.Point(741, 61);
            this.botonesDivisasPanel.Name = "botonesDivisasPanel";
            this.botonesDivisasPanel.Size = new System.Drawing.Size(230, 32);
            this.botonesDivisasPanel.TabIndex = 18;
            // 
            // dolaresRadioButton
            // 
            this.dolaresRadioButton.AutoSize = true;
            this.dolaresRadioButton.Location = new System.Drawing.Point(127, 4);
            this.dolaresRadioButton.Name = "dolaresRadioButton";
            this.dolaresRadioButton.Size = new System.Drawing.Size(61, 17);
            this.dolaresRadioButton.TabIndex = 1;
            this.dolaresRadioButton.TabStop = true;
            this.dolaresRadioButton.Text = "Dolares";
            this.dolaresRadioButton.UseVisualStyleBackColor = true;
            this.dolaresRadioButton.CheckedChanged += new System.EventHandler(this.dolaresRadioButton_CheckedChanged);
            // 
            // colonesRadioButton
            // 
            this.colonesRadioButton.AutoSize = true;
            this.colonesRadioButton.Checked = true;
            this.colonesRadioButton.Location = new System.Drawing.Point(21, 4);
            this.colonesRadioButton.Name = "colonesRadioButton";
            this.colonesRadioButton.Size = new System.Drawing.Size(63, 17);
            this.colonesRadioButton.TabIndex = 0;
            this.colonesRadioButton.TabStop = true;
            this.colonesRadioButton.Text = "Colones";
            this.colonesRadioButton.UseVisualStyleBackColor = true;
            this.colonesRadioButton.CheckedChanged += new System.EventHandler(this.colonesRadioButton_CheckedChanged);
            // 
            // tipoCambioPanel
            // 
            this.tipoCambioPanel.Controls.Add(this.totalDolaresTextBox);
            this.tipoCambioPanel.Controls.Add(this.totalLabel);
            this.tipoCambioPanel.Controls.Add(this.tipoCambioTextBox);
            this.tipoCambioPanel.Controls.Add(this.tipoCambioLabel);
            this.tipoCambioPanel.Location = new System.Drawing.Point(672, 183);
            this.tipoCambioPanel.Name = "tipoCambioPanel";
            this.tipoCambioPanel.Size = new System.Drawing.Size(330, 71);
            this.tipoCambioPanel.TabIndex = 21;
            // 
            // totalDolaresTextBox
            // 
            this.totalDolaresTextBox.Enabled = false;
            this.totalDolaresTextBox.Location = new System.Drawing.Point(214, 39);
            this.totalDolaresTextBox.Name = "totalDolaresTextBox";
            this.totalDolaresTextBox.Size = new System.Drawing.Size(113, 20);
            this.totalDolaresTextBox.TabIndex = 3;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(3, 39);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(53, 20);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Total";
            // 
            // tipoCambioTextBox
            // 
            this.tipoCambioTextBox.Enabled = false;
            this.tipoCambioTextBox.Location = new System.Drawing.Point(214, 7);
            this.tipoCambioTextBox.Name = "tipoCambioTextBox";
            this.tipoCambioTextBox.Size = new System.Drawing.Size(113, 20);
            this.tipoCambioTextBox.TabIndex = 1;
            this.tipoCambioTextBox.TextChanged += new System.EventHandler(this.tipoCambioTextBox_TextChanged);
            // 
            // tipoCambioLabel
            // 
            this.tipoCambioLabel.AutoSize = true;
            this.tipoCambioLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoCambioLabel.Location = new System.Drawing.Point(3, 7);
            this.tipoCambioLabel.Name = "tipoCambioLabel";
            this.tipoCambioLabel.Size = new System.Drawing.Size(138, 20);
            this.tipoCambioLabel.TabIndex = 0;
            this.tipoCambioLabel.Text = "Tipo de Cambio";
            // 
            // tipoGastoComboBox
            // 
            this.tipoGastoComboBox.FormattingEnabled = true;
            this.tipoGastoComboBox.Location = new System.Drawing.Point(159, 127);
            this.tipoGastoComboBox.Name = "tipoGastoComboBox";
            this.tipoGastoComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipoGastoComboBox.TabIndex = 22;
            // 
            // comercioComboBox
            // 
            this.comercioComboBox.FormattingEnabled = true;
            this.comercioComboBox.Location = new System.Drawing.Point(471, 127);
            this.comercioComboBox.Name = "comercioComboBox";
            this.comercioComboBox.Size = new System.Drawing.Size(121, 21);
            this.comercioComboBox.TabIndex = 23;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.limpiarGastosBoton);
            this.panelPrincipal.Controls.Add(this.agregarAListaBoton);
            this.panelPrincipal.Controls.Add(this.gastosPorIngresarGridView);
            this.panelPrincipal.Controls.Add(this.comercioComboBox);
            this.panelPrincipal.Controls.Add(this.tipoCambioPanel);
            this.panelPrincipal.Controls.Add(this.tipoGastoComboBox);
            this.panelPrincipal.Controls.Add(this.registrarGasto);
            this.panelPrincipal.Controls.Add(this.botonesDivisasPanel);
            this.panelPrincipal.Controls.Add(this.agregarNuevoComercioImage);
            this.panelPrincipal.Controls.Add(this.agregarNuevoComercioLabel);
            this.panelPrincipal.Controls.Add(this.nuevoTipoGastoLabel);
            this.panelPrincipal.Controls.Add(this.agregarNuevoTipoGastoImage);
            this.panelPrincipal.Controls.Add(this.cantidadBox);
            this.panelPrincipal.Controls.Add(this.cantidadLabel);
            this.panelPrincipal.Controls.Add(this.comercioLabel);
            this.panelPrincipal.Controls.Add(this.tipoGastoLabel);
            this.panelPrincipal.Controls.Add(this.fechaLabel);
            this.panelPrincipal.Controls.Add(this.fechaPicker);
            this.panelPrincipal.Location = new System.Drawing.Point(16, 39);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1046, 728);
            this.panelPrincipal.TabIndex = 24;
            // 
            // limpiarGastosBoton
            // 
            this.limpiarGastosBoton.BackColor = System.Drawing.Color.DarkGreen;
            this.limpiarGastosBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiarGastosBoton.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarGastosBoton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.limpiarGastosBoton.Location = new System.Drawing.Point(19, 673);
            this.limpiarGastosBoton.Name = "limpiarGastosBoton";
            this.limpiarGastosBoton.Size = new System.Drawing.Size(208, 39);
            this.limpiarGastosBoton.TabIndex = 28;
            this.limpiarGastosBoton.Text = "Limpiar Gastos";
            this.limpiarGastosBoton.UseVisualStyleBackColor = false;
            this.limpiarGastosBoton.Click += new System.EventHandler(this.limpiarGastosBoton_Click);
            // 
            // agregarAListaBoton
            // 
            this.agregarAListaBoton.BackColor = System.Drawing.Color.DarkGreen;
            this.agregarAListaBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarAListaBoton.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarAListaBoton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.agregarAListaBoton.Location = new System.Drawing.Point(794, 275);
            this.agregarAListaBoton.Name = "agregarAListaBoton";
            this.agregarAListaBoton.Size = new System.Drawing.Size(208, 39);
            this.agregarAListaBoton.TabIndex = 27;
            this.agregarAListaBoton.Text = "Agregar a lista";
            this.agregarAListaBoton.UseVisualStyleBackColor = false;
            this.agregarAListaBoton.Click += new System.EventHandler(this.agregarAListaBoton_Click);
            // 
            // gastosPorIngresarGridView
            // 
            this.gastosPorIngresarGridView.AllowUserToAddRows = false;
            this.gastosPorIngresarGridView.AllowUserToOrderColumns = true;
            this.gastosPorIngresarGridView.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.gastosPorIngresarGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gastosPorIngresarGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gastosPorIngresarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gastosPorIngresarGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.TipoGasto,
            this.Lugar,
            this.Monto});
            this.gastosPorIngresarGridView.Location = new System.Drawing.Point(19, 336);
            this.gastosPorIngresarGridView.Name = "gastosPorIngresarGridView";
            this.gastosPorIngresarGridView.Size = new System.Drawing.Size(983, 331);
            this.gastosPorIngresarGridView.TabIndex = 26;
            // 
            // panelReporte
            // 
            this.panelReporte.Controls.Add(this.reporteGridView);
            this.panelReporte.Location = new System.Drawing.Point(16, 213);
            this.panelReporte.Name = "panelReporte";
            this.panelReporte.Size = new System.Drawing.Size(1046, 318);
            this.panelReporte.TabIndex = 25;
            this.panelReporte.Visible = false;
            // 
            // reporteGridView
            // 
            this.reporteGridView.AllowUserToAddRows = false;
            this.reporteGridView.AllowUserToDeleteRows = false;
            this.reporteGridView.AllowUserToResizeColumns = false;
            this.reporteGridView.AllowUserToResizeRows = false;
            this.reporteGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reporteGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.reporteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reporteGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.reporteGridView.Location = new System.Drawing.Point(10, 9);
            this.reporteGridView.Name = "reporteGridView";
            this.reporteGridView.ReadOnly = true;
            this.reporteGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.reporteGridView.RowTemplate.ReadOnly = true;
            this.reporteGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reporteGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reporteGridView.Size = new System.Drawing.Size(767, 274);
            this.reporteGridView.TabIndex = 0;
            this.reporteGridView.TabStop = false;
            // 
            // dataSetBindingSource
            // 
            this.dataSetBindingSource.DataSource = typeof(System.Data.DataSet);
            this.dataSetBindingSource.Position = 0;
            // 
            // Fecha
            // 
            this.Fecha.Frozen = true;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // TipoGasto
            // 
            this.TipoGasto.Frozen = true;
            this.TipoGasto.HeaderText = "Tipo de Gasto";
            this.TipoGasto.Name = "TipoGasto";
            this.TipoGasto.Width = 250;
            // 
            // Lugar
            // 
            this.Lugar.Frozen = true;
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.Name = "Lugar";
            this.Lugar.Width = 500;
            // 
            // Monto
            // 
            this.Monto.Frozen = true;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1063, 779);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelReporte);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Gastos";
            this.Text = "Gastos Mensuales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agregarNuevoTipoGastoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agregarNuevoComercioImage)).EndInit();
            this.botonesDivisasPanel.ResumeLayout(false);
            this.botonesDivisasPanel.PerformLayout();
            this.tipoCambioPanel.ResumeLayout(false);
            this.tipoCambioPanel.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gastosPorIngresarGridView)).EndInit();
            this.panelReporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reporteGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gastosTab;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitarGastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker fechaPicker;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label tipoGastoLabel;
        private System.Windows.Forms.Label comercioLabel;
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.NumericUpDown cantidadBox;
        private System.Windows.Forms.Button registrarGasto;
        private System.Windows.Forms.ToolStripMenuItem generarReporteToolStripMenuItem;
        private System.Windows.Forms.PictureBox agregarNuevoTipoGastoImage;
        private System.Windows.Forms.Label nuevoTipoGastoLabel;
        private System.Windows.Forms.Label agregarNuevoComercioLabel;
        private System.Windows.Forms.PictureBox agregarNuevoComercioImage;
        private System.Windows.Forms.Panel botonesDivisasPanel;
        private System.Windows.Forms.RadioButton dolaresRadioButton;
        private System.Windows.Forms.RadioButton colonesRadioButton;
        private System.Windows.Forms.Panel tipoCambioPanel;
        private System.Windows.Forms.TextBox tipoCambioTextBox;
        private System.Windows.Forms.Label tipoCambioLabel;
        private System.Windows.Forms.TextBox totalDolaresTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.ComboBox tipoGastoComboBox;
        private System.Windows.Forms.ComboBox comercioComboBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelReporte;
        private System.Windows.Forms.DataGridView reporteGridView;
        private System.Windows.Forms.BindingSource dataSetBindingSource;
        private System.Windows.Forms.DataGridView gastosPorIngresarGridView;
        private System.Windows.Forms.Button agregarAListaBoton;
        private System.Windows.Forms.Button limpiarGastosBoton;
        private System.Windows.Forms.ToolTip agregarNuevoTipoGastoTooltip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoGasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
    }
}

