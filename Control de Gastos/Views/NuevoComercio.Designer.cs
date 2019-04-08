namespace Control_de_Gastos
{
    partial class NuevoComercio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoComercio));
            this.comEncontradosComboBox = new System.Windows.Forms.ComboBox();
            this.buscarComercioTextbox = new System.Windows.Forms.TextBox();
            this.addCommerceTypePictureBox = new System.Windows.Forms.PictureBox();
            this.lupaBuscarComercio = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addCommerceTypePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupaBuscarComercio)).BeginInit();
            this.SuspendLayout();
            // 
            // comEncontradosComboBox
            // 
            this.comEncontradosComboBox.FormattingEnabled = true;
            this.comEncontradosComboBox.Location = new System.Drawing.Point(39, 83);
            this.comEncontradosComboBox.Name = "comEncontradosComboBox";
            this.comEncontradosComboBox.Size = new System.Drawing.Size(219, 21);
            this.comEncontradosComboBox.TabIndex = 2;
            this.comEncontradosComboBox.Text = "Haga click en la lupa para ver resultados...";
            // 
            // buscarComercioTextbox
            // 
            this.buscarComercioTextbox.Location = new System.Drawing.Point(39, 32);
            this.buscarComercioTextbox.Name = "buscarComercioTextbox";
            this.buscarComercioTextbox.Size = new System.Drawing.Size(219, 20);
            this.buscarComercioTextbox.TabIndex = 3;
            this.buscarComercioTextbox.Text = "Digite el comercio o una parte de él...";
            // 
            // addCommerceTypePictureBox
            // 
            this.addCommerceTypePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCommerceTypePictureBox.Image = global::Control_de_Gastos.Properties.Resources.addCommerceType;
            this.addCommerceTypePictureBox.Location = new System.Drawing.Point(186, 123);
            this.addCommerceTypePictureBox.Name = "addCommerceTypePictureBox";
            this.addCommerceTypePictureBox.Size = new System.Drawing.Size(51, 50);
            this.addCommerceTypePictureBox.TabIndex = 4;
            this.addCommerceTypePictureBox.TabStop = false;
            // 
            // lupaBuscarComercio
            // 
            this.lupaBuscarComercio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lupaBuscarComercio.Image = ((System.Drawing.Image)(resources.GetObject("lupaBuscarComercio.Image")));
            this.lupaBuscarComercio.Location = new System.Drawing.Point(129, 122);
            this.lupaBuscarComercio.Name = "lupaBuscarComercio";
            this.lupaBuscarComercio.Size = new System.Drawing.Size(51, 51);
            this.lupaBuscarComercio.TabIndex = 1;
            this.lupaBuscarComercio.TabStop = false;
            this.lupaBuscarComercio.Click += new System.EventHandler(this.lupaBuscarComercio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Comercio a Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Resultados de la búsqueda";
            // 
            // NuevoComercio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 185);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addCommerceTypePictureBox);
            this.Controls.Add(this.buscarComercioTextbox);
            this.Controls.Add(this.comEncontradosComboBox);
            this.Controls.Add(this.lupaBuscarComercio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NuevoComercio";
            this.Text = "Buscar o Agregar Comercio";
            ((System.ComponentModel.ISupportInitialize)(this.addCommerceTypePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupaBuscarComercio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox lupaBuscarComercio;
        private System.Windows.Forms.ComboBox comEncontradosComboBox;
        private System.Windows.Forms.TextBox buscarComercioTextbox;
        private System.Windows.Forms.PictureBox addCommerceTypePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}