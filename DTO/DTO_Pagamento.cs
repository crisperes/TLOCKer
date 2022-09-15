using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_Pagamento
    {

        private int pag_id;
        private string pag_resp_nome;
        private DateTime pag_data;
        private decimal pag_valor;
        private int id_armario;

        public int Pag_id { get => pag_id; set => pag_id = value; }
        public string Pag_resp_nome { get => pag_resp_nome; set => pag_resp_nome = value; }
        public DateTime Pag_data { get => pag_data; set => pag_data = value; }
        public decimal Pag_valor { get => pag_valor; set => pag_valor = value; }
        public int Id_armario { get => id_armario; set => id_armario = value; }
    }
}
