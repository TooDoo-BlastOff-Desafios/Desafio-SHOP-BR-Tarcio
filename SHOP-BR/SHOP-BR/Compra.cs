using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOP_BR
{
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }

        private void BuscarProdutos_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);

            string sql = @"SELECT [Produto].[id] AS [id_produto], [Produto].[nome] AS [nome_produto], [Produto].[Preco], [Produto].[quantidade_estoque]
                            FROM[Produto]";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand command = new SqlCommand(sql, connection);

                //Abrimos a conexão com o banco de dados
                connection.Open();

                //Executa o comando sql no banco de dados
                SqlDataReader reader = command.ExecuteReader();
                var list = new List<string>();
                while (reader.Read())
                {
                    list.Add("ID: " + reader["id_produto"].ToString() + " - " + " Nome: "
                        + reader["nome_produto"].ToString() + " - " + " Preço: R$: " + reader["Preco"].ToString() + " - "
                        + " Quantidade: " + reader["quantidade_estoque"].ToString());
                }

                this.ListarProdutos.Text = "";
                foreach (var item in list)
                {
                    this.ListarProdutos.Text += item;
                    this.ListarProdutos.Text += Environment.NewLine;
                }

                reader.Close();
                //fechar conexão
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void BuscarCorreios_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);

            string sql = "SELECT [Correio].[id], [Correio].[prazo_entrega] FROM [Correio]";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand command = new SqlCommand(sql, connection);

                //Abrimos a conexão com o banco de dados
                connection.Open();

                //Executa o comando sql no banco de dados
                SqlDataReader reader = command.ExecuteReader();
                var list = new List<string>();
                while (reader.Read())
                {
                    list.Add("ID: " + reader["id"].ToString() + " - " + "Prazo: " + reader["prazo_entrega"].ToString());
                }

                this.ListarCorreios.Text = "";
                foreach (var item in list)
                {
                    this.ListarCorreios.Text += item;
                    this.ListarCorreios.Text += Environment.NewLine;
                }

                reader.Close();
                //fechar conexão
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnFazerCompra_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);


            string sql = "EXEC [NovaCompra] @produto_id, @cliente_id, @tipo_pagamento, @quantidade_comprada, @cod_rastreamento";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand cmd = new SqlCommand(sql, connection);

                //insere os dados do textBox no comando sql

                cmd.Parameters.Add(new SqlParameter("@produto_id", int.Parse(this.txtProdutoID.Text)));
                cmd.Parameters.Add(new SqlParameter("@cliente_id", this.txtClienteID.Text));
                cmd.Parameters.Add(new SqlParameter("@tipo_pagamento", this.txtTipoPagamento.Text));
                cmd.Parameters.Add(new SqlParameter("@quantidade_comprada", int.Parse(this.txtQuantidade.Text)));
                cmd.Parameters.Add(new SqlParameter("@cod_rastreamento", int.Parse(this.txtCodCorreio.Text)));

                //Abrimos a conexão com o banco de dados
                connection.Open();

                //Executa o comando sql no banco de dados
                cmd.ExecuteNonQuery();

                //fechar conexão
                connection.Close();

                MessageBox.Show("Enviado com Sucesso!");

                Avaliacao avaliacao = new Avaliacao();
                this.Hide();
                avaliacao.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void CancelarCompra_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);

            string sql = "EXEC [DeletarCompra] @id, @cpf";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand cmd = new SqlCommand(sql, connection);

                //insere os dados do textBox no comando sql

                cmd.Parameters.Add(new SqlParameter("@id", int.Parse(this.txtIdProdutoCanceleCompra.Text)));
                cmd.Parameters.Add(new SqlParameter("@cpf", this.txtIdClienteCanceleCompra.Text));

                //Abrimos a conexão com o banco de dados
                connection.Open();

                //Executa o comando sql no banco de dados
                cmd.ExecuteNonQuery();

                //fechar conexão
                connection.Close();

                MessageBox.Show("Excluído com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnAtualizarCompra_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);

            string sql = "EXEC [AtualizarCompra] @idPesquisadoProduto, @idPesquisadoCliente, @tipo_pagamento, @quantidade_comprada, @cod_rastreamento";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand cmd = new SqlCommand(sql, connection);

                //insere os dados do textBox no comando sql

                cmd.Parameters.Add(new SqlParameter("@idPesquisadoProduto", int.Parse(this.txtProdutoIDPesquisarAtualizar.Text)));
                cmd.Parameters.Add(new SqlParameter("@idPesquisadoCliente", this.txtClienteIDAtualizar.Text));
                cmd.Parameters.Add(new SqlParameter("@tipo_pagamento", this.txtTipoPagamentoAtualizar.Text));
                cmd.Parameters.Add(new SqlParameter("@quantidade_comprada", int.Parse(this.txtQuantidadeAtualizar.Text)));
                cmd.Parameters.Add(new SqlParameter("@cod_rastreamento", int.Parse(this.txtCodCorreioAtualizar.Text)));

                //Abrimos a conexão com o banco de dados
                connection.Open();

                //Executa o comando sql no banco de dados
                cmd.ExecuteNonQuery();

                //fechar conexão
                connection.Close();

                MessageBox.Show("Atualizado com Sucesso!");

                Avaliacao avaliacao = new Avaliacao();
                this.Hide();
                avaliacao.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void BuscarClienteID_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);

            string sql = @"EXEC [ListarHistoricoCompra]";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand command = new SqlCommand(sql, connection);

                //Abrimos a conexão com o banco de dados
                connection.Open();

                //Executa o comando sql no banco de dados
                SqlDataReader reader = command.ExecuteReader();
                var list = new List<string>();
                while (reader.Read())
                {
                    list.Add("Cliente: " + reader["nome_cliente"].ToString() + " - " + " Produto: "
                        + reader["nome_produto"].ToString() + " - " + " Preço Total: R$: " + reader["valor_total"].ToString() + " - "
                        + " Tipo Pagamento: " + reader["tipo_pagamento"].ToString());
                }

                this.visualizarClientesCompras.Text = "";
                foreach (var item in list)
                {
                    this.visualizarClientesCompras.Text += item;
                    this.visualizarClientesCompras.Text += Environment.NewLine;
                }

                reader.Close();
                //fechar conexão
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void VoltarMenu_Click(object sender, EventArgs e)
        {
            MenuGeral menu = new MenuGeral();
            this.Hide();
            menu.Show();
        }
    }
}
