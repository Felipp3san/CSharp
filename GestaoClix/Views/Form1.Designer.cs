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
            tabMovimentos = new TabPage();
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
            tabMovimentos.SuspendLayout();
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
            dgvMovimentos.TabIndex = 4;
            dgvMovimentos.SelectionChanged += dgvMovimentos_SelectionChanged;
            // 
            // btnLimparMovimento
            // 
            btnLimparMovimento.Font = new Font("Segoe UI", 14F);
            btnLimparMovimento.Location = new Point(789, 530);
            btnLimparMovimento.Margin = new Padding(3, 2, 3, 2);
            btnLimparMovimento.Name = "btnLimparMovimento";
            btnLimparMovimento.Size = new Size(538, 43);
            btnLimparMovimento.TabIndex = 5;
            btnLimparMovimento.Text = "LIMPAR";
            btnLimparMovimento.UseVisualStyleBackColor = true;
            btnLimparMovimento.Click += btnLimparMovimento_Click;
            // 
            // tabGestao
            // 
            tabGestao.Controls.Add(tabMovimentos);
            tabGestao.Controls.Add(tabGestaoClientes);
            tabGestao.Location = new Point(12, 12);
            tabGestao.Name = "tabGestao";
            tabGestao.SelectedIndex = 0;
            tabGestao.Size = new Size(1343, 606);
            tabGestao.TabIndex = 6;
            // 
            // tabMovimentos
            // 
            tabMovimentos.Controls.Add(label1);
            tabMovimentos.Controls.Add(rbtAtualizarMovimento);
            tabMovimentos.Controls.Add(rbtRemoverMovimento);
            tabMovimentos.Controls.Add(rbtAdicionarMovimento);
            tabMovimentos.Controls.Add(txtIdMovimento);
            tabMovimentos.Controls.Add(lblIdMovimento);
            tabMovimentos.Controls.Add(lblTipoPagamentoMovimento);
            tabMovimentos.Controls.Add(lblValorMovimento);
            tabMovimentos.Controls.Add(lblSituaçãoMovimento);
            tabMovimentos.Controls.Add(lblClienteMovimento);
            tabMovimentos.Controls.Add(lblDataMovimento);
            tabMovimentos.Controls.Add(lblDescricaoMovimento);
            tabMovimentos.Controls.Add(btnMovimentos);
            tabMovimentos.Controls.Add(cbxTipoMovimento);
            tabMovimentos.Controls.Add(txtSituacaoMovimento);
            tabMovimentos.Controls.Add(dupValorMovimento);
            tabMovimentos.Controls.Add(txtDescricaoMovimento);
            tabMovimentos.Controls.Add(dtpMovimento);
            tabMovimentos.Controls.Add(cbxClienteMovimento);
            tabMovimentos.Controls.Add(dgvMovimentos);
            tabMovimentos.Controls.Add(btnLimparMovimento);
            tabMovimentos.Location = new Point(4, 24);
            tabMovimentos.Name = "tabMovimentos";
            tabMovimentos.Padding = new Padding(3);
            tabMovimentos.Size = new Size(1335, 578);
            tabMovimentos.TabIndex = 0;
            tabMovimentos.Text = "Movimentos";
            tabMovimentos.UseVisualStyleBackColor = true;
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
            rbtAtualizarMovimento.Font = new Font("Segoe UI", 12F);
            rbtAtualizarMovimento.Location = new Point(791, 7);
            rbtAtualizarMovimento.Name = "rbtAtualizarMovimento";
            rbtAtualizarMovimento.Size = new Size(173, 25);
            rbtAtualizarMovimento.TabIndex = 23;
            rbtAtualizarMovimento.TabStop = true;
            rbtAtualizarMovimento.Text = "Atualizar Movimento";
            rbtAtualizarMovimento.UseVisualStyleBackColor = true;
            rbtAtualizarMovimento.CheckedChanged += rbtMovimento_Changed;
            // 
            // rbtRemoverMovimento
            // 
            rbtRemoverMovimento.AutoSize = true;
            rbtRemoverMovimento.Font = new Font("Segoe UI", 12F);
            rbtRemoverMovimento.Location = new Point(1154, 7);
            rbtRemoverMovimento.Name = "rbtRemoverMovimento";
            rbtRemoverMovimento.Size = new Size(175, 25);
            rbtRemoverMovimento.TabIndex = 22;
            rbtRemoverMovimento.TabStop = true;
            rbtRemoverMovimento.Text = "Remover Movimento";
            rbtRemoverMovimento.UseVisualStyleBackColor = true;
            rbtRemoverMovimento.CheckedChanged += rbtMovimento_Changed;
            // 
            // rbtAdicionarMovimento
            // 
            rbtAdicionarMovimento.AutoSize = true;
            rbtAdicionarMovimento.Font = new Font("Segoe UI", 12F);
            rbtAdicionarMovimento.Location = new Point(970, 7);
            rbtAdicionarMovimento.Name = "rbtAdicionarMovimento";
            rbtAdicionarMovimento.Size = new Size(178, 25);
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
            txtIdMovimento.TabIndex = 20;
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
            btnMovimentos.TabIndex = 12;
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
            cbxTipoMovimento.TabIndex = 11;
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
            txtSituacaoMovimento.Size = new Size(536, 32);
            txtSituacaoMovimento.TabIndex = 10;
            // 
            // dupValorMovimento
            // 
            dupValorMovimento.Font = new Font("Segoe UI", 14F);
            dupValorMovimento.Location = new Point(791, 378);
            dupValorMovimento.Margin = new Padding(2, 1, 2, 1);
            dupValorMovimento.Name = "dupValorMovimento";
            dupValorMovimento.Size = new Size(536, 32);
            dupValorMovimento.TabIndex = 9;
            dupValorMovimento.Text = "100,00";
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
            txtDescricaoMovimento.TabIndex = 8;
            // 
            // dtpMovimento
            // 
            dtpMovimento.CalendarFont = new Font("Segoe UI", 14F);
            dtpMovimento.Font = new Font("Segoe UI", 14F);
            dtpMovimento.Location = new Point(791, 125);
            dtpMovimento.Margin = new Padding(2, 1, 2, 1);
            dtpMovimento.Name = "dtpMovimento";
            dtpMovimento.Size = new Size(537, 32);
            dtpMovimento.TabIndex = 7;
            // 
            // cbxClienteMovimento
            // 
            cbxClienteMovimento.Font = new Font("Segoe UI", 14F);
            cbxClienteMovimento.FormattingEnabled = true;
            cbxClienteMovimento.Location = new Point(791, 315);
            cbxClienteMovimento.Margin = new Padding(2, 1, 2, 1);
            cbxClienteMovimento.Name = "cbxClienteMovimento";
            cbxClienteMovimento.Size = new Size(536, 33);
            cbxClienteMovimento.TabIndex = 6;
            cbxClienteMovimento.Text = " Cliente...";
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
            rbtRemoverCliente.Font = new Font("Segoe UI", 12F);
            rbtRemoverCliente.Location = new Point(1090, 7);
            rbtRemoverCliente.Name = "rbtRemoverCliente";
            rbtRemoverCliente.Size = new Size(143, 25);
            rbtRemoverCliente.TabIndex = 15;
            rbtRemoverCliente.Text = "Remover Cliente";
            rbtRemoverCliente.UseVisualStyleBackColor = true;
            rbtRemoverCliente.CheckedChanged += rbtCliente_CheckedChanged;
            // 
            // rbtAtualizarCliente
            // 
            rbtAtualizarCliente.AutoSize = true;
            rbtAtualizarCliente.Checked = true;
            rbtAtualizarCliente.Font = new Font("Segoe UI", 12F);
            rbtAtualizarCliente.Location = new Point(791, 7);
            rbtAtualizarCliente.Name = "rbtAtualizarCliente";
            rbtAtualizarCliente.Size = new Size(141, 25);
            rbtAtualizarCliente.TabIndex = 14;
            rbtAtualizarCliente.TabStop = true;
            rbtAtualizarCliente.Text = "Atualizar Cliente";
            rbtAtualizarCliente.UseVisualStyleBackColor = true;
            rbtAtualizarCliente.CheckedChanged += rbtCliente_CheckedChanged;
            // 
            // rbtAdicionarCliente
            // 
            rbtAdicionarCliente.AutoSize = true;
            rbtAdicionarCliente.Font = new Font("Segoe UI", 12F);
            rbtAdicionarCliente.Location = new Point(938, 7);
            rbtAdicionarCliente.Name = "rbtAdicionarCliente";
            rbtAdicionarCliente.Size = new Size(146, 25);
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
            dgvClientes.TabIndex = 4;
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
            ClientSize = new Size(1359, 625);
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
            tabMovimentos.ResumeLayout(false);
            tabMovimentos.PerformLayout();
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
        private TabPage tabMovimentos;
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
    }
}
