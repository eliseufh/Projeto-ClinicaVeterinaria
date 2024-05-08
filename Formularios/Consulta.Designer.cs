namespace clinicaVeterinaria.Formularios
{
    partial class Consulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_ID = new Label();
            btn_VoltarRemover = new Button();
            btn_confirmar = new Button();
            txt_ID = new TextBox();
            btn_ID = new Button();
            btn_AlterarRegisto = new Button();
            btn_RemoverConsulta = new Button();
            btn_Adicionar = new Button();
            dgvConsulta = new DataGridView();
            label1 = new Label();
            btn_Informacao = new Button();
            btn_voltarMenu = new Button();
            btn_ConfirmarAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.BackColor = SystemColors.Control;
            lbl_ID.Font = new Font("Segoe UI", 12F);
            lbl_ID.Location = new Point(716, 157);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(80, 21);
            lbl_ID.TabIndex = 21;
            lbl_ID.Text = "Insira o ID";
            lbl_ID.Visible = false;
            // 
            // btn_VoltarRemover
            // 
            btn_VoltarRemover.Font = new Font("Segoe UI", 14F);
            btn_VoltarRemover.Location = new Point(685, 344);
            btn_VoltarRemover.Name = "btn_VoltarRemover";
            btn_VoltarRemover.Size = new Size(146, 74);
            btn_VoltarRemover.TabIndex = 20;
            btn_VoltarRemover.Text = "Voltar";
            btn_VoltarRemover.UseVisualStyleBackColor = true;
            btn_VoltarRemover.Visible = false;
            btn_VoltarRemover.Click += btn_VoltarRemover_Click;
            // 
            // btn_confirmar
            // 
            btn_confirmar.Font = new Font("Segoe UI", 14F);
            btn_confirmar.Location = new Point(685, 244);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(146, 74);
            btn_confirmar.TabIndex = 19;
            btn_confirmar.Text = "Confirmar";
            btn_confirmar.UseVisualStyleBackColor = true;
            btn_confirmar.Visible = false;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(685, 192);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(146, 23);
            txt_ID.TabIndex = 18;
            txt_ID.Visible = false;
            // 
            // btn_ID
            // 
            btn_ID.Font = new Font("Segoe UI", 12F);
            btn_ID.Location = new Point(685, 141);
            btn_ID.Name = "btn_ID";
            btn_ID.Size = new Size(146, 53);
            btn_ID.TabIndex = 17;
            btn_ID.UseVisualStyleBackColor = true;
            btn_ID.Visible = false;
            // 
            // btn_AlterarRegisto
            // 
            btn_AlterarRegisto.Font = new Font("Segoe UI", 14F);
            btn_AlterarRegisto.Location = new Point(685, 244);
            btn_AlterarRegisto.Name = "btn_AlterarRegisto";
            btn_AlterarRegisto.Size = new Size(146, 74);
            btn_AlterarRegisto.TabIndex = 15;
            btn_AlterarRegisto.Text = "Alterar Registo";
            btn_AlterarRegisto.UseVisualStyleBackColor = true;
            btn_AlterarRegisto.Click += btn_AlterarRegisto_Click;
            // 
            // btn_RemoverConsulta
            // 
            btn_RemoverConsulta.Font = new Font("Segoe UI", 14F);
            btn_RemoverConsulta.Location = new Point(685, 141);
            btn_RemoverConsulta.Name = "btn_RemoverConsulta";
            btn_RemoverConsulta.Size = new Size(146, 74);
            btn_RemoverConsulta.TabIndex = 14;
            btn_RemoverConsulta.Text = "Remover Consulta";
            btn_RemoverConsulta.UseVisualStyleBackColor = true;
            btn_RemoverConsulta.Click += btn_RemoverConsulta_Click;
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.Font = new Font("Segoe UI", 14F);
            btn_Adicionar.Location = new Point(685, 37);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(146, 74);
            btn_Adicionar.TabIndex = 13;
            btn_Adicionar.Text = "Adicionar Consulta";
            btn_Adicionar.UseVisualStyleBackColor = true;
            btn_Adicionar.Click += btn_Adicionar_Click;
            // 
            // dgvConsulta
            // 
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Location = new Point(12, 37);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.Size = new Size(667, 441);
            dgvConsulta.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 11;
            label1.Text = "Consultas:";
            // 
            // btn_Informacao
            // 
            btn_Informacao.Font = new Font("Segoe UI", 14F);
            btn_Informacao.Location = new Point(685, 37);
            btn_Informacao.Name = "btn_Informacao";
            btn_Informacao.Size = new Size(146, 74);
            btn_Informacao.TabIndex = 22;
            btn_Informacao.Text = "Remover Consulta";
            btn_Informacao.UseVisualStyleBackColor = true;
            btn_Informacao.Visible = false;
            // 
            // btn_voltarMenu
            // 
            btn_voltarMenu.Font = new Font("Segoe UI", 14F);
            btn_voltarMenu.Location = new Point(685, 344);
            btn_voltarMenu.Name = "btn_voltarMenu";
            btn_voltarMenu.Size = new Size(146, 74);
            btn_voltarMenu.TabIndex = 23;
            btn_voltarMenu.Text = "Voltar";
            btn_voltarMenu.UseVisualStyleBackColor = true;
            btn_voltarMenu.Click += button1_Click;
            // 
            // btn_ConfirmarAtualizar
            // 
            btn_ConfirmarAtualizar.Font = new Font("Segoe UI", 14F);
            btn_ConfirmarAtualizar.Location = new Point(685, 244);
            btn_ConfirmarAtualizar.Name = "btn_ConfirmarAtualizar";
            btn_ConfirmarAtualizar.Size = new Size(146, 74);
            btn_ConfirmarAtualizar.TabIndex = 24;
            btn_ConfirmarAtualizar.Text = "Confirmar";
            btn_ConfirmarAtualizar.UseVisualStyleBackColor = true;
            btn_ConfirmarAtualizar.Visible = false;
            btn_ConfirmarAtualizar.Click += btn_ConfirmarAtualizar_Click;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(852, 491);
            Controls.Add(btn_ConfirmarAtualizar);
            Controls.Add(btn_voltarMenu);
            Controls.Add(btn_Informacao);
            Controls.Add(lbl_ID);
            Controls.Add(btn_VoltarRemover);
            Controls.Add(btn_confirmar);
            Controls.Add(txt_ID);
            Controls.Add(btn_ID);
            Controls.Add(btn_AlterarRegisto);
            Controls.Add(btn_RemoverConsulta);
            Controls.Add(btn_Adicionar);
            Controls.Add(dgvConsulta);
            Controls.Add(label1);
            Name = "Consulta";
            Text = "Consulta";
            Load += Consulta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ID;
        private Button btn_VoltarRemover;
        private Button btn_confirmar;
        private TextBox txt_ID;
        private Button btn_ID;
        private Button btn_AlterarRegisto;
        private Button btn_RemoverConsulta;
        private Button btn_Adicionar;
        private DataGridView dgvConsulta;
        private Label label1;
        private Button btn_Informacao;
        private Button btn_voltarMenu;
        private Button btn_ConfirmarAtualizar;
    }
}