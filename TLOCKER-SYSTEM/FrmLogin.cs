using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace TLOCKER_SYSTEM
{
    public partial class FrmLogin : Form
    {
        public DTO_Usuario usuarioretorno = new DTO_Usuario();
        public Boolean retorno = false;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            #region Autenticação usuário

            DTO_Usuario usu = new DTO_Usuario();
            usu.Login_usu = txtLogin.Text;
            usu.Senha_usu = txtSenha.Text;

            DAO_Usuario daousuario = new DAO_Usuario();
            usuarioretorno = daousuario.Login_usuario(usu);

            if (usuarioretorno.Nome_usu != null)
            {
                MessageBox.Show("Seja bem-vindo ao T-LOCKER - Sr(a) " +
                    usuarioretorno.Nome_usu, "Login Usuário",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                retorno = true;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Dados inválidos",
                    "Login Usuário", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtLogin.Focus();
            }
            
            #endregion
        }

        private void btnMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (btnMostrarSenha.Checked)
            {
                txtSenha.PasswordChar = '\u0000';
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }

        private void btnEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRecuperarSenha objrecuperar = new FrmRecuperarSenha();
            objrecuperar.ShowDialog();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
