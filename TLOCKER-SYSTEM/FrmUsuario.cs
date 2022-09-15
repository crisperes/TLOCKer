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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
            dgvUsuario.AutoGenerateColumns = false;
            CarregarUsuario();
        }

        private void CarregarUsuario()
        {
            DAO_Usuario usuariodao = new DAO_Usuario();

            DTO_ColecaoUsuario colecaousuario = usuariodao.SelecionarUsuario();

            dgvUsuario.DataSource = null;
            dgvUsuario.DataSource = colecaousuario;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ClickHover(object sender, EventArgs e)
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

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            #region Inserir Usuario
            try
            {
                DTO_Usuario usu = new DTO_Usuario();
                usu.Nome_usu = txtNome.Text;
                usu.Cpf_usu = txtCPF.Text;
                usu.Email_usu = txtEmail.Text;
                usu.Telefone_usu = txtTelefone.Text;
                usu.Login_usu = txtLogin.Text;
                usu.Senha_usu = txtSenha.Text;

                if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtCPF.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                    string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    MessageBox.Show("Por favor preencha todos os campos.");
                }
                else
                {
                    DAO_Usuario daousu = new DAO_Usuario();
                    object retorno = daousu.Inserir(usu);
                    MessageBox.Show("Usuario Cadastrado"
                        , "Cadastrado com Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarUsuario();
                    Consistencia.Limpar(this);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor preencha todos os campos.");
            }

            #endregion
        }
            private void FrmUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Consistencia.Limpar(this);
            btnRemover.Enabled = false;
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DTO_Usuario usu = new DTO_Usuario();
            usu.Nome_usu = txtNome.Text;
            usu.Cpf_usu = txtCPF.Text;
            usu.Email_usu = txtEmail.Text;
            usu.Telefone_usu = txtTelefone.Text;
            usu.Login_usu = txtLogin.Text;
            usu.Senha_usu = txtSenha.Text;
            usu.Id_usu = Convert.ToInt32(txtid.Text);



            DAO_Usuario daousu = new DAO_Usuario();
            object retorno = daousu.Alterar(usu);
            MessageBox.Show("Usuario Alterado"
                , "Alterado com Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregarUsuario();
            Consistencia.Limpar(this);
            
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            DataGridViewRow row = this.dgvUsuario.Rows[rowIndex];

            DTO_Usuario usuario =
            dgvUsuario.SelectedRows[0].DataBoundItem as DTO_Usuario;

            this.txtid.Text = usuario.Id_usu.ToString();
            this.txtNome.Text = usuario.Nome_usu;
            this.txtEmail.Text = usuario.Email_usu;
            this.txtLogin.Text = usuario.Login_usu;
            this.txtSenha.Text = usuario.Senha_usu;
            this.txtTelefone.Text = usuario.Telefone_usu;
            this.txtCPF.Text = usuario.Cpf_usu;

            btnRemover.Enabled = true;
            btnAlterar.Enabled = true;
            btnCadastrar.Enabled = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Usuario selecionado",
                    "Consistencia", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Deseja Realmente Excluir o Usuario?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DTO_Usuario usuarioselecionado = dgvUsuario.SelectedRows[0].DataBoundItem as DTO_Usuario;
                    DAO_Usuario daousuario = new DAO_Usuario();
                    string retorno = daousuario.Excluir(usuarioselecionado);

                    if (retorno == "1")
                    {
                        MessageBox.Show("Usuario Excluido com Sucesso");
                        Consistencia.Limpar(this);
                        CarregarUsuario();
                    }
                    else
                    {
                        MessageBox.Show(retorno);
                    }
                }
            }
        
    }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLimpar_MouseClick(object sender, MouseEventArgs e)
        {
            Consistencia.Limpar(this);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text != string.Empty)

            {


                DTO_Usuario usuario = new DTO_Usuario();
                usuario.Nome_usu = txtNome.Text;


                DAO_Usuario usuariodao = new DAO_Usuario();
                DTO_ColecaoUsuario colecaousuario = usuariodao.SelecionarUsuarioEspecifico(usuario);

                dgvUsuario.DataSource = colecaousuario;


            }
            else
            {
                CarregarUsuario();

            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

