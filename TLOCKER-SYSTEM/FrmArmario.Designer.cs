namespace TLOCKER_SYSTEM
{
    partial class FrmArmario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArmario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArmario = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dgvArmario = new System.Windows.Forms.DataGridView();
            this.NumeroArmario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLocarArmario = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRemover = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArmario)).BeginInit();
            this.panel1.SuspendLayout();
            this.btnLocarArmario.SuspendLayout();
            this.btnLimpar.SuspendLayout();
            this.btnCadastrar.SuspendLayout();
            this.btnAlterar.SuspendLayout();
            this.btnRemover.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "N° Armário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Local:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Descrição:";
            // 
            // txtArmario
            // 
            this.txtArmario.Location = new System.Drawing.Point(132, 45);
            this.txtArmario.Name = "txtArmario";
            this.txtArmario.Size = new System.Drawing.Size(71, 23);
            this.txtArmario.TabIndex = 23;
            this.txtArmario.TextChanged += new System.EventHandler(this.txtArmario_TextChanged);
            this.txtArmario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArmario_KeyPress);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(531, 45);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 25;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(123, 104);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(190, 23);
            this.txtLocal.TabIndex = 26;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(420, 104);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(193, 23);
            this.txtDescricao.TabIndex = 27;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Disponível",
            "Ocupado",
            "Manutenção"});
            this.cmbStatus.Location = new System.Drawing.Point(284, 45);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(168, 25);
            this.cmbStatus.TabIndex = 28;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // dgvArmario
            // 
            this.dgvArmario.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvArmario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArmario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArmario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroArmario,
            this.Status,
            this.Valor,
            this.Local,
            this.Descricao});
            this.dgvArmario.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvArmario.Location = new System.Drawing.Point(69, 307);
            this.dgvArmario.Name = "dgvArmario";
            this.dgvArmario.ReadOnly = true;
            this.dgvArmario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArmario.Size = new System.Drawing.Size(679, 277);
            this.dgvArmario.TabIndex = 29;
            this.dgvArmario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArmario_CellClick);
            this.dgvArmario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArmario_CellContentClick);
            // 
            // NumeroArmario
            // 
            this.NumeroArmario.DataPropertyName = "Id_armario";
            this.NumeroArmario.HeaderText = "N° Armário";
            this.NumeroArmario.Name = "NumeroArmario";
            this.NumeroArmario.ReadOnly = true;
            this.NumeroArmario.Width = 80;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status_armario";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 130;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor_armario";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Local
            // 
            this.Local.DataPropertyName = "Local_armario";
            this.Local.HeaderText = "Local";
            this.Local.Name = "Local";
            this.Local.ReadOnly = true;
            this.Local.Width = 155;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao_armario";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 170;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.label15.Location = new System.Drawing.Point(355, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 25);
            this.label15.TabIndex = 31;
            this.label15.Text = "ARMÁRIO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.btnLocarArmario);
            this.panel1.Location = new System.Drawing.Point(831, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 679);
            this.panel1.TabIndex = 30;
            // 
            // btnLocarArmario
            // 
            this.btnLocarArmario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.btnLocarArmario.Controls.Add(this.label6);
            this.btnLocarArmario.Controls.Add(this.panel5);
            this.btnLocarArmario.Enabled = false;
            this.btnLocarArmario.Location = new System.Drawing.Point(0, 398);
            this.btnLocarArmario.Name = "btnLocarArmario";
            this.btnLocarArmario.Size = new System.Drawing.Size(241, 50);
            this.btnLocarArmario.TabIndex = 5;
            this.btnLocarArmario.Click += new System.EventHandler(this.btnLocarArmario_Click);
            this.btnLocarArmario.Paint += new System.Windows.Forms.PaintEventHandler(this.btnLocarArmario_Paint);
            this.btnLocarArmario.MouseEnter += new System.EventHandler(this.Entrada);
            this.btnLocarArmario.MouseLeave += new System.EventHandler(this.Saida);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(60, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Locar Armário";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(3, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(36, 29);
            this.panel5.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.btnLimpar.Controls.Add(this.label7);
            this.btnLimpar.Controls.Add(this.panel3);
            this.btnLimpar.Location = new System.Drawing.Point(831, 336);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(241, 50);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLimpar_MouseClick);
            this.btnLimpar.MouseEnter += new System.EventHandler(this.Entrada);
            this.btnLimpar.MouseLeave += new System.EventHandler(this.Saida);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(60, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Limpar Campos";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            this.label7.MouseEnter += new System.EventHandler(this.Entrada);
            this.label7.MouseLeave += new System.EventHandler(this.Saida);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(3, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(36, 29);
            this.panel3.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.btnCadastrar.Controls.Add(this.label14);
            this.btnCadastrar.Controls.Add(this.panel8);
            this.btnCadastrar.Location = new System.Drawing.Point(831, 168);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(241, 50);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnCadastrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCadastrar_MouseClick);
            this.btnCadastrar.MouseEnter += new System.EventHandler(this.Entrada);
            this.btnCadastrar.MouseLeave += new System.EventHandler(this.Saida);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(60, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Cadastrar";
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel8.Location = new System.Drawing.Point(3, 11);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(36, 29);
            this.panel8.TabIndex = 0;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.btnAlterar.Controls.Add(this.label12);
            this.btnAlterar.Controls.Add(this.panel4);
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(831, 224);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(241, 50);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            this.btnAlterar.MouseEnter += new System.EventHandler(this.Entrada);
            this.btnAlterar.MouseLeave += new System.EventHandler(this.Saida);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(60, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Alterar";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(3, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(36, 29);
            this.panel4.TabIndex = 0;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.btnRemover.Controls.Add(this.label13);
            this.btnRemover.Controls.Add(this.panel6);
            this.btnRemover.Enabled = false;
            this.btnRemover.Location = new System.Drawing.Point(831, 280);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(241, 50);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            this.btnRemover.MouseEnter += new System.EventHandler(this.Entrada);
            this.btnRemover.MouseLeave += new System.EventHandler(this.Saida);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(60, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Remover";
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Location = new System.Drawing.Point(3, 11);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(36, 29);
            this.panel6.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLocal);
            this.groupBox1.Controls.Add(this.txtArmario);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Location = new System.Drawing.Point(69, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 163);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // FrmArmario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 618);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvArmario);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmArmario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmArmario";
            this.Load += new System.EventHandler(this.FrmArmario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArmario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.btnLocarArmario.ResumeLayout(false);
            this.btnLocarArmario.PerformLayout();
            this.btnLimpar.ResumeLayout(false);
            this.btnLimpar.PerformLayout();
            this.btnCadastrar.ResumeLayout(false);
            this.btnCadastrar.PerformLayout();
            this.btnAlterar.ResumeLayout(false);
            this.btnAlterar.PerformLayout();
            this.btnRemover.ResumeLayout(false);
            this.btnRemover.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArmario;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridView dgvArmario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel btnCadastrar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel btnAlterar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel btnRemover;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel btnLocarArmario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel btnLimpar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroArmario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    }
}