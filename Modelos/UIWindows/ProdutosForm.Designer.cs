namespace UIWindows
{
    partial class ProdutosForm
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtEstoqueMaximo = new System.Windows.Forms.TextBox();
            this.txtEstoqueMinimo = new System.Windows.Forms.TextBox();
            this.lblEstoqueMaximo = new System.Windows.Forms.Label();
            this.lblEstoqueMinimo = new System.Windows.Forms.Label();
            this.txtEstoqueTotal = new System.Windows.Forms.TextBox();
            this.txtEstoqueSeguranca = new System.Windows.Forms.TextBox();
            this.lblEstoqueSeguranca = new System.Windows.Forms.Label();
            this.lblEstoqueTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(11, 223);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(433, 235);
            this.dgvProdutos.TabIndex = 30;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellContentClick);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFiltro.Location = new System.Drawing.Point(369, 467);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 29;
            this.btnFiltro.Text = "Ler";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.BtnFiltro_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(364, 189);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(283, 189);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 27;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(202, 189);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 26;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(121, 189);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFiltro.Location = new System.Drawing.Point(11, 469);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(347, 20);
            this.txtFiltro.TabIndex = 24;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(364, 81);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(75, 20);
            this.txtEstoque.TabIndex = 23;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(133, 81);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(75, 20);
            this.txtPreco.TabIndex = 22;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(133, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(306, 20);
            this.txtNome.TabIndex = 21;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(133, 17);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(75, 20);
            this.txtCodigo.TabIndex = 20;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(239, 84);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(82, 13);
            this.lblEstoque.TabIndex = 19;
            this.lblEstoque.Text = "Estoque (Base):";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(8, 84);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 18;
            this.lblPreco.Text = "Preço:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(8, 52);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 17;
            this.lblNome.Text = "Nome:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(8, 20);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "Código:";
            // 
            // txtEstoqueMaximo
            // 
            this.txtEstoqueMaximo.Location = new System.Drawing.Point(364, 114);
            this.txtEstoqueMaximo.Name = "txtEstoqueMaximo";
            this.txtEstoqueMaximo.Size = new System.Drawing.Size(75, 20);
            this.txtEstoqueMaximo.TabIndex = 34;
            // 
            // txtEstoqueMinimo
            // 
            this.txtEstoqueMinimo.Location = new System.Drawing.Point(133, 114);
            this.txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            this.txtEstoqueMinimo.Size = new System.Drawing.Size(75, 20);
            this.txtEstoqueMinimo.TabIndex = 33;
            // 
            // lblEstoqueMaximo
            // 
            this.lblEstoqueMaximo.AutoSize = true;
            this.lblEstoqueMaximo.Location = new System.Drawing.Point(239, 117);
            this.lblEstoqueMaximo.Name = "lblEstoqueMaximo";
            this.lblEstoqueMaximo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEstoqueMaximo.Size = new System.Drawing.Size(88, 13);
            this.lblEstoqueMaximo.TabIndex = 32;
            this.lblEstoqueMaximo.Text = "Estoque Máximo:";
            // 
            // lblEstoqueMinimo
            // 
            this.lblEstoqueMinimo.AutoSize = true;
            this.lblEstoqueMinimo.Location = new System.Drawing.Point(8, 117);
            this.lblEstoqueMinimo.Name = "lblEstoqueMinimo";
            this.lblEstoqueMinimo.Size = new System.Drawing.Size(87, 13);
            this.lblEstoqueMinimo.TabIndex = 31;
            this.lblEstoqueMinimo.Text = "Estoque Minímo:";
            // 
            // txtEstoqueTotal
            // 
            this.txtEstoqueTotal.Enabled = false;
            this.txtEstoqueTotal.Location = new System.Drawing.Point(364, 149);
            this.txtEstoqueTotal.Name = "txtEstoqueTotal";
            this.txtEstoqueTotal.Size = new System.Drawing.Size(75, 20);
            this.txtEstoqueTotal.TabIndex = 37;
            // 
            // txtEstoqueSeguranca
            // 
            this.txtEstoqueSeguranca.Location = new System.Drawing.Point(133, 149);
            this.txtEstoqueSeguranca.Name = "txtEstoqueSeguranca";
            this.txtEstoqueSeguranca.Size = new System.Drawing.Size(75, 20);
            this.txtEstoqueSeguranca.TabIndex = 36;
            // 
            // lblEstoqueSeguranca
            // 
            this.lblEstoqueSeguranca.AutoSize = true;
            this.lblEstoqueSeguranca.Location = new System.Drawing.Point(8, 152);
            this.lblEstoqueSeguranca.Name = "lblEstoqueSeguranca";
            this.lblEstoqueSeguranca.Size = new System.Drawing.Size(119, 13);
            this.lblEstoqueSeguranca.TabIndex = 35;
            this.lblEstoqueSeguranca.Text = "Estoque de Segurança:";
            // 
            // lblEstoqueTotal
            // 
            this.lblEstoqueTotal.AutoSize = true;
            this.lblEstoqueTotal.Location = new System.Drawing.Point(239, 152);
            this.lblEstoqueTotal.Name = "lblEstoqueTotal";
            this.lblEstoqueTotal.Size = new System.Drawing.Size(76, 13);
            this.lblEstoqueTotal.TabIndex = 38;
            this.lblEstoqueTotal.Text = "Estoque Total:";
            // 
            // ProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 502);
            this.Controls.Add(this.lblEstoqueTotal);
            this.Controls.Add(this.txtEstoqueTotal);
            this.Controls.Add(this.txtEstoqueSeguranca);
            this.Controls.Add(this.lblEstoqueSeguranca);
            this.Controls.Add(this.txtEstoqueMaximo);
            this.Controls.Add(this.txtEstoqueMinimo);
            this.Controls.Add(this.lblEstoqueMaximo);
            this.Controls.Add(this.lblEstoqueMinimo);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProdutosForm";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.ProdutosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtEstoqueMaximo;
        private System.Windows.Forms.TextBox txtEstoqueMinimo;
        private System.Windows.Forms.Label lblEstoqueMaximo;
        private System.Windows.Forms.Label lblEstoqueMinimo;
        private System.Windows.Forms.TextBox txtEstoqueTotal;
        private System.Windows.Forms.TextBox txtEstoqueSeguranca;
        private System.Windows.Forms.Label lblEstoqueSeguranca;
        private System.Windows.Forms.Label lblEstoqueTotal;
    }
}