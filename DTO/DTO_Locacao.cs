using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_Locacao
    {
        private int locacao_id;
        private int rm_alu;
        private int id_armario;
        private int id_usu;
        private DateTime locacao_data;
        private decimal locacao_valor;
        private string locacao_tipo;
        int pag_id;
        string nome_alu;

        public int Locacao_id { get => locacao_id; set => locacao_id = value; }
        public int Rm_alu { get => rm_alu; set => rm_alu = value; }
        public int Id_armario { get => id_armario; set => id_armario = value; }
        public int Id_usu { get => id_usu; set => id_usu = value; }
        public DateTime Locacao_data { get => locacao_data; set => locacao_data = value; }
        public decimal Locacao_valor { get => locacao_valor; set => locacao_valor = value; }
        public string Locacao_tipo { get => locacao_tipo; set => locacao_tipo = value; }
        public int Pag_id { get => pag_id; set => pag_id = value; }
        public string Nome_alu { get => nome_alu; set => nome_alu = value; }
    }
}
