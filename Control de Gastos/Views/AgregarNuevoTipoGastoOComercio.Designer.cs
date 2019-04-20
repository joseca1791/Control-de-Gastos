namespace Control_de_Gastos
{
    partial class AgregarNuevoTipoGastoOComercio
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
            this.elementoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeAgrNueTipGasOComForm = new System.Windows.Forms.Button();
            this.agregarPictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.agregarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // elementoTextBox
            // 
            this.elementoTextBox.Location = new System.Drawing.Point(12, 38);
            this.elementoTextBox.Name = "elementoTextBox";
            this.elementoTextBox.Size = new System.Drawing.Size(543, 20);
            this.elementoTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite el nuevo elemento a agregar";
            // 
            // closeAgrNueTipGasOComForm
            // 
            this.closeAgrNueTipGasOComForm.Image = global::Control_de_Gastos.Properties.Resources.salir;
            this.closeAgrNueTipGasOComForm.Location = new System.Drawing.Point(527, 8);
            this.closeAgrNueTipGasOComForm.Name = "closeAgrNueTipGasOComForm";
            this.closeAgrNueTipGasOComForm.Size = new System.Drawing.Size(28, 24);
            this.closeAgrNueTipGasOComForm.TabIndex = 3;
            this.closeAgrNueTipGasOComForm.UseVisualStyleBackColor = true;
            this.closeAgrNueTipGasOComForm.Click += new System.EventHandler(this.closeAgrNueTipGasOComForm_Click);
            // 
            // agregarPictureBox
            // 
            this.agregarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarPictureBox.Image = global::Control_de_Gastos.Properties.Resources.addCommerceType1;
            this.agregarPictureBox.Location = new System.Drawing.Point(243, 73);
            this.agregarPictureBox.Name = "agregarPictureBox";
            this.agregarPictureBox.Size = new System.Drawing.Size(55, 50);
            this.agregarPictureBox.TabIndex = 1;
            this.agregarPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.agregarPictureBox, "Haga clic para confirmar el nuevo elemento agregado");
            this.agregarPictureBox.Click += new System.EventHandler(this.agregarPictureBox_Click);
            // 
            // AgregarNuevoTipoGastoOComercio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 122);
            this.Controls.Add(this.closeAgrNueTipGasOComForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agregarPictureBox);
            this.Controls.Add(this.elementoTextBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarNuevoTipoGastoOComercio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AgregarNuevoTipoGastoOComercio";
            ((System.ComponentModel.ISupportInitialize)(this.agregarPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox elementoTextBox;
        private System.Windows.Forms.PictureBox agregarPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeAgrNueTipGasOComForm;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}