using System;
using System.Windows.Forms;
using Csharp_e_MYSQL.Classes;

namespace Csharp_e_MYSQL.Forms
{
    public partial class InserirProduto : Form
    {

        public Produto produto = new Produto();
        private char func = 'i';

        public char Func { get => func; set => func = value; }

        public InserirProduto()
        {
            InitializeComponent();
        }

        public InserirProduto(Produto p)
        {
            InitializeComponent();
            produto = p;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                DatabaseConnection db = new DatabaseConnection();
                try
                {
                    if (Func == 'i')
                    {
                        db.NonQuery($"INSERT INTO produto VALUES (null, '{txtBoxNome.Text}', {txtBoxCodigo.Text}, {txtBoxCusto.Text.Replace(",", ".")}, {txtBoxVenda.Text.Replace(",", ".")});");
                        MessageBox.Show("Produto inserido com sucesso!", "Inserir Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparTxtBox();
                    }
                    else
                    {
                        db.NonQuery($"UPDATE produto SET nomeprod = '{txtBoxNome.Text}', codprod = {txtBoxCodigo.Text}, custoprod = {txtBoxCusto.Text.Replace(",", ".")}, vendaprod = {txtBoxVenda.Text.Replace(",", ".")} WHERE idprod = {produto.Id}");
                        produto.Nome = txtBoxNome.Text;
                        produto.Cod = Convert.ToInt32(txtBoxCodigo.Text);
                        produto.Custo = Convert.ToDecimal(txtBoxCusto.Text);
                        produto.Venda = Convert.ToDecimal(txtBoxVenda.Text);
                        MessageBox.Show("Produto alterado com sucesso!", "Alterado Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                catch(Exception er)
                {
                    if (Func == 'i')
                    {
                        MessageBox.Show("Erro ao incluir produto!" + er, "Incluir Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar produto!" + er, "Alterar Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.Close();
                    }
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
            if (func == 'i')
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
            else
            {
                if (txtBoxNome.Text != produto.Nome || txtBoxCodigo.Text != Convert.ToString(produto.Cod) || txtBoxCusto.Text != Convert.ToString(produto.Custo) || txtBoxVenda.Text != Convert.ToString(produto.Venda))
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

        public void PopularTxtBox(string nom, int cod, decimal cust, decimal vend)
        {
            txtBoxNome.Text = nom;
            txtBoxCodigo.Text = Convert.ToString(cod);
            txtBoxCusto.Text = Convert.ToString(cust);
            txtBoxVenda.Text = Convert.ToString(vend);
        }

        public void LimparTxtBox()
        {
            txtBoxNome.Text = "";
            txtBoxCodigo.Text = "";
            txtBoxCusto.Text = "";
            txtBoxVenda.Text = "";
        }

        private void txtBoxNome_TextChanged(object sender, EventArgs e)
        {
            Validador validar = new Validador();
            string msgNome = "";
            _ = validar.CampoNome(txtBoxNome.Text, ref msgNome);
            lblMsgNome.Text = msgNome;
        }

        private void txtBoxCodigo_TextChanged(object sender, EventArgs e)
        {
            Validador validar = new Validador();
            string msgCod = "";
            _ = validar.CampoCodigo(txtBoxCodigo.Text, ref msgCod);
            lblMsgCodigo.Text = msgCod;
        }

        private void txtBoxCusto_TextChanged(object sender, EventArgs e)
        {
            Validador validar = new Validador();
            string msgCusto = "";
            _ = validar.CampoDecimal(txtBoxCusto.Text, ref msgCusto);
            lblMsgCusto.Text = msgCusto;
        }

        private void txtBoxVenda_TextChanged(object sender, EventArgs e)
        {
            Validador validar = new Validador();
            string msgVenda = "";
            _ = validar.CampoDecimal(txtBoxVenda.Text, ref msgVenda);
            lblMsgVenda.Text = msgVenda;
        }
    }
}
