namespace DTO
{
    public class DTO_Armario
    {
        private int id_armario;
        private string local_armario;
        private string descricao_armario;
        private string status_armario;
        private decimal valor_armario;

        public int Id_armario { get => id_armario; set => id_armario = value; }
        public string Local_armario { get => local_armario; set => local_armario = value; }
        public string Descricao_armario { get => descricao_armario; set => descricao_armario = value; }
        public string Status_armario { get => status_armario; set => status_armario = value; }
        public decimal Valor_armario { get => valor_armario; set => valor_armario = value; }
    }
}