using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CrudClientes
{
    public partial class Form1 : Form
    {
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        public Form1()
        {
            InitializeComponent();
            InicializarComponentesCustomizados();
        }

        private void InicializarComponentesCustomizados()
        {
            Label lblNome = new Label();
            lblNome.Text = "Nome";
            lblNome.Location = new Point(20, 20);
            lblNome.AutoSize = true;
            this.Controls.Add(lblNome);

            TextBox txtNome = new TextBox();
            txtNome.Name = "txtNome";
            txtNome.Location = new Point(80, 20);
            txtNome.Width = 200;
            this.Controls.Add(txtNome);

            Label lblEmail = new Label();
            lblEmail.Text = "Email";
            lblEmail.Location = new Point(20, 60);
            lblEmail.AutoSize = true;
            this.Controls.Add(lblEmail);

            TextBox txtEmail = new TextBox();
            txtEmail.Name = "txtEmail";
            txtEmail.Location = new Point(80, 58);
            txtEmail.Width = 200;
            this.Controls.Add(txtEmail);

            Label lblTelefone = new Label();
            lblTelefone.Text = "Telefone";
            lblTelefone.Location = new Point(20, 100);
            lblTelefone.AutoSize = true;
            this.Controls.Add(lblTelefone);

            TextBox txtTelefone = new TextBox();
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Location = new Point(80, 98);
            txtTelefone.Width = 200;
            this.Controls.Add(txtTelefone);

            Label lblId = new Label();
            lblId.Text = "ID:";
            lblId.Location = new Point(20, 0);
            lblId.AutoSize = true;
            this.Controls.Add(lblId);

            TextBox txtId = new TextBox();
            txtId.Name = "txtId";
            txtId.Location = new Point(80, -2);
            txtId.Width = 200;
            txtId.Enabled = false;
            this.Controls.Add(txtId);

            Button btnInserir = new Button();
            btnInserir.Text = "Inserir";
            btnInserir.Location = new Point(20, 160);
            btnInserir.Click += BtnInserir_Click;
            this.Controls.Add(btnInserir);

            Button btnAtualizar = new Button();
            btnAtualizar.Name = "Atualizar";
            btnAtualizar.Location = new Point(120, 160);
            btnAtualizar.Click += BtnAtualizar_Click;
            this.Controls.Add(btnAtualizar);

            Button btnBuscar = new Button();
            btnBuscar.Name = "Buscar";
            btnBuscar.Location = new Point(320, 160);
            btnBuscar.Click += BtnBuscar_Click;
            this.Controls.Add(btnBuscar);

            Button btnExcluir = new Button();
            btnExcluir.Name = "Excluir";
            btnExcluir.Location = new Point(220, 160);
            btnExcluir.Click += BtnExcluir_Click;
            this.Controls.Add (btnExcluir);

            Button btnListar = new Button();
            btnListar.Text = "Listar";
            btnListar.Location = new Point(120, 160);
            btnListar.Click += BtnListar_Click;
            this.Controls.Add(btnListar);

            DataGridView dvgClientes = new DataGridView();
            dvgClientes.Name = "dvgClientes";
            dvgClientes.Location = new Point(20, 200);
            dvgClientes.Size = new Size(500, 200);
            dvgClientes.ReadOnly = true;
            dvgClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Controls.Add(dvgClientes);

        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;
            int id = 0;

            Cliente novoCliente = new Cliente(nome, id, email, telefone);

            ClienteRepositorio repositorio = new ClienteRepositorio();

            repositorio.InserirCliente(novoCliente);

            MessageBox.Show("Botão Inserir clicado!");

            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();

            ClienteRepositorio repositorio = new ClienteRepositorio();
            List<Cliente> clientes = repositorio.ObterTodos();

            string mensagem = "Clientes cadastros:\n\n";
            foreach (var cliente in clientes)
            {
                mensagem += $"ID: {cliente.Id} \nNome: {cliente.Nome}\nEmail: {cliente.Email}\nTelefone: {cliente.Telefone}\n\n";
            }

            MessageBox.Show(mensagem);
        }
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botão Atualizar clicado!");
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botão Buscar clicado!");
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botão Excluir clicado!");
        }
        private void BtnListar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botão Listar clicado!");
        }
    }
}
