namespace SGClubRaquetaSergio
{
    partial class BorradoForm
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
            this.tabControlBorrado = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEliminarSocio = new System.Windows.Forms.Button();
            this.btnPagarTodo = new System.Windows.Forms.Button();
            this.btnEliminarReservasSocio = new System.Windows.Forms.Button();
            this.dataGridViewSSocios = new System.Windows.Forms.DataGridView();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtNombrePista = new System.Windows.Forms.TextBox();
            this.txtIdPistaPista = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminarPista = new System.Windows.Forms.Button();
            this.btnEliminarReservasPistas = new System.Windows.Forms.Button();
            this.dataGridViewPPistas = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnEliminarReservaReserva = new System.Windows.Forms.Button();
            this.dataGridViewRReservas = new System.Windows.Forms.DataGridView();
            this.cboSocios = new System.Windows.Forms.ComboBox();
            this.cboPistas = new System.Windows.Forms.ComboBox();
            this.cboReservas = new System.Windows.Forms.ComboBox();
            this.lblSocios = new System.Windows.Forms.Label();
            this.lblPistas = new System.Windows.Forms.Label();
            this.lblReservas = new System.Windows.Forms.Label();
            this.clubraquetaDataSet1 = new SGClubRaquetaSergio.clubraquetaDataSet();
            this.pistasTableAdapter1 = new SGClubRaquetaSergio.clubraquetaDataSetTableAdapters.pistasTableAdapter();
            this.reservasTableAdapter1 = new SGClubRaquetaSergio.clubraquetaDataSetTableAdapters.reservasTableAdapter();
            this.sociosTableAdapter1 = new SGClubRaquetaSergio.clubraquetaDataSetTableAdapters.sociosTableAdapter();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnPagarReservaBorrado = new System.Windows.Forms.Button();
            this.tabControlBorrado.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSSocios)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPPistas)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubraquetaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlBorrado
            // 
            this.tabControlBorrado.Controls.Add(this.tabPage1);
            this.tabControlBorrado.Controls.Add(this.tabPage2);
            this.tabControlBorrado.Controls.Add(this.tabPage3);
            this.tabControlBorrado.Location = new System.Drawing.Point(9, 112);
            this.tabControlBorrado.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlBorrado.Name = "tabControlBorrado";
            this.tabControlBorrado.SelectedIndex = 0;
            this.tabControlBorrado.Size = new System.Drawing.Size(702, 572);
            this.tabControlBorrado.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEliminarSocio);
            this.tabPage1.Controls.Add(this.btnPagarTodo);
            this.tabPage1.Controls.Add(this.btnEliminarReservasSocio);
            this.tabPage1.Controls.Add(this.dataGridViewSSocios);
            this.tabPage1.Controls.Add(this.txtApellido);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.txtDNI);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(694, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Socios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEliminarSocio
            // 
            this.btnEliminarSocio.Enabled = false;
            this.btnEliminarSocio.Location = new System.Drawing.Point(389, 101);
            this.btnEliminarSocio.Name = "btnEliminarSocio";
            this.btnEliminarSocio.Size = new System.Drawing.Size(266, 23);
            this.btnEliminarSocio.TabIndex = 35;
            this.btnEliminarSocio.Text = "Eliminar socio";
            this.btnEliminarSocio.UseVisualStyleBackColor = true;
            this.btnEliminarSocio.Click += new System.EventHandler(this.btnEliminarSocio_Click);
            // 
            // btnPagarTodo
            // 
            this.btnPagarTodo.Location = new System.Drawing.Point(389, 33);
            this.btnPagarTodo.Name = "btnPagarTodo";
            this.btnPagarTodo.Size = new System.Drawing.Size(266, 23);
            this.btnPagarTodo.TabIndex = 34;
            this.btnPagarTodo.Text = "Pagar todo";
            this.btnPagarTodo.UseVisualStyleBackColor = true;
            this.btnPagarTodo.Click += new System.EventHandler(this.btnPagarTodo_Click);
            // 
            // btnEliminarReservasSocio
            // 
            this.btnEliminarReservasSocio.Enabled = false;
            this.btnEliminarReservasSocio.Location = new System.Drawing.Point(389, 67);
            this.btnEliminarReservasSocio.Name = "btnEliminarReservasSocio";
            this.btnEliminarReservasSocio.Size = new System.Drawing.Size(266, 23);
            this.btnEliminarReservasSocio.TabIndex = 33;
            this.btnEliminarReservasSocio.Text = "Eliminar reservas";
            this.btnEliminarReservasSocio.UseVisualStyleBackColor = true;
            this.btnEliminarReservasSocio.Click += new System.EventHandler(this.btnEliminarReservasSocio_Click);
            // 
            // dataGridViewSSocios
            // 
            this.dataGridViewSSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSSocios.Location = new System.Drawing.Point(39, 170);
            this.dataGridViewSSocios.Name = "dataGridViewSSocios";
            this.dataGridViewSSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSSocios.Size = new System.Drawing.Size(616, 349);
            this.dataGridViewSSocios.TabIndex = 32;
            this.dataGridViewSSocios.SelectionChanged += new System.EventHandler(this.dataGridViewSSocios_SelectionChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(96, 103);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(250, 20);
            this.txtApellido.TabIndex = 31;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(250, 20);
            this.txtNombre.TabIndex = 30;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(96, 35);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.ReadOnly = true;
            this.txtDNI.Size = new System.Drawing.Size(250, 20);
            this.txtDNI.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "DNI";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtUbicacion);
            this.tabPage2.Controls.Add(this.txtNombrePista);
            this.tabPage2.Controls.Add(this.txtIdPistaPista);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnEliminarPista);
            this.tabPage2.Controls.Add(this.btnEliminarReservasPistas);
            this.tabPage2.Controls.Add(this.dataGridViewPPistas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(694, 546);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pistas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(103, 100);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.ReadOnly = true;
            this.txtUbicacion.Size = new System.Drawing.Size(211, 20);
            this.txtUbicacion.TabIndex = 51;
            // 
            // txtNombrePista
            // 
            this.txtNombrePista.Location = new System.Drawing.Point(103, 67);
            this.txtNombrePista.Name = "txtNombrePista";
            this.txtNombrePista.ReadOnly = true;
            this.txtNombrePista.Size = new System.Drawing.Size(211, 20);
            this.txtNombrePista.TabIndex = 50;
            // 
            // txtIdPistaPista
            // 
            this.txtIdPistaPista.Location = new System.Drawing.Point(103, 33);
            this.txtIdPistaPista.Name = "txtIdPistaPista";
            this.txtIdPistaPista.ReadOnly = true;
            this.txtIdPistaPista.Size = new System.Drawing.Size(211, 20);
            this.txtIdPistaPista.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Ubicación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "idPista";
            // 
            // btnEliminarPista
            // 
            this.btnEliminarPista.Location = new System.Drawing.Point(379, 81);
            this.btnEliminarPista.Name = "btnEliminarPista";
            this.btnEliminarPista.Size = new System.Drawing.Size(266, 23);
            this.btnEliminarPista.TabIndex = 45;
            this.btnEliminarPista.Text = "Eliminar pista";
            this.btnEliminarPista.UseVisualStyleBackColor = true;
            this.btnEliminarPista.Click += new System.EventHandler(this.btnEliminarPista_Click);
            // 
            // btnEliminarReservasPistas
            // 
            this.btnEliminarReservasPistas.Location = new System.Drawing.Point(379, 40);
            this.btnEliminarReservasPistas.Name = "btnEliminarReservasPistas";
            this.btnEliminarReservasPistas.Size = new System.Drawing.Size(266, 23);
            this.btnEliminarReservasPistas.TabIndex = 43;
            this.btnEliminarReservasPistas.Text = "Eliminar reservas";
            this.btnEliminarReservasPistas.UseVisualStyleBackColor = true;
            this.btnEliminarReservasPistas.Click += new System.EventHandler(this.btnEliminarReservasPistas_Click);
            // 
            // dataGridViewPPistas
            // 
            this.dataGridViewPPistas.AllowUserToAddRows = false;
            this.dataGridViewPPistas.AllowUserToDeleteRows = false;
            this.dataGridViewPPistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPPistas.Location = new System.Drawing.Point(41, 167);
            this.dataGridViewPPistas.Name = "dataGridViewPPistas";
            this.dataGridViewPPistas.ReadOnly = true;
            this.dataGridViewPPistas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPPistas.Size = new System.Drawing.Size(616, 349);
            this.dataGridViewPPistas.TabIndex = 42;
            this.dataGridViewPPistas.SelectionChanged += new System.EventHandler(this.dataGridViewPPistas_SelectionChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnPagarReservaBorrado);
            this.tabPage3.Controls.Add(this.btnEliminarReservaReserva);
            this.tabPage3.Controls.Add(this.dataGridViewRReservas);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(694, 546);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reservas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnEliminarReservaReserva
            // 
            this.btnEliminarReservaReserva.Location = new System.Drawing.Point(208, 113);
            this.btnEliminarReservaReserva.Name = "btnEliminarReservaReserva";
            this.btnEliminarReservaReserva.Size = new System.Drawing.Size(266, 23);
            this.btnEliminarReservaReserva.TabIndex = 44;
            this.btnEliminarReservaReserva.Text = "Eliminar reserva";
            this.btnEliminarReservaReserva.UseVisualStyleBackColor = true;
            this.btnEliminarReservaReserva.Click += new System.EventHandler(this.btnEliminarReservaReserva_Click);
            // 
            // dataGridViewRReservas
            // 
            this.dataGridViewRReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRReservas.Location = new System.Drawing.Point(36, 174);
            this.dataGridViewRReservas.Name = "dataGridViewRReservas";
            this.dataGridViewRReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRReservas.Size = new System.Drawing.Size(616, 349);
            this.dataGridViewRReservas.TabIndex = 43;
            this.dataGridViewRReservas.SelectionChanged += new System.EventHandler(this.dataGridViewRReservas_SelectionChanged);
            // 
            // cboSocios
            // 
            this.cboSocios.FormattingEnabled = true;
            this.cboSocios.Location = new System.Drawing.Point(9, 62);
            this.cboSocios.Name = "cboSocios";
            this.cboSocios.Size = new System.Drawing.Size(230, 21);
            this.cboSocios.TabIndex = 2;
            this.cboSocios.SelectedIndexChanged += new System.EventHandler(this.cboSocios_SelectedIndexChanged);
            // 
            // cboPistas
            // 
            this.cboPistas.FormattingEnabled = true;
            this.cboPistas.Location = new System.Drawing.Point(245, 62);
            this.cboPistas.Name = "cboPistas";
            this.cboPistas.Size = new System.Drawing.Size(232, 21);
            this.cboPistas.TabIndex = 3;
            this.cboPistas.SelectedIndexChanged += new System.EventHandler(this.cboPistas_SelectedIndexChanged);
            // 
            // cboReservas
            // 
            this.cboReservas.FormattingEnabled = true;
            this.cboReservas.Location = new System.Drawing.Point(483, 62);
            this.cboReservas.Name = "cboReservas";
            this.cboReservas.Size = new System.Drawing.Size(216, 21);
            this.cboReservas.TabIndex = 4;
            this.cboReservas.SelectedIndexChanged += new System.EventHandler(this.cboReservas_SelectedIndexChanged);
            // 
            // lblSocios
            // 
            this.lblSocios.AutoSize = true;
            this.lblSocios.Location = new System.Drawing.Point(97, 34);
            this.lblSocios.Name = "lblSocios";
            this.lblSocios.Size = new System.Drawing.Size(39, 13);
            this.lblSocios.TabIndex = 5;
            this.lblSocios.Text = "Socios";
            // 
            // lblPistas
            // 
            this.lblPistas.AutoSize = true;
            this.lblPistas.Location = new System.Drawing.Point(302, 34);
            this.lblPistas.Name = "lblPistas";
            this.lblPistas.Size = new System.Drawing.Size(35, 13);
            this.lblPistas.TabIndex = 6;
            this.lblPistas.Text = "Pistas";
            // 
            // lblReservas
            // 
            this.lblReservas.AutoSize = true;
            this.lblReservas.Location = new System.Drawing.Point(545, 34);
            this.lblReservas.Name = "lblReservas";
            this.lblReservas.Size = new System.Drawing.Size(52, 13);
            this.lblReservas.TabIndex = 7;
            this.lblReservas.Text = "Reservas";
            // 
            // clubraquetaDataSet1
            // 
            this.clubraquetaDataSet1.DataSetName = "clubraquetaDataSet";
            this.clubraquetaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(288, 689);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(157, 23);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnPagarReservaBorrado
            // 
            this.btnPagarReservaBorrado.Location = new System.Drawing.Point(208, 64);
            this.btnPagarReservaBorrado.Name = "btnPagarReservaBorrado";
            this.btnPagarReservaBorrado.Size = new System.Drawing.Size(266, 23);
            this.btnPagarReservaBorrado.TabIndex = 45;
            this.btnPagarReservaBorrado.Text = "Pagar reserva";
            this.btnPagarReservaBorrado.UseVisualStyleBackColor = true;
            this.btnPagarReservaBorrado.Click += new System.EventHandler(this.btnPagarReservaBorrado_Click);
            // 
            // BorradoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 733);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblReservas);
            this.Controls.Add(this.lblPistas);
            this.Controls.Add(this.lblSocios);
            this.Controls.Add(this.cboReservas);
            this.Controls.Add(this.cboPistas);
            this.Controls.Add(this.cboSocios);
            this.Controls.Add(this.tabControlBorrado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BorradoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorradoForm";
            this.Load += new System.EventHandler(this.BorradoForm_Load);
            this.tabControlBorrado.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSSocios)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPPistas)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubraquetaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlBorrado;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cboSocios;
        private System.Windows.Forms.ComboBox cboPistas;
        private System.Windows.Forms.ComboBox cboReservas;
        private System.Windows.Forms.Label lblSocios;
        private System.Windows.Forms.Label lblPistas;
        private System.Windows.Forms.Label lblReservas;
        private clubraquetaDataSet clubraquetaDataSet1;
        private clubraquetaDataSetTableAdapters.pistasTableAdapter pistasTableAdapter1;
        private clubraquetaDataSetTableAdapters.reservasTableAdapter reservasTableAdapter1;
        private clubraquetaDataSetTableAdapters.sociosTableAdapter sociosTableAdapter1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarSocio;
        private System.Windows.Forms.Button btnPagarTodo;
        private System.Windows.Forms.Button btnEliminarReservasSocio;
        private System.Windows.Forms.DataGridView dataGridViewSSocios;
        private System.Windows.Forms.Button btnEliminarPista;
        private System.Windows.Forms.Button btnEliminarReservasPistas;
        private System.Windows.Forms.DataGridView dataGridViewPPistas;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.TextBox txtNombrePista;
        private System.Windows.Forms.TextBox txtIdPistaPista;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewRReservas;
        private System.Windows.Forms.Button btnEliminarReservaReserva;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnPagarReservaBorrado;
    }
}