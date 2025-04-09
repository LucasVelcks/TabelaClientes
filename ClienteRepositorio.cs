using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudClientes
{
    public class ClienteRepositorio
    {
        public void InserirCliente(Cliente cliente)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            conexao.conectar();
            cmd.Connection = conexao.conectar();
            cmd.CommandText = "INSERT INTO Clientes (Nome, Email, Telefone) Values (@Nome, @Email, @Telefone)";

        }
        public void ListarCliente(Cliente cliente)
        {

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
