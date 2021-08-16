using System.Windows.Forms;
using System.Data;
using System;

namespace Csharp_e_MYSQL.Classes
{
    public class Produto
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

        public void BuscarProdutoPorId(int idbusca, ref DataTable dt)
        {
            DatabaseConnection db = new DatabaseConnection();
            dt = db.FillDataTable($"SELECT idprod as Id, nomeprod as Nome, codprod as Codigo, custoprod as Custo, vendaprod as Venda FROM produto WHERE idprod = {idbusca};", "Buscar Produto");
        }

        public void BuscarProdutoPorNome(string busca, ref DataTable dt)
        {
            DatabaseConnection db = new DatabaseConnection();
            dt = db.FillDataTable($"SELECT idprod as Id, nomeprod as Nome, codprod as Codigo, custoprod as Custo, vendaprod as Venda FROM produto WHERE nomeprod LIKE'%{busca}%';", "Buscar Produto");
        }

        public DataTable BuscaEmDigitacao(string busca)
        {
            DatabaseConnection db = new DatabaseConnection();
            return db.FillDataTable($"SELECT idprod as Id, nomeprod as Nome, codprod as Codigo, custoprod as Custo, vendaprod as Venda FROM produto WHERE nomeprod LIKE'{busca}%';", "Buscar Produto");
        }

        public void ExcluirProduto(int idex)
        {
            DatabaseConnection db = new DatabaseConnection();
            try
            {
                db.NonQuery($"DELETE FROM produto WHERE idprod = {idex}");
                MessageBox.Show("Produto Excluído com sucesso!", "Excluir Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível realizar a exclusão!\n\n" + e, "Excluir Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
