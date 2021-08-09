using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Csharp_e_MYSQL.Classes;

namespace Csharp_e_MYSQL
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            Produto p = new Produto();
            DataTable dt = new DataTable();
            p.ListarProdutos(ref dt);
            dataGridMain.DataSource = dt;
        }
    }
}
