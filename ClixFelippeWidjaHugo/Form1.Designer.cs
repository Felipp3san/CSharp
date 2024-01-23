namespace ClixFelippeWidjaHugo
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
            components = new System.ComponentModel.Container();
            lblRegisto = new Label();
            txtDescricao = new TextBox();
            txtAutoFuncionario = new AutoCompleteTextBox();
            txtAutoCliente = new AutoCompleteTextBox();
            cbxCategoria = new ComboBox();
            txtTempoGasto = new TextBox();
            btnEnviar = new Button();
            panelRegistrarProcesso = new Panel();
            label3 = new Label();
            label2 = new Label();
            dtpDataProcesso = new DateTimePicker();
            panelAdministracao = new Panel();
            panel1 = new Panel();
            panelAdicionarRemoverCategoria = new Panel();
            lblRemoverCategoria = new Label();
            cbxNomesCategorias = new ComboBox();
            btnRemoverCategoria = new Button();
            btnAdicionarCategoria = new Button();
            txtAdicionarCategoria = new TextBox();
            lblAdicionarCategoria = new Label();
            panelAdicionarRemoverCliente = new Panel();
            lblRemoverCliente = new Label();
            cbxNomesClientes = new ComboBox();
            btnRemoverCliente = new Button();
            btnAdicionarCliente = new Button();
            txtAdicionarCliente = new TextBox();
            lblAdicionarCliente = new Label();
            panelAdicionarRemoverFuncionario = new Panel();
            lblRemoverFuncionario = new Label();
            cbxNomesFuncionarios = new ComboBox();
            btnRemoverFuncionario = new Button();
            btnAdicionarFuncionario = new Button();
            txtAdicionarFuncionario = new TextBox();
            lblAdicionarFuncionario = new Label();
            panelBackup = new Panel();
            btnFazerBackUp = new Button();
            lblBackup = new Label();
            label4 = new Label();
            txtBackup = new TextBox();
            lblAdministracao = new Label();
            panelVisualizarProcessos = new Panel();
            lblVisualizacao = new Label();
            dgvProcessos = new DataGridView();
            btnListar = new Button();
            txtTotalHoras = new TextBox();
            label5 = new Label();
            cbxFiltro = new ComboBox();
            lblAgruparPor = new Label();
            rbtNaoAgrupar = new RadioButton();
            rbtFuncionario = new RadioButton();
            rbtCliente = new RadioButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnVisualizarProcessos = new Button();
            btnRegistrarNovoProcesso = new Button();
            btnAdmin = new Button();
            panelRegistrarProcesso.SuspendLayout();
            panelAdministracao.SuspendLayout();
            panelAdicionarRemoverCategoria.SuspendLayout();
            panelAdicionarRemoverCliente.SuspendLayout();
            panelAdicionarRemoverFuncionario.SuspendLayout();
            panelBackup.SuspendLayout();
            panelVisualizarProcessos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProcessos).BeginInit();
            SuspendLayout();
            // 
            // lblRegisto
            // 
            lblRegisto.AutoSize = true;
            lblRegisto.Font = new Font("Segoe UI", 14F);
            lblRegisto.Location = new Point(33, 69);
            lblRegisto.Name = "lblRegisto";
            lblRegisto.Size = new Size(81, 32);
            lblRegisto.TabIndex = 0;
            lblRegisto.Text = "Dados";
            // 
            // txtDescricao
            // 
            txtDescricao.BorderStyle = BorderStyle.FixedSingle;
            txtDescricao.Font = new Font("Segoe UI", 12F);
            txtDescricao.Location = new Point(33, 296);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = " Descrição...";
            txtDescricao.Size = new Size(418, 34);
            txtDescricao.TabIndex = 3;
            // 
            // txtAutoFuncionario
            // 
            txtAutoFuncionario.BorderStyle = BorderStyle.FixedSingle;
            txtAutoFuncionario.Font = new Font("Segoe UI", 12F);
            txtAutoFuncionario.Location = new Point(33, 104);
            txtAutoFuncionario.Name = "txtAutoFuncionario";
            txtAutoFuncionario.PlaceholderText = " ID/Nome Funcionário....";
            txtAutoFuncionario.Size = new Size(418, 34);
            txtAutoFuncionario.TabIndex = 1;
            txtAutoFuncionario.Values = null;
            // 
            // txtAutoCliente
            // 
            txtAutoCliente.BorderStyle = BorderStyle.FixedSingle;
            txtAutoCliente.Font = new Font("Segoe UI", 12F);
            txtAutoCliente.Location = new Point(33, 148);
            txtAutoCliente.Name = "txtAutoCliente";
            txtAutoCliente.PlaceholderText = " ID/Nome Cliente....";
            txtAutoCliente.Size = new Size(418, 34);
            txtAutoCliente.TabIndex = 2;
            txtAutoCliente.Values = null;
            // 
            // cbxCategoria
            // 
            cbxCategoria.Font = new Font("Segoe UI", 12F);
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(33, 252);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(418, 36);
            cbxCategoria.TabIndex = 8;
            cbxCategoria.Text = " Categoria...";
            // 
            // txtTempoGasto
            // 
            txtTempoGasto.BorderStyle = BorderStyle.FixedSingle;
            txtTempoGasto.Font = new Font("Segoe UI", 12F);
            txtTempoGasto.Location = new Point(33, 336);
            txtTempoGasto.Name = "txtTempoGasto";
            txtTempoGasto.PlaceholderText = " Tempo gasto... (em minutos)";
            txtTempoGasto.Size = new Size(418, 34);
            txtTempoGasto.TabIndex = 4;
            // 
            // btnEnviar
            // 
            btnEnviar.Font = new Font("Segoe UI", 14F);
            btnEnviar.Location = new Point(33, 469);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(418, 45);
            btnEnviar.TabIndex = 6;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // panelRegistrarProcesso
            // 
            panelRegistrarProcesso.BorderStyle = BorderStyle.FixedSingle;
            panelRegistrarProcesso.Controls.Add(label3);
            panelRegistrarProcesso.Controls.Add(txtAutoFuncionario);
            panelRegistrarProcesso.Controls.Add(txtAutoCliente);
            panelRegistrarProcesso.Controls.Add(label2);
            panelRegistrarProcesso.Controls.Add(dtpDataProcesso);
            panelRegistrarProcesso.Controls.Add(btnEnviar);
            panelRegistrarProcesso.Controls.Add(lblRegisto);
            panelRegistrarProcesso.Controls.Add(txtDescricao);
            panelRegistrarProcesso.Controls.Add(txtTempoGasto);
            panelRegistrarProcesso.Controls.Add(cbxCategoria);
            panelRegistrarProcesso.Location = new Point(6, 37);
            panelRegistrarProcesso.Name = "panelRegistrarProcesso";
            panelRegistrarProcesso.Size = new Size(483, 534);
            panelRegistrarProcesso.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(107, 13);
            label3.Name = "label3";
            label3.Size = new Size(268, 32);
            label3.TabIndex = 10;
            label3.Text = "Registrar novo processo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(33, 217);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 9;
            label2.Text = "Processo";
            // 
            // dtpDataProcesso
            // 
            dtpDataProcesso.CalendarFont = new Font("Segoe UI", 9F);
            dtpDataProcesso.Font = new Font("Segoe UI", 12F);
            dtpDataProcesso.Format = DateTimePickerFormat.Custom;
            dtpDataProcesso.Location = new Point(33, 376);
            dtpDataProcesso.Name = "dtpDataProcesso";
            dtpDataProcesso.Size = new Size(418, 34);
            dtpDataProcesso.TabIndex = 8;
            // 
            // panelAdministracao
            // 
            panelAdministracao.BorderStyle = BorderStyle.FixedSingle;
            panelAdministracao.Controls.Add(panel1);
            panelAdministracao.Controls.Add(panelAdicionarRemoverCategoria);
            panelAdministracao.Controls.Add(panelAdicionarRemoverCliente);
            panelAdministracao.Controls.Add(panelAdicionarRemoverFuncionario);
            panelAdministracao.Controls.Add(panelBackup);
            panelAdministracao.Controls.Add(lblAdministracao);
            panelAdministracao.Location = new Point(14, 577);
            panelAdministracao.Name = "panelAdministracao";
            panelAdministracao.Size = new Size(1386, 598);
            panelAdministracao.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(709, 381);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 198);
            panel1.TabIndex = 21;
            // 
            // panelAdicionarRemoverCategoria
            // 
            panelAdicionarRemoverCategoria.BorderStyle = BorderStyle.FixedSingle;
            panelAdicionarRemoverCategoria.Controls.Add(lblRemoverCategoria);
            panelAdicionarRemoverCategoria.Controls.Add(cbxNomesCategorias);
            panelAdicionarRemoverCategoria.Controls.Add(btnRemoverCategoria);
            panelAdicionarRemoverCategoria.Controls.Add(btnAdicionarCategoria);
            panelAdicionarRemoverCategoria.Controls.Add(txtAdicionarCategoria);
            panelAdicionarRemoverCategoria.Controls.Add(lblAdicionarCategoria);
            panelAdicionarRemoverCategoria.Location = new Point(923, 59);
            panelAdicionarRemoverCategoria.Margin = new Padding(3, 4, 3, 4);
            panelAdicionarRemoverCategoria.Name = "panelAdicionarRemoverCategoria";
            panelAdicionarRemoverCategoria.Size = new Size(447, 313);
            panelAdicionarRemoverCategoria.TabIndex = 20;
            // 
            // lblRemoverCategoria
            // 
            lblRemoverCategoria.AutoSize = true;
            lblRemoverCategoria.Font = new Font("Segoe UI", 14F);
            lblRemoverCategoria.Location = new Point(15, 168);
            lblRemoverCategoria.Name = "lblRemoverCategoria";
            lblRemoverCategoria.Size = new Size(217, 32);
            lblRemoverCategoria.TabIndex = 28;
            lblRemoverCategoria.Text = "Remover Categoria";
            // 
            // cbxNomesCategorias
            // 
            cbxNomesCategorias.Font = new Font("Segoe UI", 12F);
            cbxNomesCategorias.FormattingEnabled = true;
            cbxNomesCategorias.Location = new Point(15, 203);
            cbxNomesCategorias.Name = "cbxNomesCategorias";
            cbxNomesCategorias.Size = new Size(418, 36);
            cbxNomesCategorias.TabIndex = 27;
            // 
            // btnRemoverCategoria
            // 
            btnRemoverCategoria.Font = new Font("Segoe UI", 12F);
            btnRemoverCategoria.Location = new Point(15, 248);
            btnRemoverCategoria.Margin = new Padding(3, 4, 3, 4);
            btnRemoverCategoria.Name = "btnRemoverCategoria";
            btnRemoverCategoria.Size = new Size(418, 45);
            btnRemoverCategoria.TabIndex = 23;
            btnRemoverCategoria.Text = "Remover";
            btnRemoverCategoria.UseVisualStyleBackColor = true;
            btnRemoverCategoria.Click += btnRemoverCategoria_Click;
            // 
            // btnAdicionarCategoria
            // 
            btnAdicionarCategoria.Font = new Font("Segoe UI", 12F);
            btnAdicionarCategoria.Location = new Point(14, 101);
            btnAdicionarCategoria.Margin = new Padding(3, 4, 3, 4);
            btnAdicionarCategoria.Name = "btnAdicionarCategoria";
            btnAdicionarCategoria.Size = new Size(418, 45);
            btnAdicionarCategoria.TabIndex = 22;
            btnAdicionarCategoria.Text = "Adicionar";
            btnAdicionarCategoria.UseVisualStyleBackColor = true;
            btnAdicionarCategoria.Click += btnAdicionarCategoria_Click;
            // 
            // txtAdicionarCategoria
            // 
            txtAdicionarCategoria.BorderStyle = BorderStyle.FixedSingle;
            txtAdicionarCategoria.Font = new Font("Segoe UI", 12F);
            txtAdicionarCategoria.Location = new Point(14, 55);
            txtAdicionarCategoria.Margin = new Padding(3, 4, 3, 4);
            txtAdicionarCategoria.Name = "txtAdicionarCategoria";
            txtAdicionarCategoria.PlaceholderText = " Nome da categoria...";
            txtAdicionarCategoria.Size = new Size(418, 34);
            txtAdicionarCategoria.TabIndex = 20;
            // 
            // lblAdicionarCategoria
            // 
            lblAdicionarCategoria.AutoSize = true;
            lblAdicionarCategoria.Font = new Font("Segoe UI", 14F);
            lblAdicionarCategoria.Location = new Point(13, 19);
            lblAdicionarCategoria.Name = "lblAdicionarCategoria";
            lblAdicionarCategoria.Size = new Size(223, 32);
            lblAdicionarCategoria.TabIndex = 19;
            lblAdicionarCategoria.Text = "Adicionar Categoria";
            // 
            // panelAdicionarRemoverCliente
            // 
            panelAdicionarRemoverCliente.BorderStyle = BorderStyle.FixedSingle;
            panelAdicionarRemoverCliente.Controls.Add(lblRemoverCliente);
            panelAdicionarRemoverCliente.Controls.Add(cbxNomesClientes);
            panelAdicionarRemoverCliente.Controls.Add(btnRemoverCliente);
            panelAdicionarRemoverCliente.Controls.Add(btnAdicionarCliente);
            panelAdicionarRemoverCliente.Controls.Add(txtAdicionarCliente);
            panelAdicionarRemoverCliente.Controls.Add(lblAdicionarCliente);
            panelAdicionarRemoverCliente.Location = new Point(470, 59);
            panelAdicionarRemoverCliente.Margin = new Padding(3, 4, 3, 4);
            panelAdicionarRemoverCliente.Name = "panelAdicionarRemoverCliente";
            panelAdicionarRemoverCliente.Size = new Size(447, 313);
            panelAdicionarRemoverCliente.TabIndex = 19;
            // 
            // lblRemoverCliente
            // 
            lblRemoverCliente.AutoSize = true;
            lblRemoverCliente.Font = new Font("Segoe UI", 14F);
            lblRemoverCliente.Location = new Point(15, 168);
            lblRemoverCliente.Name = "lblRemoverCliente";
            lblRemoverCliente.Size = new Size(190, 32);
            lblRemoverCliente.TabIndex = 28;
            lblRemoverCliente.Text = "Remover Cliente";
            // 
            // cbxNomesClientes
            // 
            cbxNomesClientes.Font = new Font("Segoe UI", 12F);
            cbxNomesClientes.FormattingEnabled = true;
            cbxNomesClientes.Location = new Point(15, 203);
            cbxNomesClientes.Name = "cbxNomesClientes";
            cbxNomesClientes.Size = new Size(418, 36);
            cbxNomesClientes.TabIndex = 27;
            // 
            // btnRemoverCliente
            // 
            btnRemoverCliente.Font = new Font("Segoe UI", 12F);
            btnRemoverCliente.Location = new Point(15, 248);
            btnRemoverCliente.Margin = new Padding(3, 4, 3, 4);
            btnRemoverCliente.Name = "btnRemoverCliente";
            btnRemoverCliente.Size = new Size(418, 45);
            btnRemoverCliente.TabIndex = 23;
            btnRemoverCliente.Text = "Remover";
            btnRemoverCliente.UseVisualStyleBackColor = true;
            btnRemoverCliente.Click += btnRemoverCliente_Click;
            // 
            // btnAdicionarCliente
            // 
            btnAdicionarCliente.Font = new Font("Segoe UI", 12F);
            btnAdicionarCliente.Location = new Point(14, 101);
            btnAdicionarCliente.Margin = new Padding(3, 4, 3, 4);
            btnAdicionarCliente.Name = "btnAdicionarCliente";
            btnAdicionarCliente.Size = new Size(418, 45);
            btnAdicionarCliente.TabIndex = 22;
            btnAdicionarCliente.Text = "Adicionar";
            btnAdicionarCliente.UseVisualStyleBackColor = true;
            btnAdicionarCliente.Click += btnAdicionarCliente_Click;
            // 
            // txtAdicionarCliente
            // 
            txtAdicionarCliente.BorderStyle = BorderStyle.FixedSingle;
            txtAdicionarCliente.Font = new Font("Segoe UI", 12F);
            txtAdicionarCliente.Location = new Point(14, 55);
            txtAdicionarCliente.Margin = new Padding(3, 4, 3, 4);
            txtAdicionarCliente.Name = "txtAdicionarCliente";
            txtAdicionarCliente.PlaceholderText = " Nome do cliente...";
            txtAdicionarCliente.Size = new Size(418, 34);
            txtAdicionarCliente.TabIndex = 20;
            // 
            // lblAdicionarCliente
            // 
            lblAdicionarCliente.AutoSize = true;
            lblAdicionarCliente.Font = new Font("Segoe UI", 14F);
            lblAdicionarCliente.Location = new Point(13, 19);
            lblAdicionarCliente.Name = "lblAdicionarCliente";
            lblAdicionarCliente.Size = new Size(196, 32);
            lblAdicionarCliente.TabIndex = 19;
            lblAdicionarCliente.Text = "Adicionar Cliente";
            // 
            // panelAdicionarRemoverFuncionario
            // 
            panelAdicionarRemoverFuncionario.BorderStyle = BorderStyle.FixedSingle;
            panelAdicionarRemoverFuncionario.Controls.Add(lblRemoverFuncionario);
            panelAdicionarRemoverFuncionario.Controls.Add(cbxNomesFuncionarios);
            panelAdicionarRemoverFuncionario.Controls.Add(btnRemoverFuncionario);
            panelAdicionarRemoverFuncionario.Controls.Add(btnAdicionarFuncionario);
            panelAdicionarRemoverFuncionario.Controls.Add(txtAdicionarFuncionario);
            panelAdicionarRemoverFuncionario.Controls.Add(lblAdicionarFuncionario);
            panelAdicionarRemoverFuncionario.Location = new Point(16, 59);
            panelAdicionarRemoverFuncionario.Margin = new Padding(3, 4, 3, 4);
            panelAdicionarRemoverFuncionario.Name = "panelAdicionarRemoverFuncionario";
            panelAdicionarRemoverFuncionario.Size = new Size(447, 313);
            panelAdicionarRemoverFuncionario.TabIndex = 18;
            // 
            // lblRemoverFuncionario
            // 
            lblRemoverFuncionario.AutoSize = true;
            lblRemoverFuncionario.Font = new Font("Segoe UI", 14F);
            lblRemoverFuncionario.Location = new Point(13, 168);
            lblRemoverFuncionario.Name = "lblRemoverFuncionario";
            lblRemoverFuncionario.Size = new Size(240, 32);
            lblRemoverFuncionario.TabIndex = 28;
            lblRemoverFuncionario.Text = "Remover Funcionario";
            // 
            // cbxNomesFuncionarios
            // 
            cbxNomesFuncionarios.Font = new Font("Segoe UI", 12F);
            cbxNomesFuncionarios.FormattingEnabled = true;
            cbxNomesFuncionarios.Location = new Point(13, 203);
            cbxNomesFuncionarios.Name = "cbxNomesFuncionarios";
            cbxNomesFuncionarios.Size = new Size(418, 36);
            cbxNomesFuncionarios.TabIndex = 27;
            // 
            // btnRemoverFuncionario
            // 
            btnRemoverFuncionario.Font = new Font("Segoe UI", 12F);
            btnRemoverFuncionario.Location = new Point(13, 248);
            btnRemoverFuncionario.Margin = new Padding(3, 4, 3, 4);
            btnRemoverFuncionario.Name = "btnRemoverFuncionario";
            btnRemoverFuncionario.Size = new Size(418, 45);
            btnRemoverFuncionario.TabIndex = 23;
            btnRemoverFuncionario.Text = "Remover Funcionário";
            btnRemoverFuncionario.UseVisualStyleBackColor = true;
            btnRemoverFuncionario.Click += btnRemoverFuncionario_Click;
            // 
            // btnAdicionarFuncionario
            // 
            btnAdicionarFuncionario.Font = new Font("Segoe UI", 12F);
            btnAdicionarFuncionario.Location = new Point(11, 101);
            btnAdicionarFuncionario.Margin = new Padding(3, 4, 3, 4);
            btnAdicionarFuncionario.Name = "btnAdicionarFuncionario";
            btnAdicionarFuncionario.Size = new Size(420, 45);
            btnAdicionarFuncionario.TabIndex = 22;
            btnAdicionarFuncionario.Text = "Adicionar";
            btnAdicionarFuncionario.UseVisualStyleBackColor = true;
            btnAdicionarFuncionario.Click += btnAdicionarFuncionario_Click;
            // 
            // txtAdicionarFuncionario
            // 
            txtAdicionarFuncionario.BorderStyle = BorderStyle.FixedSingle;
            txtAdicionarFuncionario.Font = new Font("Segoe UI", 12F);
            txtAdicionarFuncionario.Location = new Point(13, 55);
            txtAdicionarFuncionario.Margin = new Padding(3, 4, 3, 4);
            txtAdicionarFuncionario.Name = "txtAdicionarFuncionario";
            txtAdicionarFuncionario.PlaceholderText = " Nome do funcionário...";
            txtAdicionarFuncionario.Size = new Size(418, 34);
            txtAdicionarFuncionario.TabIndex = 20;
            // 
            // lblAdicionarFuncionario
            // 
            lblAdicionarFuncionario.AutoSize = true;
            lblAdicionarFuncionario.Font = new Font("Segoe UI", 14F);
            lblAdicionarFuncionario.Location = new Point(13, 19);
            lblAdicionarFuncionario.Name = "lblAdicionarFuncionario";
            lblAdicionarFuncionario.Size = new Size(246, 32);
            lblAdicionarFuncionario.TabIndex = 19;
            lblAdicionarFuncionario.Text = "Adicionar Funcionario";
            // 
            // panelBackup
            // 
            panelBackup.BorderStyle = BorderStyle.FixedSingle;
            panelBackup.Controls.Add(btnFazerBackUp);
            panelBackup.Controls.Add(lblBackup);
            panelBackup.Controls.Add(label4);
            panelBackup.Controls.Add(txtBackup);
            panelBackup.Location = new Point(16, 381);
            panelBackup.Margin = new Padding(3, 4, 3, 4);
            panelBackup.Name = "panelBackup";
            panelBackup.Size = new Size(687, 198);
            panelBackup.TabIndex = 17;
            // 
            // btnFazerBackUp
            // 
            btnFazerBackUp.Font = new Font("Segoe UI", 12F);
            btnFazerBackUp.Location = new Point(138, 139);
            btnFazerBackUp.Name = "btnFazerBackUp";
            btnFazerBackUp.Size = new Size(418, 45);
            btnFazerBackUp.TabIndex = 15;
            btnFazerBackUp.Text = "Fazer backup";
            btnFazerBackUp.UseVisualStyleBackColor = true;
            btnFazerBackUp.Click += btnFazerBackUp_Click;
            // 
            // lblBackup
            // 
            lblBackup.AutoSize = true;
            lblBackup.Font = new Font("Segoe UI", 14F);
            lblBackup.Location = new Point(138, 17);
            lblBackup.Name = "lblBackup";
            lblBackup.Size = new Size(91, 32);
            lblBackup.TabIndex = 18;
            lblBackup.Text = "Backup";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F);
            label4.Location = new Point(140, 63);
            label4.Name = "label4";
            label4.Size = new Size(94, 19);
            label4.TabIndex = 13;
            label4.Text = "Nome backup";
            // 
            // txtBackup
            // 
            txtBackup.BorderStyle = BorderStyle.FixedSingle;
            txtBackup.Font = new Font("Segoe UI", 12F);
            txtBackup.Location = new Point(138, 83);
            txtBackup.Name = "txtBackup";
            txtBackup.Size = new Size(418, 34);
            txtBackup.TabIndex = 14;
            txtBackup.Text = "padrao";
            // 
            // lblAdministracao
            // 
            lblAdministracao.AutoSize = true;
            lblAdministracao.Font = new Font("Segoe UI", 14F);
            lblAdministracao.Location = new Point(608, 13);
            lblAdministracao.Name = "lblAdministracao";
            lblAdministracao.Size = new Size(165, 32);
            lblAdministracao.TabIndex = 16;
            lblAdministracao.Text = "Administração";
            // 
            // panelVisualizarProcessos
            // 
            panelVisualizarProcessos.BorderStyle = BorderStyle.FixedSingle;
            panelVisualizarProcessos.Controls.Add(lblVisualizacao);
            panelVisualizarProcessos.Controls.Add(dgvProcessos);
            panelVisualizarProcessos.Controls.Add(btnListar);
            panelVisualizarProcessos.Controls.Add(txtTotalHoras);
            panelVisualizarProcessos.Controls.Add(label5);
            panelVisualizarProcessos.Controls.Add(cbxFiltro);
            panelVisualizarProcessos.Controls.Add(lblAgruparPor);
            panelVisualizarProcessos.Controls.Add(rbtNaoAgrupar);
            panelVisualizarProcessos.Controls.Add(rbtFuncionario);
            panelVisualizarProcessos.Controls.Add(rbtCliente);
            panelVisualizarProcessos.Location = new Point(495, 37);
            panelVisualizarProcessos.Name = "panelVisualizarProcessos";
            panelVisualizarProcessos.Size = new Size(973, 534);
            panelVisualizarProcessos.TabIndex = 25;
            // 
            // lblVisualizacao
            // 
            lblVisualizacao.AutoSize = true;
            lblVisualizacao.Font = new Font("Segoe UI", 14F);
            lblVisualizacao.Location = new Point(373, 8);
            lblVisualizacao.Name = "lblVisualizacao";
            lblVisualizacao.Size = new Size(225, 32);
            lblVisualizacao.TabIndex = 10;
            lblVisualizacao.Text = "Visualizar processos";
            // 
            // dgvProcessos
            // 
            dgvProcessos.AllowUserToAddRows = false;
            dgvProcessos.AllowUserToDeleteRows = false;
            dgvProcessos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProcessos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcessos.Location = new Point(21, 55);
            dgvProcessos.Name = "dgvProcessos";
            dgvProcessos.RowHeadersVisible = false;
            dgvProcessos.RowHeadersWidth = 51;
            dgvProcessos.Size = new Size(929, 352);
            dgvProcessos.TabIndex = 9;
            // 
            // btnListar
            // 
            btnListar.Font = new Font("Segoe UI", 14F);
            btnListar.Location = new Point(21, 469);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(929, 47);
            btnListar.TabIndex = 15;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // txtTotalHoras
            // 
            txtTotalHoras.BorderStyle = BorderStyle.FixedSingle;
            txtTotalHoras.Font = new Font("Segoe UI", 12F);
            txtTotalHoras.Location = new Point(741, 424);
            txtTotalHoras.Name = "txtTotalHoras";
            txtTotalHoras.ReadOnly = true;
            txtTotalHoras.Size = new Size(208, 34);
            txtTotalHoras.TabIndex = 20;
            txtTotalHoras.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(681, 428);
            label5.Name = "label5";
            label5.Size = new Size(54, 28);
            label5.TabIndex = 21;
            label5.Text = "Total";
            // 
            // cbxFiltro
            // 
            cbxFiltro.Enabled = false;
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.Location = new Point(465, 429);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(195, 28);
            cbxFiltro.TabIndex = 22;
            cbxFiltro.Text = "ID Funcionario / Cliente";
            // 
            // lblAgruparPor
            // 
            lblAgruparPor.AutoSize = true;
            lblAgruparPor.Font = new Font("Segoe UI", 12F);
            lblAgruparPor.Location = new Point(21, 427);
            lblAgruparPor.Name = "lblAgruparPor";
            lblAgruparPor.Size = new Size(124, 28);
            lblAgruparPor.TabIndex = 13;
            lblAgruparPor.Text = "Agrupar por:";
            // 
            // rbtNaoAgrupar
            // 
            rbtNaoAgrupar.AutoSize = true;
            rbtNaoAgrupar.Checked = true;
            rbtNaoAgrupar.Location = new Point(150, 432);
            rbtNaoAgrupar.Name = "rbtNaoAgrupar";
            rbtNaoAgrupar.Size = new Size(114, 24);
            rbtNaoAgrupar.TabIndex = 19;
            rbtNaoAgrupar.TabStop = true;
            rbtNaoAgrupar.Text = "Não agrupar";
            rbtNaoAgrupar.UseVisualStyleBackColor = true;
            rbtNaoAgrupar.CheckedChanged += rbtNaoFiltrar_CheckedChanged;
            // 
            // rbtFuncionario
            // 
            rbtFuncionario.AutoSize = true;
            rbtFuncionario.Location = new Point(270, 432);
            rbtFuncionario.Name = "rbtFuncionario";
            rbtFuncionario.Size = new Size(107, 24);
            rbtFuncionario.TabIndex = 11;
            rbtFuncionario.Text = "Funcionario";
            rbtFuncionario.UseVisualStyleBackColor = true;
            rbtFuncionario.CheckedChanged += rbtFuncionario_CheckedChanged;
            // 
            // rbtCliente
            // 
            rbtCliente.AutoSize = true;
            rbtCliente.Location = new Point(383, 432);
            rbtCliente.Name = "rbtCliente";
            rbtCliente.Size = new Size(76, 24);
            rbtCliente.TabIndex = 12;
            rbtCliente.Text = "Cliente";
            rbtCliente.UseVisualStyleBackColor = true;
            rbtCliente.CheckedChanged += rbtCliente_CheckedChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnVisualizarProcessos
            // 
            btnVisualizarProcessos.FlatAppearance.BorderSize = 0;
            btnVisualizarProcessos.FlatStyle = FlatStyle.Flat;
            btnVisualizarProcessos.Location = new Point(11, 0);
            btnVisualizarProcessos.Name = "btnVisualizarProcessos";
            btnVisualizarProcessos.Size = new Size(152, 35);
            btnVisualizarProcessos.TabIndex = 23;
            btnVisualizarProcessos.Text = "Visualizar Processos";
            btnVisualizarProcessos.UseVisualStyleBackColor = true;
            btnVisualizarProcessos.Click += btnVisualizarProcessos_Click;
            // 
            // btnRegistrarNovoProcesso
            // 
            btnRegistrarNovoProcesso.FlatAppearance.BorderSize = 0;
            btnRegistrarNovoProcesso.FlatStyle = FlatStyle.Flat;
            btnRegistrarNovoProcesso.Location = new Point(170, 0);
            btnRegistrarNovoProcesso.Name = "btnRegistrarNovoProcesso";
            btnRegistrarNovoProcesso.Size = new Size(190, 35);
            btnRegistrarNovoProcesso.TabIndex = 24;
            btnRegistrarNovoProcesso.Text = "Registrar Novo Processo";
            btnRegistrarNovoProcesso.UseVisualStyleBackColor = true;
            btnRegistrarNovoProcesso.Click += btnRegistrarNovoProcesso_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Location = new Point(355, 0);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(130, 35);
            btnAdmin.TabIndex = 26;
            btnAdmin.Text = "Administrador";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1474, 1201);
            Controls.Add(panelAdministracao);
            Controls.Add(panelRegistrarProcesso);
            Controls.Add(btnAdmin);
            Controls.Add(btnRegistrarNovoProcesso);
            Controls.Add(btnVisualizarProcessos);
            Controls.Add(panelVisualizarProcessos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tempos";
            Load += Form1_Load;
            panelRegistrarProcesso.ResumeLayout(false);
            panelRegistrarProcesso.PerformLayout();
            panelAdministracao.ResumeLayout(false);
            panelAdministracao.PerformLayout();
            panelAdicionarRemoverCategoria.ResumeLayout(false);
            panelAdicionarRemoverCategoria.PerformLayout();
            panelAdicionarRemoverCliente.ResumeLayout(false);
            panelAdicionarRemoverCliente.PerformLayout();
            panelAdicionarRemoverFuncionario.ResumeLayout(false);
            panelAdicionarRemoverFuncionario.PerformLayout();
            panelBackup.ResumeLayout(false);
            panelBackup.PerformLayout();
            panelVisualizarProcessos.ResumeLayout(false);
            panelVisualizarProcessos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProcessos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblRegisto;
        private TextBox txtDescricao;
        private AutoCompleteTextBox txtAutoFuncionario;
        private AutoCompleteTextBox txtAutoCliente;
        private ComboBox cbxCategoria;
        private TextBox txtTempoGasto;
        private Button btnEnviar;
        private Panel panelRegistrarProcesso;
        private DataGridView dgvProcessos;
        private Label lblVisualizacao;
        private RadioButton rbtFuncionario;
        private RadioButton rbtCliente;
        private Label lblAgruparPor;
        private Button btnListar;
        private DateTimePicker dtpDataProcesso;
        private Label label2;
        private Label label3;
        private RadioButton rbtNaoAgrupar;
        private ContextMenuStrip contextMenuStrip1;
        private Label label4;
        private TextBox txtBackup;
        private Button btnFazerBackUp;
        private Panel panelAdministracao;
        private TextBox txtTotalHoras;
        private Label label5;
        private ComboBox cbxFiltro;
        private Button btnVisualizarProcessos;
        private Button btnRegistrarNovoProcesso;
        private Panel panelVisualizarProcessos;
        private Button btnAdmin;
        private Label lblAdministracao;
        private Panel panelAdicionarRemoverFuncionario;
        private Panel panelBackup;
        private Label lblBackup;
        private Button btnRemoverFuncionario;
        private Button btnAdicionarFuncionario;
        private TextBox txtAdicionarFuncionario;
        private Label lblAdicionarFuncionario;
        private ComboBox cbxNomesFuncionarios;
        private Panel panelAdicionarRemoverCliente;
        private ComboBox cbxNomesClientes;
        private Button btnRemoverCliente;
        private Button btnAdicionarCliente;
        private TextBox txtAdicionarCliente;
        private Label lblAdicionarCliente;
        private Label lblRemoverCliente;
        private Label lblRemoverFuncionario;
        private Panel panelAdicionarRemoverCategoria;
        private Label lblRemoverCategoria;
        private ComboBox cbxNomesCategorias;
        private Button btnRemoverCategoria;
        private Button btnAdicionarCategoria;
        private TextBox txtAdicionarCategoria;
        private Label lblAdicionarCategoria;
        private Panel panel1;
    }
}
