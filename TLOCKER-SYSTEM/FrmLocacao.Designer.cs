namespace TLOCKER_SYSTEM
{
    partial class FrmLocacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLocacao));
            this.dgvLocacao = new System.Windows.Forms.DataGridView();
            this.NumArmario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAlunos = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtArmario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.dataLocacao = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnEncerrar = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnContrato = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValorF = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPagar = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocacao)).BeginInit();
            this.panel1.SuspendLayout();
            this.btnCadastrar.SuspendLayout();
            this.btnEncerrar.SuspendLayout();
            this.btnContrato.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.btnLimpar.SuspendLayout();
            this.btnPagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLocacao
            // 
            this.dgvLocacao.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLocacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumArmario,
            this.Valor,
            this.Tipo,
            this.Aluno,
            this.Data});
            this.dgvLocacao.Location = new System.Drawing.Point(75, 373);
            this.dgvLocacao.Name = "dgvLocacao";
            this.dgvLocacao.ReadOnly = true;
            this.dgvLocacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocacao.Size = new System.Drawing.Size(679, 208);
            this.dgvLocacao.TabIndex = 20;
            this.dgvLocacao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocacao_CellClick);
            this.dgvLocacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocacao_CellContentClick);
            // 
            // NumArmario
            // 
            this.NumArmario.DataPropertyName = "Id_armario";
            this.NumArmario.HeaderText = "N° Armário";
            this.NumArmario.Name = "NumArmario";
            this.NumArmario.ReadOnly = true;
            this.NumArmario.Width = 60;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Locacao_valor";
            this.Valor.HeaderText = "Valor do Armário";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Locacao_tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Aluno
            // 
            this.Aluno.DataPropertyName = "Nome_alu";
            this.Aluno.HeaderText = "Aluno";
            this.Aluno.Name = "Aluno";
            this.Aluno.ReadOnly = true;
            this.Aluno.Width = 275;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "locacao_data";
            this.Data.HeaderText = "Data de Locação";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome do aluno:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbAlunos
            // 
            this.cmbAlunos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAlunos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAlunos.FormattingEnabled = true;
            this.cmbAlunos.Location = new System.Drawing.Point(169, 109);
            this.cmbAlunos.Name = "cmbAlunos";
            this.cmbAlunos.Size = new System.Drawing.Size(450, 25);
            this.cmbAlunos.TabIndex = 22;
            this.cmbAlunos.SelectedIndexChanged += new System.EventHandler(this.cmbAlunos_SelectedIndexChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(6, 22);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(10, 23);
            this.txtValor.TabIndex = 29;
            this.txtValor.Text = "0,00";
            this.txtValor.Visible = false;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtArmario
            // 
            this.txtArmario.Location = new System.Drawing.Point(136, 44);
            this.txtArmario.Name = "txtArmario";
            this.txtArmario.Size = new System.Drawing.Size(71, 23);
            this.txtArmario.TabIndex = 28;
            this.txtArmario.TextChanged += new System.EventHandler(this.txtNumArmario_TextChanged);
            this.txtArmario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArmario_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Valor:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "N° Armário:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "SEMESTRAL",
            "ANUAL"});
            this.cmbTipo.Location = new System.Drawing.Point(466, 44);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(153, 25);
            this.cmbTipo.TabIndex = 31;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // dataLocacao
            // 
            this.dataLocacao.Location = new System.Drawing.Point(180, 167);
            this.dataLocacao.Name = "dataLocacao";
            this.dataLocacao.Size = new System.Drawing.Size(439, 23);
            this.dataLocacao.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Data da locação:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.label15.Location = new System.Drawing.Point(352, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 25);
            this.label15.TabIndex = 35;
            this.label15.Text = "LOCAÇÃO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnEncerrar);
            this.panel1.Controls.Add(this.btnContrato);
            this.panel1.Location = new System.Drawing.Point(831, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 678);
            this.panel1.TabIndex = 34;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.btnCadastrar.Controls.Add(this.label14);
            this.btnCadastrar.Controls.Add(this.panel8);
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 166);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(241, 50);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
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
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.btnEncerrar.Controls.Add(this.label13);
            this.btnEncerrar.Controls.Add(this.panel6);
            this.btnEncerrar.Enabled = false;
            this.btnEncerrar.Location = new System.Drawing.Point(0, 278);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(241, 50);
            this.btnEncerrar.TabIndex = 4;
            this.btnEncerrar.Click += new System.EventHandler(this.btnRemover_Click);
            this.btnEncerrar.MouseEnter += new System.EventHandler(this.Entrada);
            this.btnEncerrar.MouseLeave += new System.EventHandler(this.Saida);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(60, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Encerrar Locação";
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
            // btnContrato
            // 
            this.btnContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.btnContrato.Controls.Add(this.label12);
            this.btnContrato.Controls.Add(this.panel4);
            this.btnContrato.Enabled = false;
            this.btnContrato.Location = new System.Drawing.Point(0, 222);
            this.btnContrato.Name = "btnContrato";
            this.btnContrato.Size = new System.Drawing.Size(241, 50);
            this.btnContrato.TabIndex = 3;
            this.btnContrato.Paint += new System.Windows.Forms.PaintEventHandler(this.btnAlterar_Paint);
            this.btnContrato.MouseEnter += new System.EventHandler(this.Entrada);
            this.btnContrato.MouseLeave += new System.EventHandler(this.Saida);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(60, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Emitir Contrato";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValorF);
            this.groupBox1.Controls.Add(this.dataLocacao);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbAlunos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbTipo);
            this.groupBox1.Controls.Add(this.txtArmario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(75, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 235);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // txtValorF
            // 
            this.txtValorF.Enabled = false;
            this.txtValorF.Location = new System.Drawing.Point(288, 44);
            this.txtValorF.Name = "txtValorF";
            this.txtValorF.Size = new System.Drawing.Size(100, 23);
            this.txtValorF.TabIndex = 34;
            this.txtValorF.TextChanged += new System.EventHandler(this.txtValorF_TextChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.btnLimpar.Controls.Add(this.label7);
            this.btnLimpar.Controls.Add(this.panel3);
            this.btnLimpar.Location = new System.Drawing.Point(831, 329);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(241, 50);
            this.btnLimpar.TabIndex = 7;
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
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.btnPagar.Controls.Add(this.label6);
            this.btnPagar.Controls.Add(this.panel5);
            this.btnPagar.Enabled = false;
            this.btnPagar.Location = new System.Drawing.Point(831, 385);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(241, 50);
            this.btnPagar.TabIndex = 8;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            this.btnPagar.MouseEnter += new System.EventHandler(this.Entrada);
            this.btnPagar.MouseLeave += new System.EventHandler(this.Saida);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(60, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Efetuar Pagamento";
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
            // FrmLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 618);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLocacao);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmLocacao";
            this.Load += new System.EventHandler(this.FrmLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocacao)).EndInit();
            this.panel1.ResumeLayout(false);
            this.btnCadastrar.ResumeLayout(false);
            this.btnCadastrar.PerformLayout();
            this.btnEncerrar.ResumeLayout(false);
            this.btnEncerrar.PerformLayout();
            this.btnContrato.ResumeLayout(false);
            this.btnContrato.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.btnLimpar.ResumeLayout(false);
            this.btnLimpar.PerformLayout();
            this.btnPagar.ResumeLayout(false);
            this.btnPagar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLocacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAlunos;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtArmario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.DateTimePicker dataLocacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel btnCadastrar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel btnContrato;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel btnEncerrar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel btnLimpar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel btnPagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtValorF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumArmario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
    }
}