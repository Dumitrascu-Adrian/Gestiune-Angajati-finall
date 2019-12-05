namespace versiune1
{
    partial class Editare_Angajat
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
            this.textBox_nume = new System.Windows.Forms.TextBox();
            this.textBox_prenume = new System.Windows.Forms.TextBox();
            this.textBoxData_nasteri = new System.Windows.Forms.TextBox();
            this.textBox_dataangajari = new System.Windows.Forms.TextBox();
            this.textBox_salariu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Update_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_nume
            // 
            this.textBox_nume.Location = new System.Drawing.Point(257, 69);
            this.textBox_nume.Name = "textBox_nume";
            this.textBox_nume.Size = new System.Drawing.Size(100, 22);
            this.textBox_nume.TabIndex = 0;
            // 
            // textBox_prenume
            // 
            this.textBox_prenume.Location = new System.Drawing.Point(257, 130);
            this.textBox_prenume.Name = "textBox_prenume";
            this.textBox_prenume.Size = new System.Drawing.Size(100, 22);
            this.textBox_prenume.TabIndex = 1;
            // 
            // textBoxData_nasteri
            // 
            this.textBoxData_nasteri.Location = new System.Drawing.Point(257, 192);
            this.textBoxData_nasteri.Name = "textBoxData_nasteri";
            this.textBoxData_nasteri.Size = new System.Drawing.Size(100, 22);
            this.textBoxData_nasteri.TabIndex = 2;
            // 
            // textBox_dataangajari
            // 
            this.textBox_dataangajari.Location = new System.Drawing.Point(257, 250);
            this.textBox_dataangajari.Name = "textBox_dataangajari";
            this.textBox_dataangajari.Size = new System.Drawing.Size(100, 22);
            this.textBox_dataangajari.TabIndex = 3;
            // 
            // textBox_salariu
            // 
            this.textBox_salariu.Location = new System.Drawing.Point(257, 294);
            this.textBox_salariu.Name = "textBox_salariu";
            this.textBox_salariu.Size = new System.Drawing.Size(100, 22);
            this.textBox_salariu.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data Nasteri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Angajari";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salariu";
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(270, 368);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 23);
            this.Update_button.TabIndex = 11;
            this.Update_button.Text = "Update Angajat";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Editare_Angajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_salariu);
            this.Controls.Add(this.textBox_dataangajari);
            this.Controls.Add(this.textBoxData_nasteri);
            this.Controls.Add(this.textBox_prenume);
            this.Controls.Add(this.textBox_nume);
            this.Name = "Editare_Angajat";
            this.Text = "Editare_Angajat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nume;
        private System.Windows.Forms.TextBox textBox_prenume;
        private System.Windows.Forms.TextBox textBoxData_nasteri;
        private System.Windows.Forms.TextBox textBox_dataangajari;
        private System.Windows.Forms.TextBox textBox_salariu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Update_button;
    }
}