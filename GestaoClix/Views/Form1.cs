using GestaoClix.Controllers;

namespace GestaoClix
{
    public partial class Form1 : Form
    {
        ClienteController clienteController = new ClienteController();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            string nif = txtAddNif.Text;
            string nome = txtAddNome.Text;
            string situacao = txtAddSituacao.Text;

            clienteController.adicionarCliente(nif, nome, situacao);
        }

        private void btnGestaoListar_Click(object sender, EventArgs e)
        {
            dgvGestaoListar.DataSource = clienteController.listarClientes();
        }
    }
}
