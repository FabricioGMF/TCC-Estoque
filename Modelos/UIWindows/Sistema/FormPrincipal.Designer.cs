namespace UIWindows
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.tsmiSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSisBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSisSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mstMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMovimentações = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMovVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRelClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRelProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRelVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosEmFaltaToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRelProdEmFalta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAjuExibirAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAjuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.sstVersão = new System.Windows.Forms.StatusStrip();
            this.tsslVersaoPrograma = new System.Windows.Forms.ToolStripStatusLabel();
            this.mstMenu.SuspendLayout();
            this.sstVersão.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsmiSistema
            // 
            this.tsmiSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSisBackup,
            this.toolStripMenuItem3,
            this.tsmiSisSair});
            this.tsmiSistema.Name = "tsmiSistema";
            this.tsmiSistema.Size = new System.Drawing.Size(60, 20);
            this.tsmiSistema.Text = "&Sistema";
            // 
            // tsmiSisBackup
            // 
            this.tsmiSisBackup.Name = "tsmiSisBackup";
            this.tsmiSisBackup.Size = new System.Drawing.Size(189, 22);
            this.tsmiSisBackup.Text = "Backup e Restauração";
            this.tsmiSisBackup.Click += new System.EventHandler(this.TsmiSisBackup_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(186, 6);
            // 
            // tsmiSisSair
            // 
            this.tsmiSisSair.Name = "tsmiSisSair";
            this.tsmiSisSair.Size = new System.Drawing.Size(189, 22);
            this.tsmiSisSair.Text = "Sair";
            this.tsmiSisSair.Click += new System.EventHandler(this.TsmiSisSair_Click);
            // 
            // mstMenu
            // 
            this.mstMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSistema,
            this.tsmiCadastros,
            this.tsmiMovimentações,
            this.tsmiRelatorios,
            this.tsmiAjuda});
            this.mstMenu.Location = new System.Drawing.Point(0, 0);
            this.mstMenu.Name = "mstMenu";
            this.mstMenu.Size = new System.Drawing.Size(1008, 24);
            this.mstMenu.TabIndex = 0;
            this.mstMenu.Text = "menuStrip1";
            // 
            // tsmiCadastros
            // 
            this.tsmiCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadClientes,
            this.tsmiCadProdutos});
            this.tsmiCadastros.Name = "tsmiCadastros";
            this.tsmiCadastros.Size = new System.Drawing.Size(71, 20);
            this.tsmiCadastros.Text = "&Cadastros";
            // 
            // tsmiCadClientes
            // 
            this.tsmiCadClientes.Name = "tsmiCadClientes";
            this.tsmiCadClientes.Size = new System.Drawing.Size(122, 22);
            this.tsmiCadClientes.Text = "Clientes";
            this.tsmiCadClientes.Click += new System.EventHandler(this.TsmiCadClientes_Click);
            // 
            // tsmiCadProdutos
            // 
            this.tsmiCadProdutos.Name = "tsmiCadProdutos";
            this.tsmiCadProdutos.Size = new System.Drawing.Size(122, 22);
            this.tsmiCadProdutos.Text = "Produtos";
            this.tsmiCadProdutos.Click += new System.EventHandler(this.TsmiCadProdutos_Click);
            // 
            // tsmiMovimentações
            // 
            this.tsmiMovimentações.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMovVendas});
            this.tsmiMovimentações.Name = "tsmiMovimentações";
            this.tsmiMovimentações.Size = new System.Drawing.Size(104, 20);
            this.tsmiMovimentações.Text = "&Movimentações";
            // 
            // tsmiMovVendas
            // 
            this.tsmiMovVendas.Name = "tsmiMovVendas";
            this.tsmiMovVendas.Size = new System.Drawing.Size(111, 22);
            this.tsmiMovVendas.Text = "Vendas";
            this.tsmiMovVendas.Click += new System.EventHandler(this.TsmiMovVendas_Click);
            // 
            // tsmiRelatorios
            // 
            this.tsmiRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRelClientes,
            this.tsmiRelProdutos,
            this.tsmiRelVendas,
            this.produtosEmFaltaToolStripMenuItem1,
            this.tsmiRelProdEmFalta});
            this.tsmiRelatorios.Name = "tsmiRelatorios";
            this.tsmiRelatorios.Size = new System.Drawing.Size(71, 20);
            this.tsmiRelatorios.Text = "&Relatórios";
            // 
            // tsmiRelClientes
            // 
            this.tsmiRelClientes.Name = "tsmiRelClientes";
            this.tsmiRelClientes.Size = new System.Drawing.Size(170, 22);
            this.tsmiRelClientes.Text = "Clientes";
            this.tsmiRelClientes.Click += new System.EventHandler(this.TsmiRelClientes_Click);
            // 
            // tsmiRelProdutos
            // 
            this.tsmiRelProdutos.Name = "tsmiRelProdutos";
            this.tsmiRelProdutos.Size = new System.Drawing.Size(170, 22);
            this.tsmiRelProdutos.Text = "Produtos";
            this.tsmiRelProdutos.Click += new System.EventHandler(this.TsmiRelProdutos_Click);
            // 
            // tsmiRelVendas
            // 
            this.tsmiRelVendas.Name = "tsmiRelVendas";
            this.tsmiRelVendas.Size = new System.Drawing.Size(170, 22);
            this.tsmiRelVendas.Text = "Vendas";
            this.tsmiRelVendas.Click += new System.EventHandler(this.TsmiRelVendas_Click);
            // 
            // produtosEmFaltaToolStripMenuItem1
            // 
            this.produtosEmFaltaToolStripMenuItem1.Name = "produtosEmFaltaToolStripMenuItem1";
            this.produtosEmFaltaToolStripMenuItem1.Size = new System.Drawing.Size(167, 6);
            // 
            // tsmiRelProdEmFalta
            // 
            this.tsmiRelProdEmFalta.Name = "tsmiRelProdEmFalta";
            this.tsmiRelProdEmFalta.Size = new System.Drawing.Size(170, 22);
            this.tsmiRelProdEmFalta.Text = "Produtos em Falta";
            this.tsmiRelProdEmFalta.Click += new System.EventHandler(this.TsmiRelProdEmFalta_Click);
            // 
            // tsmiAjuda
            // 
            this.tsmiAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAjuExibirAjuda,
            this.toolStripMenuItem1,
            this.tsmiAjuSobre});
            this.tsmiAjuda.Name = "tsmiAjuda";
            this.tsmiAjuda.Size = new System.Drawing.Size(50, 20);
            this.tsmiAjuda.Text = "&Ajuda";
            // 
            // tsmiAjuExibirAjuda
            // 
            this.tsmiAjuExibirAjuda.Name = "tsmiAjuExibirAjuda";
            this.tsmiAjuExibirAjuda.Size = new System.Drawing.Size(158, 22);
            this.tsmiAjuExibirAjuda.Text = "Exibir Ajuda";
            this.tsmiAjuExibirAjuda.Click += new System.EventHandler(this.TsmiAjuExibirAjuda_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 6);
            // 
            // tsmiAjuSobre
            // 
            this.tsmiAjuSobre.Name = "tsmiAjuSobre";
            this.tsmiAjuSobre.Size = new System.Drawing.Size(158, 22);
            this.tsmiAjuSobre.Text = "Sobre o Sistema";
            this.tsmiAjuSobre.Click += new System.EventHandler(this.TsmiAjuSobre_Click);
            // 
            // sstVersão
            // 
            this.sstVersão.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sstVersão.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersaoPrograma});
            this.sstVersão.Location = new System.Drawing.Point(0, 539);
            this.sstVersão.Name = "sstVersão";
            this.sstVersão.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.sstVersão.Size = new System.Drawing.Size(1008, 22);
            this.sstVersão.TabIndex = 2;
            // 
            // tsslVersaoPrograma
            // 
            this.tsslVersaoPrograma.Name = "tsslVersaoPrograma";
            this.tsslVersaoPrograma.Size = new System.Drawing.Size(77, 17);
            this.tsslVersaoPrograma.Text = "Versão 2021.0";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.sstVersão);
            this.Controls.Add(this.mstMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstMenu;
            this.Name = "FormPrincipal";
            this.Text = "Controle de Estoque";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.mstMenu.ResumeLayout(false);
            this.mstMenu.PerformLayout();
            this.sstVersão.ResumeLayout(false);
            this.sstVersão.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tsmiSistema;
        private System.Windows.Forms.ToolStripMenuItem tsmiSisBackup;
        private System.Windows.Forms.ToolStripMenuItem tsmiSisSair;
        private System.Windows.Forms.MenuStrip mstMenu;
        private System.Windows.Forms.StatusStrip sstVersão;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersaoPrograma;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastros;
        private System.Windows.Forms.ToolStripMenuItem tsmiMovimentações;
        private System.Windows.Forms.ToolStripMenuItem tsmiRelatorios;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadProdutos;
        private System.Windows.Forms.ToolStripMenuItem tsmiMovVendas;
        private System.Windows.Forms.ToolStripMenuItem tsmiRelClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiRelProdutos;
        private System.Windows.Forms.ToolStripMenuItem tsmiRelVendas;
        private System.Windows.Forms.ToolStripSeparator produtosEmFaltaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRelProdEmFalta;
        private System.Windows.Forms.ToolStripMenuItem tsmiAjuda;
        private System.Windows.Forms.ToolStripMenuItem tsmiAjuExibirAjuda;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAjuSobre;
    }
}

