using System.Data.SqlClient;

namespace SHOP_BR
{
    public partial class Loja : Form
    {
        public Loja()
        {
            InitializeComponent();
        }

        private void btnCadastrarLoja_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);


            string sql = "EXEC [NovaLoja] @nome, @telefone, @email, @endereco";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand cmd = new SqlCommand(sql, connection);

                //insere os dados do textBox no comando sql

                cmd.Parameters.Add(new SqlParameter("@nome", this.txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@telefone", this.txtTelefone.Text));
                cmd.Parameters.Add(new SqlParameter("@email", this.txtEmail.Text));
                cmd.Parameters.Add(new SqlParameter("@endereco", this.txtEndereco.Text));

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

        private void BuscarLoja_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);

            string sql = "SELECT [Loja].[id], [Loja].[nome] FROM [Loja]";

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
                    list.Add("ID: " + reader["id"].ToString() + " - " + "Nome: " + reader["nome"].ToString());
                }

                this.ListaLojas.Text = "";
                foreach(var item in list)
                {
                    this.ListaLojas.Text += item;
                    this.ListaLojas.Text += Environment.NewLine;
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

        private void DeletarLoja_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);

            string sql = "EXEC [DeletarLoja] @id";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand cmd = new SqlCommand(sql, connection);

                //insere os dados do textBox no comando sql

                cmd.Parameters.Add(new SqlParameter("@id", int.Parse(this.txtIdDeleteLoja.Text)));

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

        private void AtualizarLoja_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);

            string sql = "EXEC [AtualizarLoja] @idPesquisado, @nome, @telefone, @email, @endereco";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand cmd = new SqlCommand(sql, connection);

                //insere os dados do textBox no comando sql

                cmd.Parameters.Add(new SqlParameter("@idPesquisado", int.Parse(this.txtIdPesquisado.Text)));
                cmd.Parameters.Add(new SqlParameter("@nome", this.txtNomeAtualizar.Text));
                cmd.Parameters.Add(new SqlParameter("@telefone", this.txtTelefoneAtualizar.Text));
                cmd.Parameters.Add(new SqlParameter("@email", this.txtEmailAtualizar.Text));
                cmd.Parameters.Add(new SqlParameter("@endereco", this.txtEnderecoAtualizar.Text));

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

        private void Inserir_Loja_Produto_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);

            string sql = @"INSERT INTO [Loja-Produto] (loja_id, produto_id)
                            VALUES(@idLoja, @idProduto)";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand cmd = new SqlCommand(sql, connection);

                //insere os dados do textBox no comando sql

                cmd.Parameters.Add(new SqlParameter("@idLoja", int.Parse(this.IdLoja.Text)));
                cmd.Parameters.Add(new SqlParameter("@idProduto", int.Parse(this.IdProduto.Text)));

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

        private void Listar_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);

            string sql = @"SELECT [Loja].[nome] AS [nome_loja], [Produto].[nome] AS [nome_produto], [Produto].[quantidade_estoque]
                            FROM [Loja] INNER JOIN [Loja-Produto]
                            ON [Loja].[id] = [Loja-Produto].[loja_id]
                            INNER JOIN [Produto]
                            ON [Loja-Produto].[produto_id] = [Produto].[id]";

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
                    list.Add(reader["nome_loja"].ToString() + " - " + reader["nome_produto"].ToString() + " - " + reader["quantidade_estoque"].ToString());
                }

                this.ListarLojaProduto.Text = "";
                foreach (var item in list)
                {
                    this.ListarLojaProduto.Text += item;
                    this.ListarLojaProduto.Text += Environment.NewLine;
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