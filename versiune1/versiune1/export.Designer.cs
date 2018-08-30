namespace versiune1
{
    partial class export
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
            this.Alegere_tip = new System.Windows.Forms.ComboBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Alegere_tip
            // 
            this.Alegere_tip.FormattingEnabled = true;
            this.Alegere_tip.Items.AddRange(new object[] {
            "JSON",
            "XML"});
            this.Alegere_tip.Location = new System.Drawing.Point(123, 43);
            this.Alegere_tip.Name = "Alegere_tip";
            this.Alegere_tip.Size = new System.Drawing.Size(121, 24);
            this.Alegere_tip.TabIndex = 0;
            this.Alegere_tip.Text = "JSON";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(123, 116);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 192);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.Alegere_tip);
            this.Name = "export";
            this.Text = "export";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Alegere_tip;
        private System.Windows.Forms.Button button_ok;
    }
}