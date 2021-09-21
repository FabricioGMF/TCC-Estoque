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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosEmFaltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstMenu = new System.Windows.Forms.MenuStrip();
            this.sstVersão = new System.Windows.Forms.StatusStrip();
            this.tsslVersaoPrograma = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mstMenu.SuspendLayout();
            this.sstVersão.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.toolStripMenuItem2,
            this.produtosEmFaltaToolStripMenuItem,
            this.toolStripMenuItem3,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.ProdutosToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.VendasToolStripMenuItem_Click);
            // 
            // produtosEmFaltaToolStripMenuItem
            // 
            this.produtosEmFaltaToolStripMenuItem.Name = "produtosEmFaltaToolStripMenuItem";
            this.produtosEmFaltaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosEmFaltaToolStripMenuItem.Text = "Produtos em Falta";
            this.produtosEmFaltaToolStripMenuItem.Click += new System.EventHandler(this.ProdutosEmFaltaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // mstMenu
            // 
            this.mstMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.mstMenu.Location = new System.Drawing.Point(0, 0);
            this.mstMenu.Name = "mstMenu";
            this.mstMenu.Size = new System.Drawing.Size(1008, 24);
            this.mstMenu.TabIndex = 0;
            this.mstMenu.Text = "menuStrip1";
            // 
            // sstVersão
            // 
            this.sstVersão.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sstVersão.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersaoPrograma});
            this.sstVersão.Location = new System.Drawing.Point(0, 540);
            this.sstVersão.Name = "sstVersão";
            this.sstVersão.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.sstVersão.Size = new System.Drawing.Size(1008, 22);
            this.sstVersão.TabIndex = 2;
            // 
            // tsslVersaoPrograma
            // 
            this.tsslVersaoPrograma.Name = "tsslVersaoPrograma";
            this.tsslVersaoPrograma.Size = new System.Drawing.Size(59, 17);
            this.tsslVersaoPrograma.Text = "Versão 2.0";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.sstVersão);
            this.Controls.Add(this.mstMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstMenu;
            this.Name = "FormPrincipal";
            this.Text = "Loja .Net";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.mstMenu.ResumeLayout(false);
            this.mstMenu.PerformLayout();
            this.sstVersão.ResumeLayout(false);
            this.sstVersão.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosEmFaltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mstMenu;
        private System.Windows.Forms.StatusStrip sstVersão;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersaoPrograma;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    }
}

