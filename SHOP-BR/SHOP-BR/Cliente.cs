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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);


            string sql = "EXEC [NovoCliente] @cpf, @nome, @email, @senha, @telefone";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand cmd = new SqlCommand(sql, connection);

                //insere os dados do textBox no comando sql

                cmd.Parameters.Add(new SqlParameter("@cpf", this.txtCpf.Text));
                cmd.Parameters.Add(new SqlParameter("@nome", this.txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@email", this.txtEmail.Text));
                cmd.Parameters.Add(new SqlParameter("@senha", this.txtSenha.Text));
                cmd.Parameters.Add(new SqlParameter("@telefone", this.txtTelefone.Text));

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

        private void BuscarCliente_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);

            string sql = "SELECT [Cliente].[cpf], [Cliente].[nome] FROM [Cliente]";

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
                    list.Add(reader["cpf"].ToString() + " - " + reader["nome"].ToString());
                }

                this.ListaCliente.Text = "";
                foreach (var item in list)
                {
                    this.ListaCliente.Text += item;
                    this.ListaCliente.Text += Environment.NewLine;
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

        private void DeletarCliente_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);

            string sql = "EXEC [DeletarCliente] @cpf";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand cmd = new SqlCommand(sql, connection);

                //insere os dados do textBox no comando sql

                cmd.Parameters.Add(new SqlParameter("@cpf", this.txtIdDeleteCliente.Text));

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

        private void AtualizarCliente_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);

            string sql = "EXEC [AtualizarCliente] @cpfPesquisado, @nome, @email, @senha, @telefone";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand cmd = new SqlCommand(sql, connection);

                //insere os dados do textBox no comando sql

                cmd.Parameters.Add(new SqlParameter("@cpfPesquisado", this.txtCpfAtualizar.Text));
                cmd.Parameters.Add(new SqlParameter("@nome", this.txtNomeAtualizar.Text));
                cmd.Parameters.Add(new SqlParameter("@email", this.txtEmailAtualizar.Text));
                cmd.Parameters.Add(new SqlParameter("@senha", this.txtSenhaAtualizar.Text));
                cmd.Parameters.Add(new SqlParameter("@telefone", this.txtTelefoneAtualizar.Text));

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
