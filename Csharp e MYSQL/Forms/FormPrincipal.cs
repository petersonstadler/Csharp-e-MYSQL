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
    }
}
