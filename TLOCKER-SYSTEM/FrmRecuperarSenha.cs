using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TLOCKER_SYSTEM
{
    public partial class FrmRecuperarSenha : Form
    {
        int codUsu;
        public FrmRecuperarSenha()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecuperarSenha_Click(object sender, EventArgs e)
        {

            try
            {

                DTO_Usuario objusu = new DTO_Usuario();
                objusu.Email_usu = txtEmail.Text;

                DAO_Usuario daousu = new DAO_Usuario();

                DTO_Usuario retornousu = daousu.RecuperarSenha(objusu);

                if (retornousu.Nome_usu == null)
                {
                    MessageBox.Show("E-mail não existe na Base de Dados");
                }
                else
                {
                    daousu.EnviarEmail(retornousu);
                    MessageBox.Show("E-mail encaminhado com sucesso!");
                    this.Height = 516;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            DTO_Usuario usuario = new DTO_Usuario();
            usuario.Email_usu = txtEmail.Text;
            usuario.RecuperarSenha = Convert.ToInt32(txtCodigo.Text);

            DAO_Usuario daousuario = new DAO_Usuario();
            DTO_Usuario usuretorno = daousuario.VerificarUsuario(usuario);

            if (usuretorno.Id_usu > 0)
            {
                codUsu = usuretorno.Id_usu;
                txtNovaSenha.Enabled = true;
                txtConfirmarSenha.Enabled = true;
                lblNovaSenha.Enabled = true;
                lblConfirmaSenha.Enabled = true;
                btnAlterarSenha.Enabled = true;
            }
        }

        private void txtConfirmarSenha_Leave(object sender, EventArgs e)
        {
            if (txtNovaSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("Senhas não conferem, digite novamente");
                txtNovaSenha.Focus();
            }
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            DTO_Usuario usu = new DTO_Usuario();
            usu.Id_usu = codUsu;
            usu.Senha_usu = txtNovaSenha.Text;

            DAO_Usuario daousuario = new DAO_Usuario();

            string retorno = daousuario.AlterarSenha(usu);

            if (retorno == "1")
            {
                MessageBox.Show("Senha modificada com sucesso!");
                txtNovaSenha.Enabled = false;
                txtConfirmarSenha.Enabled = false;
                lblNovaSenha.Enabled = false;
                lblConfirmaSenha.Enabled = false;
                btnAlterarSenha.Enabled = false;
                this.Height = 203;
                this.Close();
            }
        }
    }
}
