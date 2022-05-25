using System.Data.SqlClient;

namespace SHOP_BR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrarLoja_Click(object sender, EventArgs e)
        {
            //DEFINIMOS A STRING DE CONEXAO
            string connectionString = "Data Source=DESKTOP-S6OBJIL;Initial Catalog=SHOP-BR;Persist Security Info=True;User ID=sa;Password=T@passos362514";
            SqlConnection connection = new SqlConnection(connectionString);


            string sql = "INSERT INTO Loja(nome, telefone, email, endereco) VALUES (@nome, @telefone, @email, @endereco";

            try
            {
                //criando um objeto do tipo comando
                SqlCommand cmd = new SqlCommand(sql, connection);

                //insere os dados do textBox no comando sql

                cmd.Parameters.Add(new SqlParameter("@nome", this.txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@nome", this.txtTelefone.Text));
                cmd.Parameters.Add(new SqlParameter("@nome", this.txtEmail.Text));
                cmd.Parameters.Add(new SqlParameter("@nome", this.txtEndereco.Text));

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
    }
}