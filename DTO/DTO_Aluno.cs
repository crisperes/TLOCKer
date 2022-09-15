namespace DTO
{
    public class DTO_Aluno
    {
        private int rm_alu;
        private string turma_alu;
        private string nome_alu;
        private string cpf_alu;
        private string email_alu;
        private string telefone_alu;
        private string resp_nome_alu;
        private string resp_cpf_alu;
        private string resp_email_alu;
        private string resp_telefone_alu;
        int id_armario;
        private string locacao_tipo;

        public int Rm_alu { get => rm_alu; set => rm_alu = value; }
        public string Turma_alu { get => turma_alu; set => turma_alu = value; }
        public string Nome_alu { get => nome_alu; set => nome_alu = value; }
        public string Cpf_alu { get => cpf_alu; set => cpf_alu = value; }
        public string Email_alu { get => email_alu; set => email_alu = value; }
        public string Telefone_alu { get => telefone_alu; set => telefone_alu = value; }
        public string Resp_nome_alu { get => resp_nome_alu; set => resp_nome_alu = value; }
        public string Resp_cpf_alu { get => resp_cpf_alu; set => resp_cpf_alu = value; }
        public string Resp_email_alu { get => resp_email_alu; set => resp_email_alu = value; }
        public string Resp_telefone_alu { get => resp_telefone_alu; set => resp_telefone_alu = value; }
        public int Id_armario { get => id_armario; set => id_armario = value; }
        public string Locacao_tipo { get => locacao_tipo; set => locacao_tipo = value; }
    }
}