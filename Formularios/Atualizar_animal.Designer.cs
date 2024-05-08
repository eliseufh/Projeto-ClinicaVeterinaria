namespace clinicaVeterinaria.Formularios
{
    partial class Atualizar_animal
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
            panel1 = new Panel();
            lbl_ID = new Label();
            cb_sexoAnimal = new ComboBox();
            cb_tipoAnimal = new ComboBox();
            btn_Voltar = new Button();
            btn_confirmAlteracao = new Button();
            txt_pesoAnimal = new TextBox();
            label9 = new Label();
            txt_racaAnimal = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            dtp_UltimaConsulta = new DateTimePicker();
            label5 = new Label();
            txt_Contacto = new TextBox();
            label4 = new Label();
            dtp_nascimentoAnimal = new DateTimePicker();
            label3 = new Label();
            txt_nomeDono = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(lbl_ID);
            panel1.Controls.Add(cb_sexoAnimal);
            panel1.Controls.Add(cb_tipoAnimal);
            panel1.Controls.Add(btn_Voltar);
            panel1.Controls.Add(btn_confirmAlteracao);
            panel1.Controls.Add(txt_pesoAnimal);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txt_racaAnimal);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dtp_UltimaConsulta);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_Contacto);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtp_nascimentoAnimal);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_nomeDono);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 349);
            panel1.TabIndex = 2;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Segoe UI", 12F);
            lbl_ID.Location = new Point(554, 8);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(25, 21);
            lbl_ID.TabIndex = 46;
            lbl_ID.Text = "ID";
            // 
            // cb_sexoAnimal
            // 
            cb_sexoAnimal.FormattingEnabled = true;
            cb_sexoAnimal.Items.AddRange(new object[] { "Macho", "Fêmea" });
            cb_sexoAnimal.Location = new Point(311, 166);
            cb_sexoAnimal.Name = "cb_sexoAnimal";
            cb_sexoAnimal.Size = new Size(244, 23);
            cb_sexoAnimal.TabIndex = 45;
            // 
            // cb_tipoAnimal
            // 
            cb_tipoAnimal.FormattingEnabled = true;
            cb_tipoAnimal.Items.AddRange(new object[] { "Cão", "Gato" });
            cb_tipoAnimal.Location = new Point(34, 166);
            cb_tipoAnimal.Name = "cb_tipoAnimal";
            cb_tipoAnimal.Size = new Size(244, 23);
            cb_tipoAnimal.TabIndex = 44;
            // 
            // btn_Voltar
            // 
            btn_Voltar.Font = new Font("Segoe UI", 12F);
            btn_Voltar.Location = new Point(435, 271);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(124, 56);
            btn_Voltar.TabIndex = 43;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = true;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // btn_confirmAlteracao
            // 
            btn_confirmAlteracao.Font = new Font("Segoe UI", 12F);
            btn_confirmAlteracao.Location = new Point(34, 271);
            btn_confirmAlteracao.Name = "btn_confirmAlteracao";
            btn_confirmAlteracao.Size = new Size(124, 56);
            btn_confirmAlteracao.TabIndex = 41;
            btn_confirmAlteracao.Text = "Confirmar Alteração";
            btn_confirmAlteracao.UseVisualStyleBackColor = true;
            btn_confirmAlteracao.Click += btn_confirmAlteracao_Click;
            // 
            // txt_pesoAnimal
            // 
            txt_pesoAnimal.Location = new Point(311, 232);
            txt_pesoAnimal.Name = "txt_pesoAnimal";
            txt_pesoAnimal.Size = new Size(249, 23);
            txt_pesoAnimal.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(311, 208);
            label9.Name = "label9";
            label9.Size = new Size(42, 21);
            label9.TabIndex = 36;
            label9.Text = "Peso";
            // 
            // txt_racaAnimal
            // 
            txt_racaAnimal.Location = new Point(33, 232);
            txt_racaAnimal.Name = "txt_racaAnimal";
            txt_racaAnimal.Size = new Size(249, 23);
            txt_racaAnimal.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(33, 208);
            label8.Name = "label8";
            label8.Size = new Size(43, 21);
            label8.TabIndex = 34;
            label8.Text = "Raça";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(311, 142);
            label7.Name = "label7";
            label7.Size = new Size(43, 21);
            label7.TabIndex = 32;
            label7.Text = "Sexo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(33, 142);
            label6.Name = "label6";
            label6.Size = new Size(114, 21);
            label6.TabIndex = 30;
            label6.Text = "Tipo de Animal";
            // 
            // dtp_UltimaConsulta
            // 
            dtp_UltimaConsulta.Location = new Point(311, 101);
            dtp_UltimaConsulta.Name = "dtp_UltimaConsulta";
            dtp_UltimaConsulta.Size = new Size(249, 23);
            dtp_UltimaConsulta.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(311, 77);
            label5.Name = "label5";
            label5.Size = new Size(178, 21);
            label5.TabIndex = 28;
            label5.Text = "Data da Última Consulta";
            // 
            // txt_Contacto
            // 
            txt_Contacto.Location = new Point(311, 36);
            txt_Contacto.Name = "txt_Contacto";
            txt_Contacto.Size = new Size(249, 23);
            txt_Contacto.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(311, 12);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 26;
            label4.Text = "Contacto";
            // 
            // dtp_nascimentoAnimal
            // 
            dtp_nascimentoAnimal.Location = new Point(29, 101);
            dtp_nascimentoAnimal.Name = "dtp_nascimentoAnimal";
            dtp_nascimentoAnimal.Size = new Size(249, 23);
            dtp_nascimentoAnimal.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(29, 77);
            label3.Name = "label3";
            label3.Size = new Size(225, 21);
            label3.TabIndex = 24;
            label3.Text = "Data de Nascimento do Animal";
            // 
            // txt_nomeDono
            // 
            txt_nomeDono.Location = new Point(29, 36);
            txt_nomeDono.Name = "txt_nomeDono";
            txt_nomeDono.Size = new Size(249, 23);
            txt_nomeDono.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(29, 12);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 20;
            label1.Text = "Nome do Dono";
            // 
            // Atualizar_animal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 353);
            Controls.Add(panel1);
            Name = "Atualizar_animal";
            Text = "Atualizar_animal";
            Load += Atualizar_animal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cb_sexoAnimal;
        private ComboBox cb_tipoAnimal;
        private Button btn_Voltar;
        private Button btn_confirmAlteracao;
        private TextBox txt_pesoAnimal;
        private Label label9;
        private TextBox txt_racaAnimal;
        private Label label8;
        private Label label7;
        private Label label6;
        private DateTimePicker dtp_UltimaConsulta;
        private Label label5;
        private TextBox txt_Contacto;
        private Label label4;
        private DateTimePicker dtp_nascimentoAnimal;
        private Label label3;
        private TextBox txt_nomeDono;
        private Label label1;
        private Label lbl_ID;
    }
}