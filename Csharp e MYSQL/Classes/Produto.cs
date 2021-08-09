using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_e_MYSQL.Classes
{
    class Produto
    {
        private int id, cod;
        private string nome;
        decimal custo, venda;

        public int Id { get => id; set => id = value; }
        public int Cod { get => cod; set => cod = value; }
        public string Nome { get => nome; set => nome = value; }
        public decimal Custo { get => custo; set => custo = value; }
        public decimal Venda { get => venda; set => venda = value; }
    }
}
