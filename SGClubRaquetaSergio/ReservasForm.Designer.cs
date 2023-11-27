namespace SGClubRaquetaSergio
{
    partial class ReservasForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSocio = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCCC = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblRespuestaDniSocio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.pictureBoxReservas = new System.Windows.Forms.PictureBox();
            this.numUpDoMinutos = new System.Windows.Forms.NumericUpDown();
            this.numUpDoHoras = new System.Windows.Forms.NumericUpDown();
            this.cboPistaReservas = new System.Windows.Forms.ComboBox();
            this.dateTimePickerReservas = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bntPagar = new System.Windows.Forms.Button();
            this.dataGridViewReservas = new System.Windows.Forms.DataGridView();
            this.clubraquetaDataSet = new SGClubRaquetaSergio.clubraquetaDataSet();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDoMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDoHoras)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubraquetaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elige al socio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI Socio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Apellidos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "CCC:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email:";
            // 
            // cboSocio
            // 
            this.cboSocio.FormattingEnabled = true;
            this.cboSocio.Location = new System.Drawing.Point(148, 39);
            this.cboSocio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSocio.Name = "cboSocio";
            this.cboSocio.Size = new System.Drawing.Size(272, 24);
            this.cboSocio.TabIndex = 9;
            this.cboSocio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(131, 20);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(272, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(131, 110);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(272, 22);
            this.txtTelefono.TabIndex = 11;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(131, 63);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(272, 22);
            this.txtDireccion.TabIndex = 12;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(537, 25);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(312, 22);
            this.txtApellidos.TabIndex = 13;
            // 
            // txtCCC
            // 
            this.txtCCC.Location = new System.Drawing.Point(537, 68);
            this.txtCCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCCC.Name = "txtCCC";
            this.txtCCC.ReadOnly = true;
            this.txtCCC.Size = new System.Drawing.Size(312, 22);
            this.txtCCC.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(537, 111);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(312, 22);
            this.txtEmail.TabIndex = 15;
            // 
            // lblRespuestaDniSocio
            // 
            this.lblRespuestaDniSocio.AutoSize = true;
            this.lblRespuestaDniSocio.Location = new System.Drawing.Point(592, 46);
            this.lblRespuestaDniSocio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRespuestaDniSocio.Name = "lblRespuestaDniSocio";
            this.lblRespuestaDniSocio.Size = new System.Drawing.Size(0, 16);
            this.lblRespuestaDniSocio.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCCC);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(28, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 161);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btnReservar);
            this.panel2.Controls.Add(this.pictureBoxReservas);
            this.panel2.Controls.Add(this.numUpDoMinutos);
            this.panel2.Controls.Add(this.numUpDoHoras);
            this.panel2.Controls.Add(this.cboPistaReservas);
            this.panel2.Controls.Add(this.dateTimePickerReservas);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(28, 257);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 151);
            this.panel2.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(436, 73);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "1h 30min";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(436, 57);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "Duracion:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(196, 108);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = ":";
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(413, 106);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(116, 37);
            this.btnReservar.TabIndex = 12;
            this.btnReservar.Text = "RESERVAR";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // pictureBoxReservas
            // 
            this.pictureBoxReservas.Location = new System.Drawing.Point(537, 4);
            this.pictureBoxReservas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxReservas.Name = "pictureBoxReservas";
            this.pictureBoxReservas.Size = new System.Drawing.Size(333, 139);
            this.pictureBoxReservas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxReservas.TabIndex = 11;
            this.pictureBoxReservas.TabStop = false;
            // 
            // numUpDoMinutos
            // 
            this.numUpDoMinutos.Location = new System.Drawing.Point(217, 106);
            this.numUpDoMinutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUpDoMinutos.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUpDoMinutos.Name = "numUpDoMinutos";
            this.numUpDoMinutos.Size = new System.Drawing.Size(59, 22);
            this.numUpDoMinutos.TabIndex = 10;
            // 
            // numUpDoHoras
            // 
            this.numUpDoHoras.Location = new System.Drawing.Point(131, 106);
            this.numUpDoHoras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUpDoHoras.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numUpDoHoras.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numUpDoHoras.Name = "numUpDoHoras";
            this.numUpDoHoras.Size = new System.Drawing.Size(59, 22);
            this.numUpDoHoras.TabIndex = 9;
            this.numUpDoHoras.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // cboPistaReservas
            // 
            this.cboPistaReservas.FormattingEnabled = true;
            this.cboPistaReservas.Location = new System.Drawing.Point(131, 21);
            this.cboPistaReservas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboPistaReservas.Name = "cboPistaReservas";
            this.cboPistaReservas.Size = new System.Drawing.Size(272, 24);
            this.cboPistaReservas.TabIndex = 8;
            this.cboPistaReservas.SelectedIndexChanged += new System.EventHandler(this.cboPistaReservas_SelectedIndexChanged);
            // 
            // dateTimePickerReservas
            // 
            this.dateTimePickerReservas.Location = new System.Drawing.Point(131, 65);
            this.dateTimePickerReservas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerReservas.MinDate = new System.DateTime(2023, 11, 25, 19, 37, 5, 0);
            this.dateTimePickerReservas.Name = "dateTimePickerReservas";
            this.dateTimePickerReservas.Size = new System.Drawing.Size(272, 22);
            this.dateTimePickerReservas.TabIndex = 7;
            this.dateTimePickerReservas.Value = new System.DateTime(2023, 11, 25, 19, 37, 5, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Pista:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 65);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Fecha:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Hora inicio:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.bntPagar);
            this.panel3.Controls.Add(this.dataGridViewReservas);
            this.panel3.Location = new System.Drawing.Point(28, 416);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 423);
            this.panel3.TabIndex = 19;
            // 
            // bntPagar
            // 
            this.bntPagar.Location = new System.Drawing.Point(359, 366);
            this.bntPagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntPagar.Name = "bntPagar";
            this.bntPagar.Size = new System.Drawing.Size(205, 41);
            this.bntPagar.TabIndex = 18;
            this.bntPagar.Text = "PAGAR";
            this.bntPagar.UseVisualStyleBackColor = true;
            this.bntPagar.Click += new System.EventHandler(this.bntPagar_Click);
            // 
            // dataGridViewReservas
            // 
            this.dataGridViewReservas.AllowUserToAddRows = false;
            this.dataGridViewReservas.AllowUserToDeleteRows = false;
            this.dataGridViewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservas.Location = new System.Drawing.Point(28, 18);
            this.dataGridViewReservas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.ReadOnly = true;
            this.dataGridViewReservas.RowHeadersWidth = 51;
            this.dataGridViewReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReservas.Size = new System.Drawing.Size(823, 327);
            this.dataGridViewReservas.TabIndex = 0;
            this.dataGridViewReservas.SelectionChanged += new System.EventHandler(this.dataGridViewReservas_SelectionChanged);
            // 
            // clubraquetaDataSet
            // 
            this.clubraquetaDataSet.DataSetName = "clubraquetaDataSet";
            this.clubraquetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReservasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 902);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRespuestaDniSocio);
            this.Controls.Add(this.cboSocio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReservasForm";
            this.Text = "ReservasForm";
            this.Load += new System.EventHandler(this.ReservasForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDoMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDoHoras)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubraquetaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSocio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtCCC;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblRespuestaDniSocio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.PictureBox pictureBoxReservas;
        private System.Windows.Forms.NumericUpDown numUpDoMinutos;
        private System.Windows.Forms.NumericUpDown numUpDoHoras;
        private System.Windows.Forms.ComboBox cboPistaReservas;
        private System.Windows.Forms.DateTimePicker dateTimePickerReservas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private clubraquetaDataSet clubraquetaDataSet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bntPagar;
        private System.Windows.Forms.DataGridView dataGridViewReservas;
    }
}