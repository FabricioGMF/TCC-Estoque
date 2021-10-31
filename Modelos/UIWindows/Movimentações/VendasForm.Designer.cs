namespace UIWindows
{
    partial class VendasForm
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnRealizarVenda = new System.Windows.Forms.Button();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.txtTotalItem = new System.Windows.Forms.TextBox();
            this.lblTotalProduto = new System.Windows.Forms.Label();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.grpVenda = new System.Windows.Forms.GroupBox();
            this.lblDataVenda = new System.Windows.Forms.Label();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.lblNumVenda = new System.Windows.Forms.Label();
            this.txtNumVenda = new System.Windows.Forms.TextBox();
            this.grpItens = new System.Windows.Forms.GroupBox();
            this.btnAlterarItem = new System.Windows.Forms.Button();
            this.numQtdItem = new System.Windows.Forms.NumericUpDown();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.tipItem = new System.Windows.Forms.ToolTip(this.components);
            this.grpSelecionarProduto = new System.Windows.Forms.GroupBox();
            this.dgvProdutosBusca = new System.Windows.Forms.DataGridView();
            this.lblPesquisaProduto = new System.Windows.Forms.Label();
            this.txtPesquisarProduto = new System.Windows.Forms.TextBox();
            this.grpVenda.SuspendLayout();
            this.grpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.grpSelecionarProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosBusca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(171, 21);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.AutoSize = true;
            this.lblDescricaoProduto.Location = new System.Drawing.Point(105, 16);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(47, 13);
            this.lblDescricaoProduto.TabIndex = 1;
            this.lblDescricaoProduto.Text = "Produto:";
            this.lblDescricaoProduto.Visible = false;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(283, 16);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // btnRealizarVenda
            // 
            this.btnRealizarVenda.Location = new System.Drawing.Point(607, 426);
            this.btnRealizarVenda.Name = "btnRealizarVenda";
            this.btnRealizarVenda.Size = new System.Drawing.Size(165, 23);
            this.btnRealizarVenda.TabIndex = 6;
            this.btnRealizarVenda.Text = "Realizar a Venda";
            this.btnRealizarVenda.UseVisualStyleBackColor = true;
            this.btnRealizarVenda.Click += new System.EventHandler(this.BtnRealizarVenda_Click);
            // 
            // cbxCliente
            // 
            this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(219, 18);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(323, 21);
            this.cbxCliente.TabIndex = 7;
            // 
            // txtTotalItem
            // 
            this.txtTotalItem.Enabled = false;
            this.txtTotalItem.Location = new System.Drawing.Point(438, 32);
            this.txtTotalItem.Name = "txtTotalItem";
            this.txtTotalItem.Size = new System.Drawing.Size(70, 20);
            this.txtTotalItem.TabIndex = 9;
            // 
            // lblTotalProduto
            // 
            this.lblTotalProduto.AutoSize = true;
            this.lblTotalProduto.Location = new System.Drawing.Point(435, 16);
            this.lblTotalProduto.Name = "lblTotalProduto";
            this.lblTotalProduto.Size = new System.Drawing.Size(57, 13);
            this.lblTotalProduto.TabIndex = 8;
            this.lblTotalProduto.Text = "Total Item:";
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Enabled = false;
            this.txtPrecoUnitario.Location = new System.Drawing.Point(362, 32);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(70, 20);
            this.txtPrecoUnitario.TabIndex = 11;
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Location = new System.Drawing.Point(359, 16);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(61, 13);
            this.lblPrecoUnitario.TabIndex = 10;
            this.lblPrecoUnitario.Text = "Preço Item:";
            this.lblPrecoUnitario.Visible = false;
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Enabled = false;
            this.txtDescricaoProduto.Location = new System.Drawing.Point(108, 32);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(172, 20);
            this.txtDescricaoProduto.TabIndex = 13;
            // 
            // grpVenda
            // 
            this.grpVenda.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grpVenda.Controls.Add(this.lblDataVenda);
            this.grpVenda.Controls.Add(this.dtpDataVenda);
            this.grpVenda.Controls.Add(this.lblNumVenda);
            this.grpVenda.Controls.Add(this.txtNumVenda);
            this.grpVenda.Controls.Add(this.lblCliente);
            this.grpVenda.Controls.Add(this.cbxCliente);
            this.grpVenda.Location = new System.Drawing.Point(12, 12);
            this.grpVenda.Name = "grpVenda";
            this.grpVenda.Size = new System.Drawing.Size(760, 51);
            this.grpVenda.TabIndex = 15;
            this.grpVenda.TabStop = false;
            this.grpVenda.Text = "Venda";
            // 
            // lblDataVenda
            // 
            this.lblDataVenda.AutoSize = true;
            this.lblDataVenda.Location = new System.Drawing.Point(619, 21);
            this.lblDataVenda.Name = "lblDataVenda";
            this.lblDataVenda.Size = new System.Drawing.Size(33, 13);
            this.lblDataVenda.TabIndex = 20;
            this.lblDataVenda.Text = "Data:";
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenda.Location = new System.Drawing.Point(658, 19);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(96, 20);
            this.dtpDataVenda.TabIndex = 19;
            // 
            // lblNumVenda
            // 
            this.lblNumVenda.AutoSize = true;
            this.lblNumVenda.Location = new System.Drawing.Point(11, 21);
            this.lblNumVenda.Name = "lblNumVenda";
            this.lblNumVenda.Size = new System.Drawing.Size(19, 13);
            this.lblNumVenda.TabIndex = 18;
            this.lblNumVenda.Text = "Nº";
            // 
            // txtNumVenda
            // 
            this.txtNumVenda.Enabled = false;
            this.txtNumVenda.Location = new System.Drawing.Point(36, 19);
            this.txtNumVenda.Name = "txtNumVenda";
            this.txtNumVenda.Size = new System.Drawing.Size(66, 20);
            this.txtNumVenda.TabIndex = 17;
            // 
            // grpItens
            // 
            this.grpItens.Controls.Add(this.btnAlterarItem);
            this.grpItens.Controls.Add(this.numQtdItem);
            this.grpItens.Controls.Add(this.btnExcluirItem);
            this.grpItens.Controls.Add(this.btnAdicionarItem);
            this.grpItens.Controls.Add(this.txtTotalVenda);
            this.grpItens.Controls.Add(this.lblTotalVenda);
            this.grpItens.Controls.Add(this.btnBuscarProduto);
            this.grpItens.Controls.Add(this.lblCodigo);
            this.grpItens.Controls.Add(this.txtCodigo);
            this.grpItens.Controls.Add(this.lblPrecoUnitario);
            this.grpItens.Controls.Add(this.lblQuantidade);
            this.grpItens.Controls.Add(this.txtPrecoUnitario);
            this.grpItens.Controls.Add(this.txtDescricaoProduto);
            this.grpItens.Controls.Add(this.txtTotalItem);
            this.grpItens.Controls.Add(this.lblTotalProduto);
            this.grpItens.Controls.Add(this.dgvItem);
            this.grpItens.Controls.Add(this.lblDescricaoProduto);
            this.grpItens.Location = new System.Drawing.Point(258, 69);
            this.grpItens.Name = "grpItens";
            this.grpItens.Size = new System.Drawing.Size(514, 351);
            this.grpItens.TabIndex = 16;
            this.grpItens.TabStop = false;
            this.grpItens.Text = "Itens";
            // 
            // btnAlterarItem
            // 
            this.btnAlterarItem.Location = new System.Drawing.Point(478, 89);
            this.btnAlterarItem.Name = "btnAlterarItem";
            this.btnAlterarItem.Size = new System.Drawing.Size(30, 23);
            this.btnAlterarItem.TabIndex = 30;
            this.btnAlterarItem.Text = "M";
            this.tipItem.SetToolTip(this.btnAlterarItem, "Alterar Item");
            this.btnAlterarItem.UseVisualStyleBackColor = true;
            this.btnAlterarItem.Click += new System.EventHandler(this.BtnAlterarItem_Click);
            // 
            // numQtdItem
            // 
            this.numQtdItem.Location = new System.Drawing.Point(286, 32);
            this.numQtdItem.Name = "numQtdItem";
            this.numQtdItem.Size = new System.Drawing.Size(70, 20);
            this.numQtdItem.TabIndex = 29;
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Location = new System.Drawing.Point(478, 118);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(30, 23);
            this.btnExcluirItem.TabIndex = 28;
            this.btnExcluirItem.Text = "x";
            this.tipItem.SetToolTip(this.btnExcluirItem, "Excluir Item");
            this.btnExcluirItem.UseVisualStyleBackColor = true;
            this.btnExcluirItem.Click += new System.EventHandler(this.BtnExcluirItem_Click);
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(478, 60);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(30, 23);
            this.btnAdicionarItem.TabIndex = 27;
            this.btnAdicionarItem.Text = "+";
            this.tipItem.SetToolTip(this.btnAdicionarItem, "Adicionar Item");
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            this.btnAdicionarItem.Click += new System.EventHandler(this.BtnAdicionarItem_Click);
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Enabled = false;
            this.txtTotalVenda.Location = new System.Drawing.Point(432, 325);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(76, 20);
            this.txtTotalVenda.TabIndex = 26;
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.AutoSize = true;
            this.lblTotalVenda.Location = new System.Drawing.Point(358, 328);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(68, 13);
            this.lblTotalVenda.TabIndex = 25;
            this.lblTotalVenda.Text = "Total Venda:";
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Location = new System.Drawing.Point(72, 30);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(30, 23);
            this.btnBuscarProduto.TabIndex = 24;
            this.btnBuscarProduto.Text = "...";
            this.btnBuscarProduto.UseVisualStyleBackColor = true;
            this.btnBuscarProduto.Click += new System.EventHandler(this.BtnBuscarProduto_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 22;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(6, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(60, 20);
            this.txtCodigo.TabIndex = 21;
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(6, 60);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Size = new System.Drawing.Size(466, 259);
            this.dgvItem.TabIndex = 23;
            this.dgvItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvItem_CellClick);
            // 
            // grpSelecionarProduto
            // 
            this.grpSelecionarProduto.Controls.Add(this.dgvProdutosBusca);
            this.grpSelecionarProduto.Controls.Add(this.lblPesquisaProduto);
            this.grpSelecionarProduto.Controls.Add(this.txtPesquisarProduto);
            this.grpSelecionarProduto.Location = new System.Drawing.Point(12, 69);
            this.grpSelecionarProduto.Name = "grpSelecionarProduto";
            this.grpSelecionarProduto.Size = new System.Drawing.Size(240, 351);
            this.grpSelecionarProduto.TabIndex = 17;
            this.grpSelecionarProduto.TabStop = false;
            this.grpSelecionarProduto.Text = "Selecionar Produto";
            this.grpSelecionarProduto.Visible = false;
            // 
            // dgvProdutosBusca
            // 
            this.dgvProdutosBusca.AllowUserToAddRows = false;
            this.dgvProdutosBusca.AllowUserToDeleteRows = false;
            this.dgvProdutosBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutosBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosBusca.Location = new System.Drawing.Point(6, 60);
            this.dgvProdutosBusca.Name = "dgvProdutosBusca";
            this.dgvProdutosBusca.ReadOnly = true;
            this.dgvProdutosBusca.Size = new System.Drawing.Size(228, 284);
            this.dgvProdutosBusca.TabIndex = 36;
            this.dgvProdutosBusca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutosBusca_CellDoubleClick);
            // 
            // lblPesquisaProduto
            // 
            this.lblPesquisaProduto.AutoSize = true;
            this.lblPesquisaProduto.Location = new System.Drawing.Point(6, 18);
            this.lblPesquisaProduto.Name = "lblPesquisaProduto";
            this.lblPesquisaProduto.Size = new System.Drawing.Size(170, 13);
            this.lblPesquisaProduto.TabIndex = 34;
            this.lblPesquisaProduto.Text = "Digite a Descrição para Pesquisar:";
            // 
            // txtPesquisarProduto
            // 
            this.txtPesquisarProduto.Location = new System.Drawing.Point(6, 34);
            this.txtPesquisarProduto.Name = "txtPesquisarProduto";
            this.txtPesquisarProduto.Size = new System.Drawing.Size(228, 20);
            this.txtPesquisarProduto.TabIndex = 33;
            this.txtPesquisarProduto.TextChanged += new System.EventHandler(this.TxtPesquisarProduto_TextChanged);
            // 
            // VendasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.grpSelecionarProduto);
            this.Controls.Add(this.grpItens);
            this.Controls.Add(this.grpVenda);
            this.Controls.Add(this.btnRealizarVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VendasForm";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.VendasForm_Load);
            this.grpVenda.ResumeLayout(false);
            this.grpVenda.PerformLayout();
            this.grpItens.ResumeLayout(false);
            this.grpItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.grpSelecionarProduto.ResumeLayout(false);
            this.grpSelecionarProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosBusca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Button btnRealizarVenda;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.TextBox txtTotalItem;
        private System.Windows.Forms.Label lblTotalProduto;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.GroupBox grpVenda;
        private System.Windows.Forms.Label lblNumVenda;
        private System.Windows.Forms.TextBox txtNumVenda;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.GroupBox grpItens;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label lblTotalVenda;
        private System.Windows.Forms.Label lblDataVenda;
        private System.Windows.Forms.NumericUpDown numQtdItem;
        private System.Windows.Forms.Button btnAlterarItem;
        private System.Windows.Forms.ToolTip tipItem;
        private System.Windows.Forms.GroupBox grpSelecionarProduto;
        private System.Windows.Forms.DataGridView dgvProdutosBusca;
        private System.Windows.Forms.Label lblPesquisaProduto;
        private System.Windows.Forms.TextBox txtPesquisarProduto;
    }
}