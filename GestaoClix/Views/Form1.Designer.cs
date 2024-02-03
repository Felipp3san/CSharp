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
            btnAddCliente = new Button();
            txtAddNome = new TextBox();
            txtAddNif = new TextBox();
            txtAddSituacao = new TextBox();
            dgvGestaoListar = new DataGridView();
            btnGestaoListar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGestaoListar).BeginInit();
            SuspendLayout();
            // 
            // btnAddCliente
            // 
            btnAddCliente.Location = new Point(79, 178);
            btnAddCliente.Name = "btnAddCliente";
            btnAddCliente.Size = new Size(276, 29);
            btnAddCliente.TabIndex = 0;
            btnAddCliente.Text = "INSERT";
            btnAddCliente.UseVisualStyleBackColor = true;
            btnAddCliente.Click += btnAddCliente_Click;
            // 
            // txtAddNome
            // 
            txtAddNome.Location = new Point(79, 32);
            txtAddNome.Name = "txtAddNome";
            txtAddNome.PlaceholderText = "Nome...";
            txtAddNome.Size = new Size(276, 27);
            txtAddNome.TabIndex = 1;
            // 
            // txtAddNif
            // 
            txtAddNif.Location = new Point(79, 65);
            txtAddNif.Name = "txtAddNif";
            txtAddNif.PlaceholderText = "Nif...";
            txtAddNif.Size = new Size(276, 27);
            txtAddNif.TabIndex = 2;
            // 
            // txtAddSituacao
            // 
            txtAddSituacao.Location = new Point(79, 98);
            txtAddSituacao.Name = "txtAddSituacao";
            txtAddSituacao.PlaceholderText = "Situacao...";
            txtAddSituacao.Size = new Size(276, 27);
            txtAddSituacao.TabIndex = 3;
            // 
            // dgvGestaoListar
            // 
            dgvGestaoListar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestaoListar.Location = new Point(373, 32);
            dgvGestaoListar.Name = "dgvGestaoListar";
            dgvGestaoListar.RowHeadersWidth = 51;
            dgvGestaoListar.Size = new Size(636, 391);
            dgvGestaoListar.TabIndex = 4;
            // 
            // btnGestaoListar
            // 
            btnGestaoListar.Location = new Point(79, 394);
            btnGestaoListar.Name = "btnGestaoListar";
            btnGestaoListar.Size = new Size(288, 29);
            btnGestaoListar.TabIndex = 5;
            btnGestaoListar.Text = "LISTAR";
            btnGestaoListar.UseVisualStyleBackColor = true;
            btnGestaoListar.Click += btnGestaoListar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 450);
            Controls.Add(btnGestaoListar);
            Controls.Add(dgvGestaoListar);
            Controls.Add(txtAddSituacao);
            Controls.Add(txtAddNif);
            Controls.Add(txtAddNome);
            Controls.Add(btnAddCliente);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGestaoListar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddCliente;
        private TextBox txtAddNome;
        private TextBox txtAddNif;
        private TextBox txtAddSituacao;
        private DataGridView dgvGestaoListar;
        private Button btnGestaoListar;
    }
}
