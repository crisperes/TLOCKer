namespace TLOCKER_SYSTEM
{
    partial class FrmPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagamento));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataPagamento = new System.Windows.Forms.DateTimePicker();
            this.txtRespPagamento = new System.Windows.Forms.TextBox();
            this.txtArmario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dgvPagamento = new System.Windows.Forms.DataGridView();
            this.Responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumArmario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlrPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnComprovante = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
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
            this.btnLimpar = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtpagid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamento)).BeginInit();
            this.panel1.SuspendLayout();
            this.btnComprovante.SuspendLayout();
            this.btnCadastrar.SuspendLayout();
            this.btnAlterar.SuspendLayout();
            this.btnRemover.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.btnLimpar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Responsável pelo pagamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "N° Armário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Data do pagamento:";
            // 
            // dataPagamento
            // 
            this.dataPagamento.Enabled = false;
            this.dataPagamento.Location = new System.Drawing.Point(354, 109);
            this.dataPagamento.Name = "dataPagamento";
            this.dataPagamento.Size = new System.Drawing.Size(286, 23);
            this.dataPagamento.TabIndex = 22;
            // 
            // txtRespPagamento
            // 
            this.txtRespPagamento.Location = new System.Drawing.Point(239, 56);
            this.txtRespPagamento.Name = "txtRespPagamento";
            this.txtRespPagamento.Size = new System.Drawing.Size(401, 23);
            this.txtRespPagamento.TabIndex = 23;
            // 
            // txtArmario
            // 
            this.txtArmario.Enabled = false;
            this.txtArmario.Location = new System.Drawing.Point(113, 109);
            this.txtArmario.Name = "txtArmario";
            this.txtArmario.Size = new System.Drawing.Size(61, 23);
            this.txtArmario.TabIndex = 24;
            this.txtArmario.TextChanged += new System.EventHandler(this.txtArmario_TextChanged);
            this.txtArmario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArmario_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(77, 167);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(97, 23);
            this.txtValor.TabIndex = 26;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // dgvPagamento
            // 
            this.dgvPagamento.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Responsavel,
            this.NumArmario,
            this.VlrPagamento,
            this.Data});
            this.dgvPagamento.Location = new System.Drawing.Point(72, 385);
            this.dgvPagamento.Name = "dgvPagamento";
            this.dgvPagamento.ReadOnly = true;
            this.dgvPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagamento.Size = new System.Drawing.Size(679, 200);
            this.dgvPagamento.TabIndex = 27;
            this.dgvPagamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagamento_CellClick);
            this.dgvPagamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagamento_CellContentClick);
            // 
            // Responsavel
            // 
            this.Responsavel.DataPropertyName = "Pag_resp_nome";
            this.Responsavel.HeaderText = "Responsável";
            this.Responsavel.Name = "Responsavel";
            this.Responsavel.ReadOnly = true;
            this.Responsavel.Width = 250;
            // 
            // NumArmario
            // 
            this.NumArmario.DataPropertyName = "Id_armario";
            this.NumArmario.HeaderText = "N° Armário";
            this.NumArmario.Name = "NumArmario";
            this.NumArmario.ReadOnly = true;
            // 
            // VlrPagamento
            // 
            this.VlrPagamento.DataPropertyName = "Pag_valor";
            this.VlrPagamento.HeaderText = "Valor de Pagamento";
            this.VlrPagamento.Name = "VlrPagamento";
            this.VlrPagamento.ReadOnly = true;
            this.VlrPagamento.Width = 140;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Pag_data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 145;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.label15.Location = new System.Drawing.Point(340, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 25);
            this.label15.TabIndex = 29;
            this.label15.Text = "PAGAMENTO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.btnComprovante);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Location = new System.Drawing.Point(831, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 679);
            this.panel1.TabIndex = 28;
            // 
            // btnComprovante
            // 
            this.btnComprovante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.btnComprovante.Controls.Add(this.label1);
            this.btnComprovante.Controls.Add(this.panel5);
            this.btnComprovante.Enabled = false;
            this.btnComprovante.Location = new System.Drawing.Point(0, 385);
            this.btnComprovante.Name = "btnComprovante";
            this.btnComprovante.Size = new System.Drawing.Size(241, 50);
            this.btnComprovante.TabIndex = 5;
            this.btnComprovante.Click += new System.EventHandler(this.btnComprovante_Click);
            this.btnComprovante.MouseEnter += new System.EventHandler(this.Entrada);
            this.btnComprovante.MouseLeave += new System.EventHandler(this.Saida);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gerar Comprovante";
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
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.btnCadastrar.Controls.Add(this.label14);
            this.btnCadastrar.Controls.Add(this.panel8);
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 161);
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
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.btnAlterar.Controls.Add(this.label12);
            this.btnAlterar.Controls.Add(this.panel4);
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(0, 217);
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
            this.btnRemover.Location = new System.Drawing.Point(0, 273);
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
            this.groupBox1.Controls.Add(this.txtpagid);
            this.groupBox1.Controls.Add(this.txtRespPagamento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.dataPagamento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtArmario);
            this.groupBox1.Location = new System.Drawing.Point(72, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 236);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(91)))), ((int)(((byte)(87)))));
            this.btnLimpar.Controls.Add(this.label7);
            this.btnLimpar.Controls.Add(this.panel3);
            this.btnLimpar.Location = new System.Drawing.Point(831, 323);
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
            // txtpagid
            // 
            this.txtpagid.Location = new System.Drawing.Point(6, 22);
            this.txtpagid.Name = "txtpagid";
            this.txtpagid.Size = new System.Drawing.Size(10, 23);
            this.txtpagid.TabIndex = 27;
            this.txtpagid.Visible = false;
            // 
            // FrmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 618);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPagamento);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPagamento";
            this.Load += new System.EventHandler(this.FrmPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.btnComprovante.ResumeLayout(false);
            this.btnComprovante.PerformLayout();
            this.btnCadastrar.ResumeLayout(false);
            this.btnCadastrar.PerformLayout();
            this.btnAlterar.ResumeLayout(false);
            this.btnAlterar.PerformLayout();
            this.btnRemover.ResumeLayout(false);
            this.btnRemover.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.btnLimpar.ResumeLayout(false);
            this.btnLimpar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dataPagamento;
        private System.Windows.Forms.TextBox txtRespPagamento;
        private System.Windows.Forms.TextBox txtArmario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridView dgvPagamento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel btnComprovante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
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
        private System.Windows.Forms.Panel btnLimpar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumArmario;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlrPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.TextBox txtpagid;
    }
}