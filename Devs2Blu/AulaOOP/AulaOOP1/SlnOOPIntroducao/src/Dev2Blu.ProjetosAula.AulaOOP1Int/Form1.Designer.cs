
namespace Dev2Blu.ProjetosAula.AulaOOP1Int
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdRecepcionista = new System.Windows.Forms.RadioButton();
            this.rdDiretor = new System.Windows.Forms.RadioButton();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.txtSobreNome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.btnLimparStatus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.btn);
            this.groupBox1.Controls.Add(this.lblIdade);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtNascimento);
            this.groupBox1.Controls.Add(this.txtSobreNome);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Funcionários";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(78, 91);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(0, 20);
            this.lblIdade.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdRecepcionista);
            this.groupBox4.Controls.Add(this.rdDiretor);
            this.groupBox4.Location = new System.Drawing.Point(52, 182);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(255, 88);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo Funcionário";
            // 
            // rdRecepcionista
            // 
            this.rdRecepcionista.AutoSize = true;
            this.rdRecepcionista.Location = new System.Drawing.Point(133, 42);
            this.rdRecepcionista.Name = "rdRecepcionista";
            this.rdRecepcionista.Size = new System.Drawing.Size(93, 17);
            this.rdRecepcionista.TabIndex = 1;
            this.rdRecepcionista.Text = "Recepcionista";
            this.rdRecepcionista.UseVisualStyleBackColor = true;
            // 
            // rdDiretor
            // 
            this.rdDiretor.AutoSize = true;
            this.rdDiretor.Checked = true;
            this.rdDiretor.Location = new System.Drawing.Point(17, 42);
            this.rdDiretor.Name = "rdDiretor";
            this.rdDiretor.Size = new System.Drawing.Size(56, 17);
            this.rdDiretor.TabIndex = 0;
            this.rdDiretor.TabStop = true;
            this.rdDiretor.Text = "Diretor";
            this.rdDiretor.UseVisualStyleBackColor = true;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(110, 122);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(212, 20);
            this.txtEndereco.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.DarkGray;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(22, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 20);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Idade:";
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(125, 61);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtNascimento.TabIndex = 6;
            // 
            // txtSobreNome
            // 
            this.txtSobreNome.Location = new System.Drawing.Point(205, 34);
            this.txtSobreNome.Name = "txtSobreNome";
            this.txtSobreNome.Size = new System.Drawing.Size(117, 20);
            this.txtSobreNome.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(117, 20);
            this.txtNome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nascimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Location = new System.Drawing.Point(12, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controles";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DimGray;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(52, 70);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(255, 34);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DimGray;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(52, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(255, 34);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox3.Controls.Add(this.btnLimparStatus);
            this.groupBox3.Controls.Add(this.txtStatus);
            this.groupBox3.Location = new System.Drawing.Point(377, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 426);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.DimGray;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.White;
            this.txtStatus.Location = new System.Drawing.Point(6, 20);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(218, 349);
            this.txtStatus.TabIndex = 0;
            this.txtStatus.Text = "Cadatrando funcionários...";
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.DimGray;
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(231, 61);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(92, 23);
            this.btn.TabIndex = 12;
            this.btn.Text = "Calcular idade";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnLimparStatus
            // 
            this.btnLimparStatus.BackColor = System.Drawing.Color.DimGray;
            this.btnLimparStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparStatus.ForeColor = System.Drawing.Color.White;
            this.btnLimparStatus.Location = new System.Drawing.Point(6, 386);
            this.btnLimparStatus.Name = "btnLimparStatus";
            this.btnLimparStatus.Size = new System.Drawing.Size(218, 34);
            this.btnLimparStatus.TabIndex = 2;
            this.btnLimparStatus.Text = "Limpar status";
            this.btnLimparStatus.UseVisualStyleBackColor = false;
            this.btnLimparStatus.Click += new System.EventHandler(this.btnLimparStatus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Aula OOP 1 -Sistema de Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdRecepcionista;
        private System.Windows.Forms.RadioButton rdDiretor;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.TextBox txtSobreNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnLimparStatus;
    }
}

