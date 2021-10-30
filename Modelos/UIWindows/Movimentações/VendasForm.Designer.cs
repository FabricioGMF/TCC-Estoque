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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.txtTotalProduto = new System.Windows.Forms.TextBox();
            this.lblTotalProduto = new System.Windows.Forms.Label();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.grpVenda = new System.Windows.Forms.GroupBox();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.lblNumVenda = new System.Windows.Forms.Label();
            this.txtNumVenda = new System.Windows.Forms.TextBox();
            this.grpItens = new System.Windows.Forms.GroupBox();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.lblDataVenda = new System.Windows.Forms.Label();
            this.grpVenda.SuspendLayout();
            this.grpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
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
            this.lblDescricaoProduto.Location = new System.Drawing.Point(111, 16);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(47, 13);
            this.lblDescricaoProduto.TabIndex = 1;
            this.lblDescricaoProduto.Text = "Produto:";
            this.lblDescricaoProduto.Visible = false;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(477, 16);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(480, 32);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(75, 20);
            this.txtQuantidade.TabIndex = 5;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(607, 426);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(165, 23);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "Realizar a Venda";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // cbxCliente
            // 
            this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(219, 18);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(323, 21);
            this.cbxCliente.TabIndex = 7;
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.CbxCliente_SelectedIndexChanged);
            // 
            // txtTotalProduto
            // 
            this.txtTotalProduto.Enabled = false;
            this.txtTotalProduto.Location = new System.Drawing.Point(642, 32);
            this.txtTotalProduto.Name = "txtTotalProduto";
            this.txtTotalProduto.Size = new System.Drawing.Size(76, 20);
            this.txtTotalProduto.TabIndex = 9;
            this.txtTotalProduto.TextChanged += new System.EventHandler(this.txtTotalProduto_TextChanged);
            // 
            // lblTotalProduto
            // 
            this.lblTotalProduto.AutoSize = true;
            this.lblTotalProduto.Location = new System.Drawing.Point(639, 16);
            this.lblTotalProduto.Name = "lblTotalProduto";
            this.lblTotalProduto.Size = new System.Drawing.Size(57, 13);
            this.lblTotalProduto.TabIndex = 8;
            this.lblTotalProduto.Text = "Total Item:";
            this.lblTotalProduto.Click += new System.EventHandler(this.lblTotalProduto_Click);
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Enabled = false;
            this.txtPrecoUnitario.Location = new System.Drawing.Point(561, 32);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(75, 20);
            this.txtPrecoUnitario.TabIndex = 11;
            this.txtPrecoUnitario.Visible = false;
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Location = new System.Drawing.Point(558, 16);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(77, 13);
            this.lblPrecoUnitario.TabIndex = 10;
            this.lblPrecoUnitario.Text = "Preço Unitário:";
            this.lblPrecoUnitario.Visible = false;
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Enabled = false;
            this.txtDescricaoProduto.Location = new System.Drawing.Point(114, 32);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(360, 20);
            this.txtDescricaoProduto.TabIndex = 13;
            this.txtDescricaoProduto.Visible = false;
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
            this.txtNumVenda.Visible = false;
            // 
            // grpItens
            // 
            this.grpItens.Controls.Add(this.btnExcluirItem);
            this.grpItens.Controls.Add(this.btnAdicionarItem);
            this.grpItens.Controls.Add(this.txtTotalVenda);
            this.grpItens.Controls.Add(this.lblTotalVenda);
            this.grpItens.Controls.Add(this.btnBuscarProduto);
            this.grpItens.Controls.Add(this.lblCodigo);
            this.grpItens.Controls.Add(this.txtCodigo);
            this.grpItens.Controls.Add(this.lblPrecoUnitario);
            this.grpItens.Controls.Add(this.lblQuantidade);
            this.grpItens.Controls.Add(this.txtQuantidade);
            this.grpItens.Controls.Add(this.txtPrecoUnitario);
            this.grpItens.Controls.Add(this.txtDescricaoProduto);
            this.grpItens.Controls.Add(this.txtTotalProduto);
            this.grpItens.Controls.Add(this.lblTotalProduto);
            this.grpItens.Controls.Add(this.dgvItem);
            this.grpItens.Controls.Add(this.lblDescricaoProduto);
            this.grpItens.Location = new System.Drawing.Point(12, 69);
            this.grpItens.Name = "grpItens";
            this.grpItens.Size = new System.Drawing.Size(760, 351);
            this.grpItens.TabIndex = 16;
            this.grpItens.TabStop = false;
            this.grpItens.Text = "Itens";
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Location = new System.Drawing.Point(724, 88);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(30, 23);
            this.btnExcluirItem.TabIndex = 28;
            this.btnExcluirItem.Text = "x";
            this.btnExcluirItem.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(724, 59);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(30, 23);
            this.btnAdicionarItem.TabIndex = 27;
            this.btnAdicionarItem.Text = "+";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Enabled = false;
            this.txtTotalVenda.Location = new System.Drawing.Point(642, 325);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(76, 20);
            this.txtTotalVenda.TabIndex = 26;
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.AutoSize = true;
            this.lblTotalVenda.Location = new System.Drawing.Point(579, 328);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(57, 13);
            this.lblTotalVenda.TabIndex = 25;
            this.lblTotalVenda.Text = "Total Item:";
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Location = new System.Drawing.Point(78, 30);
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
            this.txtCodigo.Size = new System.Drawing.Size(66, 20);
            this.txtCodigo.TabIndex = 21;
            this.txtCodigo.Visible = false;
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(6, 59);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Size = new System.Drawing.Size(712, 260);
            this.dgvItem.TabIndex = 23;
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
            // VendasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.grpItens);
            this.Controls.Add(this.grpVenda);
            this.Controls.Add(this.btnIncluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VendasForm";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.VendasForm_Load);
            this.grpVenda.ResumeLayout(false);
            this.grpVenda.PerformLayout();
            this.grpItens.ResumeLayout(false);
            this.grpItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.TextBox txtTotalProduto;
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
    }
}