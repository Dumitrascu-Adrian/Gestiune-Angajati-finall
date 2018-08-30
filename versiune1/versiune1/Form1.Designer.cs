namespace versiune1
{
    partial class Form1
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
            this.ListaAngajati = new System.Windows.Forms.ListBox();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Export_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Angajat_nou_button
            // 
            this.Angajat_nou_button.Location = new System.Drawing.Point(97, 404);
            this.Angajat_nou_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Angajat_nou_button.Name = "Angajat_nou_button";
            this.Angajat_nou_button.Size = new System.Drawing.Size(125, 61);
            this.Angajat_nou_button.TabIndex = 0;
            this.Angajat_nou_button.Text = "Angajat nou";
            this.Angajat_nou_button.UseVisualStyleBackColor = true;
            this.Angajat_nou_button.Click += new System.EventHandler(this.Angajat_nou_button_Click);
            // 
            // ListaAngajati
            // 
            this.ListaAngajati.FormattingEnabled = true;
            this.ListaAngajati.ItemHeight = 16;
            this.ListaAngajati.Location = new System.Drawing.Point(38, 13);
            this.ListaAngajati.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListaAngajati.Name = "ListaAngajati";
            this.ListaAngajati.Size = new System.Drawing.Size(411, 324);
            this.ListaAngajati.TabIndex = 1;
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(557, 153);
            this.Edit_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(79, 60);
            this.Edit_button.TabIndex = 2;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(680, 155);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(77, 58);
            this.Delete_button.TabIndex = 4;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Export_button
            // 
            this.Export_button.Location = new System.Drawing.Point(300, 404);
            this.Export_button.Name = "Export_button";
            this.Export_button.Size = new System.Drawing.Size(125, 61);
            this.Export_button.TabIndex = 5;
            this.Export_button.Text = "Export";
            this.Export_button.UseVisualStyleBackColor = true;
            this.Export_button.Click += new System.EventHandler(this.Export_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 88);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(346, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pentru a edita sau a sterge selectati un camp din lista";
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(774, 442);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 7;
            this.exit_button.Text = "exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 507);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Export_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.ListaAngajati);
            this.Controls.Add(this.Angajat_nou_button);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Angajat_nou_button;
        private System.Windows.Forms.ListBox ListaAngajati;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Export_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit_button;
    }
}

