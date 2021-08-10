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
                    db.NonQuery($"INSERT INTO produto VALUES (null, '{txtBoxNome.Text}', {txtBoxCodigo.Text}, {txtBoxCusto.Text.Replace(",",".")}, {txtBoxVenda.Text.Replace(",", ".")});");
                    MessageBox.Show("Produto inserido com sucesso!", "Inserir Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Validador validar = new Validador();
            string msgNome = "";
            string msgCodigo = "";
            string msgCusto = "";
            string msgVenda = "";
            bool nom, cod, custo, venda;

            nom = validar.CampoNome(txtBoxNome.Text, ref msgNome);
            cod = validar.CampoCodigo(txtBoxCodigo.Text, ref msgCodigo);
            custo = validar.CampoDecimal(txtBoxCusto.Text, ref msgCusto);
            venda = validar.CampoDecimal(txtBoxVenda.Text, ref msgVenda);

            if (nom && cod && custo && venda)
            {
                lblMsgNome.Text = msgNome;
                lblMsgCodigo.Text = msgCodigo;
                lblMsgCusto.Text = msgCusto;
                lblMsgVenda.Text = msgVenda;
                return true;
            }
            else
            {
                lblMsgNome.Text = msgNome;
                lblMsgCodigo.Text = msgCodigo;
                lblMsgCusto.Text = msgCusto;
                lblMsgVenda.Text = msgVenda;
                MessageBox.Show("Confira as mensagens dos campos", "Inserir Produto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InserirProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtBoxNome.Text != "" || txtBoxCodigo.Text != "" || txtBoxCusto.Text != "" || txtBoxVenda.Text != "") 
            {
                var msg = MessageBox.Show("Tem certeza que deseja sair sem salvar as alterações?", "Sair sem Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                } 
            }
        }
    }
}
