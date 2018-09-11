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
            this.gb_submodules = new System.Windows.Forms.GroupBox();
            this.tv_XML = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // b_load_file
            // 
            this.b_load_file.Location = new System.Drawing.Point(239, 12);
            this.b_load_file.Name = "b_load_file";
            this.b_load_file.Size = new System.Drawing.Size(130, 23);
            this.b_load_file.TabIndex = 0;
            this.b_load_file.Text = "Load submodules file";
            this.b_load_file.UseVisualStyleBackColor = true;
            this.b_load_file.Click += new System.EventHandler(this.b_load_file_Click);
            // 
            // gb_submodules
            // 
            this.gb_submodules.Location = new System.Drawing.Point(12, 12);
            this.gb_submodules.Name = "gb_submodules";
            this.gb_submodules.Size = new System.Drawing.Size(200, 100);
            this.gb_submodules.TabIndex = 1;
            this.gb_submodules.TabStop = false;
            this.gb_submodules.Text = "Submodules";
            // 
            // tv_XML
            // 
            this.tv_XML.Location = new System.Drawing.Point(107, 203);
            this.tv_XML.Name = "tv_XML";
            this.tv_XML.Size = new System.Drawing.Size(262, 136);
            this.tv_XML.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tv_XML);
            this.Controls.Add(this.gb_submodules);
            this.Controls.Add(this.b_load_file);
            this.Name = "Form1";
            this.Text = "GitSubmodulesInstaller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_load_file;
        private System.Windows.Forms.GroupBox gb_submodules;
        private System.Windows.Forms.TreeView tv_XML;
    }
}

