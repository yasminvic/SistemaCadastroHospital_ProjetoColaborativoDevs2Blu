namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbFormCadastro = new System.Windows.Forms.GroupBox();
            this.txtRisco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCGCCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbEnderecoCadastro = new System.Windows.Forms.GroupBox();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCGCCPF = new System.Windows.Forms.Label();
            this.gbTipoPessoa = new System.Windows.Forms.GroupBox();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cboConvenio = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gridEndereco = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridPaciente = new System.Windows.Forms.DataGridView();
            this.gbControles = new System.Windows.Forms.GroupBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbFormCadastro.SuspendLayout();
            this.gbEnderecoCadastro.SuspendLayout();
            this.gbTipoPessoa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEndereco)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPaciente)).BeginInit();
            this.gbControles.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFormCadastro
            // 
            this.gbFormCadastro.Controls.Add(this.txtRisco);
            this.gbFormCadastro.Controls.Add(this.label9);
            this.gbFormCadastro.Controls.Add(this.txtCGCCPF);
            this.gbFormCadastro.Controls.Add(this.btnLimpar);
            this.gbFormCadastro.Controls.Add(this.txtNome);
            this.gbFormCadastro.Controls.Add(this.label2);
            this.gbFormCadastro.Controls.Add(this.gbEnderecoCadastro);
            this.gbFormCadastro.Controls.Add(this.lblCGCCPF);
            this.gbFormCadastro.Controls.Add(this.gbTipoPessoa);
            this.gbFormCadastro.Controls.Add(this.label1);
            this.gbFormCadastro.Controls.Add(this.cboConvenio);
            this.gbFormCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbFormCadastro.Location = new System.Drawing.Point(24, 46);
            this.gbFormCadastro.Name = "gbFormCadastro";
            this.gbFormCadastro.Size = new System.Drawing.Size(362, 382);
            this.gbFormCadastro.TabIndex = 2;
            this.gbFormCadastro.TabStop = false;
            this.gbFormCadastro.Text = "Formulário de Cadastro";
            // 
            // txtRisco
            // 
            this.txtRisco.Location = new System.Drawing.Point(214, 105);
            this.txtRisco.Name = "txtRisco";
            this.txtRisco.Size = new System.Drawing.Size(115, 20);
            this.txtRisco.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Risco:";
            // 
            // txtCGCCPF
            // 
            this.txtCGCCPF.Location = new System.Drawing.Point(73, 70);
            this.txtCGCCPF.Mask = "000.000.000-00";
            this.txtCGCCPF.Name = "txtCGCCPF";
            this.txtCGCCPF.Size = new System.Drawing.Size(95, 20);
            this.txtCGCCPF.TabIndex = 16;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Beige;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(137, 344);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(71, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(258, 20);
            this.txtNome.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome: ";
            // 
            // gbEnderecoCadastro
            // 
            this.gbEnderecoCadastro.Controls.Add(this.cboUF);
            this.gbEnderecoCadastro.Controls.Add(this.mskCEP);
            this.gbEnderecoCadastro.Controls.Add(this.txtNum);
            this.gbEnderecoCadastro.Controls.Add(this.txtCidade);
            this.gbEnderecoCadastro.Controls.Add(this.txtBairro);
            this.gbEnderecoCadastro.Controls.Add(this.txtRua);
            this.gbEnderecoCadastro.Controls.Add(this.label8);
            this.gbEnderecoCadastro.Controls.Add(this.label7);
            this.gbEnderecoCadastro.Controls.Add(this.label6);
            this.gbEnderecoCadastro.Controls.Add(this.label5);
            this.gbEnderecoCadastro.Controls.Add(this.label4);
            this.gbEnderecoCadastro.Controls.Add(this.label3);
            this.gbEnderecoCadastro.Location = new System.Drawing.Point(9, 140);
            this.gbEnderecoCadastro.Name = "gbEnderecoCadastro";
            this.gbEnderecoCadastro.Size = new System.Drawing.Size(331, 190);
            this.gbEnderecoCadastro.TabIndex = 12;
            this.gbEnderecoCadastro.TabStop = false;
            this.gbEnderecoCadastro.Text = "Endereço/Contato";
            // 
            // cboUF
            // 
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Items.AddRange(new object[] {
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
            this.cboUF.Location = new System.Drawing.Point(205, 151);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(52, 21);
            this.cboUF.TabIndex = 12;
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(57, 39);
            this.mskCEP.Mask = "00.000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(73, 20);
            this.mskCEP.TabIndex = 11;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(207, 39);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(113, 20);
            this.txtNum.TabIndex = 10;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(56, 151);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(99, 20);
            this.txtCidade.TabIndex = 9;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(55, 113);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(265, 20);
            this.txtBairro.TabIndex = 8;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(55, 76);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(265, 20);
            this.txtRua.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "UF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Bairro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Rua:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CEP: ";
            // 
            // lblCGCCPF
            // 
            this.lblCGCCPF.AutoSize = true;
            this.lblCGCCPF.Location = new System.Drawing.Point(13, 73);
            this.lblCGCCPF.Name = "lblCGCCPF";
            this.lblCGCCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCGCCPF.TabIndex = 9;
            this.lblCGCCPF.Text = "CPF:";
            // 
            // gbTipoPessoa
            // 
            this.gbTipoPessoa.Controls.Add(this.rbJuridica);
            this.gbTipoPessoa.Controls.Add(this.rbFisica);
            this.gbTipoPessoa.Location = new System.Drawing.Point(189, 56);
            this.gbTipoPessoa.Name = "gbTipoPessoa";
            this.gbTipoPessoa.Size = new System.Drawing.Size(143, 43);
            this.gbTipoPessoa.TabIndex = 7;
            this.gbTipoPessoa.TabStop = false;
            this.gbTipoPessoa.Text = "Tipo Pessoa";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Location = new System.Drawing.Point(77, 17);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(63, 17);
            this.rbJuridica.TabIndex = 8;
            this.rbJuridica.Text = "Jurídica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Checked = true;
            this.rbFisica.Location = new System.Drawing.Point(17, 17);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(54, 17);
            this.rbFisica.TabIndex = 7;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Convenio:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // cboConvenio
            // 
            this.cboConvenio.FormattingEnabled = true;
            this.cboConvenio.Items.AddRange(new object[] {
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
            this.cboConvenio.Location = new System.Drawing.Point(70, 101);
            this.cboConvenio.Name = "cboConvenio";
            this.cboConvenio.Size = new System.Drawing.Size(95, 21);
            this.cboConvenio.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Lime;
            this.btnSalvar.Location = new System.Drawing.Point(235, 18);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 161);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(414, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 382);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gridEndereco);
            this.groupBox4.Location = new System.Drawing.Point(12, 205);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(603, 166);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Endereço";
            // 
            // gridEndereco
            // 
            this.gridEndereco.AllowUserToAddRows = false;
            this.gridEndereco.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            this.gridEndereco.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEndereco.Location = new System.Drawing.Point(10, 18);
            this.gridEndereco.Name = "gridEndereco";
            this.gridEndereco.ReadOnly = true;
            this.gridEndereco.RowHeadersVisible = false;
            this.gridEndereco.Size = new System.Drawing.Size(587, 141);
            this.gridEndereco.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridPaciente);
            this.groupBox2.Location = new System.Drawing.Point(12, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paciente";
            // 
            // gridPaciente
            // 
            this.gridPaciente.AllowUserToAddRows = false;
            this.gridPaciente.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gridPaciente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPaciente.Location = new System.Drawing.Point(10, 18);
            this.gridPaciente.Name = "gridPaciente";
            this.gridPaciente.ReadOnly = true;
            this.gridPaciente.RowHeadersVisible = false;
            this.gridPaciente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridPaciente.Size = new System.Drawing.Size(587, 153);
            this.gridPaciente.TabIndex = 0;
            // 
            // gbControles
            // 
            this.gbControles.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbControles.Controls.Add(this.btnStatus);
            this.gbControles.Controls.Add(this.btnExcluir);
            this.gbControles.Controls.Add(this.btnSalvar);
            this.gbControles.Controls.Add(this.btnInfo);
            this.gbControles.Location = new System.Drawing.Point(24, 453);
            this.gbControles.Name = "gbControles";
            this.gbControles.Size = new System.Drawing.Size(438, 197);
            this.gbControles.TabIndex = 4;
            this.gbControles.TabStop = false;
            this.gbControles.Text = "Controles";
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.Yellow;
            this.btnStatus.Location = new System.Drawing.Point(325, 18);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(75, 161);
            this.btnStatus.TabIndex = 4;
            this.btnStatus.Text = "Ver status";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Location = new System.Drawing.Point(137, 18);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 161);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(42, 18);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 161);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpeToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1227, 24);
            this.menuMain.TabIndex = 5;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Exit";
            // 
            // helpeToolStripMenuItem
            // 
            this.helpeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpeToolStripMenuItem.Name = "helpeToolStripMenuItem";
            this.helpeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpeToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 776);
            this.Controls.Add(this.gbControles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbFormCadastro);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+Devs2Blu - Sistema de Cadastro Hospitalar";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbFormCadastro.ResumeLayout(false);
            this.gbFormCadastro.PerformLayout();
            this.gbEnderecoCadastro.ResumeLayout(false);
            this.gbEnderecoCadastro.PerformLayout();
            this.gbTipoPessoa.ResumeLayout(false);
            this.gbTipoPessoa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEndereco)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPaciente)).EndInit();
            this.gbControles.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFormCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboConvenio;
        private System.Windows.Forms.GroupBox gbTipoPessoa;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.Label lblCGCCPF;
        private System.Windows.Forms.GroupBox gbEnderecoCadastro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbControles;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView gridPaciente;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox txtCGCCPF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRisco;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView gridEndereco;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStatus;
    }
}

