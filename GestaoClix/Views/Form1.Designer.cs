namespace GestaoClix
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClientes = new Button();
            txtNomeCliente = new TextBox();
            txtSituacaoCliente = new TextBox();
            dgvMovimentos = new DataGridView();
            btnLimparMovimento = new Button();
            tabGestao = new TabControl();
            tabGestãoMovimentos = new TabPage();
            label1 = new Label();
            rbtAtualizarMovimento = new RadioButton();
            rbtRemoverMovimento = new RadioButton();
            rbtAdicionarMovimento = new RadioButton();
            txtIdMovimento = new TextBox();
            lblIdMovimento = new Label();
            lblTipoPagamentoMovimento = new Label();
            lblValorMovimento = new Label();
            lblSituaçãoMovimento = new Label();
            lblClienteMovimento = new Label();
            lblDataMovimento = new Label();
            lblDescricaoMovimento = new Label();
            btnMovimentos = new Button();
            cbxTipoMovimento = new ComboBox();
            txtSituacaoMovimento = new TextBox();
            dupValorMovimento = new DomainUpDown();
            txtDescricaoMovimento = new TextBox();
            dtpMovimento = new DateTimePicker();
            cbxClienteMovimento = new ComboBox();
            tabListarMovimentos = new TabPage();
            rbtListagemClientesSemMarcador = new RadioButton();
            txtMarcadorListagem = new TextBox();
            rbtListagemClienteMesAno = new RadioButton();
            rbtListagemClientesNegativos = new RadioButton();
            chkListagemAno = new CheckBox();
            chkListagemMes = new CheckBox();
            label3 = new Label();
            lblMesListagem = new Label();
            cbxAnoListagem = new ComboBox();
            cbxMesListagem = new ComboBox();
            lblClienteListagem = new Label();
            cbxClienteListagem = new ComboBox();
            btnListar = new Button();
            btnLimpar = new Button();
            lblListagens = new Label();
            dgvListagens = new DataGridView();
            tabGestaoClientes = new TabPage();
            label2 = new Label();
            rbtRemoverCliente = new RadioButton();
            rbtAtualizarCliente = new RadioButton();
            rbtAdicionarCliente = new RadioButton();
            lblSituacaoCliente = new Label();
            lblNomeCliente = new Label();
            lblIdCliente = new Label();
            lblNifCliente = new Label();
            txtIdCliente = new TextBox();
            btnLimparCliente = new Button();
            dgvClientes = new DataGridView();
            txtNifCliente = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMovimentos).BeginInit();
            tabGestao.SuspendLayout();
            tabGestãoMovimentos.SuspendLayout();
            tabListarMovimentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListagens).BeginInit();
            tabGestaoClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Segoe UI", 14F);
            btnClientes.Location = new Point(789, 484);
            btnClientes.Margin = new Padding(3, 2, 3, 2);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(538, 43);
            btnClientes.TabIndex = 5;
            btnClientes.Text = "ATUALIZAR";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BorderStyle = BorderStyle.FixedSingle;
            txtNomeCliente.Font = new Font("Segoe UI", 14F);
            txtNomeCliente.Location = new Point(791, 189);
            txtNomeCliente.Margin = new Padding(3, 2, 3, 2);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.PlaceholderText = " Nome...";
            txtNomeCliente.Size = new Size(541, 32);
            txtNomeCliente.TabIndex = 3;
            // 
            // txtSituacaoCliente
            // 
            txtSituacaoCliente.BorderStyle = BorderStyle.FixedSingle;
            txtSituacaoCliente.Font = new Font("Segoe UI", 14F);
            txtSituacaoCliente.Location = new Point(791, 254);
            txtSituacaoCliente.Margin = new Padding(3, 2, 3, 2);
            txtSituacaoCliente.Name = "txtSituacaoCliente";
            txtSituacaoCliente.PlaceholderText = " Situacao...";
            txtSituacaoCliente.Size = new Size(541, 32);
            txtSituacaoCliente.TabIndex = 4;
            // 
            // dgvMovimentos
            // 
            dgvMovimentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovimentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimentos.Location = new Point(6, 57);
            dgvMovimentos.Margin = new Padding(3, 2, 3, 2);
            dgvMovimentos.Name = "dgvMovimentos";
            dgvMovimentos.RowHeadersVisible = false;
            dgvMovimentos.RowHeadersWidth = 51;
            dgvMovimentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovimentos.Size = new Size(777, 516);
            dgvMovimentos.TabIndex = 99;
            dgvMovimentos.SelectionChanged += dgvMovimentos_SelectionChanged;
            // 
            // btnLimparMovimento
            // 
            btnLimparMovimento.Font = new Font("Segoe UI", 14F);
            btnLimparMovimento.Location = new Point(789, 530);
            btnLimparMovimento.Margin = new Padding(3, 2, 3, 2);
            btnLimparMovimento.Name = "btnLimparMovimento";
            btnLimparMovimento.Size = new Size(538, 43);
            btnLimparMovimento.TabIndex = 18;
            btnLimparMovimento.Text = "LIMPAR";
            btnLimparMovimento.UseVisualStyleBackColor = true;
            btnLimparMovimento.Click += btnLimparMovimento_Click;
            // 
            // tabGestao
            // 
            tabGestao.Controls.Add(tabGestãoMovimentos);
            tabGestao.Controls.Add(tabListarMovimentos);
            tabGestao.Controls.Add(tabGestaoClientes);
            tabGestao.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabGestao.Location = new Point(12, 12);
            tabGestao.Name = "tabGestao";
            tabGestao.SelectedIndex = 0;
            tabGestao.Size = new Size(1343, 606);
            tabGestao.TabIndex = 6;
            // 
            // tabGestãoMovimentos
            // 
            tabGestãoMovimentos.Controls.Add(label1);
            tabGestãoMovimentos.Controls.Add(rbtAtualizarMovimento);
            tabGestãoMovimentos.Controls.Add(rbtRemoverMovimento);
            tabGestãoMovimentos.Controls.Add(rbtAdicionarMovimento);
            tabGestãoMovimentos.Controls.Add(txtIdMovimento);
            tabGestãoMovimentos.Controls.Add(lblIdMovimento);
            tabGestãoMovimentos.Controls.Add(lblTipoPagamentoMovimento);
            tabGestãoMovimentos.Controls.Add(lblValorMovimento);
            tabGestãoMovimentos.Controls.Add(lblSituaçãoMovimento);
            tabGestãoMovimentos.Controls.Add(lblClienteMovimento);
            tabGestãoMovimentos.Controls.Add(lblDataMovimento);
            tabGestãoMovimentos.Controls.Add(lblDescricaoMovimento);
            tabGestãoMovimentos.Controls.Add(btnMovimentos);
            tabGestãoMovimentos.Controls.Add(cbxTipoMovimento);
            tabGestãoMovimentos.Controls.Add(txtSituacaoMovimento);
            tabGestãoMovimentos.Controls.Add(dupValorMovimento);
            tabGestãoMovimentos.Controls.Add(txtDescricaoMovimento);
            tabGestãoMovimentos.Controls.Add(dtpMovimento);
            tabGestãoMovimentos.Controls.Add(cbxClienteMovimento);
            tabGestãoMovimentos.Controls.Add(dgvMovimentos);
            tabGestãoMovimentos.Controls.Add(btnLimparMovimento);
            tabGestãoMovimentos.Location = new Point(4, 24);
            tabGestãoMovimentos.Name = "tabGestãoMovimentos";
            tabGestãoMovimentos.Padding = new Padding(3);
            tabGestãoMovimentos.Size = new Size(1335, 578);
            tabGestãoMovimentos.TabIndex = 0;
            tabGestãoMovimentos.Text = "Gestão de Movimentos";
            tabGestãoMovimentos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(6, 7);
            label1.Name = "label1";
            label1.Size = new Size(262, 32);
            label1.TabIndex = 24;
            label1.Text = "Gestão de Movimentos";
            // 
            // rbtAtualizarMovimento
            // 
            rbtAtualizarMovimento.AutoSize = true;
            rbtAtualizarMovimento.Checked = true;
            rbtAtualizarMovimento.Font = new Font("Segoe UI", 10F);
            rbtAtualizarMovimento.Location = new Point(791, 7);
            rbtAtualizarMovimento.Name = "rbtAtualizarMovimento";
            rbtAtualizarMovimento.Size = new Size(155, 23);
            rbtAtualizarMovimento.TabIndex = 23;
            rbtAtualizarMovimento.TabStop = true;
            rbtAtualizarMovimento.Text = "Atualizar Movimento";
            rbtAtualizarMovimento.UseVisualStyleBackColor = true;
            rbtAtualizarMovimento.CheckedChanged += rbtMovimento_Changed;
            // 
            // rbtRemoverMovimento
            // 
            rbtRemoverMovimento.AutoSize = true;
            rbtRemoverMovimento.Font = new Font("Segoe UI", 10F);
            rbtRemoverMovimento.Location = new Point(1154, 7);
            rbtRemoverMovimento.Name = "rbtRemoverMovimento";
            rbtRemoverMovimento.Size = new Size(156, 23);
            rbtRemoverMovimento.TabIndex = 22;
            rbtRemoverMovimento.TabStop = true;
            rbtRemoverMovimento.Text = "Remover Movimento";
            rbtRemoverMovimento.UseVisualStyleBackColor = true;
            rbtRemoverMovimento.CheckedChanged += rbtMovimento_Changed;
            // 
            // rbtAdicionarMovimento
            // 
            rbtAdicionarMovimento.AutoSize = true;
            rbtAdicionarMovimento.Font = new Font("Segoe UI", 10F);
            rbtAdicionarMovimento.Location = new Point(970, 7);
            rbtAdicionarMovimento.Name = "rbtAdicionarMovimento";
            rbtAdicionarMovimento.Size = new Size(159, 23);
            rbtAdicionarMovimento.TabIndex = 21;
            rbtAdicionarMovimento.TabStop = true;
            rbtAdicionarMovimento.Text = "Adicionar Movimento";
            rbtAdicionarMovimento.UseVisualStyleBackColor = true;
            rbtAdicionarMovimento.CheckedChanged += rbtMovimento_Changed;
            // 
            // txtIdMovimento
            // 
            txtIdMovimento.BorderStyle = BorderStyle.FixedSingle;
            txtIdMovimento.Font = new Font("Segoe UI", 14F);
            txtIdMovimento.Location = new Point(791, 57);
            txtIdMovimento.Margin = new Padding(2, 1, 2, 1);
            txtIdMovimento.Name = "txtIdMovimento";
            txtIdMovimento.PlaceholderText = " ID...";
            txtIdMovimento.ReadOnly = true;
            txtIdMovimento.Size = new Size(537, 32);
            txtIdMovimento.TabIndex = 10;
            // 
            // lblIdMovimento
            // 
            lblIdMovimento.AutoSize = true;
            lblIdMovimento.Font = new Font("Segoe UI", 12F);
            lblIdMovimento.Location = new Point(791, 35);
            lblIdMovimento.Margin = new Padding(2, 0, 2, 0);
            lblIdMovimento.Name = "lblIdMovimento";
            lblIdMovimento.Size = new Size(25, 21);
            lblIdMovimento.TabIndex = 19;
            lblIdMovimento.Text = "ID";
            // 
            // lblTipoPagamentoMovimento
            // 
            lblTipoPagamentoMovimento.AutoSize = true;
            lblTipoPagamentoMovimento.Font = new Font("Segoe UI", 12F);
            lblTipoPagamentoMovimento.Location = new Point(791, 421);
            lblTipoPagamentoMovimento.Margin = new Padding(2, 0, 2, 0);
            lblTipoPagamentoMovimento.Name = "lblTipoPagamentoMovimento";
            lblTipoPagamentoMovimento.Size = new Size(122, 21);
            lblTipoPagamentoMovimento.TabIndex = 18;
            lblTipoPagamentoMovimento.Text = "Tipo Pagamento";
            // 
            // lblValorMovimento
            // 
            lblValorMovimento.AutoSize = true;
            lblValorMovimento.Font = new Font("Segoe UI", 12F);
            lblValorMovimento.Location = new Point(791, 356);
            lblValorMovimento.Margin = new Padding(2, 0, 2, 0);
            lblValorMovimento.Name = "lblValorMovimento";
            lblValorMovimento.Size = new Size(46, 21);
            lblValorMovimento.TabIndex = 17;
            lblValorMovimento.Text = "Valor";
            // 
            // lblSituaçãoMovimento
            // 
            lblSituaçãoMovimento.AutoSize = true;
            lblSituaçãoMovimento.Font = new Font("Segoe UI", 12F);
            lblSituaçãoMovimento.Location = new Point(791, 231);
            lblSituaçãoMovimento.Margin = new Padding(2, 0, 2, 0);
            lblSituaçãoMovimento.Name = "lblSituaçãoMovimento";
            lblSituaçãoMovimento.Size = new Size(69, 21);
            lblSituaçãoMovimento.TabIndex = 16;
            lblSituaçãoMovimento.Text = "Situação";
            // 
            // lblClienteMovimento
            // 
            lblClienteMovimento.AutoSize = true;
            lblClienteMovimento.Font = new Font("Segoe UI", 12F);
            lblClienteMovimento.Location = new Point(791, 293);
            lblClienteMovimento.Margin = new Padding(2, 0, 2, 0);
            lblClienteMovimento.Name = "lblClienteMovimento";
            lblClienteMovimento.Size = new Size(58, 21);
            lblClienteMovimento.TabIndex = 15;
            lblClienteMovimento.Text = "Cliente";
            // 
            // lblDataMovimento
            // 
            lblDataMovimento.AutoSize = true;
            lblDataMovimento.Font = new Font("Segoe UI", 12F);
            lblDataMovimento.Location = new Point(791, 103);
            lblDataMovimento.Margin = new Padding(2, 0, 2, 0);
            lblDataMovimento.Name = "lblDataMovimento";
            lblDataMovimento.Size = new Size(42, 21);
            lblDataMovimento.TabIndex = 14;
            lblDataMovimento.Text = "Data";
            // 
            // lblDescricaoMovimento
            // 
            lblDescricaoMovimento.AutoSize = true;
            lblDescricaoMovimento.Font = new Font("Segoe UI", 12F);
            lblDescricaoMovimento.Location = new Point(791, 167);
            lblDescricaoMovimento.Margin = new Padding(2, 0, 2, 0);
            lblDescricaoMovimento.Name = "lblDescricaoMovimento";
            lblDescricaoMovimento.Size = new Size(77, 21);
            lblDescricaoMovimento.TabIndex = 13;
            lblDescricaoMovimento.Text = "Descrição";
            // 
            // btnMovimentos
            // 
            btnMovimentos.Font = new Font("Segoe UI", 14F);
            btnMovimentos.Location = new Point(789, 484);
            btnMovimentos.Margin = new Padding(2, 1, 2, 1);
            btnMovimentos.Name = "btnMovimentos";
            btnMovimentos.Size = new Size(538, 43);
            btnMovimentos.TabIndex = 17;
            btnMovimentos.Text = "ATUALIZAR";
            btnMovimentos.UseVisualStyleBackColor = true;
            btnMovimentos.Click += btnMovimentos_Click;
            // 
            // cbxTipoMovimento
            // 
            cbxTipoMovimento.Font = new Font("Segoe UI", 14F);
            cbxTipoMovimento.FormattingEnabled = true;
            cbxTipoMovimento.Location = new Point(791, 443);
            cbxTipoMovimento.Margin = new Padding(2, 1, 2, 1);
            cbxTipoMovimento.Name = "cbxTipoMovimento";
            cbxTipoMovimento.Size = new Size(536, 33);
            cbxTipoMovimento.TabIndex = 16;
            cbxTipoMovimento.Text = " Tipo...";
            // 
            // txtSituacaoMovimento
            // 
            txtSituacaoMovimento.BorderStyle = BorderStyle.FixedSingle;
            txtSituacaoMovimento.Font = new Font("Segoe UI", 14F);
            txtSituacaoMovimento.Location = new Point(791, 254);
            txtSituacaoMovimento.Margin = new Padding(2, 1, 2, 1);
            txtSituacaoMovimento.Name = "txtSituacaoMovimento";
            txtSituacaoMovimento.PlaceholderText = " Situação do movimento...";
            txtSituacaoMovimento.ShortcutsEnabled = false;
            txtSituacaoMovimento.Size = new Size(536, 32);
            txtSituacaoMovimento.TabIndex = 13;
            // 
            // dupValorMovimento
            // 
            dupValorMovimento.Font = new Font("Segoe UI", 14F);
            dupValorMovimento.Location = new Point(791, 378);
            dupValorMovimento.Margin = new Padding(2, 1, 2, 1);
            dupValorMovimento.Name = "dupValorMovimento";
            dupValorMovimento.Size = new Size(536, 32);
            dupValorMovimento.TabIndex = 15;
            dupValorMovimento.Text = "0.00";
            // 
            // txtDescricaoMovimento
            // 
            txtDescricaoMovimento.BorderStyle = BorderStyle.FixedSingle;
            txtDescricaoMovimento.Font = new Font("Segoe UI", 14F);
            txtDescricaoMovimento.Location = new Point(791, 189);
            txtDescricaoMovimento.Margin = new Padding(2, 1, 2, 1);
            txtDescricaoMovimento.Name = "txtDescricaoMovimento";
            txtDescricaoMovimento.PlaceholderText = " Descrição...";
            txtDescricaoMovimento.Size = new Size(536, 32);
            txtDescricaoMovimento.TabIndex = 12;
            // 
            // dtpMovimento
            // 
            dtpMovimento.CalendarFont = new Font("Segoe UI", 14F);
            dtpMovimento.CustomFormat = "yyyy - MM - dd";
            dtpMovimento.Font = new Font("Segoe UI", 14F);
            dtpMovimento.Format = DateTimePickerFormat.Custom;
            dtpMovimento.Location = new Point(791, 125);
            dtpMovimento.Margin = new Padding(2, 1, 2, 1);
            dtpMovimento.Name = "dtpMovimento";
            dtpMovimento.Size = new Size(537, 32);
            dtpMovimento.TabIndex = 11;
            // 
            // cbxClienteMovimento
            // 
            cbxClienteMovimento.Font = new Font("Segoe UI", 14F);
            cbxClienteMovimento.FormattingEnabled = true;
            cbxClienteMovimento.Location = new Point(791, 315);
            cbxClienteMovimento.Margin = new Padding(2, 1, 2, 1);
            cbxClienteMovimento.Name = "cbxClienteMovimento";
            cbxClienteMovimento.Size = new Size(536, 33);
            cbxClienteMovimento.TabIndex = 14;
            cbxClienteMovimento.Text = " Cliente...";
            // 
            // tabListarMovimentos
            // 
            tabListarMovimentos.Controls.Add(rbtListagemClientesSemMarcador);
            tabListarMovimentos.Controls.Add(txtMarcadorListagem);
            tabListarMovimentos.Controls.Add(rbtListagemClienteMesAno);
            tabListarMovimentos.Controls.Add(rbtListagemClientesNegativos);
            tabListarMovimentos.Controls.Add(chkListagemAno);
            tabListarMovimentos.Controls.Add(chkListagemMes);
            tabListarMovimentos.Controls.Add(label3);
            tabListarMovimentos.Controls.Add(lblMesListagem);
            tabListarMovimentos.Controls.Add(cbxAnoListagem);
            tabListarMovimentos.Controls.Add(cbxMesListagem);
            tabListarMovimentos.Controls.Add(lblClienteListagem);
            tabListarMovimentos.Controls.Add(cbxClienteListagem);
            tabListarMovimentos.Controls.Add(btnListar);
            tabListarMovimentos.Controls.Add(btnLimpar);
            tabListarMovimentos.Controls.Add(lblListagens);
            tabListarMovimentos.Controls.Add(dgvListagens);
            tabListarMovimentos.Location = new Point(4, 24);
            tabListarMovimentos.Margin = new Padding(3, 2, 3, 2);
            tabListarMovimentos.Name = "tabListarMovimentos";
            tabListarMovimentos.Size = new Size(1335, 578);
            tabListarMovimentos.TabIndex = 2;
            tabListarMovimentos.Text = "Listar Movimentos";
            tabListarMovimentos.UseVisualStyleBackColor = true;
            // 
            // rbtListagemClientesSemMarcador
            // 
            rbtListagemClientesSemMarcador.AutoSize = true;
            rbtListagemClientesSemMarcador.Font = new Font("Segoe UI", 10F);
            rbtListagemClientesSemMarcador.Location = new Point(789, 273);
            rbtListagemClientesSemMarcador.Name = "rbtListagemClientesSemMarcador";
            rbtListagemClientesSemMarcador.Size = new Size(305, 23);
            rbtListagemClientesSemMarcador.TabIndex = 118;
            rbtListagemClientesSemMarcador.TabStop = true;
            rbtListagemClientesSemMarcador.Text = "Clientes que não possuem o marcador abaixo";
            rbtListagemClientesSemMarcador.UseVisualStyleBackColor = true;
            // 
            // txtMarcadorListagem
            // 
            txtMarcadorListagem.BorderStyle = BorderStyle.FixedSingle;
            txtMarcadorListagem.Font = new Font("Segoe UI", 14F);
            txtMarcadorListagem.Location = new Point(789, 300);
            txtMarcadorListagem.Margin = new Padding(2, 1, 2, 1);
            txtMarcadorListagem.Name = "txtMarcadorListagem";
            txtMarcadorListagem.PlaceholderText = " Marcador...";
            txtMarcadorListagem.Size = new Size(536, 32);
            txtMarcadorListagem.TabIndex = 117;
            // 
            // rbtListagemClienteMesAno
            // 
            rbtListagemClienteMesAno.AutoSize = true;
            rbtListagemClienteMesAno.Checked = true;
            rbtListagemClienteMesAno.Font = new Font("Segoe UI", 10F);
            rbtListagemClienteMesAno.Location = new Point(791, 7);
            rbtListagemClienteMesAno.Name = "rbtListagemClienteMesAno";
            rbtListagemClienteMesAno.Size = new Size(215, 23);
            rbtListagemClienteMesAno.TabIndex = 116;
            rbtListagemClienteMesAno.TabStop = true;
            rbtListagemClienteMesAno.Text = "Movimentos Cliente (mes/ano)";
            rbtListagemClienteMesAno.UseVisualStyleBackColor = true;
            rbtListagemClienteMesAno.CheckedChanged += rbtListagemClienteMesAno_CheckedChanged;
            // 
            // rbtListagemClientesNegativos
            // 
            rbtListagemClientesNegativos.AutoSize = true;
            rbtListagemClientesNegativos.Font = new Font("Segoe UI", 10F);
            rbtListagemClientesNegativos.Location = new Point(789, 214);
            rbtListagemClientesNegativos.Name = "rbtListagemClientesNegativos";
            rbtListagemClientesNegativos.Size = new Size(252, 23);
            rbtListagemClientesNegativos.TabIndex = 114;
            rbtListagemClientesNegativos.TabStop = true;
            rbtListagemClientesNegativos.Text = "Clientes com saldo negativo (>1000)";
            rbtListagemClientesNegativos.UseVisualStyleBackColor = true;
            // 
            // chkListagemAno
            // 
            chkListagemAno.AutoSize = true;
            chkListagemAno.Font = new Font("Segoe UI", 12F);
            chkListagemAno.Location = new Point(1116, 154);
            chkListagemAno.Margin = new Padding(3, 2, 3, 2);
            chkListagemAno.Name = "chkListagemAno";
            chkListagemAno.Size = new Size(135, 25);
            chkListagemAno.TabIndex = 111;
            chkListagemAno.Text = "Filtrar por ano?";
            chkListagemAno.UseVisualStyleBackColor = true;
            // 
            // chkListagemMes
            // 
            chkListagemMes.AutoSize = true;
            chkListagemMes.Font = new Font("Segoe UI", 12F);
            chkListagemMes.Location = new Point(791, 154);
            chkListagemMes.Margin = new Padding(3, 2, 3, 2);
            chkListagemMes.Name = "chkListagemMes";
            chkListagemMes.Size = new Size(138, 25);
            chkListagemMes.TabIndex = 110;
            chkListagemMes.Text = "Filtrar por mês?";
            chkListagemMes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(1116, 96);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 21);
            label3.TabIndex = 109;
            label3.Text = "Ano";
            // 
            // lblMesListagem
            // 
            lblMesListagem.AutoSize = true;
            lblMesListagem.Font = new Font("Segoe UI", 12F);
            lblMesListagem.Location = new Point(791, 96);
            lblMesListagem.Margin = new Padding(2, 0, 2, 0);
            lblMesListagem.Name = "lblMesListagem";
            lblMesListagem.Size = new Size(39, 21);
            lblMesListagem.TabIndex = 108;
            lblMesListagem.Text = "Mês";
            // 
            // cbxAnoListagem
            // 
            cbxAnoListagem.Font = new Font("Segoe UI", 14F);
            cbxAnoListagem.FormattingEnabled = true;
            cbxAnoListagem.Location = new Point(1116, 118);
            cbxAnoListagem.Margin = new Padding(2, 1, 2, 1);
            cbxAnoListagem.Name = "cbxAnoListagem";
            cbxAnoListagem.Size = new Size(210, 33);
            cbxAnoListagem.TabIndex = 107;
            cbxAnoListagem.Text = "Ano...";
            // 
            // cbxMesListagem
            // 
            cbxMesListagem.Font = new Font("Segoe UI", 14F);
            cbxMesListagem.FormattingEnabled = true;
            cbxMesListagem.Location = new Point(791, 118);
            cbxMesListagem.Margin = new Padding(2, 1, 2, 1);
            cbxMesListagem.Name = "cbxMesListagem";
            cbxMesListagem.Size = new Size(322, 33);
            cbxMesListagem.TabIndex = 106;
            cbxMesListagem.Text = "Mês...";
            // 
            // lblClienteListagem
            // 
            lblClienteListagem.AutoSize = true;
            lblClienteListagem.Font = new Font("Segoe UI", 12F);
            lblClienteListagem.Location = new Point(791, 35);
            lblClienteListagem.Margin = new Padding(2, 0, 2, 0);
            lblClienteListagem.Name = "lblClienteListagem";
            lblClienteListagem.Size = new Size(58, 21);
            lblClienteListagem.TabIndex = 105;
            lblClienteListagem.Text = "Cliente";
            // 
            // cbxClienteListagem
            // 
            cbxClienteListagem.Font = new Font("Segoe UI", 14F);
            cbxClienteListagem.FormattingEnabled = true;
            cbxClienteListagem.Location = new Point(791, 57);
            cbxClienteListagem.Margin = new Padding(2, 1, 2, 1);
            cbxClienteListagem.Name = "cbxClienteListagem";
            cbxClienteListagem.Size = new Size(536, 33);
            cbxClienteListagem.TabIndex = 104;
            cbxClienteListagem.Text = " Cliente...";
            // 
            // btnListar
            // 
            btnListar.Font = new Font("Segoe UI", 14F);
            btnListar.Location = new Point(789, 484);
            btnListar.Margin = new Padding(2, 1, 2, 1);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(538, 43);
            btnListar.TabIndex = 102;
            btnListar.Text = "LISTAR";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 14F);
            btnLimpar.Location = new Point(789, 530);
            btnLimpar.Margin = new Padding(3, 2, 3, 2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(538, 43);
            btnLimpar.TabIndex = 103;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // lblListagens
            // 
            lblListagens.AutoSize = true;
            lblListagens.Font = new Font("Segoe UI", 18F);
            lblListagens.Location = new Point(6, 7);
            lblListagens.Name = "lblListagens";
            lblListagens.Size = new Size(112, 32);
            lblListagens.TabIndex = 100;
            lblListagens.Text = "Listagens";
            // 
            // dgvListagens
            // 
            dgvListagens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListagens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListagens.Location = new Point(6, 57);
            dgvListagens.Margin = new Padding(3, 2, 3, 2);
            dgvListagens.Name = "dgvListagens";
            dgvListagens.RowHeadersVisible = false;
            dgvListagens.RowHeadersWidth = 51;
            dgvListagens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListagens.Size = new Size(777, 516);
            dgvListagens.TabIndex = 101;
            // 
            // tabGestaoClientes
            // 
            tabGestaoClientes.Controls.Add(label2);
            tabGestaoClientes.Controls.Add(rbtRemoverCliente);
            tabGestaoClientes.Controls.Add(rbtAtualizarCliente);
            tabGestaoClientes.Controls.Add(rbtAdicionarCliente);
            tabGestaoClientes.Controls.Add(lblSituacaoCliente);
            tabGestaoClientes.Controls.Add(lblNomeCliente);
            tabGestaoClientes.Controls.Add(lblIdCliente);
            tabGestaoClientes.Controls.Add(lblNifCliente);
            tabGestaoClientes.Controls.Add(txtIdCliente);
            tabGestaoClientes.Controls.Add(btnLimparCliente);
            tabGestaoClientes.Controls.Add(dgvClientes);
            tabGestaoClientes.Controls.Add(txtNomeCliente);
            tabGestaoClientes.Controls.Add(txtNifCliente);
            tabGestaoClientes.Controls.Add(txtSituacaoCliente);
            tabGestaoClientes.Controls.Add(btnClientes);
            tabGestaoClientes.Location = new Point(4, 24);
            tabGestaoClientes.Name = "tabGestaoClientes";
            tabGestaoClientes.Padding = new Padding(3);
            tabGestaoClientes.Size = new Size(1335, 578);
            tabGestaoClientes.TabIndex = 1;
            tabGestaoClientes.Text = "Gestão de Clientes";
            tabGestaoClientes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(6, 6);
            label2.Name = "label2";
            label2.Size = new Size(213, 32);
            label2.TabIndex = 16;
            label2.Text = "Gestão de Clientes";
            // 
            // rbtRemoverCliente
            // 
            rbtRemoverCliente.AutoSize = true;
            rbtRemoverCliente.Font = new Font("Segoe UI", 10F);
            rbtRemoverCliente.Location = new Point(1090, 7);
            rbtRemoverCliente.Name = "rbtRemoverCliente";
            rbtRemoverCliente.Size = new Size(127, 23);
            rbtRemoverCliente.TabIndex = 15;
            rbtRemoverCliente.Text = "Remover Cliente";
            rbtRemoverCliente.UseVisualStyleBackColor = true;
            rbtRemoverCliente.CheckedChanged += rbtCliente_CheckedChanged;
            // 
            // rbtAtualizarCliente
            // 
            rbtAtualizarCliente.AutoSize = true;
            rbtAtualizarCliente.Checked = true;
            rbtAtualizarCliente.Font = new Font("Segoe UI", 10F);
            rbtAtualizarCliente.Location = new Point(791, 7);
            rbtAtualizarCliente.Name = "rbtAtualizarCliente";
            rbtAtualizarCliente.Size = new Size(126, 23);
            rbtAtualizarCliente.TabIndex = 14;
            rbtAtualizarCliente.TabStop = true;
            rbtAtualizarCliente.Text = "Atualizar Cliente";
            rbtAtualizarCliente.UseVisualStyleBackColor = true;
            rbtAtualizarCliente.CheckedChanged += rbtCliente_CheckedChanged;
            // 
            // rbtAdicionarCliente
            // 
            rbtAdicionarCliente.AutoSize = true;
            rbtAdicionarCliente.Font = new Font("Segoe UI", 10F);
            rbtAdicionarCliente.Location = new Point(938, 7);
            rbtAdicionarCliente.Name = "rbtAdicionarCliente";
            rbtAdicionarCliente.Size = new Size(130, 23);
            rbtAdicionarCliente.TabIndex = 13;
            rbtAdicionarCliente.Text = "Adicionar Cliente";
            rbtAdicionarCliente.UseVisualStyleBackColor = true;
            rbtAdicionarCliente.CheckedChanged += rbtCliente_CheckedChanged;
            // 
            // lblSituacaoCliente
            // 
            lblSituacaoCliente.AutoSize = true;
            lblSituacaoCliente.Font = new Font("Segoe UI", 12F);
            lblSituacaoCliente.Location = new Point(791, 231);
            lblSituacaoCliente.Name = "lblSituacaoCliente";
            lblSituacaoCliente.Size = new Size(69, 21);
            lblSituacaoCliente.TabIndex = 11;
            lblSituacaoCliente.Text = "Situação";
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Font = new Font("Segoe UI", 12F);
            lblNomeCliente.Location = new Point(789, 166);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(53, 21);
            lblNomeCliente.TabIndex = 10;
            lblNomeCliente.Text = "Nome";
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Font = new Font("Segoe UI", 12F);
            lblIdCliente.Location = new Point(788, 34);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(25, 21);
            lblIdCliente.TabIndex = 9;
            lblIdCliente.Text = "ID";
            // 
            // lblNifCliente
            // 
            lblNifCliente.AutoSize = true;
            lblNifCliente.Font = new Font("Segoe UI", 12F);
            lblNifCliente.Location = new Point(788, 102);
            lblNifCliente.Name = "lblNifCliente";
            lblNifCliente.Size = new Size(34, 21);
            lblNifCliente.TabIndex = 8;
            lblNifCliente.Text = "NIF";
            // 
            // txtIdCliente
            // 
            txtIdCliente.BorderStyle = BorderStyle.FixedSingle;
            txtIdCliente.Font = new Font("Segoe UI", 14F);
            txtIdCliente.Location = new Point(791, 57);
            txtIdCliente.Margin = new Padding(3, 2, 3, 2);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.PlaceholderText = " ID...";
            txtIdCliente.ReadOnly = true;
            txtIdCliente.Size = new Size(541, 32);
            txtIdCliente.TabIndex = 1;
            // 
            // btnLimparCliente
            // 
            btnLimparCliente.Font = new Font("Segoe UI", 14F);
            btnLimparCliente.Location = new Point(789, 530);
            btnLimparCliente.Name = "btnLimparCliente";
            btnLimparCliente.Size = new Size(538, 43);
            btnLimparCliente.TabIndex = 6;
            btnLimparCliente.Text = "LIMPAR";
            btnLimparCliente.UseVisualStyleBackColor = true;
            btnLimparCliente.Click += btnLimparCliente_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(6, 57);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 82;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(777, 516);
            dgvClientes.TabIndex = 98;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            // 
            // txtNifCliente
            // 
            txtNifCliente.BorderStyle = BorderStyle.FixedSingle;
            txtNifCliente.Font = new Font("Segoe UI", 14F);
            txtNifCliente.Location = new Point(791, 125);
            txtNifCliente.Margin = new Padding(3, 2, 3, 2);
            txtNifCliente.Name = "txtNifCliente";
            txtNifCliente.PlaceholderText = " Nif...";
            txtNifCliente.Size = new Size(541, 32);
            txtNifCliente.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 625);
            Controls.Add(tabGestao);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão Clix";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMovimentos).EndInit();
            tabGestao.ResumeLayout(false);
            tabGestãoMovimentos.ResumeLayout(false);
            tabGestãoMovimentos.PerformLayout();
            tabListarMovimentos.ResumeLayout(false);
            tabListarMovimentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListagens).EndInit();
            tabGestaoClientes.ResumeLayout(false);
            tabGestaoClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private TextBox txtNomeCliente;
        private TextBox txtSituacaoCliente;
        private DataGridView dgvMovimentos;
        private Button btnLimparMovimento;
        private TabControl tabGestao;
        private TabPage tabGestãoMovimentos;
        private TabPage tabGestaoClientes;
        private DataGridView dgvClientes;
        private Button btnLimparCliente;
        private TextBox txtIdCliente;
        private Label lblNomeCliente;
        private Label lblIdCliente;
        private Label lblNifCliente;
        private Label lblSituacaoCliente;
        private RadioButton rbtRemoverCliente;
        private RadioButton rbtAtualizarCliente;
        private RadioButton rbtAdicionarCliente;
        private ComboBox cbxClienteMovimento;
        private DateTimePicker dtpMovimento;
        private TextBox txtDescricaoMovimento;
        private ComboBox cbxTipoMovimento;
        private TextBox txtSituacaoMovimento;
        private DomainUpDown dupValorMovimento;
        private Button btnMovimentos;
        private Label lblDescricaoMovimento;
        private Label lblTipoPagamentoMovimento;
        private Label lblValorMovimento;
        private Label lblSituaçãoMovimento;
        private Label lblClienteMovimento;
        private Label lblDataMovimento;
        private TextBox txtIdMovimento;
        private Label lblIdMovimento;
        private RadioButton rbtAtualizarMovimento;
        private RadioButton rbtRemoverMovimento;
        private RadioButton rbtAdicionarMovimento;
        private Label label1;
        private Label label2;
        private TextBox txtNifCliente;
        private TabPage tabListarMovimentos;
        private Label lblListagens;
        private DataGridView dgvListagens;
        private Label lblClienteListagem;
        private ComboBox cbxClienteListagem;
        private Button btnListar;
        private Button btnLimpar;
        private Label label3;
        private Label lblMesListagem;
        private ComboBox cbxAnoListagem;
        private ComboBox cbxMesListagem;
        private CheckBox chkListagemMes;
        private CheckBox chkListagemAno;
        private RadioButton rbtListagemClienteMesAno;
        private RadioButton rbtListagemClientesNegativos;
        private RadioButton rbtListagemClientesSemMarcador;
        private TextBox txtMarcadorListagem;
    }
}
