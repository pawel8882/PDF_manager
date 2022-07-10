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
            this.select_files = new System.Windows.Forms.Button();
            this.selected_files = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.moveDown_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.addImage_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pdfmerge
            // 
            this.Pdfmerge.Location = new System.Drawing.Point(506, 130);
            this.Pdfmerge.Name = "Pdfmerge";
            this.Pdfmerge.Size = new System.Drawing.Size(127, 46);
            this.Pdfmerge.TabIndex = 0;
            this.Pdfmerge.Text = "Merge pdf";
            this.Pdfmerge.UseVisualStyleBackColor = true;
            this.Pdfmerge.Click += new System.EventHandler(this.Pdfmerge_button);
            // 
            // directory_textbox
            // 
            this.directory_textbox.Location = new System.Drawing.Point(506, 185);
            this.directory_textbox.Name = "directory_textbox";
            this.directory_textbox.Size = new System.Drawing.Size(127, 20);
            this.directory_textbox.TabIndex = 1;
            this.directory_textbox.Text = "E:\\";
            this.directory_textbox.TextChanged += new System.EventHandler(this.directory_textbox_TextChanged);
            // 
            // select_files
            // 
            this.select_files.Location = new System.Drawing.Point(346, 36);
            this.select_files.Name = "select_files";
            this.select_files.Size = new System.Drawing.Size(75, 23);
            this.select_files.TabIndex = 2;
            this.select_files.Text = "Select files";
            this.select_files.UseVisualStyleBackColor = true;
            this.select_files.Click += new System.EventHandler(this.select_files_Click);
            // 
            // selected_files
            // 
            this.selected_files.HideSelection = false;
            this.selected_files.Location = new System.Drawing.Point(12, 36);
            this.selected_files.Name = "selected_files";
            this.selected_files.Size = new System.Drawing.Size(328, 368);
            this.selected_files.TabIndex = 3;
            this.selected_files.UseCompatibleStateImageBehavior = false;
            this.selected_files.SelectedIndexChanged += new System.EventHandler(this.selected_files_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // moveUpButton
            // 
            this.moveUpButton.Location = new System.Drawing.Point(346, 130);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(75, 23);
            this.moveUpButton.TabIndex = 5;
            this.moveUpButton.Text = "Move Up";
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // moveDown_button
            // 
            this.moveDown_button.Location = new System.Drawing.Point(346, 159);
            this.moveDown_button.Name = "moveDown_button";
            this.moveDown_button.Size = new System.Drawing.Size(75, 23);
            this.moveDown_button.TabIndex = 6;
            this.moveDown_button.Text = "Move Down";
            this.moveDown_button.UseVisualStyleBackColor = true;
            this.moveDown_button.Click += new System.EventHandler(this.moveDown_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(346, 188);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 7;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // addImage_button
            // 
            this.addImage_button.Location = new System.Drawing.Point(522, 381);
            this.addImage_button.Name = "addImage_button";
            this.addImage_button.Size = new System.Drawing.Size(75, 23);
            this.addImage_button.TabIndex = 8;
            this.addImage_button.Text = "Add image";
            this.addImage_button.UseVisualStyleBackColor = true;
            this.addImage_button.Click += new System.EventHandler(this.addImage_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addImage_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.moveDown_button);
            this.Controls.Add(this.moveUpButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selected_files);
            this.Controls.Add(this.select_files);
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
        private System.Windows.Forms.Button select_files;
        private System.Windows.Forms.ListView selected_files;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.Button moveDown_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button addImage_button;
    }
}

