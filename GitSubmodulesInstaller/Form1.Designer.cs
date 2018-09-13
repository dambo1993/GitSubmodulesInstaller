namespace GitSubmodulesInstaller
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
            this.b_load_file = new System.Windows.Forms.Button();
            this.tv_XML = new System.Windows.Forms.TreeView();
            this.b_generate_command = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_load_file
            // 
            this.b_load_file.Location = new System.Drawing.Point(12, 344);
            this.b_load_file.Name = "b_load_file";
            this.b_load_file.Size = new System.Drawing.Size(130, 23);
            this.b_load_file.TabIndex = 0;
            this.b_load_file.Text = "Load submodules file";
            this.b_load_file.UseVisualStyleBackColor = true;
            this.b_load_file.Click += new System.EventHandler(this.b_load_file_Click);
            // 
            // tv_XML
            // 
            this.tv_XML.Location = new System.Drawing.Point(12, 12);
            this.tv_XML.Name = "tv_XML";
            this.tv_XML.Size = new System.Drawing.Size(262, 326);
            this.tv_XML.TabIndex = 2;
            // 
            // b_generate_command
            // 
            this.b_generate_command.Location = new System.Drawing.Point(12, 373);
            this.b_generate_command.Name = "b_generate_command";
            this.b_generate_command.Size = new System.Drawing.Size(130, 23);
            this.b_generate_command.TabIndex = 3;
            this.b_generate_command.Text = "Generate Git command";
            this.b_generate_command.UseVisualStyleBackColor = true;
            this.b_generate_command.Click += new System.EventHandler(this.b_generate_command_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 450);
            this.Controls.Add(this.b_generate_command);
            this.Controls.Add(this.tv_XML);
            this.Controls.Add(this.b_load_file);
            this.Name = "Form1";
            this.Text = "GitSubmodulesInstaller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_load_file;
        private System.Windows.Forms.TreeView tv_XML;
        private System.Windows.Forms.Button b_generate_command;
    }
}

