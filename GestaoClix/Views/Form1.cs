using GestaoClix.Controllers;
using GestaoClix.Models;
using System.Data;

namespace GestaoClix
{
    public partial class Form1 : Form
    {
        GestorCliente gestorCliente = new GestorCliente();
        GestorMovimento gestorMovimento = new GestorMovimento();
        GestorTipo gestorTipo = new GestorTipo();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PreencherDgvClientes();
            PreencherComboBoxMovimento();
        }


        // Gestão de clientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            string idCliente = txtIdCliente.Text;
            string nif = txtNifCliente.Text;
            string nome = txtNomeCliente.Text;
            string situacao = txtSituacaoCliente.Text;

            if (rbtAdicionarCliente.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtNifCliente.Text)
                        && !string.IsNullOrWhiteSpace(txtNomeCliente.Text)
                            && !string.IsNullOrWhiteSpace(txtSituacaoCliente.Text))
                    gestorCliente.adicionarCliente(nif, nome, situacao);
                else
                    MessageBox.Show("Preencha os campos para adicionar um cliente.");
            }
            else if (rbtAtualizarCliente.Checked)
            {
                if (dgvClientes.SelectedRows.Count > 0)
                    gestorCliente.atualizarCliente(idCliente, nif, nome, situacao);
                else
                    MessageBox.Show("Selecione um cliente da tabela para atualizar.");
            }
            else if (rbtRemoverCliente.Checked)
            {
                if (dgvClientes.SelectedRows.Count > 0)
                    gestorCliente.removerCliente(idCliente);
                else
                    MessageBox.Show("Selecione um cliente da tabela para remover.");
            }

            PreencherDgvClientes();
        }

        private void btnLimparCliente_Click(object sender, EventArgs e)
        {
            LimparSelecao();
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtIdCliente.Text = dgvClientes.SelectedCells[0].Value.ToString();
                txtNomeCliente.Text = dgvClientes.SelectedCells[1].Value.ToString();
                txtNifCliente.Text = dgvClientes.SelectedCells[2].Value.ToString();
                txtSituacaoCliente.Text = dgvClientes.SelectedCells[3].Value.ToString();
            }
            catch { }
        }

        private void rbtCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtAdicionarCliente.Checked)
            {
                LimparSelecao();
                dgvClientes.Enabled = false;
                txtNifCliente.ReadOnly = false;
                txtSituacaoCliente.ReadOnly = false;
                txtNomeCliente.ReadOnly = false;
                btnClientes.Text = "ADICIONAR";
            }
            else if (rbtAtualizarCliente.Checked)
            {
                LimparSelecao();
                dgvClientes.Enabled = true;
                txtNifCliente.ReadOnly = false;
                txtSituacaoCliente.ReadOnly = false;
                txtNomeCliente.ReadOnly = false;
                btnClientes.Text = "ATUALIZAR";
            }
            else if (rbtRemoverCliente.Checked)
            {
                LimparSelecao();
                dgvClientes.Enabled = true;
                txtNifCliente.ReadOnly = true;
                txtSituacaoCliente.ReadOnly = true;
                txtNomeCliente.ReadOnly = true;
                btnClientes.Text = "REMOVER";
            }
        }

        private void LimparSelecao()
        {
            // Clientes
            txtIdCliente.Clear();
            txtNifCliente.Clear();
            txtNomeCliente.Clear();
            txtSituacaoCliente.Clear();
            dgvClientes.ClearSelection();

            // Movimentos
            txtIdMovimento.Clear();
            txtDescricaoMovimento.Clear();
            txtSituacaoMovimento.Clear();
            cbxClienteMovimento.ResetText();
            cbxTipoMovimento.ResetText();
            dtpMovimento.ResetText();
            dgvMovimentos.ClearSelection();
        }

        private void PreencherDgvClientes()
        {
            dgvClientes.DataSource = gestorCliente.ListarClientes();
            LimparSelecao();
        }


        // Gestão de movimentos
        private void btnGestaoListar_Click(object sender, EventArgs e)
        {
            dgvMovimentos.DataSource = gestorMovimento.ListarMovimentos();
        }

        private void btnMovimentos_Click(object sender, EventArgs e)
        {
            DateTime data = dtpMovimento.Value;
            string descricao = txtDescricaoMovimento.Text;
            decimal valor = Convert.ToDecimal(dupValorMovimento.Text);
            string situacao = txtSituacaoMovimento.Text;
            int clienteId = Convert.ToInt16(cbxClienteMovimento.SelectedValue);
            int tipoId = Convert.ToInt16(cbxTipoMovimento.SelectedValue);

            gestorMovimento.AdicionarMovimento(data, descricao, valor, situacao, clienteId, tipoId);
        }

        private void rbtMovimento_Changed(object sender, EventArgs e)
        {
            if (rbtAdicionarMovimento.Checked)
            {
                LimparSelecao();
                dgvMovimentos.Enabled = false;
                txtDescricaoMovimento.ReadOnly = false;
                txtSituacaoMovimento.ReadOnly = false;
                cbxClienteMovimento.Enabled = true;
                cbxTipoMovimento.Enabled = true;
                dtpMovimento.Enabled = true;
                dupValorMovimento.Enabled = true;
                dupValorMovimento.ResetText();
                btnMovimentos.Text = "ADICIONAR";
            }
            else if (rbtAtualizarMovimento.Checked)
            {
                LimparSelecao();
                dgvMovimentos.Enabled = true;
                txtDescricaoMovimento.ReadOnly = false;
                txtSituacaoMovimento.ReadOnly = false;
                cbxClienteMovimento.Enabled = true;
                cbxTipoMovimento.Enabled = true;
                dtpMovimento.Enabled = true;
                dupValorMovimento.Enabled = true;
                dupValorMovimento.ResetText();
                btnMovimentos.Text = "ATUALIZAR";
            }
            else if (rbtRemoverMovimento.Checked)
            {
                LimparSelecao();
                dgvMovimentos.Enabled = true;
                txtDescricaoMovimento.ReadOnly = true;
                txtSituacaoMovimento.ReadOnly = true;
                cbxClienteMovimento.Enabled = false;
                cbxTipoMovimento.Enabled = false;
                dtpMovimento.Enabled = false;
                dupValorMovimento.Enabled = false;
                btnMovimentos.Text = "REMOVER";
            }
        }

        private void PreencherComboBoxMovimento()
        {
            cbxTipoMovimento.DataSource = gestorTipo.ListarTipos();
            cbxTipoMovimento.DisplayMember = "Designacao";
            cbxTipoMovimento.ValueMember = "Id";

            cbxClienteMovimento.DataSource = gestorCliente.ListarClientes();
            cbxClienteMovimento.DisplayMember = "Nome";
            cbxClienteMovimento.ValueMember = "Id";
        }

        private void dgvMovimentos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtIdMovimento.Text = dgvMovimentos.SelectedCells[0].Value.ToString();
                txtDescricaoMovimento.Text = dgvMovimentos.SelectedCells[1].Value.ToString();
                txtSituacaoMovimento.Text = dgvMovimentos.SelectedCells[2].Value.ToString();
                dtpMovimento.Text = dgvMovimentos.SelectedCells[3].Value.ToString();
                cbxClienteMovimento.SelectedValue = dgvMovimentos.SelectedCells[5].Value;
                dupValorMovimento.Text = dgvMovimentos.SelectedCells[6].Value.ToString();
                cbxTipoMovimento.SelectedValue = dgvMovimentos.SelectedCells[8].Value;
            }
            catch { }
        }
    }
}
