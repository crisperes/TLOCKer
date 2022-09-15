using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using View;

namespace TLOCKER_SYSTEM
{
    public partial class FrmPrincipal : Form
    {
        int codusu;
        public FrmPrincipal(DTO_Usuario usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario.Nome_usu;
            codusu = usuario.Id_usu;
            lblData.Text = DateTime.Now.ToShortDateString();
            
        }

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Consistencia.AbrirForm(new FrmArmario(), this, this);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnInicio_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnAlunos_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnLocacao_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnPagamentos_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnAdmin_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnSair_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnSair_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnAdmin_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnPagamentos_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnLocacao_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnAlunos_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnInicio_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void timeHour_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnMinimizar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClickHover(object sender, MouseEventArgs e)
        {

        }

        private void btnAlunos_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnLocacao_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnPagamentos_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnAdmin_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnManual_Paint(object sender, PaintEventArgs e)
        {
            // Abrir manual em PDF
        }

        private void btnSobre_Paint(object sender, PaintEventArgs e)
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

        private void btnAlunos_MouseClick_1(object sender, MouseEventArgs e)
        {
            Consistencia.AbrirForm(new FrmAluno(), this, this);
        }

        private void btnLocacao_MouseClick_1(object sender, MouseEventArgs e)
        {
            Consistencia.AbrirForm(new FrmLocacao(), this, this);
        }

        private void btnPagamentos_MouseClick_1(object sender, MouseEventArgs e)
        {
            Consistencia.AbrirForm(new FrmPagamento(), this, this);
        }

        private void btnAdmin_MouseClick_1(object sender, MouseEventArgs e)
        {
            Consistencia.AbrirForm(new FrmUsuario(), this, this);
        }

        private void btnManual_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnInicio_MouseClick_1(object sender, MouseEventArgs e)
        {
            Consistencia.AbrirForm(new FrmArmario()
                , this, this);
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnSobre_MouseClick(object sender, MouseEventArgs e)
        {
            Consistencia.AbrirForm(new FrmSobre(), this, this);
        }

        private void btnSair_MouseClick_1(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
