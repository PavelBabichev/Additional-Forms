namespace ComputerStore
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
            this.lstBoxSelling = new System.Windows.Forms.ListBox();
            this.ccmbBoxItems = new System.Windows.Forms.ComboBox();
            this.btnAddToSelling = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddParts = new System.Windows.Forms.Button();
            this.btnEditParts = new System.Windows.Forms.Button();
            this.btnDeleteParts = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxSelling
            // 
            this.lstBoxSelling.FormattingEnabled = true;
            this.lstBoxSelling.Location = new System.Drawing.Point(12, 65);
            this.lstBoxSelling.Name = "lstBoxSelling";
            this.lstBoxSelling.Size = new System.Drawing.Size(292, 147);
            this.lstBoxSelling.TabIndex = 0;
            // 
            // ccmbBoxItems
            // 
            this.ccmbBoxItems.FormattingEnabled = true;
            this.ccmbBoxItems.Location = new System.Drawing.Point(12, 12);
            this.ccmbBoxItems.Name = "ccmbBoxItems";
            this.ccmbBoxItems.Size = new System.Drawing.Size(226, 21);
            this.ccmbBoxItems.TabIndex = 1;
            this.ccmbBoxItems.SelectedIndexChanged += new System.EventHandler(this.ccmbBoxItems_SelectedIndexChanged);
            // 
            // btnAddToSelling
            // 
            this.btnAddToSelling.Location = new System.Drawing.Point(363, 12);
            this.btnAddToSelling.Name = "btnAddToSelling";
            this.btnAddToSelling.Size = new System.Drawing.Size(102, 21);
            this.btnAddToSelling.TabIndex = 2;
            this.btnAddToSelling.Text = "Добавить";
            this.btnAddToSelling.UseVisualStyleBackColor = true;
            this.btnAddToSelling.Click += new System.EventHandler(this.btnAddToSelling_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPrice.Location = new System.Drawing.Point(257, 13);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(47, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "грн.";
            // 
            // btnAddParts
            // 
            this.btnAddParts.Location = new System.Drawing.Point(313, 65);
            this.btnAddParts.Name = "btnAddParts";
            this.btnAddParts.Size = new System.Drawing.Size(191, 23);
            this.btnAddParts.TabIndex = 5;
            this.btnAddParts.Text = "Добавить комплектующие";
            this.btnAddParts.UseVisualStyleBackColor = true;
            this.btnAddParts.Click += new System.EventHandler(this.btnAddParts_Click);
            // 
            // btnEditParts
            // 
            this.btnEditParts.Location = new System.Drawing.Point(313, 127);
            this.btnEditParts.Name = "btnEditParts";
            this.btnEditParts.Size = new System.Drawing.Size(191, 23);
            this.btnEditParts.TabIndex = 6;
            this.btnEditParts.Text = "Редактировать комплектующие";
            this.btnEditParts.UseVisualStyleBackColor = true;
            this.btnEditParts.Click += new System.EventHandler(this.btnEditParts_Click);
            // 
            // btnDeleteParts
            // 
            this.btnDeleteParts.Location = new System.Drawing.Point(313, 189);
            this.btnDeleteParts.Name = "btnDeleteParts";
            this.btnDeleteParts.Size = new System.Drawing.Size(191, 23);
            this.btnDeleteParts.TabIndex = 7;
            this.btnDeleteParts.Text = "Удалить комплектующие";
            this.btnDeleteParts.UseVisualStyleBackColor = true;
            this.btnDeleteParts.Click += new System.EventHandler(this.btnDeleteParts_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(244, 218);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(60, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(134, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Общая сумма";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 270);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnDeleteParts);
            this.Controls.Add(this.btnEditParts);
            this.Controls.Add(this.btnAddParts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnAddToSelling);
            this.Controls.Add(this.ccmbBoxItems);
            this.Controls.Add(this.lstBoxSelling);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxSelling;
        private System.Windows.Forms.ComboBox ccmbBoxItems;
        private System.Windows.Forms.Button btnAddToSelling;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddParts;
        private System.Windows.Forms.Button btnEditParts;
        private System.Windows.Forms.Button btnDeleteParts;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
    }
}

