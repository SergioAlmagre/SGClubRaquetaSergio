namespace SGClubRaquetaSergio
{
    partial class PreciosForm
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
            this.dataGridPrecios = new System.Windows.Forms.DataGridView();
            this.btnVolverPrecios = new System.Windows.Forms.Button();
            this.lblPrecios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrecios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPrecios
            // 
            this.dataGridPrecios.AllowUserToAddRows = false;
            this.dataGridPrecios.AllowUserToDeleteRows = false;
            this.dataGridPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPrecios.Location = new System.Drawing.Point(40, 102);
            this.dataGridPrecios.MultiSelect = false;
            this.dataGridPrecios.Name = "dataGridPrecios";
            this.dataGridPrecios.ReadOnly = true;
            this.dataGridPrecios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPrecios.Size = new System.Drawing.Size(623, 572);
            this.dataGridPrecios.TabIndex = 0;
            this.dataGridPrecios.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridPrecios.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnVolverPrecios
            // 
            this.btnVolverPrecios.Location = new System.Drawing.Point(40, 710);
            this.btnVolverPrecios.Name = "btnVolverPrecios";
            this.btnVolverPrecios.Size = new System.Drawing.Size(623, 23);
            this.btnVolverPrecios.TabIndex = 1;
            this.btnVolverPrecios.Text = "Volver";
            this.btnVolverPrecios.UseVisualStyleBackColor = true;
            this.btnVolverPrecios.Click += new System.EventHandler(this.btnVolverPrecios_Click);
            // 
            // lblPrecios
            // 
            this.lblPrecios.AutoSize = true;
            this.lblPrecios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecios.Location = new System.Drawing.Point(257, 45);
            this.lblPrecios.Name = "lblPrecios";
            this.lblPrecios.Size = new System.Drawing.Size(184, 31);
            this.lblPrecios.TabIndex = 2;
            this.lblPrecios.Text = "Precios pistas";
            // 
            // PreciosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 789);
            this.Controls.Add(this.lblPrecios);
            this.Controls.Add(this.btnVolverPrecios);
            this.Controls.Add(this.dataGridPrecios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PreciosForm";
            this.Text = "PreciosForm";
            this.Load += new System.EventHandler(this.PreciosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrecios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPrecios;
        private System.Windows.Forms.Button btnVolverPrecios;
        private System.Windows.Forms.Label lblPrecios;
    }
}