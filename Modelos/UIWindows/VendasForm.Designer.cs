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
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.txtFaturado = new System.Windows.Forms.TextBox();
            this.lblFaturado = new System.Windows.Forms.Label();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.dgvProdutoVenda = new System.Windows.Forms.DataGridView();
            this.txtNomeProdVenda = new System.Windows.Forms.TextBox();
            this.lblSelecionaProduto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(9, 14);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(234, 14);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(9, 257);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(94, 254);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(75, 20);
            this.txtQuantidade.TabIndex = 5;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(273, 291);
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
            this.cbxCliente.Location = new System.Drawing.Point(57, 11);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(146, 21);
            this.cbxCliente.TabIndex = 7;
            // 
            // txtFaturado
            // 
            this.txtFaturado.Enabled = false;
            this.txtFaturado.Location = new System.Drawing.Point(94, 292);
            this.txtFaturado.Name = "txtFaturado";
            this.txtFaturado.Size = new System.Drawing.Size(75, 20);
            this.txtFaturado.TabIndex = 9;
            // 
            // lblFaturado
            // 
            this.lblFaturado.AutoSize = true;
            this.lblFaturado.Location = new System.Drawing.Point(9, 295);
            this.lblFaturado.Name = "lblFaturado";
            this.lblFaturado.Size = new System.Drawing.Size(79, 13);
            this.lblFaturado.TabIndex = 8;
            this.lblFaturado.Text = "Total Faturado:";
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Enabled = false;
            this.txtPrecoUnitario.Location = new System.Drawing.Point(363, 254);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(75, 20);
            this.txtPrecoUnitario.TabIndex = 11;
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Location = new System.Drawing.Point(270, 257);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(77, 13);
            this.lblPrecoUnitario.TabIndex = 10;
            this.lblPrecoUnitario.Text = "Preço Unitário:";
            // 
            // dgvProdutoVenda
            // 
            this.dgvProdutoVenda.AllowUserToAddRows = false;
            this.dgvProdutoVenda.AllowUserToDeleteRows = false;
            this.dgvProdutoVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutoVenda.Location = new System.Drawing.Point(12, 65);
            this.dgvProdutoVenda.Name = "dgvProdutoVenda";
            this.dgvProdutoVenda.ReadOnly = true;
            this.dgvProdutoVenda.Size = new System.Drawing.Size(426, 183);
            this.dgvProdutoVenda.TabIndex = 12;
            this.dgvProdutoVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutoVenda_CellContentClick);
            // 
            // txtNomeProdVenda
            // 
            this.txtNomeProdVenda.Enabled = false;
            this.txtNomeProdVenda.Location = new System.Drawing.Point(287, 12);
            this.txtNomeProdVenda.Name = "txtNomeProdVenda";
            this.txtNomeProdVenda.Size = new System.Drawing.Size(151, 20);
            this.txtNomeProdVenda.TabIndex = 13;
            // 
            // lblSelecionaProduto
            // 
            this.lblSelecionaProduto.AutoSize = true;
            this.lblSelecionaProduto.Location = new System.Drawing.Point(12, 49);
            this.lblSelecionaProduto.Name = "lblSelecionaProduto";
            this.lblSelecionaProduto.Size = new System.Drawing.Size(106, 13);
            this.lblSelecionaProduto.TabIndex = 14;
            this.lblSelecionaProduto.Text = "Selecione o Produto:";
            // 
            // VendasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 326);
            this.Controls.Add(this.lblSelecionaProduto);
            this.Controls.Add(this.txtNomeProdVenda);
            this.Controls.Add(this.dgvProdutoVenda);
            this.Controls.Add(this.txtPrecoUnitario);
            this.Controls.Add(this.lblPrecoUnitario);
            this.Controls.Add(this.txtFaturado);
            this.Controls.Add(this.lblFaturado);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VendasForm";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.VendasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.TextBox txtFaturado;
        private System.Windows.Forms.Label lblFaturado;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.DataGridView dgvProdutoVenda;
        private System.Windows.Forms.TextBox txtNomeProdVenda;
        private System.Windows.Forms.Label lblSelecionaProduto;
    }
}