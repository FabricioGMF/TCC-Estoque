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
            this.components = new System.ComponentModel.Container();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblEstoqueMaximo = new System.Windows.Forms.Label();
            this.lblEstoqueMinimo = new System.Windows.Forms.Label();
            this.txtEstoqueSeguranca = new System.Windows.Forms.TextBox();
            this.lblEstoqueSeguranca = new System.Windows.Forms.Label();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.errValorCompra = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDescricao = new System.Windows.Forms.ErrorProvider(this.components);
            this.errEstoque = new System.Windows.Forms.ErrorProvider(this.components);
            this.errValorVenda = new System.Windows.Forms.ErrorProvider(this.components);
            this.errEstoqueMinimo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errEstoqueMaximo = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.numValorCompra = new System.Windows.Forms.NumericUpDown();
            this.numEstoque = new System.Windows.Forms.NumericUpDown();
            this.numValorVenda = new System.Windows.Forms.NumericUpDown();
            this.numEstoqueMinimo = new System.Windows.Forms.NumericUpDown();
            this.numEstoqueMaximo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errValorCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDescricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errValorVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEstoqueMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEstoqueMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoqueMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoqueMaximo)).BeginInit();
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
            this.dgvProdutos.Location = new System.Drawing.Point(11, 182);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(433, 262);
            this.dgvProdutos.TabIndex = 30;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellClick);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFiltro.Location = new System.Drawing.Point(369, 450);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 29;
            this.btnFiltro.Text = "Ler";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.BtnFiltro_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(364, 153);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(283, 153);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 27;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(202, 153);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 26;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(121, 153);
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
            this.txtFiltro.Location = new System.Drawing.Point(11, 452);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(347, 20);
            this.txtFiltro.TabIndex = 24;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(133, 43);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(306, 20);
            this.txtDescricao.TabIndex = 21;
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
            this.lblEstoque.Location = new System.Drawing.Point(8, 98);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(56, 13);
            this.lblEstoque.TabIndex = 19;
            this.lblEstoque.Text = "* Estoque:";
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Location = new System.Drawing.Point(239, 72);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(75, 13);
            this.lblValorVenda.TabIndex = 18;
            this.lblValorVenda.Text = "* Valor Venda:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(8, 46);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(65, 13);
            this.lblDescricao.TabIndex = 17;
            this.lblDescricao.Text = "* Descrição:";
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
            // lblEstoqueMaximo
            // 
            this.lblEstoqueMaximo.AutoSize = true;
            this.lblEstoqueMaximo.Location = new System.Drawing.Point(239, 124);
            this.lblEstoqueMaximo.Name = "lblEstoqueMaximo";
            this.lblEstoqueMaximo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEstoqueMaximo.Size = new System.Drawing.Size(95, 13);
            this.lblEstoqueMaximo.TabIndex = 32;
            this.lblEstoqueMaximo.Text = "* Estoque Máximo:";
            // 
            // lblEstoqueMinimo
            // 
            this.lblEstoqueMinimo.AutoSize = true;
            this.lblEstoqueMinimo.Location = new System.Drawing.Point(239, 98);
            this.lblEstoqueMinimo.Name = "lblEstoqueMinimo";
            this.lblEstoqueMinimo.Size = new System.Drawing.Size(94, 13);
            this.lblEstoqueMinimo.TabIndex = 31;
            this.lblEstoqueMinimo.Text = "* Estoque Minímo:";
            // 
            // txtEstoqueSeguranca
            // 
            this.txtEstoqueSeguranca.Enabled = false;
            this.txtEstoqueSeguranca.Location = new System.Drawing.Point(133, 121);
            this.txtEstoqueSeguranca.Name = "txtEstoqueSeguranca";
            this.txtEstoqueSeguranca.Size = new System.Drawing.Size(75, 20);
            this.txtEstoqueSeguranca.TabIndex = 36;
            // 
            // lblEstoqueSeguranca
            // 
            this.lblEstoqueSeguranca.AutoSize = true;
            this.lblEstoqueSeguranca.Location = new System.Drawing.Point(8, 124);
            this.lblEstoqueSeguranca.Name = "lblEstoqueSeguranca";
            this.lblEstoqueSeguranca.Size = new System.Drawing.Size(119, 13);
            this.lblEstoqueSeguranca.TabIndex = 35;
            this.lblEstoqueSeguranca.Text = "Estoque de Segurança:";
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Location = new System.Drawing.Point(8, 72);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(80, 13);
            this.lblValorCompra.TabIndex = 37;
            this.lblValorCompra.Text = "* Valor Compra:";
            // 
            // errValorCompra
            // 
            this.errValorCompra.ContainerControl = this;
            this.errValorCompra.RightToLeft = true;
            // 
            // errDescricao
            // 
            this.errDescricao.ContainerControl = this;
            this.errDescricao.RightToLeft = true;
            // 
            // errEstoque
            // 
            this.errEstoque.ContainerControl = this;
            this.errEstoque.RightToLeft = true;
            // 
            // errValorVenda
            // 
            this.errValorVenda.ContainerControl = this;
            this.errValorVenda.RightToLeft = true;
            // 
            // errEstoqueMinimo
            // 
            this.errEstoqueMinimo.ContainerControl = this;
            this.errEstoqueMinimo.RightToLeft = true;
            // 
            // errEstoqueMaximo
            // 
            this.errEstoqueMaximo.ContainerControl = this;
            this.errEstoqueMaximo.RightToLeft = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "* - Campos Obrigatórios.";
            // 
            // numValorCompra
            // 
            this.numValorCompra.DecimalPlaces = 2;
            this.numValorCompra.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numValorCompra.Location = new System.Drawing.Point(133, 69);
            this.numValorCompra.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numValorCompra.Name = "numValorCompra";
            this.numValorCompra.Size = new System.Drawing.Size(75, 20);
            this.numValorCompra.TabIndex = 40;
            // 
            // numEstoque
            // 
            this.numEstoque.Location = new System.Drawing.Point(133, 95);
            this.numEstoque.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numEstoque.Name = "numEstoque";
            this.numEstoque.Size = new System.Drawing.Size(75, 20);
            this.numEstoque.TabIndex = 41;
            // 
            // numValorVenda
            // 
            this.numValorVenda.DecimalPlaces = 2;
            this.numValorVenda.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numValorVenda.Location = new System.Drawing.Point(364, 69);
            this.numValorVenda.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numValorVenda.Name = "numValorVenda";
            this.numValorVenda.Size = new System.Drawing.Size(75, 20);
            this.numValorVenda.TabIndex = 42;
            // 
            // numEstoqueMinimo
            // 
            this.numEstoqueMinimo.Location = new System.Drawing.Point(364, 95);
            this.numEstoqueMinimo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numEstoqueMinimo.Name = "numEstoqueMinimo";
            this.numEstoqueMinimo.Size = new System.Drawing.Size(75, 20);
            this.numEstoqueMinimo.TabIndex = 43;
            // 
            // numEstoqueMaximo
            // 
            this.numEstoqueMaximo.Location = new System.Drawing.Point(364, 121);
            this.numEstoqueMaximo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numEstoqueMaximo.Name = "numEstoqueMaximo";
            this.numEstoqueMaximo.Size = new System.Drawing.Size(75, 20);
            this.numEstoqueMaximo.TabIndex = 44;
            // 
            // ProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(452, 502);
            this.Controls.Add(this.numEstoqueMaximo);
            this.Controls.Add(this.numEstoqueMinimo);
            this.Controls.Add(this.numValorVenda);
            this.Controls.Add(this.numEstoque);
            this.Controls.Add(this.numValorCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValorCompra);
            this.Controls.Add(this.txtEstoqueSeguranca);
            this.Controls.Add(this.lblEstoqueSeguranca);
            this.Controls.Add(this.lblEstoqueMaximo);
            this.Controls.Add(this.lblEstoqueMinimo);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblValorVenda);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProdutosForm";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.ProdutosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errValorCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDescricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errValorVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEstoqueMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEstoqueMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoqueMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoqueMaximo)).EndInit();
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
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEstoqueMaximo;
        private System.Windows.Forms.Label lblEstoqueMinimo;
        private System.Windows.Forms.TextBox txtEstoqueSeguranca;
        private System.Windows.Forms.Label lblEstoqueSeguranca;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.ErrorProvider errValorCompra;
        private System.Windows.Forms.ErrorProvider errDescricao;
        private System.Windows.Forms.ErrorProvider errEstoque;
        private System.Windows.Forms.ErrorProvider errValorVenda;
        private System.Windows.Forms.ErrorProvider errEstoqueMinimo;
        private System.Windows.Forms.ErrorProvider errEstoqueMaximo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numValorCompra;
        private System.Windows.Forms.NumericUpDown numEstoqueMaximo;
        private System.Windows.Forms.NumericUpDown numEstoqueMinimo;
        private System.Windows.Forms.NumericUpDown numValorVenda;
        private System.Windows.Forms.NumericUpDown numEstoque;
    }
}