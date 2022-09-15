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
    public partial class FrmPagamento : Form
    {
        AcaoTela opcao;
        public FrmPagamento()
        {
            InitializeComponent();
            dgvPagamento.AutoGenerateColumns = false;
            CarregarPagamento();


            opcao = AcaoTela.Inserir;
        }
        public FrmPagamento(AcaoTela acaoTela, DTO_Locacao locacao)
        {
            InitializeComponent();
            dgvPagamento.AutoGenerateColumns = false;
            CarregarPagamento();
            CarregarLocacao();
            btnCadastrar.Enabled = true;
            dataPagamento.Enabled = true;
            
            
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
                txtArmario.Text = locacao.Id_armario.ToString();
                txtValor.Text = Convert.ToString(locacao.Locacao_valor);

            }
            #endregion
        }

        private void CarregarPagamento()
        {
            DAO_Pagamento pagamentodao = new DAO_Pagamento();

            DTO_ColecaoPagamento colecaopagamento = pagamentodao.SelecionarPagamento();

            dgvPagamento.DataSource = null;
            dgvPagamento.DataSource = colecaopagamento;
        }

        private void CarregarLocacao()
        {

            DAO_Pagamento pagar = new DAO_Pagamento();
            DataTable dataS = pagar.CarregarLocacao();


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

        private void FrmPagamento_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_MouseClick(object sender, MouseEventArgs e)
        {
            Consistencia.Limpar(this);
            btnRemover.Enabled = false;
            btnAlterar.Enabled = false;
            btnComprovante.Enabled = false;
            btnCadastrar.Enabled = false;
            dataPagamento.Enabled = false;
        }

        private void dgvPagamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DTO_Pagamento pagamento = dgvPagamento.SelectedRows[0].DataBoundItem as DTO_Pagamento;
                txtArmario.Text = pagamento.Id_armario.ToString();
                txtpagid.Text = pagamento.Pag_id.ToString();
                txtValor.Text = pagamento.Pag_valor.ToString();
                dataPagamento.Value = pagamento.Pag_data;
                txtRespPagamento.Text = pagamento.Pag_resp_nome.ToString();
                btnRemover.Enabled = true;
                btnAlterar.Enabled = true;
                btnComprovante.Enabled = true;
                dataPagamento.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Efetue o Pagamento antes de Consultar");
            }
           
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            #region Cadastrar Pagamento
            try
            {

                DTO_Pagamento pag = new DTO_Pagamento();

                pag.Pag_resp_nome = txtRespPagamento.Text;
                pag.Pag_data = dataPagamento.Value = DateTime.Parse(dataPagamento.Text);
                pag.Pag_valor = Convert.ToDecimal(txtValor.Text);
                pag.Id_armario = Convert.ToInt32(txtArmario.Text);


                if (string.IsNullOrWhiteSpace(txtArmario.Text) || string.IsNullOrWhiteSpace(txtValor.Text) ||
                    string.IsNullOrWhiteSpace(txtRespPagamento.Text))
                {
                    MessageBox.Show("Por favor preencha todos os campos.");
                }
                else
                {
                    DAO_Pagamento daoloc = new DAO_Pagamento();
                    object retorno = daoloc.Adicionar(pag);
                    MessageBox.Show("Pagamento Realizado"
                        , "Pagamento bem Sucedido",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarPagamento();
                    Consistencia.Limpar(this);
                    btnCadastrar.Enabled = false;
                    dataPagamento.Enabled = false;
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
            if (dgvPagamento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Pagamento selecionado",
                    "Consistencia", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Deseja Realmente Excluir o Pagamento?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DTO_Pagamento pagamentoselecionado = dgvPagamento.SelectedRows[0].DataBoundItem as DTO_Pagamento;
                    DAO_Pagamento daopagamento = new DAO_Pagamento();
                    string retorno = daopagamento.Excluir(pagamentoselecionado);

                    if (retorno == "1")
                    {
                        MessageBox.Show("Pagamento Excluido com Sucesso");
                        Consistencia.Limpar(this);
                        btnRemover.Enabled = false;
                        btnAlterar.Enabled = false;
                        btnComprovante.Enabled = false;



                        CarregarPagamento();
                    }
                    else
                    {
                        MessageBox.Show(retorno);
                    }

                }
            }
        }

        private void dgvPagamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtArmario_TextChanged(object sender, EventArgs e)
        {
            if (txtArmario.Text != string.Empty)

            {
                DTO_Pagamento pagamento = new DTO_Pagamento();
                pagamento.Id_armario = Convert.ToInt32(txtArmario.Text);


                DAO_Pagamento pagamentodao = new DAO_Pagamento();
                DTO_ColecaoPagamento colecaopagamento = pagamentodao.SelecionarPagamentoEspecifico(pagamento);

                dgvPagamento.DataSource = colecaopagamento;

            }

            else
            {
                CarregarPagamento();

            }
        }

        private void btnComprovante_Click(object sender, EventArgs e)
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            #region Alterar Pagamento
            try
            {

                DTO_Pagamento pag = new DTO_Pagamento();

                pag.Pag_resp_nome = txtRespPagamento.Text;
                pag.Pag_data = dataPagamento.Value = DateTime.Parse(dataPagamento.Text);
                pag.Pag_valor = Convert.ToDecimal(txtValor.Text);
                pag.Id_armario = Convert.ToInt32(txtArmario.Text);
                pag.Pag_id = Convert.ToInt32(txtpagid.Text);


                if (string.IsNullOrWhiteSpace(txtArmario.Text) || string.IsNullOrWhiteSpace(txtValor.Text) ||
                    string.IsNullOrWhiteSpace(txtRespPagamento.Text))
                {
                    MessageBox.Show("Por favor preencha todos os campos.");
                }
                else
                {
                    DAO_Pagamento daoloc = new DAO_Pagamento();
                   object retorno = daoloc.Alterar(pag);
                    MessageBox.Show("Pagamento Alterado"
                        , "Alteração bem Sucedida",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarPagamento();
                    Consistencia.Limpar(this);
                    btnCadastrar.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnRemover.Enabled = false;
                    btnComprovante.Enabled = false;
                    
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Por favor preencha todos os campos.");
            }
            #endregion
        }

        private void btnAlterar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
