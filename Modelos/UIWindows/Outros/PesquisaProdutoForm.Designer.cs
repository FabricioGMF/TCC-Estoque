
namespace UIWindows.Outros
{
    partial class PesquisaProdutoForm
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
            this.lblPesquisaProduto = new System.Windows.Forms.Label();
            this.txtPesquisarProduto = new System.Windows.Forms.TextBox();
            this.dgvProdutosBusca = new System.Windows.Forms.DataGridView();
            this.btnFiltroProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosBusca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesquisaProduto
            // 
            this.lblPesquisaProduto.AutoSize = true;
            this.lblPesquisaProduto.Location = new System.Drawing.Point(12, 9);
            this.lblPesquisaProduto.Name = "lblPesquisaProduto";
            this.lblPesquisaProduto.Size = new System.Drawing.Size(170, 13);
            this.lblPesquisaProduto.TabIndex = 5;
            this.lblPesquisaProduto.Text = "Digite a Descrição para Pesquisar:";
            // 
            // txtPesquisarProduto
            // 
            this.txtPesquisarProduto.Location = new System.Drawing.Point(12, 25);
            this.txtPesquisarProduto.Name = "txtPesquisarProduto";
            this.txtPesquisarProduto.Size = new System.Drawing.Size(229, 20);
            this.txtPesquisarProduto.TabIndex = 3;
            this.txtPesquisarProduto.TextChanged += new System.EventHandler(this.TxtPesquisaProduto_TextChanged);
            // 
            // dgvProdutosBusca
            // 
            this.dgvProdutosBusca.AllowUserToAddRows = false;
            this.dgvProdutosBusca.AllowUserToDeleteRows = false;
            this.dgvProdutosBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutosBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosBusca.Location = new System.Drawing.Point(12, 51);
            this.dgvProdutosBusca.Name = "dgvProdutosBusca";
            this.dgvProdutosBusca.ReadOnly = true;
            this.dgvProdutosBusca.Size = new System.Drawing.Size(310, 348);
            this.dgvProdutosBusca.TabIndex = 32;
            // 
            // btnFiltroProduto
            // 
            this.btnFiltroProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFiltroProduto.Location = new System.Drawing.Point(247, 23);
            this.btnFiltroProduto.Name = "btnFiltroProduto";
            this.btnFiltroProduto.Size = new System.Drawing.Size(75, 23);
            this.btnFiltroProduto.TabIndex = 31;
            this.btnFiltroProduto.Text = "Ler";
            this.btnFiltroProduto.UseVisualStyleBackColor = true;
            this.btnFiltroProduto.Click += new System.EventHandler(this.BtnFiltroProduto_Click);
            // 
            // PesquisaProdutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.dgvProdutosBusca);
            this.Controls.Add(this.btnFiltroProduto);
            this.Controls.Add(this.lblPesquisaProduto);
            this.Controls.Add(this.txtPesquisarProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PesquisaProdutoForm";
            this.Text = "Pesquisar Produto";
            this.Load += new System.EventHandler(this.PesquisaProdutoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosBusca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesquisaProduto;
        private System.Windows.Forms.TextBox txtPesquisarProduto;
        private System.Windows.Forms.DataGridView dgvProdutosBusca;
        private System.Windows.Forms.Button btnFiltroProduto;
    }
}