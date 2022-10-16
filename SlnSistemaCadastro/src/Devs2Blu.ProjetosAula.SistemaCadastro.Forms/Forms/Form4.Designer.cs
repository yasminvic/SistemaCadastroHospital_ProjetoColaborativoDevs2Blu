namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
{
    partial class Form4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpStatus = new System.Windows.Forms.GroupBox();
            this.gpEndereco = new System.Windows.Forms.GroupBox();
            this.gridEndereco = new System.Windows.Forms.DataGridView();
            this.gpPaciente = new System.Windows.Forms.GroupBox();
            this.gridPaciente = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.gpStatus.SuspendLayout();
            this.gpEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEndereco)).BeginInit();
            this.gpPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // gpStatus
            // 
            this.gpStatus.Controls.Add(this.gpEndereco);
            this.gpStatus.Controls.Add(this.gpPaciente);
            this.gpStatus.Location = new System.Drawing.Point(12, 12);
            this.gpStatus.Name = "gpStatus";
            this.gpStatus.Size = new System.Drawing.Size(1069, 603);
            this.gpStatus.TabIndex = 4;
            this.gpStatus.TabStop = false;
            this.gpStatus.Text = "Status";
            // 
            // gpEndereco
            // 
            this.gpEndereco.Controls.Add(this.gridEndereco);
            this.gpEndereco.Location = new System.Drawing.Point(334, 19);
            this.gpEndereco.Name = "gpEndereco";
            this.gpEndereco.Size = new System.Drawing.Size(718, 572);
            this.gpEndereco.TabIndex = 2;
            this.gpEndereco.TabStop = false;
            this.gpEndereco.Text = "Endereço";
            // 
            // gridEndereco
            // 
            this.gridEndereco.AllowUserToAddRows = false;
            this.gridEndereco.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            this.gridEndereco.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEndereco.Location = new System.Drawing.Point(6, 15);
            this.gridEndereco.Name = "gridEndereco";
            this.gridEndereco.ReadOnly = true;
            this.gridEndereco.RowHeadersVisible = false;
            this.gridEndereco.Size = new System.Drawing.Size(702, 551);
            this.gridEndereco.TabIndex = 0;
            // 
            // gpPaciente
            // 
            this.gpPaciente.Controls.Add(this.gridPaciente);
            this.gpPaciente.Location = new System.Drawing.Point(12, 16);
            this.gpPaciente.Name = "gpPaciente";
            this.gpPaciente.Size = new System.Drawing.Size(316, 575);
            this.gpPaciente.TabIndex = 1;
            this.gpPaciente.TabStop = false;
            this.gpPaciente.Text = "Paciente";
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
            this.gridPaciente.Size = new System.Drawing.Size(296, 551);
            this.gridPaciente.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(1102, 28);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(91, 92);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 621);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gpStatus);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.gpStatus.ResumeLayout(false);
            this.gpEndereco.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEndereco)).EndInit();
            this.gpPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpStatus;
        private System.Windows.Forms.GroupBox gpEndereco;
        private System.Windows.Forms.DataGridView gridEndereco;
        private System.Windows.Forms.GroupBox gpPaciente;
        private System.Windows.Forms.DataGridView gridPaciente;
        private System.Windows.Forms.Button btnFechar;
    }
}