namespace Developer_Assistant
{
    partial class Item
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.openProjectButton = new System.Windows.Forms.Button();
            this.SetProjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openProjectButton
            // 
            this.openProjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openProjectButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.openProjectButton.Location = new System.Drawing.Point(14, 14);
            this.openProjectButton.Name = "openProjectButton";
            this.openProjectButton.Size = new System.Drawing.Size(170, 170);
            this.openProjectButton.TabIndex = 0;
            this.openProjectButton.Text = "Open Project";
            this.openProjectButton.UseVisualStyleBackColor = false;
            this.openProjectButton.Click += new System.EventHandler(this.OpenProject);
            // 
            // SetProjectButton
            // 
            this.SetProjectButton.BackColor = System.Drawing.Color.Teal;
            this.SetProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SetProjectButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SetProjectButton.Location = new System.Drawing.Point(158, 14);
            this.SetProjectButton.Name = "SetProjectButton";
            this.SetProjectButton.Size = new System.Drawing.Size(26, 27);
            this.SetProjectButton.TabIndex = 1;
            this.SetProjectButton.Text = "+";
            this.SetProjectButton.UseVisualStyleBackColor = false;
            this.SetProjectButton.Click += new System.EventHandler(this.SetUpItem);
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SetProjectButton);
            this.Controls.Add(this.openProjectButton);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(200, 200);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openProjectButton;
        private System.Windows.Forms.Button SetProjectButton;
    }
}
