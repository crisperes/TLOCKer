namespace TLOCKER_SYSTEM
{
    partial class FrmAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAluno));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbMaiorDeIdade = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmailResp = new System.Windows.Forms.TextBox();
            this.txtCPFResp = new System.Windows.Forms.TextBox();
            this.txtTelefoneResp = new System.Windows.Forms.TextBox();
            this.txtNomeResp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtEmailAluno = new System.Windows.Forms.TextBox();
            this.txtTelefoneAluno = new System.Windows.Forms.TextBox();
            this.txtCPFAluno = new System.Windows.Forms.TextBox();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.txtRM = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
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
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.RM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Armário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoLocação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.btnArmario = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.btnLimpar.SuspendLayout();
            this.btnCadastrar.SuspendLayout();
            this.btnAlterar.SuspendLayout();
            this.btnRemover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.btnArmario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Turma:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "RM:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "CPF:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefone:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // rdbMaiorDeIdade
            // 
            this.rdbMaiorDeIdade.AutoSize = true;
            this.rdbMaiorDeIdade.Location = new System.Drawing.Point(425, 123);
            this.rdbMaiorDeIdade.Name = "rdbMaiorDeIdade";
            this.rdbMaiorDeIdade.Size = new System.Drawing.Size(196, 21);
            this.rdbMaiorDeIdade.TabIndex = 7;
            this.rdbMaiorDeIdade.Text = "O aluno é maior de idade";
            this.rdbMaiorDeIdade.UseVisualStyleBackColor = true;
            this.rdbMaiorDeIdade.CheckedChanged += new System.EventHandler(this.rdbMaiorDeIdade_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "CPF:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "E-mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Telefone:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmailResp);
            this.groupBox1.Controls.Add(this.txtCPFResp);
            this.groupBox1.Controls.Add(this.txtTelefoneResp);
            this.groupBox1.Controls.Add(this.txtNomeResp);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(72, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 127);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DADOS DO RESPONSÁVEL";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtEmailResp
            // 
            this.txtEmailResp.Location = new System.Drawing.Point(280, 79);
            this.txtEmailResp.Name = "txtEmailResp";
            this.txtEmailResp.Size = new System.Drawing.Size(377, 23);
            this.txtEmailResp.TabIndex = 15;
            // 
            // txtCPFResp
            // 
            this.txtCPFResp.Location = new System.Drawing.Point(59, 79);
            this.txtCPFResp.Name = "txtCPFResp";
            this.txtCPFResp.Size = new System.Drawing.Size(151, 23);
            this.txtCPFResp.TabIndex = 15;
            this.txtCPFResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPFResp_KeyPress);
            // 
            // txtTelefoneResp
            // 
            this.txtTelefoneResp.Location = new System.Drawing.Point(509, 37);
            this.txtTelefoneResp.Name = "txtTelefoneResp";
            this.txtTelefoneResp.Size = new System.Drawing.Size(148, 23);
            this.txtTelefoneResp.TabIndex = 15;
            this.txtTelefoneResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneResp_KeyPress);
            // 
            // txtNomeResp
            // 
            this.txtNomeResp.Location = new System.Drawing.Point(74, 37);
            this.txtNomeResp.Name = "txtNomeResp";
            this.txtNomeResp.Size = new System.Drawing.Size(343, 23);
            this.txtNomeResp.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNomeAluno);
            this.groupBox2.Controls.Add(this.txtEmailAluno);
            this.groupBox2.Controls.Add(this.txtTelefoneAluno);
            this.groupBox2.Controls.Add(this.txtCPFAluno);
            this.groupBox2.Controls.Add(this.txtTurma);
            this.groupBox2.Controls.Add(this.txtRM);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rdbMaiorDeIdade);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(72, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 174);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DADOS DO ALUNO";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(73, 37);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(376, 23);
            this.txtNomeAluno.TabIndex = 16;
            // 
            // txtEmailAluno
            // 
            this.txtEmailAluno.Location = new System.Drawing.Point(73, 123);
            this.txtEmailAluno.Name = "txtEmailAluno";
            this.txtEmailAluno.Size = new System.Drawing.Size(314, 23);
            this.txtEmailAluno.TabIndex = 13;
            // 
            // txtTelefoneAluno
            // 
            this.txtTelefoneAluno.Location = new System.Drawing.Point(509, 76);
            this.txtTelefoneAluno.Name = "txtTelefoneAluno";
            this.txtTelefoneAluno.Size = new System.Drawing.Size(148, 23);
            this.txtTelefoneAluno.TabIndex = 12;
            this.txtTelefoneAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneAluno_KeyPress);
            // 
            // txtCPFAluno
            // 
            this.txtCPFAluno.Location = new System.Drawing.Point(266, 79);
            this.txtCPFAluno.Name = "txtCPFAluno";
            this.txtCPFAluno.Size = new System.Drawing.Size(151, 23);
            this.txtCPFAluno.TabIndex = 11;
            this.txtCPFAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPFAluno_KeyPress);
            // 
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(73, 79);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(132, 23);
            this.txtTurma.TabIndex = 10;
            // 
            // txtRM
            // 
            this.txtRM.Location = new System.Drawing.Point(509, 37);
            this.txtRM.Name = "txtRM";
            this.txtRM.Size = new System.Drawing.Size(148, 23);
            this.txtRM.TabIndex = 9;
            this.txtRM.TextChanged += new System.EventHandler(this.txtRM_TextChanged);
            this.txtRM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRM_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.panel1.Location = new System.Drawing.Point(832, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 679);
            this.panel1.TabIndex = 15;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.btnLimpar.Controls.Add(this.label11);
            this.btnLimpar.Controls.Add(this.panel3);
            this.btnLimpar.Location = new System.Drawing.Point(832, 334);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(241, 52);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLimpar_MouseClick);
            this.btnLimpar.MouseEnter += new System.EventHandler(this.Entrada);
            this.btnLimpar.MouseLeave += new System.EventHandler(this.Saida);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(60, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Limpar Campos";
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
            this.btnCadastrar.Location = new System.Drawing.Point(832, 166);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(241, 50);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnCadastrar.Paint += new System.Windows.Forms.PaintEventHandler(this.btnCadastrar_Paint);
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
            this.btnAlterar.Location = new System.Drawing.Point(832, 222);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(241, 50);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            this.btnAlterar.Paint += new System.Windows.Forms.PaintEventHandler(this.btnAlterar_Paint);
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
            this.btnRemover.Location = new System.Drawing.Point(832, 278);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(241, 50);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            this.btnRemover.Paint += new System.Windows.Forms.PaintEventHandler(this.btnRemover_Paint);
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
            // dgvAluno
            // 
            this.dgvAluno.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RM,
            this.Aluno,
            this.Armário,
            this.TipoLocação});
            this.dgvAluno.Location = new System.Drawing.Point(72, 427);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.ReadOnly = true;
            this.dgvAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAluno.Size = new System.Drawing.Size(679, 161);
            this.dgvAluno.TabIndex = 16;
            this.dgvAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAluno_CellClick);
            // 
            // RM
            // 
            this.RM.DataPropertyName = "Rm_alu";
            this.RM.HeaderText = "RM";
            this.RM.Name = "RM";
            this.RM.ReadOnly = true;
            // 
            // Aluno
            // 
            this.Aluno.DataPropertyName = "Nome_alu";
            this.Aluno.HeaderText = "Aluno";
            this.Aluno.Name = "Aluno";
            this.Aluno.ReadOnly = true;
            this.Aluno.Width = 375;
            // 
            // Armário
            // 
            this.Armário.DataPropertyName = "Id_armario";
            this.Armário.FillWeight = 70F;
            this.Armário.HeaderText = "Armário";
            this.Armário.Name = "Armário";
            this.Armário.ReadOnly = true;
            // 
            // TipoLocação
            // 
            this.TipoLocação.DataPropertyName = "Locacao_tipo";
            this.TipoLocação.HeaderText = "Tipo de Locação";
            this.TipoLocação.Name = "TipoLocação";
            this.TipoLocação.ReadOnly = true;
            this.TipoLocação.Width = 160;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.label15.Location = new System.Drawing.Point(364, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 25);
            this.label15.TabIndex = 17;
            this.label15.Text = "ALUNO";
            // 
            // btnArmario
            // 
            this.btnArmario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.btnArmario.Controls.Add(this.label16);
            this.btnArmario.Controls.Add(this.panel5);
            this.btnArmario.Enabled = false;
            this.btnArmario.Location = new System.Drawing.Point(832, 392);
            this.btnArmario.Name = "btnArmario";
            this.btnArmario.Size = new System.Drawing.Size(241, 52);
            this.btnArmario.TabIndex = 6;
            this.btnArmario.Click += new System.EventHandler(this.btnArmario_Click);
            this.btnArmario.Paint += new System.Windows.Forms.PaintEventHandler(this.btnArmario_Paint);
            this.btnArmario.MouseEnter += new System.EventHandler(this.Entrada);
            this.btnArmario.MouseLeave += new System.EventHandler(this.Saida);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(60, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "Selecionar Armário";
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
            // FrmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 618);
            this.Controls.Add(this.btnArmario);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.dgvAluno);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAluno";
            this.Load += new System.EventHandler(this.FrmAluno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.btnLimpar.ResumeLayout(false);
            this.btnLimpar.PerformLayout();
            this.btnCadastrar.ResumeLayout(false);
            this.btnCadastrar.PerformLayout();
            this.btnAlterar.ResumeLayout(false);
            this.btnAlterar.PerformLayout();
            this.btnRemover.ResumeLayout(false);
            this.btnRemover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.btnArmario.ResumeLayout(false);
            this.btnArmario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox rdbMaiorDeIdade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmailResp;
        private System.Windows.Forms.TextBox txtCPFResp;
        private System.Windows.Forms.TextBox txtTelefoneResp;
        private System.Windows.Forms.TextBox txtNomeResp;
        private System.Windows.Forms.TextBox txtEmailAluno;
        private System.Windows.Forms.TextBox txtTelefoneAluno;
        private System.Windows.Forms.TextBox txtCPFAluno;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.TextBox txtRM;
        private System.Windows.Forms.Panel btnCadastrar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel btnAlterar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel btnRemover;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel btnLimpar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel btnArmario;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn RM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Armário;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoLocação;
    }
}