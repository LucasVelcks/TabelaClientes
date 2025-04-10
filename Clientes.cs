using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudClientes
{
    public class Cliente
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public String mensagem;
        public Cliente(string nome, int id, string email, string telefone)
        {
            Nome = nome;
            Id = id;
            Email = email;
            Telefone = telefone;
        }
        
        public string Nome {  get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Telefone {  get; set; }
       
    }

}
