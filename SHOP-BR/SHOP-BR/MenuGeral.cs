using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOP_BR
{
    public partial class MenuGeral : Form
    {
        public MenuGeral()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja();
            this.Hide();
            loja.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            this.Hide();
            produto.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            this.Hide();
            cliente.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();
            this.Hide();
            compra.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Correio correio = new Correio();
            this.Hide();
            correio.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Avaliacao avaliacao = new Avaliacao();
            this.Hide();
            avaliacao.Show();
        }
    }
}
