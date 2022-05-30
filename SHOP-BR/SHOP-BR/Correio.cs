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
    public partial class Correio : Form
    {
        public Correio()
        {
            InitializeComponent();
        }

        private void btnCadastrarCorreio_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);


            string sql = "EXEC [NovoCorreio] @prazo_entrega, @valor_frete";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand cmd = new SqlCommand(sql, connection);

                //insere os dados do textBox no comando sql

                cmd.Parameters.Add(new SqlParameter("@prazo_entrega", int.Parse(this.txtPrazo.Text)));
                cmd.Parameters.Add(new SqlParameter("@valor_frete", double.Parse(this.txtFrete.Text)));

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

        private void BuscarCorreio_Click(object sender, EventArgs e)
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

                this.ListaCorreio.Text = "";
                foreach (var item in list)
                {
                    this.ListaCorreio.Text += item;
                    this.ListaCorreio.Text += Environment.NewLine;
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

        private void DeletarCorreio_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);

            string sql = "EXEC [DeletarCorreio] @id";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand cmd = new SqlCommand(sql, connection);

                //insere os dados do textBox no comando sql

                cmd.Parameters.Add(new SqlParameter("@id", int.Parse(this.txtIdDeleteCorreio.Text)));

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

        private void AtualizarCorreio_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);

            string sql = "EXEC [AtualizarCorreio] @idPesquisado, @prazo_entrega, @valor_frete";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand cmd = new SqlCommand(sql, connection);

                //insere os dados do textBox no comando sql

                cmd.Parameters.Add(new SqlParameter("@idPesquisado", int.Parse(this.txtIdPesquisado.Text)));
                cmd.Parameters.Add(new SqlParameter("@prazo_entrega", int.Parse(this.txtPrazoAtualizar.Text)));
                cmd.Parameters.Add(new SqlParameter("@valor_frete", double.Parse(this.txtFreteAtualizar.Text)));
                

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
