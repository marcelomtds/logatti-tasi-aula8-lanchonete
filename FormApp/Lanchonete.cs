using System;
using System.Windows.Forms;
using DB;

namespace FormApp
{
    public partial class Lanchonete : Form
    {
        ConnectionSQLServer connectionSQLServer = new ConnectionSQLServer();

        public Lanchonete()
        {
            InitializeComponent();
            ListarTodas();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (IsFormularioInvalido())
            {
                MessageBox.Show("É necessário preencher todos campos obrigatórios.");
            }
            else
            {
                try
                {
                    var lanchonete = new Model.Lanchonete()
                    {
                        Descricao = txtDescricao.Text,
                        QuantidadeClientes = int.Parse(txtQuantidadeClientes.Text),
                        NumeroEmpregados = int.Parse(txtNumeroEmpregados.Text),
                        TotalReceita = double.Parse(txtReceita.Text),
                        TotalDespesa = double.Parse(txtDespesa.Text)
                    };
                    connectionSQLServer.Inserir(lanchonete);
                    ListarTodas();
                    ResetarFormulario();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private void ListarTodas()
        {
            dgvLanchonete.DataSource = null;
            dgvLanchonete.DataSource = connectionSQLServer.ListarTodas();
        }

        private void ResetarFormulario()
        {
            txtDescricao.Clear();
            txtQuantidadeClientes.Clear();
            txtNumeroEmpregados.Clear();
            txtReceita.Clear();
            txtDespesa.Clear();
            txtDescricao.Focus();
        }

        private bool IsFormularioInvalido()
        {
            return string.IsNullOrWhiteSpace(txtDescricao.Text)
                || string.IsNullOrWhiteSpace(txtQuantidadeClientes.Text)
                || string.IsNullOrWhiteSpace(txtNumeroEmpregados.Text)
                || string.IsNullOrWhiteSpace(txtReceita.Text)
                || string.IsNullOrWhiteSpace(txtDespesa.Text);
        }
    }
}
