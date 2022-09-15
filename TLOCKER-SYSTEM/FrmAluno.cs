using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;
using DTO;
using DAO;

namespace TLOCKER_SYSTEM
{
    public partial class FrmAluno : Form
    {
        public FrmAluno()
        {
            InitializeComponent();            
            dgvAluno.AutoGenerateColumns = false;
            CarregarAluno();
            
        }

        private void CarregarAluno()
        {
            DAO_Aluno alunodao = new DAO_Aluno();

            ColecaoAluno colecaoaluno = alunodao.SelecionarAlunos();

            dgvAluno.DataSource = null;
            dgvAluno.DataSource = colecaoaluno;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {

        }

        private void Entrada(object sender, EventArgs e)
        {
            Consistencia.Entrada(sender);
        }

        private void Saida(object sender, EventArgs e)
        {
            Consistencia.Saida(sender);
        }

        private void btnCadastrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtCPFAluno.PasswordChar = '#';
            txtCPFResp.PasswordChar = '#';
            txtCPFAluno.Enabled = false;
            txtCPFResp.Enabled = false;

            int column = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            
            
            DTO_Aluno aluno =
            dgvAluno.SelectedRows[0].DataBoundItem as DTO_Aluno;

            this.txtRM.Text = aluno.Rm_alu.ToString();
            this.txtNomeAluno.Text = aluno.Nome_alu;
            this.txtTurma.Text = aluno.Turma_alu;
            this.txtEmailAluno.Text = aluno.Email_alu;
            this.txtTelefoneAluno.Text = aluno.Telefone_alu;
            this.txtCPFAluno.Text = aluno.Cpf_alu;
            this.txtNomeResp.Text = aluno.Resp_nome_alu;
            this.txtTelefoneResp.Text = aluno.Resp_telefone_alu;
            this.txtCPFResp.Text = aluno.Resp_cpf_alu;
            this.txtEmailResp.Text = aluno.Resp_email_alu;

            if (string.IsNullOrWhiteSpace(txtCPFResp.Text) || string.IsNullOrWhiteSpace(txtNomeResp.Text) ||
                        string.IsNullOrWhiteSpace(txtEmailResp.Text) || string.IsNullOrWhiteSpace(txtTelefoneResp.Text))
            {

               
                btnCadastrar.Enabled = false;
                btnAlterar.Enabled = true;
                btnRemover.Enabled = true;
                txtNomeResp.Enabled = false;
                txtEmailResp.Enabled = false;
                txtTelefoneResp.Enabled = false;
                btnArmario.Enabled = true;
                txtRM.Enabled = false;

                rdbMaiorDeIdade.Checked = true;
                rdbMaiorDeIdade.Enabled = false;
            }

            else
            {
                




                btnCadastrar.Enabled = false;
                btnAlterar.Enabled = true;
                btnRemover.Enabled = true;
                txtNomeResp.Enabled = false;
                txtEmailResp.Enabled = false;
                txtTelefoneResp.Enabled = false;
                btnArmario.Enabled = true;
                txtRM.Enabled = false;
                rdbMaiorDeIdade.Checked = false;

                rdbMaiorDeIdade.Enabled = false;
            }
           

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            #region Inserir Aluno

                try
                {
                    DTO_Aluno alu = new DTO_Aluno();
                    alu.Rm_alu = Convert.ToInt32(txtRM.Text);
                    alu.Turma_alu = txtTurma.Text;
                    alu.Nome_alu = txtNomeAluno.Text;
                    alu.Cpf_alu = txtCPFAluno.Text;
                    alu.Email_alu = txtEmailAluno.Text;
                    alu.Telefone_alu = txtTelefoneAluno.Text;
                    alu.Resp_nome_alu = txtNomeResp.Text;
                    alu.Resp_cpf_alu = txtCPFResp.Text;
                    alu.Resp_email_alu = txtEmailResp.Text;
                    alu.Resp_telefone_alu = txtTelefoneResp.Text;

                    if (string.IsNullOrWhiteSpace(txtNomeAluno.Text) || string.IsNullOrWhiteSpace(txtEmailAluno.Text) ||
                        string.IsNullOrWhiteSpace(txtTelefoneAluno.Text) || string.IsNullOrWhiteSpace(txtRM.Text) ||
                        string.IsNullOrWhiteSpace(txtTurma.Text) || string.IsNullOrWhiteSpace(txtCPFAluno.Text))
                    {
                        MessageBox.Show("Por favor preencha todos os campos.");
                    }
                    else if (rdbMaiorDeIdade.Checked)
                    {
                        DAO_Aluno daoalu = new DAO_Aluno();
                        object retorno = daoalu.Inserir(alu);
                        MessageBox.Show("Aluno Cadastrado"
                            , "Cadastrado com Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarAluno();
                        Consistencia.Limpar(this);
                    rdbMaiorDeIdade.Checked = false;
                    rdbMaiorDeIdade.Enabled = true;
                }            
                    else
                    {
                        if (string.IsNullOrWhiteSpace(txtCPFResp.Text) || string.IsNullOrWhiteSpace(txtNomeResp.Text) ||
                        string.IsNullOrWhiteSpace(txtEmailResp.Text) || string.IsNullOrWhiteSpace(txtTelefoneResp.Text))
                        {
                            MessageBox.Show("Por favor preencha todos os campos.");
                        }
                        else
                        {
                            DAO_Aluno daoalu = new DAO_Aluno();
                            object retorno = daoalu.Inserir(alu);
                            MessageBox.Show("Aluno Cadastrado"
                                , "Cadastrado com Sucesso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarAluno();
                            Consistencia.Limpar(this);
                        rdbMaiorDeIdade.Enabled = true;
                    }
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Por favor preencha todos os campos.");
                }
            
            #endregion
        }

        private void btnRemover_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Consistencia.Limpar(this);
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnRemover.Enabled = false;
            txtCPFAluno.Enabled = true;
            txtCPFResp.Enabled = true;
            txtNomeResp.Enabled = true;
            txtEmailResp.Enabled = true;
            txtTelefoneResp.Enabled = true;
            btnArmario.Enabled = false;
            txtRM.Enabled = true;
            rdbMaiorDeIdade.Checked = false;
            txtCPFAluno.PasswordChar = '\0';
            txtCPFResp.PasswordChar = '\0';
            rdbMaiorDeIdade.Enabled = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvAluno.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Aluno selecionado",
                    "Consistencia", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Deseja Realmente Excluir o Aluno?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DTO_Aluno alunoselecionado = dgvAluno.SelectedRows[0].DataBoundItem as DTO_Aluno;
                    DAO_Aluno daoaluno = new DAO_Aluno();
                    string retorno = daoaluno.Excluir(alunoselecionado);

                    if (retorno == "1")
                    {
                        MessageBox.Show("Aluno Excluido com Sucesso");
                        Consistencia.Limpar(this);
                        btnCadastrar.Enabled = true;
                        btnAlterar.Enabled = false;
                        btnRemover.Enabled = false;
                        txtCPFAluno.Enabled = true;
                        txtCPFResp.Enabled = true;
                        txtRM.Enabled = true;
                        btnArmario.Enabled = false;
                        rdbMaiorDeIdade.Checked = false;
                        rdbMaiorDeIdade.Enabled = true;
                        txtCPFAluno.PasswordChar = '\0';
                        txtCPFResp.PasswordChar = '\0';
                        
                        CarregarAluno();
                    }
                    else
                    {
                        MessageBox.Show(retorno);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consistencia.Limpar(this);
        }

        private void btnAlterar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            #region Alterar Aluno

            try
            {
                DTO_Aluno alu = new DTO_Aluno();
                alu.Rm_alu = Convert.ToInt32(txtRM.Text);
                alu.Turma_alu = txtTurma.Text;
                alu.Nome_alu = txtNomeAluno.Text;
                alu.Cpf_alu = txtCPFAluno.Text;
                alu.Email_alu = txtEmailAluno.Text;
                alu.Telefone_alu = txtTelefoneAluno.Text;
                alu.Resp_nome_alu = txtNomeResp.Text;
                alu.Resp_cpf_alu = txtCPFResp.Text;
                alu.Resp_email_alu = txtEmailResp.Text;
                alu.Resp_telefone_alu = txtTelefoneResp.Text;

                if (string.IsNullOrWhiteSpace(txtNomeAluno.Text) || string.IsNullOrWhiteSpace(txtEmailAluno.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefoneAluno.Text) || string.IsNullOrWhiteSpace(txtRM.Text) ||
                    string.IsNullOrWhiteSpace(txtTurma.Text) || string.IsNullOrWhiteSpace(txtCPFAluno.Text))
                {
                    MessageBox.Show("Por favor preencha todos os campos.");
                }
                else if (rdbMaiorDeIdade.Checked)
                {
                    DAO_Aluno daoalu = new DAO_Aluno();
                    object retorno = daoalu.Alterar(alu);
                    MessageBox.Show("Aluno Alterado"
                        , "Alterado com Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarAluno();
                    Consistencia.Limpar(this);
                    btnCadastrar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnRemover.Enabled = false;
                    txtCPFAluno.Enabled = true;
                    txtCPFResp.Enabled = true;
                    btnArmario.Enabled = false;
                    txtRM.Enabled = true;
                    txtCPFAluno.PasswordChar = '\0';
                    txtCPFResp.PasswordChar = '\0';
                    rdbMaiorDeIdade.Checked = false;
                    rdbMaiorDeIdade.Enabled = true;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtCPFResp.Text) || string.IsNullOrWhiteSpace(txtNomeResp.Text) ||
                    string.IsNullOrWhiteSpace(txtEmailResp.Text) || string.IsNullOrWhiteSpace(txtTelefoneResp.Text))
                    {
                        MessageBox.Show("Por favor preencha todos os campos.");
                    }
                    else
                    {
                        DAO_Aluno daoalu = new DAO_Aluno();
                        object retorno = daoalu.Alterar(alu);
                        MessageBox.Show("Aluno Alterado"
                            , "Alterado com Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarAluno();
                        Consistencia.Limpar(this);
                        btnCadastrar.Enabled = true;
                        btnAlterar.Enabled = false;
                        btnRemover.Enabled = false;
                        txtCPFAluno.Enabled = true;
                        txtCPFResp.Enabled = true;
                        btnArmario.Enabled = false;
                        txtRM.Enabled = true;
                        rdbMaiorDeIdade.Enabled = true;
                        txtCPFAluno.PasswordChar = '\0';
                        txtCPFResp.PasswordChar = '\0';

                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor preencha todos os campos.");
            }

            #endregion
            

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void txtRM_TextChanged(object sender, EventArgs e)
        {
            if (txtRM.Text != string.Empty)
            {
                
                DTO_Aluno aluno = new DTO_Aluno();
                aluno.Rm_alu = Convert.ToInt32(txtRM.Text);
                

                DAO_Aluno alunodao = new DAO_Aluno();
                ColecaoAluno colecaoaluno = alunodao.SelecionarAlunoEspecifico(aluno);

                dgvAluno.DataSource = null;
                dgvAluno.DataSource = colecaoaluno;
                
            }
            else
            {
                CarregarAluno();

            }
        }

        private void btnLimpar_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void rdbMaiorDeIdade_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbMaiorDeIdade.Checked)
            {
                txtNomeResp.Enabled = false;
                txtEmailResp.Enabled = false;
                txtTelefoneResp.Enabled = false;
                txtCPFResp.Enabled = false;
            }
            else
            {
                txtNomeResp.Enabled = true;
                txtEmailResp.Enabled = true;
                txtTelefoneResp.Enabled = true;
                txtCPFResp.Enabled = true;

                txtNomeResp.Clear();
                txtEmailResp.Clear();
                txtTelefoneResp.Clear();
                txtCPFResp.Clear();

            }
        
    }

        private void txtRM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtTelefoneAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCPFAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCPFResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtTelefoneResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnArmario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnArmario_Click(object sender, EventArgs e)
        {
            Consistencia.AbrirForm(new FrmArmario(), this.ParentForm, this.ParentForm);


        }
    }
}
