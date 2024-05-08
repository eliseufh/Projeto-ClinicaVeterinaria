namespace clinicaVeterinaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btn_consulta = new Button();
            btn_animal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(138, 62);
            label1.Name = "label1";
            label1.Size = new Size(355, 41);
            label1.TabIndex = 0;
            label1.Text = "Bem vindo(a) ao VetClinic";
            // 
            // btn_consulta
            // 
            btn_consulta.Font = new Font("Segoe UI", 14F);
            btn_consulta.Location = new Point(174, 125);
            btn_consulta.Name = "btn_consulta";
            btn_consulta.Size = new Size(121, 44);
            btn_consulta.TabIndex = 1;
            btn_consulta.Text = "Consulta";
            btn_consulta.UseVisualStyleBackColor = true;
            btn_consulta.Click += btn_consulta_Click;
            // 
            // btn_animal
            // 
            btn_animal.Font = new Font("Segoe UI", 14F);
            btn_animal.Location = new Point(334, 125);
            btn_animal.Name = "btn_animal";
            btn_animal.Size = new Size(121, 44);
            btn_animal.TabIndex = 2;
            btn_animal.Text = "Animal";
            btn_animal.UseVisualStyleBackColor = true;
            btn_animal.Click += btn_animal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(644, 248);
            Controls.Add(btn_animal);
            Controls.Add(btn_consulta);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_consulta;
        private Button btn_animal;
    }
}
