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
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.numericUpDownEuros = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.chkReservadas = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rboTodos = new System.Windows.Forms.RadioButton();
            this.rboMenor = new System.Windows.Forms.RadioButton();
            this.rboMayor = new System.Windows.Forms.RadioButton();
            this.dateTimePickerBusqueda = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGroupSource = new System.Windows.Forms.GroupBox();
            this.rboReservas = new System.Windows.Forms.RadioButton();
            this.rboSocios = new System.Windows.Forms.RadioButton();
            this.rboPistas = new System.Windows.Forms.RadioButton();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
            this.rboTodasFuentes = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusquedas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubraquetaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEuros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.dataGroupSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridBusquedas
            // 
            this.dataGridBusquedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBusquedas.Location = new System.Drawing.Point(31, 146);
            this.dataGridBusquedas.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridBusquedas.Name = "dataGridBusquedas";
            this.dataGridBusquedas.RowHeadersWidth = 51;
            this.dataGridBusquedas.Size = new System.Drawing.Size(954, 501);
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
            this.lblNombreSocio.Location = new System.Drawing.Point(33, 58);
            this.lblNombreSocio.Name = "lblNombreSocio";
            this.lblNombreSocio.Size = new System.Drawing.Size(92, 16);
            this.lblNombreSocio.TabIndex = 4;
            this.lblNombreSocio.Text = "Nombre socio";
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.Location = new System.Drawing.Point(131, 55);
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.Size = new System.Drawing.Size(207, 22);
            this.txtNombreSocio.TabIndex = 3;
            // 
            // numericUpDownEuros
            // 
            this.numericUpDownEuros.Location = new System.Drawing.Point(74, 54);
            this.numericUpDownEuros.Name = "numericUpDownEuros";
            this.numericUpDownEuros.Size = new System.Drawing.Size(146, 22);
            this.numericUpDownEuros.TabIndex = 5;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(26, 56);
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
            this.groupBox1.Controls.Add(this.rboTodos);
            this.groupBox1.Controls.Add(this.rboMenor);
            this.groupBox1.Controls.Add(this.rboMayor);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.numericUpDownEuros);
            this.groupBox1.Location = new System.Drawing.Point(360, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 90);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de precios";
            // 
            // rboTodos
            // 
            this.rboTodos.AutoSize = true;
            this.rboTodos.Location = new System.Drawing.Point(193, 28);
            this.rboTodos.Name = "rboTodos";
            this.rboTodos.Size = new System.Drawing.Size(68, 20);
            this.rboTodos.TabIndex = 7;
            this.rboTodos.TabStop = true;
            this.rboTodos.Text = "Todos";
            this.rboTodos.UseVisualStyleBackColor = true;
            // 
            // rboMenor
            // 
            this.rboMenor.AutoSize = true;
            this.rboMenor.Location = new System.Drawing.Point(102, 28);
            this.rboMenor.Name = "rboMenor";
            this.rboMenor.Size = new System.Drawing.Size(85, 20);
            this.rboMenor.TabIndex = 1;
            this.rboMenor.TabStop = true;
            this.rboMenor.Text = "Menor de";
            this.rboMenor.UseVisualStyleBackColor = true;
            // 
            // rboMayor
            // 
            this.rboMayor.AutoSize = true;
            this.rboMayor.Location = new System.Drawing.Point(11, 28);
            this.rboMayor.Name = "rboMayor";
            this.rboMayor.Size = new System.Drawing.Size(85, 20);
            this.rboMayor.TabIndex = 0;
            this.rboMayor.TabStop = true;
            this.rboMayor.Text = "Mayor de";
            this.rboMayor.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerBusqueda
            // 
            this.dateTimePickerBusqueda.Location = new System.Drawing.Point(633, 62);
            this.dateTimePickerBusqueda.Name = "dateTimePickerBusqueda";
            this.dateTimePickerBusqueda.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBusqueda.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(859, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(126, 107);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGroupSource
            // 
            this.dataGroupSource.Controls.Add(this.rboTodasFuentes);
            this.dataGroupSource.Controls.Add(this.rboReservas);
            this.dataGroupSource.Controls.Add(this.rboSocios);
            this.dataGroupSource.Controls.Add(this.rboPistas);
            this.dataGroupSource.Location = new System.Drawing.Point(31, 87);
            this.dataGroupSource.Name = "dataGroupSource";
            this.dataGroupSource.Size = new System.Drawing.Size(392, 52);
            this.dataGroupSource.TabIndex = 12;
            this.dataGroupSource.TabStop = false;
            this.dataGroupSource.Text = "Filtro de datos";
            // 
            // rboReservas
            // 
            this.rboReservas.AutoSize = true;
            this.rboReservas.Location = new System.Drawing.Point(210, 21);
            this.rboReservas.Name = "rboReservas";
            this.rboReservas.Size = new System.Drawing.Size(87, 20);
            this.rboReservas.TabIndex = 9;
            this.rboReservas.TabStop = true;
            this.rboReservas.Text = "Reservas";
            this.rboReservas.UseVisualStyleBackColor = true;
            this.rboReservas.CheckedChanged += new System.EventHandler(this.rboReservas_CheckedChanged);
            // 
            // rboSocios
            // 
            this.rboSocios.AutoSize = true;
            this.rboSocios.Location = new System.Drawing.Point(118, 21);
            this.rboSocios.Name = "rboSocios";
            this.rboSocios.Size = new System.Drawing.Size(70, 20);
            this.rboSocios.TabIndex = 8;
            this.rboSocios.TabStop = true;
            this.rboSocios.Text = "Socios";
            this.rboSocios.UseVisualStyleBackColor = true;
            this.rboSocios.CheckedChanged += new System.EventHandler(this.rboSocios_CheckedChanged);
            // 
            // rboPistas
            // 
            this.rboPistas.AutoSize = true;
            this.rboPistas.Location = new System.Drawing.Point(38, 21);
            this.rboPistas.Name = "rboPistas";
            this.rboPistas.Size = new System.Drawing.Size(65, 20);
            this.rboPistas.TabIndex = 7;
            this.rboPistas.TabStop = true;
            this.rboPistas.Text = "Pistas";
            this.rboPistas.UseVisualStyleBackColor = true;
            this.rboPistas.CheckedChanged += new System.EventHandler(this.rboPistas_CheckedChanged);
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(673, 96);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(122, 32);
            this.btnPrueba.TabIndex = 13;
            this.btnPrueba.Text = "Prueba";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // rboTodasFuentes
            // 
            this.rboTodasFuentes.AutoSize = true;
            this.rboTodasFuentes.Location = new System.Drawing.Point(318, 21);
            this.rboTodasFuentes.Name = "rboTodasFuentes";
            this.rboTodasFuentes.Size = new System.Drawing.Size(68, 20);
            this.rboTodasFuentes.TabIndex = 8;
            this.rboTodasFuentes.TabStop = true;
            this.rboTodasFuentes.Text = "Todos";
            this.rboTodasFuentes.UseVisualStyleBackColor = true;
            this.rboTodasFuentes.CheckedChanged += new System.EventHandler(this.rboTodasFuentes_CheckedChanged);
            // 
            // Busquedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 672);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.dataGroupSource);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dateTimePickerBusqueda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkReservadas);
            this.Controls.Add(this.lblNombreSocio);
            this.Controls.Add(this.txtNombreSocio);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEuros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.dataGroupSource.ResumeLayout(false);
            this.dataGroupSource.PerformLayout();
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
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.NumericUpDown numericUpDownEuros;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.CheckBox chkReservadas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rboMenor;
        private System.Windows.Forms.RadioButton rboMayor;
        private System.Windows.Forms.DateTimePicker dateTimePickerBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox dataGroupSource;
        private System.Windows.Forms.RadioButton rboReservas;
        private System.Windows.Forms.RadioButton rboSocios;
        private System.Windows.Forms.RadioButton rboPistas;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.SaveFileDialog sfdRuta;
        private System.Windows.Forms.RadioButton rboTodos;
        private System.Windows.Forms.RadioButton rboTodasFuentes;
    }
}