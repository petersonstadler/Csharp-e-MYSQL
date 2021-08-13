using System.Windows.Forms;
using System.Data;

namespace Csharp_e_MYSQL.Classes
{
    class Produto
    {
        private int id, cod;
        private string nome;
        private decimal custo, venda;

        public int Id { get => id; set => id = value; }
        public int Cod { get => cod; set => cod = value; }
        public string Nome { get => nome; set => nome = value; }
        public decimal Custo { get => custo; set => custo = value; }
        public decimal Venda { get => venda; set => venda = value; }

        public void ListarProdutos(ref DataTable dt)
        {
            DatabaseConnection db = new DatabaseConnection();
            dt = db.FillDataTable("SELECT idprod as Id, nomeprod as Nome, codprod as Codigo, custoprod as Custo, vendaprod as Venda FROM produto;", "Listar Produtos");
        }
    }
}
