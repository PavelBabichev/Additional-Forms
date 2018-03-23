namespace AdditionalForms
{
    partial class Form2
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
            this.txtListFiles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtListFiles
            // 
            this.txtListFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtListFiles.Location = new System.Drawing.Point(0, 0);
            this.txtListFiles.Multiline = true;
            this.txtListFiles.Name = "txtListFiles";
            this.txtListFiles.Size = new System.Drawing.Size(284, 216);
            this.txtListFiles.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtListFiles);
            this.Name = "Form2";
            this.Text = "Список файлов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtListFiles;
    }
}