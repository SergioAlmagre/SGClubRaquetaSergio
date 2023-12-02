namespace SGClubRaquetaSergio
{
    partial class InformesForm
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
            this.dataGridViewInformes = new System.Windows.Forms.DataGridView();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnGenerarXml = new System.Windows.Forms.Button();
            this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInformes
            // 
            this.dataGridViewInformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInformes.Location = new System.Drawing.Point(19, 324);
            this.dataGridViewInformes.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInformes.Name = "dataGridViewInformes";
            this.dataGridViewInformes.RowHeadersWidth = 51;
            this.dataGridViewInformes.RowTemplate.Height = 24;
            this.dataGridViewInformes.Size = new System.Drawing.Size(652, 240);
            this.dataGridViewInformes.TabIndex = 0;
            this.dataGridViewInformes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInformes_CellContentClick);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(19, 25);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(652, 32);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "PISTA MAS ALQUILADA";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(19, 63);
            this.btn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(652, 32);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "PISTA MENOS ALQUILADA";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(18, 100);
            this.btn3.Margin = new System.Windows.Forms.Padding(2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(652, 32);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "PISTAS POR ORDEN ALQUILER MAS A MENOS";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(19, 137);
            this.btn4.Margin = new System.Windows.Forms.Padding(2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(652, 32);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "SOCIO MAS MOROSOS";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(18, 175);
            this.btn5.Margin = new System.Windows.Forms.Padding(2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(652, 32);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "CANTIDAD TOTAL PAGADA POR SOCIO";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(19, 212);
            this.btn6.Margin = new System.Windows.Forms.Padding(2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(652, 32);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "PISTAS ALQUILADAS AHORA MISMO";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(19, 249);
            this.btn7.Margin = new System.Windows.Forms.Padding(2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(652, 32);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "HORA DE INICIO MAS FRECUENTE DE ALQUILER";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(19, 287);
            this.btn8.Margin = new System.Windows.Forms.Padding(2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(652, 32);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "NOMBRE Y PRECIO PISTAS DE MAYOR A MENOR";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(19, 569);
            this.btn9.Margin = new System.Windows.Forms.Padding(2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(308, 32);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "LIMPIAR";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnGenerarXml
            // 
            this.btnGenerarXml.Location = new System.Drawing.Point(362, 569);
            this.btnGenerarXml.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarXml.Name = "btnGenerarXml";
            this.btnGenerarXml.Size = new System.Drawing.Size(308, 32);
            this.btnGenerarXml.TabIndex = 10;
            this.btnGenerarXml.Text = "GENERAR DOCUMENTO XML";
            this.btnGenerarXml.UseVisualStyleBackColor = true;
            this.btnGenerarXml.Click += new System.EventHandler(this.btnGenerarXml_Click);
            // 
            // InformesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 611);
            this.Controls.Add(this.btnGenerarXml);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.dataGridViewInformes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InformesForm";
            this.Text = "InformesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInformes;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnGenerarXml;
        private System.Windows.Forms.SaveFileDialog sfdRuta;
    }
}