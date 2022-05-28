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
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);


            string sql = "EXEC [NovoProduto] @nome, @marca, @tipo, @preco, @quantidade";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand cmd = new SqlCommand(sql, connection);

                //insere os dados do textBox no comando sql

                cmd.Parameters.Add(new SqlParameter("@nome", this.txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@marca", this.txtMarca.Text));
                cmd.Parameters.Add(new SqlParameter("@tipo", this.txtTipo.Text));
                
                cmd.Parameters.Add(new SqlParameter("@preco",double.Parse(this.txtPreco.Text)));
                cmd.Parameters.Add(new SqlParameter("@quantidade", int.Parse(this.txtQuantidadeEstoque.Text)));

                //Abrimos a conexão com o banco de dados
                connection.Open();

                //Executa o comando sql no banco de dados
                cmd.ExecuteNonQuery();

                //fechar conexão
                connection.Close();

                MessageBox.Show("Enviado com Sucesso!");
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

        private void BuscarProduto_Click(object sender, EventArgs e)
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

                this.ListaProdutos.Text = "";
                foreach (var item in list)
                {
                    this.ListaProdutos.Text += item;
                    this.ListaProdutos.Text += Environment.NewLine;
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

        private void DeletarProduto_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);

            string sql = "EXEC [DeletarProduto] @id";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand cmd = new SqlCommand(sql, connection);

                //insere os dados do textBox no comando sql

                cmd.Parameters.Add(new SqlParameter("@id", int.Parse(this.txtIdDeleteProduto.Text)));

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

        private void AtualizarProduto_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);

            string sql = "EXEC [AtualizarProduto] @idPesquisado, @nome, @marca, @tipo, @preco, @quantidade";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand cmd = new SqlCommand(sql, connection);

                //insere os dados do textBox no comando sql

                cmd.Parameters.Add(new SqlParameter("@idPesquisado", int.Parse(this.txtIdPesquisado.Text)));
                cmd.Parameters.Add(new SqlParameter("@nome", this.txtNomeAtualizar.Text));
                cmd.Parameters.Add(new SqlParameter("@marca", this.txtMarcaAtualizar.Text));
                cmd.Parameters.Add(new SqlParameter("@tipo", this.txtTipoAtualizar.Text));
                cmd.Parameters.Add(new SqlParameter("@preco", double.Parse(this.txtPrecoAtualizar.Text)));
                cmd.Parameters.Add(new SqlParameter("@quantidade", int.Parse(this.txtQuantidadeAtualizar.Text)));

                //Abrimos a conexão com o banco de dados
                connection.Open();

                //Executa o comando sql no banco de dados
                cmd.ExecuteNonQuery();

                //fechar conexão
                connection.Close();

                MessageBox.Show("Atualizado com Sucesso!");
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
