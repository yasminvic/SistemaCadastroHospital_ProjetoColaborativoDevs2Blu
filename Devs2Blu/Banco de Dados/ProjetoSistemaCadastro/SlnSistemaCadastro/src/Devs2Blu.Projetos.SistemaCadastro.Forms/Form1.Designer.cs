namespace Devs2Blu.Projetos.SistemaCadastro.Forms
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
            this.components = new System.ComponentModel.Container();
            this.cboConvenio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpFormCadastro = new System.Windows.Forms.GroupBox();
            this.txtRisco = new System.Windows.Forms.TextBox();
            this.lblRisco = new System.Windows.Forms.Label();
            this.txtCGCCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCGCCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpTipoPessoa = new System.Windows.Forms.GroupBox();
            this.rdJuridica = new System.Windows.Forms.RadioButton();
            this.rdFisica = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gpPaciente = new System.Windows.Forms.GroupBox();
            this.gridPacientes = new System.Windows.Forms.DataGridView();
            this.panelControle = new System.Windows.Forms.Panel();
            this.btnExluir = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpEndereco = new System.Windows.Forms.GroupBox();
            this.gridEndereco = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gpFormCadastro.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gpTipoPessoa.SuspendLayout();
            this.gpPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).BeginInit();
            this.panelControle.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gpEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEndereco)).BeginInit();
            this.SuspendLayout();
            // 
            // cboConvenio
            // 
            this.cboConvenio.FormattingEnabled = true;
            this.cboConvenio.Location = new System.Drawing.Point(113, 79);
            this.cboConvenio.Name = "cboConvenio";
            this.cboConvenio.Size = new System.Drawing.Size(136, 21);
            this.cboConvenio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Convênio";
            // 
            // gpFormCadastro
            // 
            this.gpFormCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(214)))), ((int)(((byte)(203)))));
            this.gpFormCadastro.Controls.Add(this.txtRisco);
            this.gpFormCadastro.Controls.Add(this.lblRisco);
            this.gpFormCadastro.Controls.Add(this.txtCGCCPF);
            this.gpFormCadastro.Controls.Add(this.btnLimpar);
            this.gpFormCadastro.Controls.Add(this.txtNome);
            this.gpFormCadastro.Controls.Add(this.groupBox3);
            this.gpFormCadastro.Controls.Add(this.lblCGCCPF);
            this.gpFormCadastro.Controls.Add(this.lblNome);
            this.gpFormCadastro.Controls.Add(this.gpTipoPessoa);
            this.gpFormCadastro.Controls.Add(this.cboConvenio);
            this.gpFormCadastro.Controls.Add(this.label1);
            this.gpFormCadastro.Location = new System.Drawing.Point(12, 27);
            this.gpFormCadastro.Name = "gpFormCadastro";
            this.gpFormCadastro.Size = new System.Drawing.Size(456, 376);
            this.gpFormCadastro.TabIndex = 2;
            this.gpFormCadastro.TabStop = false;
            this.gpFormCadastro.Text = "Formulario de Cadastro";
            // 
            // txtRisco
            // 
            this.txtRisco.Location = new System.Drawing.Point(111, 160);
            this.txtRisco.Name = "txtRisco";
            this.txtRisco.Size = new System.Drawing.Size(138, 20);
            this.txtRisco.TabIndex = 16;
            // 
            // lblRisco
            // 
            this.lblRisco.AutoSize = true;
            this.lblRisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRisco.Location = new System.Drawing.Point(24, 164);
            this.lblRisco.Name = "lblRisco";
            this.lblRisco.Size = new System.Drawing.Size(47, 16);
            this.lblRisco.TabIndex = 14;
            this.lblRisco.Text = "Risco";
            // 
            // txtCGCCPF
            // 
            this.txtCGCCPF.Location = new System.Drawing.Point(113, 127);
            this.txtCGCCPF.Mask = "000.000.000-00";
            this.txtCGCCPF.Name = "txtCGCCPF";
            this.txtCGCCPF.Size = new System.Drawing.Size(136, 20);
            this.txtCGCCPF.TabIndex = 13;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(24, 313);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 40);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(113, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(310, 20);
            this.txtNome.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
            this.groupBox3.Controls.Add(this.mskCEP);
            this.groupBox3.Controls.Add(this.txtBairro);
            this.groupBox3.Controls.Add(this.txtNumero);
            this.groupBox3.Controls.Add(this.txtCidade);
            this.groupBox3.Controls.Add(this.cboUF);
            this.groupBox3.Controls.Add(this.txtRua);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(16, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 111);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço/Contato";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(58, 20);
            this.mskCEP.Mask = "00.000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(64, 20);
            this.mskCEP.TabIndex = 15;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(58, 76);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(138, 20);
            this.txtBairro.TabIndex = 14;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(310, 47);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(98, 20);
            this.txtNumero.TabIndex = 13;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(254, 19);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(154, 20);
            this.txtCidade.TabIndex = 11;
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
            this.cboUF.Location = new System.Drawing.Point(153, 18);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(43, 21);
            this.cboUF.TabIndex = 11;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(58, 47);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(190, 20);
            this.txtRua.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(202, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(128, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "UF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bairro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(254, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CEP";
            // 
            // lblCGCCPF
            // 
            this.lblCGCCPF.AutoSize = true;
            this.lblCGCCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCGCCPF.Location = new System.Drawing.Point(21, 128);
            this.lblCGCCPF.Name = "lblCGCCPF";
            this.lblCGCCPF.Size = new System.Drawing.Size(36, 16);
            this.lblCGCCPF.TabIndex = 7;
            this.lblCGCCPF.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(21, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome";
            // 
            // gpTipoPessoa
            // 
            this.gpTipoPessoa.Controls.Add(this.rdJuridica);
            this.gpTipoPessoa.Controls.Add(this.rdFisica);
            this.gpTipoPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTipoPessoa.Location = new System.Drawing.Point(265, 57);
            this.gpTipoPessoa.Name = "gpTipoPessoa";
            this.gpTipoPessoa.Size = new System.Drawing.Size(158, 75);
            this.gpTipoPessoa.TabIndex = 5;
            this.gpTipoPessoa.TabStop = false;
            this.gpTipoPessoa.Text = "Tipo Pessoa";
            // 
            // rdJuridica
            // 
            this.rdJuridica.AutoSize = true;
            this.rdJuridica.Location = new System.Drawing.Point(17, 42);
            this.rdJuridica.Name = "rdJuridica";
            this.rdJuridica.Size = new System.Drawing.Size(114, 17);
            this.rdJuridica.TabIndex = 4;
            this.rdJuridica.Text = "Pessoa Juridica";
            this.rdJuridica.UseVisualStyleBackColor = true;
            this.rdJuridica.CheckedChanged += new System.EventHandler(this.rdJuridica_CheckedChanged);
            // 
            // rdFisica
            // 
            this.rdFisica.AutoSize = true;
            this.rdFisica.Checked = true;
            this.rdFisica.Location = new System.Drawing.Point(17, 19);
            this.rdFisica.Name = "rdFisica";
            this.rdFisica.Size = new System.Drawing.Size(103, 17);
            this.rdFisica.TabIndex = 2;
            this.rdFisica.TabStop = true;
            this.rdFisica.Text = "Pessoa Fisica";
            this.rdFisica.UseVisualStyleBackColor = true;
            this.rdFisica.CheckedChanged += new System.EventHandler(this.rdFisica_CheckedChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(16, 8);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(77, 59);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gpPaciente
            // 
            this.gpPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(214)))), ((int)(((byte)(203)))));
            this.gpPaciente.Controls.Add(this.gridPacientes);
            this.gpPaciente.Location = new System.Drawing.Point(474, 27);
            this.gpPaciente.Name = "gpPaciente";
            this.gpPaciente.Size = new System.Drawing.Size(606, 376);
            this.gpPaciente.TabIndex = 3;
            this.gpPaciente.TabStop = false;
            // 
            // gridPacientes
            // 
            this.gridPacientes.AllowUserToAddRows = false;
            this.gridPacientes.AllowUserToOrderColumns = true;
            this.gridPacientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
            this.gridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacientes.Location = new System.Drawing.Point(11, 16);
            this.gridPacientes.Name = "gridPacientes";
            this.gridPacientes.ReadOnly = true;
            this.gridPacientes.Size = new System.Drawing.Size(589, 348);
            this.gridPacientes.TabIndex = 0;
            // 
            // panelControle
            // 
            this.panelControle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(214)))), ((int)(((byte)(203)))));
            this.panelControle.Controls.Add(this.btnExluir);
            this.panelControle.Controls.Add(this.btnSalvar);
            this.panelControle.Controls.Add(this.btnInfo);
            this.panelControle.Location = new System.Drawing.Point(12, 537);
            this.panelControle.Name = "panelControle";
            this.panelControle.Size = new System.Drawing.Size(962, 74);
            this.panelControle.TabIndex = 4;
            // 
            // btnExluir
            // 
            this.btnExluir.Location = new System.Drawing.Point(113, 8);
            this.btnExluir.Name = "btnExluir";
            this.btnExluir.Size = new System.Drawing.Size(77, 63);
            this.btnExluir.TabIndex = 1;
            this.btnExluir.Text = "Excluir";
            this.btnExluir.UseVisualStyleBackColor = true;
            this.btnExluir.Click += new System.EventHandler(this.btnExluir_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(882, 8);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(77, 63);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "Informação";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1706, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // gpEndereco
            // 
            this.gpEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(214)))), ((int)(((byte)(203)))));
            this.gpEndereco.Controls.Add(this.gridEndereco);
            this.gpEndereco.Location = new System.Drawing.Point(1088, 27);
            this.gpEndereco.Name = "gpEndereco";
            this.gpEndereco.Size = new System.Drawing.Size(606, 376);
            this.gpEndereco.TabIndex = 4;
            this.gpEndereco.TabStop = false;
            // 
            // gridEndereco
            // 
            this.gridEndereco.AllowUserToAddRows = false;
            this.gridEndereco.AllowUserToOrderColumns = true;
            this.gridEndereco.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
            this.gridEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEndereco.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridEndereco.Location = new System.Drawing.Point(11, 16);
            this.gridEndereco.Name = "gridEndereco";
            this.gridEndereco.ReadOnly = true;
            this.gridEndereco.Size = new System.Drawing.Size(589, 348);
            this.gridEndereco.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(152)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(1706, 639);
            this.Controls.Add(this.gpEndereco);
            this.Controls.Add(this.panelControle);
            this.Controls.Add(this.gpPaciente);
            this.Controls.Add(this.gpFormCadastro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "\'\'";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpFormCadastro.ResumeLayout(false);
            this.gpFormCadastro.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gpTipoPessoa.ResumeLayout(false);
            this.gpTipoPessoa.PerformLayout();
            this.gpPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).EndInit();
            this.panelControle.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpEndereco.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEndereco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboConvenio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpFormCadastro;
        private System.Windows.Forms.RadioButton rdFisica;
        private System.Windows.Forms.RadioButton rdJuridica;
        private System.Windows.Forms.GroupBox gpTipoPessoa;
        private System.Windows.Forms.Label lblCGCCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gpPaciente;
        private System.Windows.Forms.Panel panelControle;
        private System.Windows.Forms.Button btnExluir;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.DataGridView gridPacientes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox txtCGCCPF;
        private System.Windows.Forms.GroupBox gpEndereco;
        private System.Windows.Forms.DataGridView gridEndereco;
        private System.Windows.Forms.TextBox txtRisco;
        private System.Windows.Forms.Label lblRisco;
        private System.Windows.Forms.ImageList imageList1;
    }
}

