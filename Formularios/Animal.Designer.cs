namespace clinicaVeterinaria.Formularios
{
    partial class Animal
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
            dgvAnimais = new DataGridView();
            btn_VoltarRemover = new Button();
            label2 = new Label();
            btn_Confirmar = new Button();
            btn_RemoverAnimal = new Button();
            txt_ID = new TextBox();
            btn_Adicionar = new Button();
            btn_ID = new Button();
            btn_removeranimal1 = new Button();
            btn_AlterarRegisto = new Button();
            btn_ConfirmarAtualizar = new Button();
            btn_VoltarMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAnimais).BeginInit();
            SuspendLayout();
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Segoe UI", 12F);
            lbl_ID.Location = new Point(716, 157);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(80, 21);
            lbl_ID.TabIndex = 30;
            lbl_ID.Text = "Insira o ID";
            lbl_ID.Visible = false;
            // 
            // dgvAnimais
            // 
            dgvAnimais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimais.Location = new Point(12, 37);
            dgvAnimais.Name = "dgvAnimais";
            dgvAnimais.Size = new Size(667, 441);
            dgvAnimais.TabIndex = 21;
            // 
            // btn_VoltarRemover
            // 
            btn_VoltarRemover.Font = new Font("Segoe UI", 14F);
            btn_VoltarRemover.Location = new Point(685, 340);
            btn_VoltarRemover.Name = "btn_VoltarRemover";
            btn_VoltarRemover.Size = new Size(146, 74);
            btn_VoltarRemover.TabIndex = 29;
            btn_VoltarRemover.Text = "Voltar";
            btn_VoltarRemover.UseVisualStyleBackColor = true;
            btn_VoltarRemover.Visible = false;
            btn_VoltarRemover.Click += btn_VoltarRemover_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 20;
            label2.Text = "Animais:";
            // 
            // btn_Confirmar
            // 
            btn_Confirmar.Font = new Font("Segoe UI", 14F);
            btn_Confirmar.Location = new Point(685, 244);
            btn_Confirmar.Name = "btn_Confirmar";
            btn_Confirmar.Size = new Size(146, 74);
            btn_Confirmar.TabIndex = 28;
            btn_Confirmar.Text = "Confirmar";
            btn_Confirmar.UseVisualStyleBackColor = true;
            btn_Confirmar.Visible = false;
            btn_Confirmar.Click += btn_Confirmar_Click;
            // 
            // btn_RemoverAnimal
            // 
            btn_RemoverAnimal.Enabled = false;
            btn_RemoverAnimal.Font = new Font("Segoe UI", 14F);
            btn_RemoverAnimal.Location = new Point(685, 37);
            btn_RemoverAnimal.Name = "btn_RemoverAnimal";
            btn_RemoverAnimal.Size = new Size(146, 74);
            btn_RemoverAnimal.TabIndex = 25;
            btn_RemoverAnimal.Text = "Remover Animal";
            btn_RemoverAnimal.UseVisualStyleBackColor = true;
            btn_RemoverAnimal.Visible = false;
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(685, 192);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(146, 23);
            txt_ID.TabIndex = 27;
            txt_ID.Visible = false;
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.Font = new Font("Segoe UI", 14F);
            btn_Adicionar.Location = new Point(685, 37);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(146, 74);
            btn_Adicionar.TabIndex = 22;
            btn_Adicionar.Text = "Adicionar Animal";
            btn_Adicionar.UseVisualStyleBackColor = true;
            btn_Adicionar.Click += btn_Adicionar_animal_Click;
            // 
            // btn_ID
            // 
            btn_ID.Font = new Font("Segoe UI", 12F);
            btn_ID.Location = new Point(685, 141);
            btn_ID.Name = "btn_ID";
            btn_ID.Size = new Size(146, 53);
            btn_ID.TabIndex = 26;
            btn_ID.UseVisualStyleBackColor = true;
            btn_ID.Visible = false;
            // 
            // btn_removeranimal1
            // 
            btn_removeranimal1.Font = new Font("Segoe UI", 14F);
            btn_removeranimal1.Location = new Point(685, 141);
            btn_removeranimal1.Name = "btn_removeranimal1";
            btn_removeranimal1.Size = new Size(146, 74);
            btn_removeranimal1.TabIndex = 23;
            btn_removeranimal1.Text = "Remover Animal";
            btn_removeranimal1.UseVisualStyleBackColor = true;
            btn_removeranimal1.Click += btn_removeranimal1_Click;
            // 
            // btn_AlterarRegisto
            // 
            btn_AlterarRegisto.Font = new Font("Segoe UI", 14F);
            btn_AlterarRegisto.Location = new Point(685, 244);
            btn_AlterarRegisto.Name = "btn_AlterarRegisto";
            btn_AlterarRegisto.Size = new Size(146, 74);
            btn_AlterarRegisto.TabIndex = 24;
            btn_AlterarRegisto.Text = "Alterar Registo";
            btn_AlterarRegisto.UseVisualStyleBackColor = true;
            btn_AlterarRegisto.Click += btn_AlterarRegisto_Click_1;
            // 
            // btn_ConfirmarAtualizar
            // 
            btn_ConfirmarAtualizar.Font = new Font("Segoe UI", 14F);
            btn_ConfirmarAtualizar.Location = new Point(685, 244);
            btn_ConfirmarAtualizar.Name = "btn_ConfirmarAtualizar";
            btn_ConfirmarAtualizar.Size = new Size(146, 74);
            btn_ConfirmarAtualizar.TabIndex = 31;
            btn_ConfirmarAtualizar.Text = "Confirmar";
            btn_ConfirmarAtualizar.UseVisualStyleBackColor = true;
            btn_ConfirmarAtualizar.Visible = false;
            btn_ConfirmarAtualizar.Click += btn_ConfirmarAtualizar_Click;
            // 
            // btn_VoltarMenu
            // 
            btn_VoltarMenu.Font = new Font("Segoe UI", 14F);
            btn_VoltarMenu.Location = new Point(685, 340);
            btn_VoltarMenu.Name = "btn_VoltarMenu";
            btn_VoltarMenu.Size = new Size(146, 74);
            btn_VoltarMenu.TabIndex = 32;
            btn_VoltarMenu.Text = "Voltar";
            btn_VoltarMenu.UseVisualStyleBackColor = true;
            btn_VoltarMenu.Click += btn_VoltarMenu_Click;
            // 
            // Animal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(838, 493);
            Controls.Add(btn_VoltarMenu);
            Controls.Add(btn_ConfirmarAtualizar);
            Controls.Add(lbl_ID);
            Controls.Add(dgvAnimais);
            Controls.Add(btn_VoltarRemover);
            Controls.Add(label2);
            Controls.Add(btn_Confirmar);
            Controls.Add(btn_RemoverAnimal);
            Controls.Add(txt_ID);
            Controls.Add(btn_Adicionar);
            Controls.Add(btn_ID);
            Controls.Add(btn_removeranimal1);
            Controls.Add(btn_AlterarRegisto);
            Name = "Animal";
            Text = "Animal";
            Load += Animal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ID;
        private DataGridView dgvAnimais;
        private Button btn_VoltarRemover;
        private Label label2;
        private Button btn_Confirmar;
        private Button btn_RemoverAnimal;
        private TextBox txt_ID;
        private Button btn_Adicionar;
        private Button btn_ID;
        private Button btn_removeranimal1;
        private Button btn_AlterarRegisto;
        private Button btn_ConfirmarAtualizar;
        private Button btn_VoltarMenu;
    }
}