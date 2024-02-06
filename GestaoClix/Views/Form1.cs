using GestaoClix.Controllers;
using GestaoClix.Models;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;
using System.Globalization;

namespace GestaoClix
{
    public partial class Form1 : Form
    {
        GestorCliente gestorCliente = new GestorCliente();
        GestorMovimento gestorMovimento = new GestorMovimento();
        GestorTipo gestorTipo = new GestorTipo();

        CultureInfo culture = CultureInfo.CreateSpecificCulture("pt-PT");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PreencherDgvClientes();
            PreencherDgvMovimentos();
            PreencherComboBoxMovimento();
            PreencherComboBoxListagem();
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
                AdicionarCliente(nif, nome, situacao);
            }
            else if (rbtAtualizarCliente.Checked)
            {
                AtualizarCliente(idCliente, nif, nome, situacao);
            }
            else if (rbtRemoverCliente.Checked)
            {
                RemoverCliente(idCliente);
            }

            PreencherDgvClientes();
        }

        private void AdicionarCliente(string nif, string nome, string situacao)
        {
            string mensagem =
            @$"Está a adicionar o cliente com os seguintes dados: 

                NIF: {nif}
                Nome: {nome}
                Situação: {situacao}
            
            Confirmar? ";

            string cabecalho = "Adicionar Cliente";

            var result = MessageBox.Show(mensagem, cabecalho, MessageBoxButtons.YesNo);

            if (!string.IsNullOrWhiteSpace(txtNifCliente.Text)
                && !string.IsNullOrWhiteSpace(txtNomeCliente.Text)
                    && !string.IsNullOrWhiteSpace(txtSituacaoCliente.Text))

                if (result == DialogResult.Yes)
                    gestorCliente.AdicionarCliente(nif, nome, situacao);
                else
                    MessageBox.Show("Operaçao cancelada.");
            else
                MessageBox.Show("Preencha os campos para adicionar um cliente.");
        }

        private void AtualizarCliente(string idCliente, string nif, string nome, string situacao)
        {
            if (dgvClientes.SelectedRows.Count > 0)
                gestorCliente.AtualizarCliente(idCliente, nif, nome, situacao);
            else
                MessageBox.Show("Selecione um cliente da tabela para atualizar.");
        }

        private void RemoverCliente(string idCliente)
        {
            if (dgvClientes.SelectedRows.Count > 0)
                if (gestorMovimento.ListarMovimentosCliente(idCliente).Count > 0)
                    MessageBox.Show("O cliente selecionado possui movimentos.");
                else
                    gestorCliente.RemoverCliente(idCliente);
            else
                MessageBox.Show("Selecione um cliente da tabela para remover.");
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

        private void PreencherDgvClientes()
        {
            dgvClientes.DataSource = gestorCliente.ListarClientes();
            LimparSelecao();
        }


        // Gestão de movimentos
        private void btnMovimentos_Click(object sender, EventArgs e)
        {
            string idMovimento = txtIdMovimento.Text;
            DateTime data = dtpMovimento.Value;
            string descricao = txtDescricaoMovimento.Text;
            string situacao = txtSituacaoMovimento.Text;
            int clienteId = Convert.ToInt16(cbxClienteMovimento.SelectedValue);
            int tipoId = Convert.ToInt16(cbxTipoMovimento.SelectedValue);
            decimal valor = 0.0m;

            try
            {
                valor = Convert.ToDecimal(dupValorMovimento.Text);
            }
            catch
            {
                MessageBox.Show("Preencha o camp 'Valor' corretamente.");
                return;
            }

            if (rbtAdicionarMovimento.Checked)
            {
                if (!string.IsNullOrWhiteSpace(descricao) && !string.IsNullOrWhiteSpace(situacao) && clienteId != 0 && tipoId != 0)
                {
                    gestorMovimento.AdicionarMovimento(data, descricao, valor, situacao, clienteId, tipoId);
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente.");
                }
            }
            else if (rbtAtualizarMovimento.Checked)
            {
                if (dgvMovimentos.SelectedRows.Count > 0)
                    gestorMovimento.AtualizarMovimento(idMovimento, data, descricao, situacao, valor, clienteId, tipoId);
                else
                    MessageBox.Show("Selecione um movimento da tabela para atualizar.");
            }
            else if (rbtRemoverMovimento.Checked)
            {
                if (dgvMovimentos.SelectedRows.Count > 0)
                {
                    gestorMovimento.RemoverMovimento(idMovimento);
                }
                else
                    MessageBox.Show("Selecione um cliente da tabela para remover.");
            }

            PreencherDgvMovimentos();
        }

        private void btnLimparMovimento_Click(object sender, EventArgs e)
        {
            LimparSelecao();
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
                dupValorMovimento.Text = "0.0";
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
                dupValorMovimento.Text = "0.0";
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

        private void PreencherDgvMovimentos()
        {
            dgvMovimentos.DataSource = gestorMovimento.ListarMovimentos();
            dgvMovimentos.Columns["ClienteId"].Visible = false;
            dgvMovimentos.Columns["TipoId"].Visible = false;
            LimparSelecao();
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


        // Movimentos
        private void btnListar_Click(object sender, EventArgs e)
        {
            if (rbtListagemClienteMesAno.Checked)
                ListarPorClienteMesAno();
            else if (rbtListagemClientesNegativos.Checked)
                ListarClientesNegativos();
        }

        private void ListarPorClienteMesAno()
        {
            string idCliente = cbxClienteListagem.SelectedValue.ToString();
            int mes = (int)cbxMesListagem.SelectedValue;
            int ano = (int)cbxAnoListagem.SelectedValue;

            if (chkListagemMes.Checked == false && chkListagemAno.Checked == false)
                dgvListagens.DataSource = gestorMovimento.ListarMovimentosCliente(idCliente);
            else if (chkListagemMes.Checked == true && chkListagemAno.Checked == false)
                dgvListagens.DataSource = gestorMovimento.ListarMovimentosClienteMesAno(idCliente, mes, ano, 1);
            else if (chkListagemAno.Checked == true && chkListagemMes.Checked == false)
                dgvListagens.DataSource = gestorMovimento.ListarMovimentosClienteMesAno(idCliente, mes, ano, 2);
            else
                dgvListagens.DataSource = gestorMovimento.ListarMovimentosClienteMesAno(idCliente, mes, ano, 3);
        }

        private void ListarClientesNegativos()
        {
            dgvListagens.DataSource = gestorMovimento.ListarClientesNegativos();
        }

        private void CalcularSaldo()
        {
            if (dgvListagens.DataSource != null)
            {
                decimal total = 0;

                foreach(DataGridViewRow row in dgvListagens.Rows)
                {
                    total += (decimal)row.Cells["Valor"].Value;
                }

                // total.ToString("C2", culture);
            }
        }

        private void PreencherComboBoxListagem()
        {
            cbxClienteListagem.DataSource = gestorCliente.ListarClientes();
            cbxClienteListagem.DisplayMember = "Nome";
            cbxClienteListagem.ValueMember = "Id";

            List<int> listaAnos = new List<int>();
            List<object> listaMeses = new List<object>();

            for (int i = 2000; i <= DateTime.Now.Year; i++)
            {
                listaAnos.Add(i);
            }

            cbxAnoListagem.DataSource = listaAnos;

            for (int i = 1; i <= 12; i++)
            {
                string mes = culture.DateTimeFormat.GetMonthName(i);
                mes = char.ToUpper(mes[0]) + mes.Substring(1);

                object obj = new { Id = i, Mes = mes };
                listaMeses.Add(obj);
            }

            cbxMesListagem.DataSource = listaMeses;
            cbxMesListagem.DisplayMember = "Mes";
            cbxMesListagem.ValueMember = "Id";
        }

        // Geral
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
            cbxClienteMovimento.SelectedIndex = -1;
            cbxTipoMovimento.SelectedIndex = -1;
            dtpMovimento.ResetText();
            dgvMovimentos.ClearSelection();
        }

    }
}
