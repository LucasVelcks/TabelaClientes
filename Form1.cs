using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudClientes
{
    public partial class Form1 : Form
    {
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
        }
    }
}
