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
    public partial class FrmLocacao : Form
    {
        AcaoTela opcao;
        public FrmLocacao()
        {
            InitializeComponent();
            dgvLocacao.AutoGenerateColumns = false;
            CarregarLocacao();
            CarregarAluno();


            opcao = AcaoTela.Inserir;

        }
        public FrmLocacao(AcaoTela acaoTela, DTO_Armario armario)
        {
            InitializeComponent();
            dgvLocacao.AutoGenerateColumns = false;

            CarregarLocacao();
            CarregarArmario();
            CarregarAluno();
            CarregarUsuario();
            txtArmario.Enabled = false;
            btnCadastrar.Enabled = true;
            

            #region Verifica ação que será excutada
            if (acaoTela == AcaoTela.Inserir)
            {
                this.Text = "Opção invalida";
                opcao = acaoTela;
            }
            else if (acaoTela == AcaoTela.Alterar)
            {
                this.Text = "Locação de Armario";
                opcao = acaoTela;
                txtArmario.Text = armario.Id_armario.ToString();
                txtValor.Text = Convert.ToString(armario.Valor_armario);
                
            }
            #endregion
        }

        private void CarregarArmario()
        {

            DAO_Locacao locar2 = new DAO_Locacao();
            DataTable dataS = locar2.CarregarArmario();
            

        }

        private void CarregarAluno()
        {
            DAO_Locacao locar = new DAO_Locacao();
            DataTable dataT = locar.CarregarAluno();

            cmbAlunos.DataSource = dataT;

            cmbAlunos.ValueMember = "tb_aluno_rm";
            cmbAlunos.DisplayMember = "tb_aluno_nome";

        }
        private void CarregarLocacao()
        {
            DAO_Locacao locacaodao = new DAO_Locacao();

            DTO_ColecaoLocacao colecaolocacao = locacaodao.SelecionarLocacao();

            dgvLocacao.DataSource = null;
            dgvLocacao.DataSource = colecaolocacao;
        }

       

        private void CarregarUsuario()
        {
            DAO_Locacao locar3 = new DAO_Locacao();
            DataTable dataR = locar3.CarregarUsuario();

        }


        private void ClickHover(object sender, MouseEventArgs e)
        {

        }

        private void ClickHover(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNumArmario_TextChanged(object sender, EventArgs e)
        {
            if (txtArmario.Text != string.Empty)

            {
                DTO_Locacao locacao = new DTO_Locacao();
                locacao.Id_armario = Convert.ToInt32(txtArmario.Text);
                



                DAO_Locacao locacaodao = new DAO_Locacao();
                DTO_ColecaoLocacao colecaolocacao = locacaodao.SelecionarLocacaoEspecifica(locacao);

                dgvLocacao.DataSource = colecaolocacao;

            }

            else
            {
                CarregarLocacao();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmLocacao_Load(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvLocacao.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma Locação selecionada",
                    "Consistencia", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Deseja Realmente Excluir a Locação?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DTO_Locacao locacaoselecionada = dgvLocacao.SelectedRows[0].DataBoundItem as DTO_Locacao;
                    DAO_Locacao daolocacao = new DAO_Locacao();
                    string retorno = daolocacao.Excluir(locacaoselecionada);

                    if (retorno == "1")
                    {
                        MessageBox.Show("Locação Excluida com Sucesso");
                        #region limpar
                        txtValor.Text = "0,00";
                        txtValorF.Text = null;
                        txtArmario.Text = null;
                        dataLocacao.Text = null;
                        cmbAlunos.Text = null;
                        cmbTipo.Text = null;
                        #endregion
                        btnCadastrar.Enabled = false;
                        btnContrato.Enabled = false;
                        btnEncerrar.Enabled = false;
                        btnPagar.Enabled = false;



                        CarregarLocacao();
                    }
                    else
                    {
                        MessageBox.Show(retorno);
                    }

                }
            }
        }

        private void btnAlterar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            #region Cadastrar Locação
            try
            {

                DTO_Locacao loc = new DTO_Locacao();
                loc.Rm_alu = Convert.ToInt32(cmbAlunos.SelectedValue.ToString());
                loc.Id_armario = Convert.ToInt32(txtArmario.Text);
                loc.Locacao_data = dataLocacao.Value = DateTime.Parse(dataLocacao.Text);
                loc.Locacao_valor = Convert.ToDecimal(txtValorF.Text);
                loc.Locacao_tipo = cmbTipo.SelectedItem.ToString();


                if (string.IsNullOrWhiteSpace(txtArmario.Text) || string.IsNullOrWhiteSpace(txtValor.Text) || string.IsNullOrWhiteSpace(cmbAlunos.Text))
                {
                    MessageBox.Show("Por favor preencha todos os campos.");
                }
                else
                {
                    DAO_Locacao daoloc = new DAO_Locacao();
                    object retorno = daoloc.Adicionar(loc);
                    MessageBox.Show("Locação Realizada"
                        , "Locação bem Sucedida",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarLocacao();
                    //Consistencia.Limpar(this);
                    #region limpar
                    txtValor.Text = "0,00";
                    txtValorF.Text = null;
                    txtArmario.Text = null;
                    dataLocacao.Text = null;
                    cmbAlunos.Text = null;
                    cmbTipo.Text = null;
                    #endregion
                    btnCadastrar.Enabled = false;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Por favor preencha todos os campos.");
            }

            #endregion


        }

        private void btnLimpar_MouseClick(object sender, MouseEventArgs e)
        {


            #region limpar
            txtValor.Text = "0,00";
            txtValorF.Text = null;
            txtArmario.Text = null;
            dataLocacao.Text = null;
            cmbAlunos.Text = null;
            cmbTipo.Text = null;
            #endregion
            btnCadastrar.Enabled = false;
            btnContrato.Enabled = false;
            btnEncerrar.Enabled = false;
            btnPagar.Enabled = false;
            
        }

        private void dgvLocacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvLocacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DTO_Locacao locacao = dgvLocacao.SelectedRows[0].DataBoundItem as DTO_Locacao;
                txtArmario.Text = locacao.Id_armario.ToString();
                cmbAlunos.SelectedValue = locacao.Rm_alu.ToString();
                cmbTipo.Text = locacao.Locacao_tipo;

                txtValorF.Text = locacao.Locacao_valor.ToString();
                dataLocacao.Value = locacao.Locacao_data;

                btnCadastrar.Enabled = false;
                btnContrato.Enabled = true;
                btnEncerrar.Enabled = true;
                btnPagar.Enabled = true;

            }
            catch (Exception)
            {

                MessageBox.Show("Efetue a Locação antes de Consultar");
            }
            
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            DTO_Locacao locacaoselecionada = dgvLocacao.SelectedRows[0].DataBoundItem as DTO_Locacao;
            Consistencia.AbrirForm(new FrmPagamento(AcaoTela.Alterar, locacaoselecionada), this.ParentForm, this.ParentForm);
            CarregarLocacao();
        }

        private void cmbAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            decimal price = Convert.ToDecimal(txtValor.Text);
            
         

            if (cmbTipo.SelectedIndex == 0)
            {

                txtValorF.Text = Convert.ToDecimal(price).ToString();

            }

            else if (cmbTipo.SelectedIndex == -1)
            {
               
            }

            else
            {
                decimal price1, price2, price3;

                price1 = Convert.ToDecimal(price);
                price2 = Convert.ToDecimal(price);
                price3 = price1 + price2;

                txtValorF.Text = Convert.ToDecimal(price3).ToString();
            }


        }

        private void txtValorF_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
