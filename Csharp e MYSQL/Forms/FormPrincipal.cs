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
            Produto p = new Produto();
            DataTable dt = new DataTable();
            p.ListarProdutos(ref dt);
            dataGridMain.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(FormProduto == null || FormProduto.IsDisposed)
            {
                FormProduto = new InserirProduto();
                FormProduto.Show();
            }
            else
            {
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
                produto.Venda = Convert.ToDecimal(dataGridMain.Rows[e.RowIndex].Cells[3].Value);
            }
            catch(Exception er)
            {
                MessageBox.Show("Erro ao preencher produto. \n\n" + er, "Preencher Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
