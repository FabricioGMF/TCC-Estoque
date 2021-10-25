namespace UIWindows
{
    partial class ClientesForm
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCPF_CNPJ = new System.Windows.Forms.Label();
            this.mskCPF_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.cmbCPF_CNPJ = new System.Windows.Forms.ComboBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.cmbUF = new System.Windows.Forms.ComboBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 44);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(106, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome/Razão Social:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(351, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelefone1
            // 
            this.lblTelefone1.AutoSize = true;
            this.lblTelefone1.Location = new System.Drawing.Point(420, 97);
            this.lblTelefone1.Name = "lblTelefone1";
            this.lblTelefone1.Size = new System.Drawing.Size(16, 13);
            this.lblTelefone1.TabIndex = 3;
            this.lblTelefone1.Text = "1:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(124, 15);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(70, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(124, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(207, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(442, 67);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFiltro.Location = new System.Drawing.Point(354, 179);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(218, 20);
            this.txtFiltro.TabIndex = 8;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(13, 177);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(94, 177);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 11;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(175, 177);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(256, 177);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFiltro.Location = new System.Drawing.Point(578, 177);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 14;
            this.btnFiltro.Text = "Ler";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.BtnFiltro_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(13, 206);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(640, 223);
            this.dgvClientes.TabIndex = 15;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellClick);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(12, 149);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 16;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(124, 146);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(207, 20);
            this.txtCidade.TabIndex = 17;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(351, 18);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 18;
            this.lblUF.Text = "UF:";
            // 
            // lblCPF_CNPJ
            // 
            this.lblCPF_CNPJ.AutoSize = true;
            this.lblCPF_CNPJ.Location = new System.Drawing.Point(12, 70);
            this.lblCPF_CNPJ.Name = "lblCPF_CNPJ";
            this.lblCPF_CNPJ.Size = new System.Drawing.Size(62, 13);
            this.lblCPF_CNPJ.TabIndex = 20;
            this.lblCPF_CNPJ.Text = "CPF/CNPJ:";
            // 
            // mskCPF_CNPJ
            // 
            this.mskCPF_CNPJ.Location = new System.Drawing.Point(124, 67);
            this.mskCPF_CNPJ.Name = "mskCPF_CNPJ";
            this.mskCPF_CNPJ.Size = new System.Drawing.Size(126, 20);
            this.mskCPF_CNPJ.TabIndex = 21;
            this.mskCPF_CNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCPF_CNPJ.TextChanged += new System.EventHandler(this.MskCPF_CNPJ_TextChanged);
            this.mskCPF_CNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MskCPF_CNPJ_KeyPress);
            // 
            // cmbCPF_CNPJ
            // 
            this.cmbCPF_CNPJ.FormattingEnabled = true;
            this.cmbCPF_CNPJ.Items.AddRange(new object[] {
            "CPF",
            "CNPJ"});
            this.cmbCPF_CNPJ.Location = new System.Drawing.Point(256, 66);
            this.cmbCPF_CNPJ.Name = "cmbCPF_CNPJ";
            this.cmbCPF_CNPJ.Size = new System.Drawing.Size(75, 21);
            this.cmbCPF_CNPJ.TabIndex = 22;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(124, 94);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(207, 20);
            this.txtLogradouro.TabIndex = 24;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(12, 97);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lblLogradouro.TabIndex = 23;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(442, 94);
            this.mskTelefone.Mask = "(00) 00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(88, 20);
            this.mskTelefone.TabIndex = 25;
            this.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MskTelefone_KeyPress);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(124, 120);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(207, 20);
            this.txtBairro.TabIndex = 27;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(12, 123);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 26;
            this.lblBairro.Text = "Bairro:";
            // 
            // cmbUF
            // 
            this.cmbUF.FormattingEnabled = true;
            this.cmbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbUF.Location = new System.Drawing.Point(442, 14);
            this.cmbUF.Name = "cmbUF";
            this.cmbUF.Size = new System.Drawing.Size(61, 21);
            this.cmbUF.TabIndex = 28;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(351, 44);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 29;
            this.lblCEP.Text = "CEP:";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(442, 41);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(61, 20);
            this.mskCEP.TabIndex = 30;
            this.mskCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MskCEP_KeyPress);
            // 
            // mskTelefone2
            // 
            this.mskTelefone2.Location = new System.Drawing.Point(565, 94);
            this.mskTelefone2.Mask = "(00) 00000-0000";
            this.mskTelefone2.Name = "mskTelefone2";
            this.mskTelefone2.Size = new System.Drawing.Size(88, 20);
            this.mskTelefone2.TabIndex = 32;
            this.mskTelefone2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskTelefone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MskTelefone2_KeyPress);
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.Location = new System.Drawing.Point(543, 97);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(16, 13);
            this.lblTelefone2.TabIndex = 31;
            this.lblTelefone2.Text = "2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Telefones";
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.Location = new System.Drawing.Point(442, 146);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(211, 20);
            this.dtpDataCadastro.TabIndex = 34;
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(351, 149);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(78, 13);
            this.lblDataCadastro.TabIndex = 35;
            this.lblDataCadastro.Text = "Data Cadastro:";
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(664, 441);
            this.Controls.Add(this.lblDataCadastro);
            this.Controls.Add(this.dtpDataCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskTelefone2);
            this.Controls.Add(this.lblTelefone2);
            this.Controls.Add(this.mskCEP);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.cmbUF);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.cmbCPF_CNPJ);
            this.Controls.Add(this.mskCPF_CNPJ);
            this.Controls.Add(this.lblCPF_CNPJ);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblTelefone1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClientesForm";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCPF_CNPJ;
        private System.Windows.Forms.MaskedTextBox mskCPF_CNPJ;
        private System.Windows.Forms.ComboBox cmbCPF_CNPJ;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.ComboBox cmbUF;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.MaskedTextBox mskTelefone2;
        private System.Windows.Forms.Label lblTelefone2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private System.Windows.Forms.Label lblDataCadastro;
    }
}