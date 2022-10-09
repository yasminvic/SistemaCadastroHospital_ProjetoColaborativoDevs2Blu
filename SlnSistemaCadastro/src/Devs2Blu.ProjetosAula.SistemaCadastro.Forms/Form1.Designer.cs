
namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gpFormCadastro = new System.Windows.Forms.GroupBox();
            this.txtCGCCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gpEnderecoCadastro = new System.Windows.Forms.GroupBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCGCCPF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpTipoPessoa = new System.Windows.Forms.GroupBox();
            this.rdJuridica = new System.Windows.Forms.RadioButton();
            this.rdFisica = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cboConvenio = new System.Windows.Forms.ComboBox();
            this.panelControles = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.gpConteudo = new System.Windows.Forms.GroupBox();
            this.gridPacientes = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpFormCadastro.SuspendLayout();
            this.gpEnderecoCadastro.SuspendLayout();
            this.gpTipoPessoa.SuspendLayout();
            this.panelControles.SuspendLayout();
            this.gpConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpFormCadastro
            // 
            this.gpFormCadastro.BackColor = System.Drawing.Color.White;
            this.gpFormCadastro.Controls.Add(this.txtCGCCPF);
            this.gpFormCadastro.Controls.Add(this.btnLimpar);
            this.gpFormCadastro.Controls.Add(this.txtNome);
            this.gpFormCadastro.Controls.Add(this.gpEnderecoCadastro);
            this.gpFormCadastro.Controls.Add(this.lblCGCCPF);
            this.gpFormCadastro.Controls.Add(this.label2);
            this.gpFormCadastro.Controls.Add(this.gpTipoPessoa);
            this.gpFormCadastro.Controls.Add(this.label1);
            this.gpFormCadastro.Controls.Add(this.cboConvenio);
            this.gpFormCadastro.Location = new System.Drawing.Point(16, 42);
            this.gpFormCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.gpFormCadastro.Name = "gpFormCadastro";
            this.gpFormCadastro.Padding = new System.Windows.Forms.Padding(4);
            this.gpFormCadastro.Size = new System.Drawing.Size(477, 404);
            this.gpFormCadastro.TabIndex = 3;
            this.gpFormCadastro.TabStop = false;
            this.gpFormCadastro.Text = "Formulário de Cadastro";
            // 
            // txtCGCCPF
            // 
            this.txtCGCCPF.Location = new System.Drawing.Point(85, 67);
            this.txtCGCCPF.Mask = "000.000.000-00";
            this.txtCGCCPF.Name = "txtCGCCPF";
            this.txtCGCCPF.Size = new System.Drawing.Size(137, 22);
            this.txtCGCCPF.TabIndex = 16;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(19, 338);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 38);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(85, 34);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(332, 22);
            this.txtNome.TabIndex = 12;
            // 
            // gpEnderecoCadastro
            // 
            this.gpEnderecoCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpEnderecoCadastro.Controls.Add(this.mskCEP);
            this.gpEnderecoCadastro.Controls.Add(this.txtBairro);
            this.gpEnderecoCadastro.Controls.Add(this.txtNumero);
            this.gpEnderecoCadastro.Controls.Add(this.txtCidade);
            this.gpEnderecoCadastro.Controls.Add(this.cboUF);
            this.gpEnderecoCadastro.Controls.Add(this.txtRua);
            this.gpEnderecoCadastro.Controls.Add(this.label8);
            this.gpEnderecoCadastro.Controls.Add(this.label7);
            this.gpEnderecoCadastro.Controls.Add(this.label6);
            this.gpEnderecoCadastro.Controls.Add(this.label5);
            this.gpEnderecoCadastro.Controls.Add(this.label4);
            this.gpEnderecoCadastro.Controls.Add(this.label3);
            this.gpEnderecoCadastro.Location = new System.Drawing.Point(8, 174);
            this.gpEnderecoCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.gpEnderecoCadastro.Name = "gpEnderecoCadastro";
            this.gpEnderecoCadastro.Padding = new System.Windows.Forms.Padding(4);
            this.gpEnderecoCadastro.Size = new System.Drawing.Size(461, 117);
            this.gpEnderecoCadastro.TabIndex = 11;
            this.gpEnderecoCadastro.TabStop = false;
            this.gpEnderecoCadastro.Text = "Endereço/Contato";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(52, 27);
            this.mskCEP.Margin = new System.Windows.Forms.Padding(4);
            this.mskCEP.Mask = "00.000-00";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(84, 22);
            this.mskCEP.TabIndex = 20;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(52, 82);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(188, 22);
            this.txtBairro.TabIndex = 19;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(361, 54);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(76, 22);
            this.txtNumero.TabIndex = 18;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(301, 26);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(137, 22);
            this.txtCidade.TabIndex = 17;
            // 
            // cboUF
            // 
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(172, 26);
            this.cboUF.Margin = new System.Windows.Forms.Padding(4);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(71, 24);
            this.cboUF.TabIndex = 16;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(52, 54);
            this.txtRua.Margin = new System.Windows.Forms.Padding(4);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(249, 22);
            this.txtRua.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(143, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "UF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(249, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bairro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(305, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "CEP";
            // 
            // lblCGCCPF
            // 
            this.lblCGCCPF.AutoSize = true;
            this.lblCGCCPF.Location = new System.Drawing.Point(39, 70);
            this.lblCGCCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCGCCPF.Name = "lblCGCCPF";
            this.lblCGCCPF.Size = new System.Drawing.Size(33, 16);
            this.lblCGCCPF.TabIndex = 10;
            this.lblCGCCPF.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome";
            // 
            // gpTipoPessoa
            // 
            this.gpTipoPessoa.Controls.Add(this.rdJuridica);
            this.gpTipoPessoa.Controls.Add(this.rdFisica);
            this.gpTipoPessoa.Location = new System.Drawing.Point(232, 71);
            this.gpTipoPessoa.Margin = new System.Windows.Forms.Padding(4);
            this.gpTipoPessoa.Name = "gpTipoPessoa";
            this.gpTipoPessoa.Padding = new System.Windows.Forms.Padding(4);
            this.gpTipoPessoa.Size = new System.Drawing.Size(187, 52);
            this.gpTipoPessoa.TabIndex = 8;
            this.gpTipoPessoa.TabStop = false;
            this.gpTipoPessoa.Text = "Tipo Pessoa";
            // 
            // rdJuridica
            // 
            this.rdJuridica.AutoSize = true;
            this.rdJuridica.Location = new System.Drawing.Point(88, 20);
            this.rdJuridica.Margin = new System.Windows.Forms.Padding(4);
            this.rdJuridica.Name = "rdJuridica";
            this.rdJuridica.Size = new System.Drawing.Size(75, 20);
            this.rdJuridica.TabIndex = 9;
            this.rdJuridica.Text = "Jurídica";
            this.rdJuridica.UseVisualStyleBackColor = true;
            this.rdJuridica.CheckedChanged += new System.EventHandler(this.rdJuridica_CheckedChanged);
            // 
            // rdFisica
            // 
            this.rdFisica.AutoSize = true;
            this.rdFisica.Checked = true;
            this.rdFisica.Location = new System.Drawing.Point(8, 20);
            this.rdFisica.Margin = new System.Windows.Forms.Padding(4);
            this.rdFisica.Name = "rdFisica";
            this.rdFisica.Size = new System.Drawing.Size(64, 20);
            this.rdFisica.TabIndex = 8;
            this.rdFisica.TabStop = true;
            this.rdFisica.Text = "Física";
            this.rdFisica.UseVisualStyleBackColor = true;
            this.rdFisica.CheckedChanged += new System.EventHandler(this.rdFisica_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Convênio";
            // 
            // cboConvenio
            // 
            this.cboConvenio.FormattingEnabled = true;
            this.cboConvenio.Location = new System.Drawing.Point(85, 101);
            this.cboConvenio.Margin = new System.Windows.Forms.Padding(4);
            this.cboConvenio.Name = "cboConvenio";
            this.cboConvenio.Size = new System.Drawing.Size(137, 24);
            this.cboConvenio.TabIndex = 3;
            // 
            // panelControles
            // 
            this.panelControles.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelControles.Controls.Add(this.btnSalvar);
            this.panelControles.Controls.Add(this.btnExcluir);
            this.panelControles.Controls.Add(this.btnInfo);
            this.panelControles.Location = new System.Drawing.Point(16, 455);
            this.panelControles.Margin = new System.Windows.Forms.Padding(4);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(1035, 89);
            this.panelControles.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Location = new System.Drawing.Point(15, 6);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(136, 80);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Location = new System.Drawing.Point(170, 6);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(134, 80);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.Location = new System.Drawing.Point(939, 5);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(92, 80);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // gpConteudo
            // 
            this.gpConteudo.Controls.Add(this.gridPacientes);
            this.gpConteudo.Location = new System.Drawing.Point(501, 32);
            this.gpConteudo.Margin = new System.Windows.Forms.Padding(4);
            this.gpConteudo.Name = "gpConteudo";
            this.gpConteudo.Padding = new System.Windows.Forms.Padding(4);
            this.gpConteudo.Size = new System.Drawing.Size(548, 416);
            this.gpConteudo.TabIndex = 5;
            this.gpConteudo.TabStop = false;
            // 
            // gridPacientes
            // 
            this.gridPacientes.AllowUserToAddRows = false;
            this.gridPacientes.AllowUserToOrderColumns = true;
            this.gridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacientes.Location = new System.Drawing.Point(0, 10);
            this.gridPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.gridPacientes.Name = "gridPacientes";
            this.gridPacientes.ReadOnly = true;
            this.gridPacientes.RowHeadersWidth = 51;
            this.gridPacientes.Size = new System.Drawing.Size(546, 404);
            this.gridPacientes.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.sairToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gpConteudo);
            this.Controls.Add(this.panelControles);
            this.Controls.Add(this.gpFormCadastro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "+Devs2Blu - Sistema de Cadastro Hospitalar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpFormCadastro.ResumeLayout(false);
            this.gpFormCadastro.PerformLayout();
            this.gpEnderecoCadastro.ResumeLayout(false);
            this.gpEnderecoCadastro.PerformLayout();
            this.gpTipoPessoa.ResumeLayout(false);
            this.gpTipoPessoa.PerformLayout();
            this.panelControles.ResumeLayout(false);
            this.gpConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpFormCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboConvenio;
        private System.Windows.Forms.GroupBox gpTipoPessoa;
        private System.Windows.Forms.RadioButton rdJuridica;
        private System.Windows.Forms.RadioButton rdFisica;
        private System.Windows.Forms.Label lblCGCCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpEnderecoCadastro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.GroupBox gpConteudo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView gridPacientes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox txtCGCCPF;
    }
}

