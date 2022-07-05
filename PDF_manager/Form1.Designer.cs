namespace PDF_manager
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pdfmerge = new System.Windows.Forms.Button();
            this.directory_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Pdfmerge
            // 
            this.Pdfmerge.Location = new System.Drawing.Point(340, 167);
            this.Pdfmerge.Name = "Pdfmerge";
            this.Pdfmerge.Size = new System.Drawing.Size(127, 46);
            this.Pdfmerge.TabIndex = 0;
            this.Pdfmerge.Text = "Merge pdf";
            this.Pdfmerge.UseVisualStyleBackColor = true;
            this.Pdfmerge.Click += new System.EventHandler(this.Pdfmerge_button);
            // 
            // directory_textbox
            // 
            this.directory_textbox.Location = new System.Drawing.Point(340, 94);
            this.directory_textbox.Name = "directory_textbox";
            this.directory_textbox.Size = new System.Drawing.Size(127, 20);
            this.directory_textbox.TabIndex = 1;
            this.directory_textbox.Text = "E:\\";
            this.directory_textbox.TextChanged += new System.EventHandler(this.directory_textbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.directory_textbox);
            this.Controls.Add(this.Pdfmerge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Pdfmerge;
        private System.Windows.Forms.TextBox directory_textbox;
    }
}

