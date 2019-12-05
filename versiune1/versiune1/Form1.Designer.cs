namespace versiune1
{
    partial class Main_Form
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
            this.Angajat_nou_button = new System.Windows.Forms.Button();
            this.Export_button = new System.Windows.Forms.Button();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.tabel_afisare = new System.Windows.Forms.DataGridView();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Nasteri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Angajari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salariu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.stergere = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_afisare)).BeginInit();
            this.SuspendLayout();
            // 
            // Angajat_nou_button
            // 
            this.Angajat_nou_button.Location = new System.Drawing.Point(99, 427);
            this.Angajat_nou_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Angajat_nou_button.Name = "Angajat_nou_button";
            this.Angajat_nou_button.Size = new System.Drawing.Size(125, 61);
            this.Angajat_nou_button.TabIndex = 0;
            this.Angajat_nou_button.Text = "Angajat nou";
            this.Angajat_nou_button.UseVisualStyleBackColor = true;
            this.Angajat_nou_button.Click += new System.EventHandler(this.Angajat_nou_button_Click);
            // 
            // Export_button
            // 
            this.Export_button.Location = new System.Drawing.Point(292, 427);
            this.Export_button.Name = "Export_button";
            this.Export_button.Size = new System.Drawing.Size(125, 61);
            this.Export_button.TabIndex = 5;
            this.Export_button.Text = "Export";
            this.Export_button.UseVisualStyleBackColor = true;
            this.Export_button.Click += new System.EventHandler(this.Export_button_Click);
            // 
            // Refresh_button
            // 
            this.Refresh_button.Location = new System.Drawing.Point(610, 426);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(95, 61);
            this.Refresh_button.TabIndex = 7;
            this.Refresh_button.Text = "Refresh";
            this.Refresh_button.UseVisualStyleBackColor = true;
            this.Refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // tabel_afisare
            // 
            this.tabel_afisare.AllowUserToAddRows = false;
            this.tabel_afisare.AllowUserToDeleteRows = false;
            this.tabel_afisare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabel_afisare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume,
            this.Prenume,
            this.Data_Nasteri,
            this.Data_Angajari,
            this.Salariu,
            this.edit,
            this.stergere,
            this.Id});
            this.tabel_afisare.Location = new System.Drawing.Point(16, 1);
            this.tabel_afisare.Name = "tabel_afisare";
            this.tabel_afisare.ReadOnly = true;
            this.tabel_afisare.RowTemplate.Height = 24;
            this.tabel_afisare.Size = new System.Drawing.Size(1091, 419);
            this.tabel_afisare.TabIndex = 8;
            this.tabel_afisare.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.Name = "Nume";
            this.Nume.ReadOnly = true;
            // 
            // Prenume
            // 
            this.Prenume.HeaderText = "Prenume";
            this.Prenume.Name = "Prenume";
            this.Prenume.ReadOnly = true;
            // 
            // Data_Nasteri
            // 
            this.Data_Nasteri.HeaderText = "Data Nasteri";
            this.Data_Nasteri.Name = "Data_Nasteri";
            this.Data_Nasteri.ReadOnly = true;
            // 
            // Data_Angajari
            // 
            this.Data_Angajari.HeaderText = "Data Angajari";
            this.Data_Angajari.Name = "Data_Angajari";
            this.Data_Angajari.ReadOnly = true;
            // 
            // Salariu
            // 
            this.Salariu.HeaderText = "Salariu";
            this.Salariu.Name = "Salariu";
            this.Salariu.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.HeaderText = "Editare";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Editati";
            this.edit.UseColumnTextForButtonValue = true;
            // 
            // stergere
            // 
            this.stergere.HeaderText = "Stergere";
            this.stergere.Name = "stergere";
            this.stergere.ReadOnly = true;
            this.stergere.Text = "Stergeti";
            this.stergere.UseColumnTextForButtonValue = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 507);
            this.Controls.Add(this.tabel_afisare);
            this.Controls.Add(this.Refresh_button);
            this.Controls.Add(this.Export_button);
            this.Controls.Add(this.Angajat_nou_button);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main_Form";
            this.Text = "Pagina Principala";
            ((System.ComponentModel.ISupportInitialize)(this.tabel_afisare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Angajat_nou_button;
        private System.Windows.Forms.Button Export_button;
        private System.Windows.Forms.Button Refresh_button;
        private System.Windows.Forms.DataGridView tabel_afisare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Nasteri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Angajari;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salariu;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn stergere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}

