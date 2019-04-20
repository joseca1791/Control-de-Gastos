using System;

namespace Control_de_Gastos
{
    partial class NuevoTipoGasto
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
            this.tipoGastoEncontradosComboBox = new System.Windows.Forms.ComboBox();
            this.buscarTipoGastoTextbox = new System.Windows.Forms.TextBox();
            this.newExpenseTypePictureBox = new System.Windows.Forms.PictureBox();
            this.lupaBuscarComercio = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.newExpenseTypePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupaBuscarComercio)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoGastoEncontradosComboBox
            // 
            this.tipoGastoEncontradosComboBox.FormattingEnabled = true;
            this.tipoGastoEncontradosComboBox.Location = new System.Drawing.Point(39, 83);
            this.tipoGastoEncontradosComboBox.Name = "tipoGastoEncontradosComboBox";
            this.tipoGastoEncontradosComboBox.Size = new System.Drawing.Size(219, 21);
            this.tipoGastoEncontradosComboBox.TabIndex = 2;
            this.tipoGastoEncontradosComboBox.Text = "Haga click en la lupa para ver resultados...";
            // 
            // buscarTipoGastoTextbox
            // 
            this.buscarTipoGastoTextbox.Location = new System.Drawing.Point(39, 32);
            this.buscarTipoGastoTextbox.Name = "buscarTipoGastoTextbox";
            this.buscarTipoGastoTextbox.Size = new System.Drawing.Size(219, 20);
            this.buscarTipoGastoTextbox.TabIndex = 3;
            this.buscarTipoGastoTextbox.Text = "Digite el tipo de gasto o una parte de él...";
            // 
            // newExpenseTypePictureBox
            // 
            this.newExpenseTypePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newExpenseTypePictureBox.Image = global::Control_de_Gastos.Properties.Resources.addCommerceType;
            this.newExpenseTypePictureBox.Location = new System.Drawing.Point(186, 122);
            this.newExpenseTypePictureBox.Name = "newExpenseTypePictureBox";
            this.newExpenseTypePictureBox.Size = new System.Drawing.Size(51, 50);
            this.newExpenseTypePictureBox.TabIndex = 4;
            this.newExpenseTypePictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.newExpenseTypePictureBox, "Haga clic para agregar un nuevo tipo de gasto");
            this.newExpenseTypePictureBox.Click += new System.EventHandler(this.newExpenseTypePictureBox_Click);
            // 
            // lupaBuscarComercio
            // 
            this.lupaBuscarComercio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lupaBuscarComercio.Image = global::Control_de_Gastos.Properties.Resources.buscarComercio;
            this.lupaBuscarComercio.Location = new System.Drawing.Point(129, 122);
            this.lupaBuscarComercio.Name = "lupaBuscarComercio";
            this.lupaBuscarComercio.Size = new System.Drawing.Size(51, 51);
            this.lupaBuscarComercio.TabIndex = 1;
            this.lupaBuscarComercio.TabStop = false;
            this.toolTip1.SetToolTip(this.lupaBuscarComercio, "Haga clic para buscar el tipo de gasto digitado");
            this.lupaBuscarComercio.Click += new System.EventHandler(this.lupaBuscarComercio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo de Gasto a Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultados de la búsqueda";
            // 
            // NuevoTipoGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 185);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newExpenseTypePictureBox);
            this.Controls.Add(this.buscarTipoGastoTextbox);
            this.Controls.Add(this.tipoGastoEncontradosComboBox);
            this.Controls.Add(this.lupaBuscarComercio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NuevoTipoGasto";
            this.Text = "Buscar o Agregar Gastos";
            ((System.ComponentModel.ISupportInitialize)(this.newExpenseTypePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupaBuscarComercio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox lupaBuscarComercio;
        private System.Windows.Forms.ComboBox tipoGastoEncontradosComboBox;
        private System.Windows.Forms.TextBox buscarTipoGastoTextbox;
        private System.Windows.Forms.PictureBox newExpenseTypePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}