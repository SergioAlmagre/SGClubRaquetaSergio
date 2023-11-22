namespace SGClubRaquetaSergio
{
    partial class SociosForm
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
            this.dataGSocios = new System.Windows.Forms.DataGridView();
            this.clubraquetaDataSet = new SGClubRaquetaSergio.clubraquetaDataSet();
            this.sociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sociosTableAdapter = new SGClubRaquetaSergio.clubraquetaDataSetTableAdapters.sociosTableAdapter();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnTodos = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtCuentaCorriente = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCuentaBancaria = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubraquetaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGSocios
            // 
            this.dataGSocios.AllowUserToAddRows = false;
            this.dataGSocios.AllowUserToDeleteRows = false;
            this.dataGSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGSocios.Location = new System.Drawing.Point(26, 310);
            this.dataGSocios.MultiSelect = false;
            this.dataGSocios.Name = "dataGSocios";
            this.dataGSocios.ReadOnly = true;
            this.dataGSocios.RowHeadersWidth = 51;
            this.dataGSocios.RowTemplate.Height = 24;
            this.dataGSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGSocios.Size = new System.Drawing.Size(931, 210);
            this.dataGSocios.TabIndex = 0;
            this.dataGSocios.SelectionChanged += new System.EventHandler(this.dataGSocios_SelectionChanged);
            // 
            // clubraquetaDataSet
            // 
            this.clubraquetaDataSet.DataSetName = "clubraquetaDataSet";
            this.clubraquetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sociosBindingSource
            // 
            this.sociosBindingSource.DataMember = "socios";
            this.sociosBindingSource.DataSource = this.clubraquetaDataSet;
            // 
            // sociosTableAdapter
            // 
            this.sociosTableAdapter.ClearBeforeFill = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(26, 38);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(209, 23);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(26, 97);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(209, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(26, 145);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(209, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(375, 124);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(375, 193);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(206, 20);
            this.txtApellidos.TabIndex = 5;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(375, 56);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(206, 20);
            this.txtDNI.TabIndex = 6;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(26, 249);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(209, 23);
            this.btnTodos.TabIndex = 9;
            this.btnTodos.Text = "TODOS";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(751, 193);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(751, 124);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(206, 20);
            this.txtTelefono.TabIndex = 11;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(751, 59);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(206, 20);
            this.txtDomicilio.TabIndex = 10;
            // 
            // txtCuentaCorriente
            // 
            this.txtCuentaCorriente.Location = new System.Drawing.Point(579, 266);
            this.txtCuentaCorriente.Name = "txtCuentaCorriente";
            this.txtCuentaCorriente.Size = new System.Drawing.Size(378, 20);
            this.txtCuentaCorriente.TabIndex = 13;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(634, 62);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(74, 19);
            this.lblDomicilio.TabIndex = 14;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(299, 127);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 19);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(299, 62);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(35, 19);
            this.lblDni.TabIndex = 16;
            this.lblDni.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(299, 199);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(71, 19);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "Apellidos";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(634, 199);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 19);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(634, 130);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(69, 19);
            this.lblTelefono.TabIndex = 19;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblCuentaBancaria
            // 
            this.lblCuentaBancaria.AutoSize = true;
            this.lblCuentaBancaria.Location = new System.Drawing.Point(452, 266);
            this.lblCuentaBancaria.Name = "lblCuentaBancaria";
            this.lblCuentaBancaria.Size = new System.Drawing.Size(97, 15);
            this.lblCuentaBancaria.TabIndex = 20;
            this.lblCuentaBancaria.Text = "Cuenta bancaria";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(26, 199);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(209, 23);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // SociosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 549);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblCuentaBancaria);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.txtCuentaCorriente);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dataGSocios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SociosForm";
            this.Text = "Socios";
            this.Load += new System.EventHandler(this.SociosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubraquetaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGSocios;
        private clubraquetaDataSet clubraquetaDataSet;
        private System.Windows.Forms.BindingSource sociosBindingSource;
        private clubraquetaDataSetTableAdapters.sociosTableAdapter sociosTableAdapter;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtCuentaCorriente;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCuentaBancaria;
        private System.Windows.Forms.Button btnLimpiar;
    }
}