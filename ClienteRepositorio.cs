using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudClientes
{
    public class ClienteRepositorio
    {
        public void InserirCliente(Cliente cliente)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            try
            {
                conexao.conectar();
                cmd.Connection = conexao.conectar();
                cmd.CommandText = "INSERT INTO Clientes (Nome, Email, Telefone) Values (@Nome, @Email, @Telefone)";

                cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao inserir cliente: " + ex.Message);
            }
            finally 
            { 
               conexao.desconectar();
            }
        }
        public void ListarCliente(Cliente cliente)
        {
            Conexao conexao = new Conexao();
            SqlCommand select = new SqlCommand();

            List<Cliente> Cliente = new List<Cliente>();

            conexao.conectar();
            string sql = "SELECT * FROM Clientes";

        }
        public void AtualizarCliente(Cliente cliente)
        {

        }

        public void DeletarCliente(int Id)
        {

        }

        public void BuscarPorId(int Id)
        {

        }

    }
}
