namespace SGClubRaquetaSergio
{
    partial class GestionForm
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
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label pistaLabel;
            System.Windows.Forms.Label socioLabel;
            System.Windows.Forms.Label pagadoLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label idReservaLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionForm));
            this.clubraquetaDataSet = new SGClubRaquetaSergio.clubraquetaDataSet();
            this.reservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservasTableAdapter = new SGClubRaquetaSergio.clubraquetaDataSetTableAdapters.reservasTableAdapter();
            this.tableAdapterManager = new SGClubRaquetaSergio.clubraquetaDataSetTableAdapters.TableAdapterManager();
            this.reservasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.txtDataPickerFecha = new System.Windows.Forms.DateTimePicker();
            this.txtPistaReserva = new System.Windows.Forms.ComboBox();
            this.pistasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSocioReserva = new System.Windows.Forms.ComboBox();
            this.sociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sociosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtPagado = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecioHora = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtNombrePista = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.btnModificarFoto = new System.Windows.Forms.Button();
            this.dataGridGestion = new System.Windows.Forms.DataGridView();
            this.btnModificarSocio = new System.Windows.Forms.Button();
            this.btnModificarReserva = new System.Windows.Forms.Button();
            this.btnModificarPista = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIdPistaPista = new System.Windows.Forms.TextBox();
            this.txtMaskCuentaC = new System.Windows.Forms.MaskedTextBox();
            this.txtMaskEmail = new System.Windows.Forms.MaskedTextBox();
            this.txtMaskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.reservasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pistasTableAdapter = new SGClubRaquetaSergio.clubraquetaDataSetTableAdapters.pistasTableAdapter();
            this.sociosTableAdapter = new SGClubRaquetaSergio.clubraquetaDataSetTableAdapters.sociosTableAdapter();
            this.reservasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ofdCaratula = new System.Windows.Forms.OpenFileDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.numUpDoMinutosGestion = new System.Windows.Forms.NumericUpDown();
            this.numUpDoHorasGestion = new System.Windows.Forms.NumericUpDown();
            fechaLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            pistaLabel = new System.Windows.Forms.Label();
            socioLabel = new System.Windows.Forms.Label();
            pagadoLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            idReservaLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clubraquetaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingNavigator)).BeginInit();
            this.reservasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDoMinutosGestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDoHorasGestion)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(69, 94);
            fechaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(43, 16);
            fechaLabel.TabIndex = 3;
            fechaLabel.Text = "fecha:";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(69, 124);
            horaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(37, 16);
            horaLabel.TabIndex = 5;
            horaLabel.Text = "hora:";
            // 
            // pistaLabel
            // 
            pistaLabel.AutoSize = true;
            pistaLabel.Location = new System.Drawing.Point(69, 156);
            pistaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pistaLabel.Name = "pistaLabel";
            pistaLabel.Size = new System.Drawing.Size(39, 16);
            pistaLabel.TabIndex = 7;
            pistaLabel.Text = "pista:";
            // 
            // socioLabel
            // 
            socioLabel.AutoSize = true;
            socioLabel.Location = new System.Drawing.Point(69, 190);
            socioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            socioLabel.Name = "socioLabel";
            socioLabel.Size = new System.Drawing.Size(43, 16);
            socioLabel.TabIndex = 9;
            socioLabel.Text = "socio:";
            // 
            // pagadoLabel
            // 
            pagadoLabel.AutoSize = true;
            pagadoLabel.Location = new System.Drawing.Point(69, 223);
            pagadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pagadoLabel.Name = "pagadoLabel";
            pagadoLabel.Size = new System.Drawing.Size(58, 16);
            pagadoLabel.TabIndex = 11;
            pagadoLabel.Text = "pagado:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(69, 255);
            cantidadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(62, 16);
            cantidadLabel.TabIndex = 13;
            cantidadLabel.Text = "cantidad:";
            // 
            // idReservaLabel1
            // 
            idReservaLabel1.AutoSize = true;
            idReservaLabel1.Location = new System.Drawing.Point(69, 62);
            idReservaLabel1.Name = "idReservaLabel1";
            idReservaLabel1.Size = new System.Drawing.Size(76, 16);
            idReservaLabel1.TabIndex = 50;
            idReservaLabel1.Text = "id Reserva:";
            // 
            // clubraquetaDataSet
            // 
            this.clubraquetaDataSet.DataSetName = "clubraquetaDataSet";
            this.clubraquetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservasBindingSource
            // 
            this.reservasBindingSource.DataMember = "reservas";
            this.reservasBindingSource.DataSource = this.clubraquetaDataSet;
            // 
            // reservasTableAdapter
            // 
            this.reservasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pistasTableAdapter = null;
            this.tableAdapterManager.reservasTableAdapter = this.reservasTableAdapter;
            this.tableAdapterManager.sociosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SGClubRaquetaSergio.clubraquetaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reservasBindingNavigator
            // 
            this.reservasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.reservasBindingNavigator.BindingSource = this.reservasBindingSource;
            this.reservasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.reservasBindingNavigator.DeleteItem = null;
            this.reservasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.reservasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.reservasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.reservasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.reservasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.reservasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.reservasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.reservasBindingNavigator.Name = "reservasBindingNavigator";
            this.reservasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.reservasBindingNavigator.Size = new System.Drawing.Size(917, 27);
            this.reservasBindingNavigator.TabIndex = 0;
            this.reservasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // txtDataPickerFecha
            // 
            this.txtDataPickerFecha.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservasBindingSource, "fecha", true));
            this.txtDataPickerFecha.Location = new System.Drawing.Point(159, 89);
            this.txtDataPickerFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDataPickerFecha.Name = "txtDataPickerFecha";
            this.txtDataPickerFecha.Size = new System.Drawing.Size(280, 22);
            this.txtDataPickerFecha.TabIndex = 4;
            // 
            // txtPistaReserva
            // 
            this.txtPistaReserva.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.reservasBindingSource, "pista", true));
            this.txtPistaReserva.DataSource = this.pistasBindingSource1;
            this.txtPistaReserva.DisplayMember = "nombre";
            this.txtPistaReserva.FormattingEnabled = true;
            this.txtPistaReserva.Location = new System.Drawing.Point(159, 153);
            this.txtPistaReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPistaReserva.Name = "txtPistaReserva";
            this.txtPistaReserva.Size = new System.Drawing.Size(280, 24);
            this.txtPistaReserva.TabIndex = 8;
            this.txtPistaReserva.ValueMember = "idPista";
            this.txtPistaReserva.SelectedValueChanged += new System.EventHandler(this.txtPistaReserva_SelectedValueChanged);
            // 
            // pistasBindingSource1
            // 
            this.pistasBindingSource1.DataMember = "pistas";
            this.pistasBindingSource1.DataSource = this.clubraquetaDataSet;
            // 
            // pistasBindingSource
            // 
            this.pistasBindingSource.DataMember = "pistas";
            this.pistasBindingSource.DataSource = this.clubraquetaDataSet;
            // 
            // txtSocioReserva
            // 
            this.txtSocioReserva.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.reservasBindingSource, "socio", true));
            this.txtSocioReserva.DataSource = this.sociosBindingSource;
            this.txtSocioReserva.DisplayMember = "apellidos";
            this.txtSocioReserva.FormattingEnabled = true;
            this.txtSocioReserva.Location = new System.Drawing.Point(159, 186);
            this.txtSocioReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSocioReserva.Name = "txtSocioReserva";
            this.txtSocioReserva.Size = new System.Drawing.Size(280, 24);
            this.txtSocioReserva.TabIndex = 10;
            this.txtSocioReserva.ValueMember = "DNI";
            this.txtSocioReserva.SelectedValueChanged += new System.EventHandler(this.txtSocioReserva_SelectedValueChanged);
            // 
            // sociosBindingSource
            // 
            this.sociosBindingSource.DataMember = "socios";
            this.sociosBindingSource.DataSource = this.clubraquetaDataSet;
            // 
            // sociosBindingSource1
            // 
            this.sociosBindingSource1.DataMember = "socios";
            this.sociosBindingSource1.DataSource = this.clubraquetaDataSet;
            // 
            // txtPagado
            // 
            this.txtPagado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservasBindingSource, "pagado", true));
            this.txtPagado.Location = new System.Drawing.Point(159, 219);
            this.txtPagado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPagado.Name = "txtPagado";
            this.txtPagado.Size = new System.Drawing.Size(280, 22);
            this.txtPagado.TabIndex = 12;
            // 
            // txtCantidad
            // 
            this.txtCantidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservasBindingSource, "cantidad", true));
            this.txtCantidad.Location = new System.Drawing.Point(159, 251);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(280, 22);
            this.txtCantidad.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Domicilio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(467, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cuenta Corriente";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(589, 53);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(280, 22);
            this.txtDNI.TabIndex = 22;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(589, 89);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 22);
            this.txtNombre.TabIndex = 24;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(589, 122);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(280, 22);
            this.txtApellido.TabIndex = 25;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(589, 155);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(280, 22);
            this.txtDomicilio.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 369);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "idPista";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 398);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 427);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Ubicación";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(80, 457);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "PrecioHora";
            // 
            // txtPrecioHora
            // 
            this.txtPrecioHora.Location = new System.Drawing.Point(163, 458);
            this.txtPrecioHora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioHora.Name = "txtPrecioHora";
            this.txtPrecioHora.Size = new System.Drawing.Size(280, 22);
            this.txtPrecioHora.TabIndex = 38;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(163, 426);
            this.txtUbicacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(280, 22);
            this.txtUbicacion.TabIndex = 37;
            // 
            // txtNombrePista
            // 
            this.txtNombrePista.Location = new System.Drawing.Point(163, 394);
            this.txtNombrePista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombrePista.Name = "txtNombrePista";
            this.txtNombrePista.Size = new System.Drawing.Size(280, 22);
            this.txtNombrePista.TabIndex = 36;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pistasBindingSource1, "foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(512, 361);
            this.fotoPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(359, 206);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 39;
            this.fotoPictureBox.TabStop = false;
            // 
            // btnModificarFoto
            // 
            this.btnModificarFoto.Location = new System.Drawing.Point(512, 586);
            this.btnModificarFoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarFoto.Name = "btnModificarFoto";
            this.btnModificarFoto.Size = new System.Drawing.Size(359, 28);
            this.btnModificarFoto.TabIndex = 40;
            this.btnModificarFoto.Text = "MODIFICAR";
            this.btnModificarFoto.UseVisualStyleBackColor = true;
            this.btnModificarFoto.Click += new System.EventHandler(this.btnModificarFoto_Click);
            // 
            // dataGridGestion
            // 
            this.dataGridGestion.AllowUserToAddRows = false;
            this.dataGridGestion.AllowUserToDeleteRows = false;
            this.dataGridGestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGestion.Location = new System.Drawing.Point(51, 635);
            this.dataGridGestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridGestion.Name = "dataGridGestion";
            this.dataGridGestion.ReadOnly = true;
            this.dataGridGestion.RowHeadersWidth = 51;
            this.dataGridGestion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridGestion.Size = new System.Drawing.Size(820, 185);
            this.dataGridGestion.TabIndex = 41;
            // 
            // btnModificarSocio
            // 
            this.btnModificarSocio.Location = new System.Drawing.Point(589, 294);
            this.btnModificarSocio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarSocio.Name = "btnModificarSocio";
            this.btnModificarSocio.Size = new System.Drawing.Size(281, 28);
            this.btnModificarSocio.TabIndex = 42;
            this.btnModificarSocio.Text = "MODIFICAR";
            this.btnModificarSocio.UseVisualStyleBackColor = true;
            this.btnModificarSocio.Click += new System.EventHandler(this.btnModificarSocio_Click);
            // 
            // btnModificarReserva
            // 
            this.btnModificarReserva.Location = new System.Drawing.Point(159, 294);
            this.btnModificarReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarReserva.Name = "btnModificarReserva";
            this.btnModificarReserva.Size = new System.Drawing.Size(281, 28);
            this.btnModificarReserva.TabIndex = 43;
            this.btnModificarReserva.Tag = "";
            this.btnModificarReserva.Text = "MODIFICAR";
            this.btnModificarReserva.UseVisualStyleBackColor = true;
            this.btnModificarReserva.Click += new System.EventHandler(this.btnModificarReserva_Click);
            // 
            // btnModificarPista
            // 
            this.btnModificarPista.Location = new System.Drawing.Point(163, 503);
            this.btnModificarPista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarPista.Name = "btnModificarPista";
            this.btnModificarPista.Size = new System.Drawing.Size(281, 28);
            this.btnModificarPista.TabIndex = 44;
            this.btnModificarPista.Text = "MODIFICAR";
            this.btnModificarPista.UseVisualStyleBackColor = true;
            this.btnModificarPista.Click += new System.EventHandler(this.btnModificarPista_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(163, 553);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(281, 61);
            this.btnBuscar.TabIndex = 46;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarSocio_Click);
            // 
            // txtIdPistaPista
            // 
            this.txtIdPistaPista.Location = new System.Drawing.Point(163, 361);
            this.txtIdPistaPista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdPistaPista.Name = "txtIdPistaPista";
            this.txtIdPistaPista.Size = new System.Drawing.Size(280, 22);
            this.txtIdPistaPista.TabIndex = 35;
            // 
            // txtMaskCuentaC
            // 
            this.txtMaskCuentaC.Location = new System.Drawing.Point(589, 250);
            this.txtMaskCuentaC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaskCuentaC.Name = "txtMaskCuentaC";
            this.txtMaskCuentaC.Size = new System.Drawing.Size(280, 22);
            this.txtMaskCuentaC.TabIndex = 48;
            // 
            // txtMaskEmail
            // 
            this.txtMaskEmail.Location = new System.Drawing.Point(589, 218);
            this.txtMaskEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaskEmail.Name = "txtMaskEmail";
            this.txtMaskEmail.Size = new System.Drawing.Size(281, 22);
            this.txtMaskEmail.TabIndex = 49;
            // 
            // txtMaskTelefono
            // 
            this.txtMaskTelefono.Location = new System.Drawing.Point(589, 188);
            this.txtMaskTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaskTelefono.Name = "txtMaskTelefono";
            this.txtMaskTelefono.Size = new System.Drawing.Size(280, 22);
            this.txtMaskTelefono.TabIndex = 50;
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservasBindingSource, "idReserva", true));
            this.txtIdReserva.Location = new System.Drawing.Point(159, 58);
            this.txtIdReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.Size = new System.Drawing.Size(280, 22);
            this.txtIdReserva.TabIndex = 51;
            // 
            // reservasBindingSource1
            // 
            this.reservasBindingSource1.DataMember = "reservas";
            this.reservasBindingSource1.DataSource = this.clubraquetaDataSet;
            // 
            // pistasTableAdapter
            // 
            this.pistasTableAdapter.ClearBeforeFill = true;
            // 
            // sociosTableAdapter
            // 
            this.sociosTableAdapter.ClearBeforeFill = true;
            // 
            // reservasBindingSource2
            // 
            this.reservasBindingSource2.DataMember = "reservas";
            this.reservasBindingSource2.DataSource = this.clubraquetaDataSet;
            // 
            // ofdCaratula
            // 
            this.ofdCaratula.FileName = "openFileDialog1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(225, 123);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 16);
            this.label12.TabIndex = 54;
            this.label12.Text = ":";
            // 
            // numUpDoMinutosGestion
            // 
            this.numUpDoMinutosGestion.Location = new System.Drawing.Point(247, 121);
            this.numUpDoMinutosGestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUpDoMinutosGestion.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUpDoMinutosGestion.Name = "numUpDoMinutosGestion";
            this.numUpDoMinutosGestion.Size = new System.Drawing.Size(59, 22);
            this.numUpDoMinutosGestion.TabIndex = 53;
            // 
            // numUpDoHorasGestion
            // 
            this.numUpDoHorasGestion.Location = new System.Drawing.Point(160, 121);
            this.numUpDoHorasGestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUpDoHorasGestion.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numUpDoHorasGestion.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numUpDoHorasGestion.Name = "numUpDoHorasGestion";
            this.numUpDoHorasGestion.Size = new System.Drawing.Size(59, 22);
            this.numUpDoHorasGestion.TabIndex = 52;
            this.numUpDoHorasGestion.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // GestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 839);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numUpDoMinutosGestion);
            this.Controls.Add(this.numUpDoHorasGestion);
            this.Controls.Add(idReservaLabel1);
            this.Controls.Add(this.txtIdReserva);
            this.Controls.Add(this.txtMaskTelefono);
            this.Controls.Add(this.txtMaskEmail);
            this.Controls.Add(this.txtMaskCuentaC);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificarPista);
            this.Controls.Add(this.btnModificarReserva);
            this.Controls.Add(this.btnModificarSocio);
            this.Controls.Add(this.dataGridGestion);
            this.Controls.Add(this.btnModificarFoto);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.txtPrecioHora);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.txtNombrePista);
            this.Controls.Add(this.txtIdPistaPista);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.txtDataPickerFecha);
            this.Controls.Add(horaLabel);
            this.Controls.Add(pistaLabel);
            this.Controls.Add(this.txtPistaReserva);
            this.Controls.Add(socioLabel);
            this.Controls.Add(this.txtSocioReserva);
            this.Controls.Add(pagadoLabel);
            this.Controls.Add(this.txtPagado);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.reservasBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GestionForm";
            this.Text = "GestionForm";
            this.Load += new System.EventHandler(this.GestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clubraquetaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingNavigator)).EndInit();
            this.reservasBindingNavigator.ResumeLayout(false);
            this.reservasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDoMinutosGestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDoHorasGestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private clubraquetaDataSet clubraquetaDataSet;
        private System.Windows.Forms.BindingSource reservasBindingSource;
        private clubraquetaDataSetTableAdapters.reservasTableAdapter reservasTableAdapter;
        private clubraquetaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator reservasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DateTimePicker txtDataPickerFecha;
        private System.Windows.Forms.ComboBox txtPistaReserva;
        private System.Windows.Forms.ComboBox txtSocioReserva;
        private System.Windows.Forms.TextBox txtPagado;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecioHora;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.TextBox txtNombrePista;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Button btnModificarFoto;
        private System.Windows.Forms.DataGridView dataGridGestion;
        private System.Windows.Forms.Button btnModificarSocio;
        private System.Windows.Forms.Button btnModificarReserva;
        private System.Windows.Forms.Button btnModificarPista;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIdPistaPista;
        private System.Windows.Forms.MaskedTextBox txtMaskCuentaC;
        private System.Windows.Forms.MaskedTextBox txtMaskEmail;
        private System.Windows.Forms.MaskedTextBox txtMaskTelefono;
        private System.Windows.Forms.TextBox txtIdReserva;
        private System.Windows.Forms.BindingSource reservasBindingSource1;
        private System.Windows.Forms.BindingSource pistasBindingSource;
        private clubraquetaDataSetTableAdapters.pistasTableAdapter pistasTableAdapter;
        private System.Windows.Forms.BindingSource sociosBindingSource;
        private clubraquetaDataSetTableAdapters.sociosTableAdapter sociosTableAdapter;
        private System.Windows.Forms.BindingSource sociosBindingSource1;
        private System.Windows.Forms.BindingSource reservasBindingSource2;
        private System.Windows.Forms.BindingSource pistasBindingSource1;
        private System.Windows.Forms.OpenFileDialog ofdCaratula;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numUpDoMinutosGestion;
        private System.Windows.Forms.NumericUpDown numUpDoHorasGestion;
    }
}