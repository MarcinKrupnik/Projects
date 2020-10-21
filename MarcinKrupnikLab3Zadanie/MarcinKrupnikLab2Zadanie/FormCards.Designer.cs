namespace MarcinKrupnikLab2Zadanie
{
    partial class FormCards
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
            this.dataGridViewCards = new System.Windows.Forms.DataGridView();
            this.textBoxFiltr = new System.Windows.Forms.TextBox();
            this.buttonFiltr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCards)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCards
            // 
            this.dataGridViewCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCards.Location = new System.Drawing.Point(91, 3);
            this.dataGridViewCards.Name = "dataGridViewCards";
            this.dataGridViewCards.Size = new System.Drawing.Size(439, 374);
            this.dataGridViewCards.TabIndex = 0;
            // 
            // textBoxFiltr
            // 
            this.textBoxFiltr.Location = new System.Drawing.Point(553, 32);
            this.textBoxFiltr.Name = "textBoxFiltr";
            this.textBoxFiltr.Size = new System.Drawing.Size(100, 20);
            this.textBoxFiltr.TabIndex = 1;
            // 
            // buttonFiltr
            // 
            this.buttonFiltr.Location = new System.Drawing.Point(563, 80);
            this.buttonFiltr.Name = "buttonFiltr";
            this.buttonFiltr.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltr.TabIndex = 2;
            this.buttonFiltr.Text = "Filtr";
            this.buttonFiltr.UseVisualStyleBackColor = true;
            this.buttonFiltr.Click += new System.EventHandler(this.buttonFiltr_Click);
            // 
            // FormCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 459);
            this.Controls.Add(this.buttonFiltr);
            this.Controls.Add(this.textBoxFiltr);
            this.Controls.Add(this.dataGridViewCards);
            this.Name = "FormCards";
            this.Text = "FormCards";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCards;
        private System.Windows.Forms.TextBox textBoxFiltr;
        private System.Windows.Forms.Button buttonFiltr;
    }
}