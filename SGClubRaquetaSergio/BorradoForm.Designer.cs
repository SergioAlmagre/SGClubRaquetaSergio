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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            this.tabControlBorrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clubraquetaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlBorrado
            // 
            this.tabControlBorrado.Controls.Add(this.tabPage1);
            this.tabControlBorrado.Controls.Add(this.tabPage2);
            this.tabControlBorrado.Controls.Add(this.tabPage3);
            this.tabControlBorrado.Location = new System.Drawing.Point(9, 112);
            this.tabControlBorrado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlBorrado.Name = "tabControlBorrado";
            this.tabControlBorrado.SelectedIndex = 0;
            this.tabControlBorrado.Size = new System.Drawing.Size(690, 829);
            this.tabControlBorrado.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(682, 803);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Socios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(670, 803);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pistas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(670, 803);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reservas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cboSocios
            // 
            this.cboSocios.FormattingEnabled = true;
            this.cboSocios.Location = new System.Drawing.Point(9, 62);
            this.cboSocios.Name = "cboSocios";
            this.cboSocios.Size = new System.Drawing.Size(230, 21);
            this.cboSocios.TabIndex = 2;
            // 
            // cboPistas
            // 
            this.cboPistas.FormattingEnabled = true;
            this.cboPistas.Location = new System.Drawing.Point(245, 62);
            this.cboPistas.Name = "cboPistas";
            this.cboPistas.Size = new System.Drawing.Size(232, 21);
            this.cboPistas.TabIndex = 3;
            // 
            // cboReservas
            // 
            this.cboReservas.FormattingEnabled = true;
            this.cboReservas.Location = new System.Drawing.Point(483, 62);
            this.cboReservas.Name = "cboReservas";
            this.cboReservas.Size = new System.Drawing.Size(216, 21);
            this.cboReservas.TabIndex = 4;
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
            // BorradoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 997);
            this.Controls.Add(this.lblReservas);
            this.Controls.Add(this.lblPistas);
            this.Controls.Add(this.lblSocios);
            this.Controls.Add(this.cboReservas);
            this.Controls.Add(this.cboPistas);
            this.Controls.Add(this.cboSocios);
            this.Controls.Add(this.tabControlBorrado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BorradoForm";
            this.Text = "BorradoForm";
            this.Load += new System.EventHandler(this.BorradoForm_Load);
            this.tabControlBorrado.ResumeLayout(false);
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
    }
}