﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudClientes;

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
        public List<Cliente> ListarCliente()
        {
            Conexao conexao = new Conexao();
            SqlCommand select = new SqlCommand();

            List<Cliente> clientes = new List<Cliente>();

            try
            {
                conexao.conectar();
                string sqlSelect = "SELECT * FROM Clientes";
                select.CommandText  = sqlSelect; 
                select.Connection = conexao.conectar();

                select.ExecuteReader();
                SqlDataReader reader = select.ExecuteReader();

                while (reader.Read())
                {
                    clientes.Add(new Cliente(
                        reader["Nome"].ToString(), 
                        Convert.ToInt32(reader["Id"]), 
                        reader["Email"].ToString(), 
                        reader["Telefone"].ToString()
                        ));
                }
                return clientes;
            }

            catch (Exception ex)
            {
                
            }

            finally
            {
                conexao.desconectar();
            }

            return clientes;
        }
        public void AtualizarCliente(Cliente cliente)
        {
            Conexao conexao = new Conexao();
            SqlCommand Update = new SqlCommand();

            try
            {
                conexao.conectar();
                string sql = "UPDATE Clientes SET (Nome = @Nome, Email = @Email, Telefone = @Telefone Where Id = @Id)";

                Update.Parameters.AddWithValue("@Nome", cliente.Nome);
                Update.Parameters.AddWithValue("@Email", cliente.Email);
                Update.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                Update.Parameters.AddWithValue("@Id", cliente.Id);

                Update.ExecuteNonQuery();
            }

            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao atualizar cliente", ex.Message);
            }

            finally 
            {
                conexao.desconectar();
            }
        }

        public void DeletarCliente(int Id)
        {
            SqlCommand Deletar = new SqlCommand();
            Conexao conexao = new Conexao();

            try { 
            conexao.conectar();
            string sql = "DELETE FROM Clientes WHERE Id = @Id";

            Deletar.Parameters.AddWithValue("@Id", Id);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar cliente", ex.Message);
            }

            finally 
            { 
            Deletar.ExecuteNonQuery();
            }

        }

        public Cliente BuscarPorId(int Id)
        {
            Conexao conexao = new Conexao();
            SqlCommand Buscar = new SqlCommand();
            string sql = "SELECT * FROM Clientes WHERE Id = @Id";

            conexao.conectar();
            Buscar.Parameters.AddWithValue("@Id", Id);

            SqlDataReader reader = Buscar.ExecuteReader();

            if (reader.Read()) 
            {
                Cliente clientes = new Cliente(
                reader["Nome"].ToString(),
                Convert.ToInt32(reader["Id"]),
                reader["Email"].ToString(),
                reader["Telefone"].ToString()
                );

                return clientes;
            }
            return null;

        }

    }
}
