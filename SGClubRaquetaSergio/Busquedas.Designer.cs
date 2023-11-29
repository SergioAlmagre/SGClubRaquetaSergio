namespace SGClubRaquetaSergio
{
    partial class Busquedas
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
            this.dataGridBusquedas = new System.Windows.Forms.DataGridView();
            this.pistasTableAdapter1 = new SGClubRaquetaSergio.clubraquetaDataSetTableAdapters.pistasTableAdapter();
            this.reservasTableAdapter1 = new SGClubRaquetaSergio.clubraquetaDataSetTableAdapters.reservasTableAdapter();
            this.sociosTableAdapter1 = new SGClubRaquetaSergio.clubraquetaDataSetTableAdapters.sociosTableAdapter();
            this.clubraquetaDataSet1 = new SGClubRaquetaSergio.clubraquetaDataSet();
            this.txtNombrePista = new System.Windows.Forms.TextBox();
            this.lblNombrePista = new System.Windows.Forms.Label();
            this.lblNombreSocio = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.chkReservadas = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoEncima = new System.Windows.Forms.RadioButton();
            this.rdoMenor = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusquedas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubraquetaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridBusquedas
            // 
            this.dataGridBusquedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBusquedas.Location = new System.Drawing.Point(31, 109);
            this.dataGridBusquedas.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridBusquedas.Name = "dataGridBusquedas";
            this.dataGridBusquedas.RowHeadersWidth = 51;
            this.dataGridBusquedas.Size = new System.Drawing.Size(954, 538);
            this.dataGridBusquedas.TabIndex = 0;
            this.dataGridBusquedas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridBusquedas_MouseDoubleClick);
            // 
            // pistasTableAdapter1
            // 
            this.pistasTableAdapter1.ClearBeforeFill = true;
            // 
            // reservasTableAdapter1
            // 
            this.reservasTableAdapter1.ClearBeforeFill = true;
            // 
            // sociosTableAdapter1
            // 
            this.sociosTableAdapter1.ClearBeforeFill = true;
            // 
            // clubraquetaDataSet1
            // 
            this.clubraquetaDataSet1.DataSetName = "clubraquetaDataSet";
            this.clubraquetaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNombrePista
            // 
            this.txtNombrePista.Location = new System.Drawing.Point(131, 21);
            this.txtNombrePista.Name = "txtNombrePista";
            this.txtNombrePista.Size = new System.Drawing.Size(207, 22);
            this.txtNombrePista.TabIndex = 1;
            // 
            // lblNombrePista
            // 
            this.lblNombrePista.AutoSize = true;
            this.lblNombrePista.Location = new System.Drawing.Point(33, 23);
            this.lblNombrePista.Name = "lblNombrePista";
            this.lblNombrePista.Size = new System.Drawing.Size(88, 16);
            this.lblNombrePista.TabIndex = 2;
            this.lblNombrePista.Text = "Nombre pista";
            // 
            // lblNombreSocio
            // 
            this.lblNombreSocio.AutoSize = true;
            this.lblNombreSocio.Location = new System.Drawing.Point(33, 62);
            this.lblNombreSocio.Name = "lblNombreSocio";
            this.lblNombreSocio.Size = new System.Drawing.Size(92, 16);
            this.lblNombreSocio.TabIndex = 4;
            this.lblNombreSocio.Text = "Nombre socio";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 22);
            this.textBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(74, 47);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(146, 22);
            this.numericUpDown1.TabIndex = 5;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(26, 49);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(42, 16);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Euros";
            // 
            // chkReservadas
            // 
            this.chkReservadas.AutoSize = true;
            this.chkReservadas.Location = new System.Drawing.Point(633, 22);
            this.chkReservadas.Name = "chkReservadas";
            this.chkReservadas.Size = new System.Drawing.Size(138, 20);
            this.chkReservadas.TabIndex = 8;
            this.chkReservadas.Text = "Pistas reservadas";
            this.chkReservadas.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoMenor);
            this.groupBox1.Controls.Add(this.rdoEncima);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(360, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 78);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de precios";
            // 
            // rdoEncima
            // 
            this.rdoEncima.AutoSize = true;
            this.rdoEncima.Location = new System.Drawing.Point(21, 21);
            this.rdoEncima.Name = "rdoEncima";
            this.rdoEncima.Size = new System.Drawing.Size(85, 20);
            this.rdoEncima.TabIndex = 0;
            this.rdoEncima.TabStop = true;
            this.rdoEncima.Text = "Mayor de";
            this.rdoEncima.UseVisualStyleBackColor = true;
            // 
            // rdoMenor
            // 
            this.rdoMenor.AutoSize = true;
            this.rdoMenor.Location = new System.Drawing.Point(135, 21);
            this.rdoMenor.Name = "rdoMenor";
            this.rdoMenor.Size = new System.Drawing.Size(85, 20);
            this.rdoMenor.TabIndex = 1;
            this.rdoMenor.TabStop = true;
            this.rdoMenor.Text = "Menor de";
            this.rdoMenor.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(633, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(859, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(126, 61);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // Busquedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 672);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkReservadas);
            this.Controls.Add(this.lblNombreSocio);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNombrePista);
            this.Controls.Add(this.txtNombrePista);
            this.Controls.Add(this.dataGridBusquedas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Busquedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busquedas";
            this.Load += new System.EventHandler(this.Busquedas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusquedas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubraquetaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBusquedas;
        private clubraquetaDataSetTableAdapters.pistasTableAdapter pistasTableAdapter1;
        private clubraquetaDataSetTableAdapters.reservasTableAdapter reservasTableAdapter1;
        private clubraquetaDataSetTableAdapters.sociosTableAdapter sociosTableAdapter1;
        private clubraquetaDataSet clubraquetaDataSet1;
        private System.Windows.Forms.TextBox txtNombrePista;
        private System.Windows.Forms.Label lblNombrePista;
        private System.Windows.Forms.Label lblNombreSocio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.CheckBox chkReservadas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoMenor;
        private System.Windows.Forms.RadioButton rdoEncima;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnBuscar;
    }
}