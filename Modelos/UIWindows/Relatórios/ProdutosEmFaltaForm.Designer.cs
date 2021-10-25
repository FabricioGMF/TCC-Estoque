namespace UIWindows
{
    partial class ProdutosEmFaltaForm
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
            this.lblProdutosEmFalta = new System.Windows.Forms.Label();
            this.dgvProdutosEmFalta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosEmFalta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdutosEmFalta
            // 
            this.lblProdutosEmFalta.AutoSize = true;
            this.lblProdutosEmFalta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutosEmFalta.Location = new System.Drawing.Point(9, 21);
            this.lblProdutosEmFalta.Name = "lblProdutosEmFalta";
            this.lblProdutosEmFalta.Size = new System.Drawing.Size(258, 20);
            this.lblProdutosEmFalta.TabIndex = 0;
            this.lblProdutosEmFalta.Text = "Relatório de produtos em falta:";
            // 
            // dgvProdutosEmFalta
            // 
            this.dgvProdutosEmFalta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutosEmFalta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosEmFalta.Location = new System.Drawing.Point(12, 58);
            this.dgvProdutosEmFalta.Name = "dgvProdutosEmFalta";
            this.dgvProdutosEmFalta.Size = new System.Drawing.Size(474, 206);
            this.dgvProdutosEmFalta.TabIndex = 1;
            // 
            // ProdutosEmFaltaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(494, 272);
            this.Controls.Add(this.dgvProdutosEmFalta);
            this.Controls.Add(this.lblProdutosEmFalta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProdutosEmFaltaForm";
            this.Text = "Produtos em falta";
            this.Load += new System.EventHandler(this.ProdutosEmFaltaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosEmFalta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdutosEmFalta;
        private System.Windows.Forms.DataGridView dgvProdutosEmFalta;
    }
}