using System;
using System.Data;
using System.Windows.Forms;
using Csharp_e_MYSQL.Classes;
using Csharp_e_MYSQL.Forms;

namespace Csharp_e_MYSQL
{
    public partial class FormPrincipal : Form
    {
        private InserirProduto FormProduto;
        private Produto produto = new Produto();

        public FormPrincipal()
        {
            InitializeComponent();
            dataGridMain.DataSource = produto.ListarProdutos();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(FormProduto == null || FormProduto.IsDisposed)
            {
                FormProduto = new InserirProduto();
                FormProduto.InserirOuAlterar = 'i';
                FormProduto.Show();
            }
            else
            {
                FormProduto.LimparTxtBox();
                FormProduto.InserirOuAlterar = 'i';
                FormProduto.Show();
                FormProduto.Focus();
            }
        }

        private void dataGridMain_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridMain.Rows[e.RowIndex].Selected = true;
                produto.Id = Convert.ToInt32(dataGridMain.Rows[e.RowIndex].Cells[0].Value);
                produto.Nome = Convert.ToString(dataGridMain.Rows[e.RowIndex].Cells[1].Value);
                produto.Cod = Convert.ToInt32(dataGridMain.Rows[e.RowIndex].Cells[2].Value);
                produto.Custo = Convert.ToDecimal(dataGridMain.Rows[e.RowIndex].Cells[3].Value);
                produto.Venda = Convert.ToDecimal(dataGridMain.Rows[e.RowIndex].Cells[4].Value);
            }
            catch(Exception er)
            {
                MessageBox.Show("Erro ao preencher produto. \n\n" + er, "Preencher Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (FormProduto == null || FormProduto.IsDisposed)
            {
                FormProduto = new InserirProduto();
                FormProduto.InserirOuAlterar = 'a';
                FormProduto.produto = produto;
                FormProduto.PopularTxtBox(produto.Nome, produto.Cod, produto.Custo, produto.Venda);
                FormProduto.Show();
            }
            else
            {
                FormProduto.produto = produto;
                FormProduto.PopularTxtBox(produto.Nome, produto.Cod, produto.Custo, produto.Venda);
                FormProduto.InserirOuAlterar = 'a';
                FormProduto.Show();
                FormProduto.Focus();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int busca;
            if(int.TryParse(txtBoxPesquisa.Text, out busca))
            {
                dataGridMain.DataSource = produto.BuscarProdutoPorId(busca);
            }
            else
            {
                dataGridMain.DataSource = produto.BuscarProdutoPorNome(txtBoxPesquisa.Text);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Deseja Excluir o Produto {produto.Nome}?", "Excluir Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                result = MessageBox.Show($"Tem certeza que deseja Excluir o Produto {produto.Nome}? Uma vez excluido não terá retorno.", "Excluir Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    produto.ExcluirProduto(produto.Id);
                    produto = new Produto();
                }
                else
                {
                    MessageBox.Show("Produto não excluido!", "Excluir Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
            dataGridMain.DataSource = produto.BuscaEmDigitacao(txtBoxPesquisa.Text);
        }
    }
}
