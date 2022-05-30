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
    public partial class Avaliacao : Form
    {
        public Avaliacao()
        {
            InitializeComponent();
        }

        private void EnviarAvaliacao_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);


            string sql = @"INSERT INTO [Avaliacao] (produto_id, cliente_id, nota, descricao)
                            VALUES(@idProduto, @idCliente, @nota, @descricao)"; ;

            try
            {
                //criando um objeto do tipo comando
                SqlCommand cmd = new SqlCommand(sql, connection);

                //insere os dados do textBox no comando sql

                cmd.Parameters.Add(new SqlParameter("@idProduto", int.Parse(this.txtcodProduto.Text)));
                cmd.Parameters.Add(new SqlParameter("@idCliente", this.txtcod_cliente.Text));
                cmd.Parameters.Add(new SqlParameter("@nota", this.txtNota.Text));
                cmd.Parameters.Add(new SqlParameter("@descricao", this.txtDescricao.Text));

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

        private void visualizarAvaliacoes_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);

            string sql = @"SELECT [Produto].[nome] AS [nome_produto], [Cliente].[nome] AS [nome_cliente], [Avaliacao].[nota], [Avaliacao].[descricao]
                            FROM[Produto] INNER JOIN[Avaliacao]
                            ON[Produto].[id] = [Avaliacao].[produto_id]
                            INNER JOIN[Cliente]
                            ON[Avaliacao].[cliente_id] = [Cliente].[cpf]";

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
                    list.Add(reader["nome_produto"].ToString() + " - " + reader["nome_cliente"].ToString() + " - " + reader["nota"].ToString() + " - " + reader["descricao"].ToString());
                }

                this.exibirAvaliacao.Text = "";
                foreach (var item in list)
                {
                    this.exibirAvaliacao.Text += item;
                    this.exibirAvaliacao.Text += Environment.NewLine;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);

            string sql = @"DELETE FROM [Avaliacao]
                            WHERE @idProduto = [Avaliacao].[produto_id] and @idCliente = [Avaliacao].[cliente_id]";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand cmd = new SqlCommand(sql, connection);

                //insere os dados do textBox no comando sql

                cmd.Parameters.Add(new SqlParameter("@idProduto", int.Parse(this.txtcodProdutoDeleteAvaliacao.Text)));
                cmd.Parameters.Add(new SqlParameter("@idCliente", this.txtcodClienteDeleteAvaliacao.Text));

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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);

            string sql = @"UPDATE [Avaliacao]
                            SET[Avaliacao].[nota] = @nota ,
                            [Avaliacao].[descricao] = @descricao
                            WHERE @idProduto = [Avaliacao].[produto_id] and @idCliente = [Avaliacao].[cliente_id]; ";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand cmd = new SqlCommand(sql, connection);

                //insere os dados do textBox no comando sql

                cmd.Parameters.Add(new SqlParameter("@idProduto", int.Parse(this.txtCodProdutoParaAtualizar.Text)));
                cmd.Parameters.Add(new SqlParameter("@idCliente", this.txtCodClienteParaAtualizar.Text));
                cmd.Parameters.Add(new SqlParameter("@nota", this.txtNotaAtualizar.Text));
                cmd.Parameters.Add(new SqlParameter("@descricao", this.txtDescricaoAtualizar.Text));
               

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
