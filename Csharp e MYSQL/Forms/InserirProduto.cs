using System;
using System.Windows.Forms;
using Csharp_e_MYSQL.Classes;

namespace Csharp_e_MYSQL.Forms
{
    public partial class InserirProduto : Form
    {
        public InserirProduto()
        {
            InitializeComponent();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                DatabaseConnection db = new DatabaseConnection();
                try
                {
                    db.NonQuery($"INSERT INTO produto VALUES (null, '{txtBoxNome.Text}', {txtBoxCodigo.Text}, {txtBoxCusto.Text}, {txtBoxVenda.Text});");
                    MessageBox.Show("Produto inserido com sucesso!", "Inserir Produto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch(Exception er)
                {
                    MessageBox.Show("Erro ao incluir produto!" + er, "Incluir Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db.Close();
                }
            }
        }

        private bool ValidarFormulario()
        {
            return true;
        }
    }
}
