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
    public partial class FrmArmario : Form
    {
        public FrmArmario()
        {
            InitializeComponent();
            dgvArmario.AutoGenerateColumns = false;
            CarregarArmario();
            cmbStatus.SelectedIndex = 0;
        }

        private void CarregarArmario()
        {
            DAO_Armario armariodao = new DAO_Armario();

            ColecaoArmario colecaoarmario = armariodao.SelecionarArmarios();

            dgvArmario.DataSource = null;
            dgvArmario.DataSource = colecaoarmario;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAlterar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRemover_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClickHover(object sender, EventArgs e)
        {

        }

        private void ClickHover(object sender, MouseEventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            #region Inserir Armario
            try
            {
                
                DTO_Armario arm = new DTO_Armario();
                arm.Id_armario = Convert.ToInt16(txtArmario.Text);
                arm.Local_armario = txtLocal.Text;
                arm.Descricao_armario = txtDescricao.Text;
                arm.Status_armario = cmbStatus.SelectedItem.ToString();
                arm.Valor_armario = Convert.ToDecimal(txtValor.Text);


                if (string.IsNullOrWhiteSpace(txtArmario.Text) || string.IsNullOrWhiteSpace(txtValor.Text) || string.IsNullOrWhiteSpace(txtLocal.Text) ||
                    string.IsNullOrWhiteSpace(txtDescricao.Text))
                {
                    MessageBox.Show("Por favor preencha todos os campos.");
                }
                else
                {
                    DAO_Armario daoarm = new DAO_Armario();
                    object retorno = daoarm.Inserir(arm);
                    MessageBox.Show("Armario Cadastrado", "Cadastrado com Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvArmario.DataSource = daoarm.SelecionarArmarios();
                    Consistencia.Limpar(this);
                    txtArmario.Enabled = true;
                    cmbStatus.SelectedIndex = 0;
                    CarregarArmario();
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor preencha todos os campos.");
            }

            #endregion
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            #region Alterar Armario
            try
            {

                DTO_Armario arm = new DTO_Armario();
                arm.Id_armario = Convert.ToInt16(txtArmario.Text);
                arm.Local_armario = txtLocal.Text;
                arm.Descricao_armario = txtDescricao.Text;
                arm.Status_armario = cmbStatus.SelectedItem.ToString();
                arm.Valor_armario = Convert.ToDecimal(txtValor.Text);


                if (string.IsNullOrWhiteSpace(txtArmario.Text) || string.IsNullOrWhiteSpace(txtValor.Text) || string.IsNullOrWhiteSpace(txtLocal.Text) ||
                    string.IsNullOrWhiteSpace(txtDescricao.Text))
                {
                    MessageBox.Show("Por favor preencha todos os campos.");
                }
                else
                {
                    DAO_Armario daoarm = new DAO_Armario();
                    daoarm.Alterar(arm);
                    MessageBox.Show("Armario Alterado.", "Alterado com Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvArmario.DataSource = daoarm.SelecionarArmarios();
                    Consistencia.Limpar(this);
                    txtArmario.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnCadastrar.Enabled = true;
                    btnRemover.Enabled = false;
                    btnLocarArmario.Enabled = false;
                    cmbStatus.SelectedIndex = 0;
                    CarregarArmario();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Por favor preencha todos os campos.");
            }

            #endregion
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

            #region Remover Armario

            if (dgvArmario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum armario selecionado.",
                    "Consistencia", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Deseja realmente excluir o Armario?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DTO_Armario armarioselecionado = dgvArmario.SelectedRows[0].DataBoundItem as DTO_Armario;
                    DAO_Armario daoarmario = new DAO_Armario();
                    string retorno = daoarmario.Excluir(armarioselecionado);

                    if (retorno == "1")
                    {
                        MessageBox.Show("Armario excluido com Sucesso");
                        Consistencia.Limpar(this);
                        txtArmario.Enabled = true;
                        btnAlterar.Enabled = false;
                        btnCadastrar.Enabled = true;
                        btnRemover.Enabled = false;
                        btnLocarArmario.Enabled = false;
                        cmbStatus.SelectedIndex = 0;
                        CarregarArmario();
                    }
                    else
                    {
                        MessageBox.Show(retorno);
                    }

                }
            }

            #endregion
        }

        private void dgvArmario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int rowIndex = e.RowIndex;

          



            DTO_Armario armario =
            dgvArmario.SelectedRows[0].DataBoundItem as DTO_Armario;

            this.txtArmario.Text = armario.Id_armario.ToString();
            this.txtDescricao.Text = armario.Descricao_armario;
            this.txtLocal.Text = armario.Local_armario;
            this.txtValor.Text = Convert.ToString(armario.Valor_armario);
            this.cmbStatus.Text = armario.Status_armario;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnRemover.Enabled = true;
            btnLocarArmario.Enabled = true;
            txtArmario.Enabled = false;

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text != string.Empty)

            {
                DTO_Armario armario = new DTO_Armario();
                armario.Status_armario = cmbStatus.Text;


                DAO_Armario armariodao = new DAO_Armario();
                ColecaoArmario colecaoarmario = armariodao.SelecionarArmEspecifico(armario);

                dgvArmario.DataSource = colecaoarmario;
                
            }
        }

        private void btnLocarArmario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLocarArmario_Click(object sender, EventArgs e)
        {
            DTO_Armario armarioselecionado = dgvArmario.SelectedRows[0].DataBoundItem as DTO_Armario;
            Consistencia.AbrirForm(new FrmLocacao(AcaoTela.Alterar, armarioselecionado), this.ParentForm, this.ParentForm);
            CarregarArmario();
        }

        private void FrmArmario_Load(object sender, EventArgs e)
        {

        }

        private void txtArmario_TextChanged(object sender, EventArgs e)
        {
            

            
        }

        private void dgvArmario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCadastrar_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnLimpar_MouseClick(object sender, MouseEventArgs e)
        {
            Consistencia.Limpar(this);
            cmbStatus.SelectedIndex = 0;
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnRemover.Enabled = false;
            btnLocarArmario.Enabled = false;
            txtArmario.Enabled = true;
            CarregarArmario();
        }

        private void txtArmario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnCadastrar_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
