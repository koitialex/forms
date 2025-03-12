namespace forms
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
            textNome = new TextBox();
            TxtNumeroMatricula = new TextBox();
            lblNome = new Label();
            lblCpf = new Label();
            TxtCpf = new MaskedTextBox();
            LblNumeroMatricula = new Label();
            maskedTextBox1 = new MaskedTextBox();
            TxtTelefone = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            TxtEmail = new TextBox();
            LblEmail = new Label();
            TxtNascimento = new MaskedTextBox();
            LblNascimento = new Label();
            LblNomeMae = new Label();
            TxtNomeMae = new MaskedTextBox();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.Location = new Point(12, 22);
            textNome.Name = "textNome";
            textNome.Size = new Size(338, 23);
            textNome.TabIndex = 0;
            // 
            // TxtNumeroMatricula
            // 
            TxtNumeroMatricula.Location = new Point(126, 82);
            TxtNumeroMatricula.Name = "TxtNumeroMatricula";
            TxtNumeroMatricula.Size = new Size(100, 23);
            TxtNumeroMatricula.TabIndex = 3;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(13, 2);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(38, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "nome";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(13, 62);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 5;
            lblCpf.Text = "CPF";
            // 
            // TxtCpf
            // 
            TxtCpf.Location = new Point(12, 78);
            TxtCpf.Mask = "000.000.000-00";
            TxtCpf.Name = "TxtCpf";
            TxtCpf.Size = new Size(72, 23);
            TxtCpf.TabIndex = 6;
            // 
            // LblNumeroMatricula
            // 
            LblNumeroMatricula.AutoSize = true;
            LblNumeroMatricula.Location = new Point(127, 64);
            LblNumeroMatricula.Name = "LblNumeroMatricula";
            LblNumeroMatricula.Size = new Size(90, 15);
            LblNumeroMatricula.TabIndex = 7;
            LblNumeroMatricula.Text = "N° de matricula";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(277, 80);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(73, 23);
            maskedTextBox1.TabIndex = 8;
            // 
            // TxtTelefone
            // 
            TxtTelefone.AutoSize = true;
            TxtTelefone.Location = new Point(277, 62);
            TxtTelefone.Name = "TxtTelefone";
            TxtTelefone.Size = new Size(51, 15);
            TxtTelefone.TabIndex = 9;
            TxtTelefone.Text = "Telefone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(602, 51);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 10;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(604, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 11;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(604, 393);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 12;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(13, 205);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(337, 23);
            TxtEmail.TabIndex = 11;
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(12, 187);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(36, 15);
            LblEmail.TabIndex = 10;
            LblEmail.Text = "Email";
            // 
            // TxtNascimento
            // 
            TxtNascimento.Location = new Point(12, 146);
            TxtNascimento.Mask = "00/00/0000";
            TxtNascimento.Name = "TxtNascimento";
            TxtNascimento.Size = new Size(100, 23);
            TxtNascimento.TabIndex = 12;
            TxtNascimento.ValidatingType = typeof(DateTime);
            // 
            // LblNascimento
            // 
            LblNascimento.AutoSize = true;
            LblNascimento.Location = new Point(9, 128);
            LblNascimento.Name = "LblNascimento";
            LblNascimento.Size = new Size(115, 15);
            LblNascimento.TabIndex = 10;
            LblNascimento.Text = "Dada de nascimento";
            // 
            // LblNomeMae
            // 
            LblNomeMae.AutoSize = true;
            LblNomeMae.Location = new Point(130, 128);
            LblNomeMae.Name = "LblNomeMae";
            LblNomeMae.Size = new Size(82, 15);
            LblNomeMae.TabIndex = 10;
            LblNomeMae.Text = "Nome da Mãe";
            // 
            // TxtNomeMae
            // 
            TxtNomeMae.Location = new Point(127, 146);
            TxtNomeMae.Name = "TxtNomeMae";
            TxtNomeMae.Size = new Size(223, 23);
            TxtNomeMae.TabIndex = 12;
            TxtNomeMae.MaskInputRejected += TxtNomeMae_MaskInputRejected;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtNascimento);
            Controls.Add(TxtNomeMae);
            Controls.Add(maskedTextBox2);
            Controls.Add(TxtEmail);
            Controls.Add(textBox1);
            Controls.Add(LblEmail);
            Controls.Add(LblNascimento);
            Controls.Add(LblNomeMae);
            Controls.Add(label1);
            Controls.Add(TxtTelefone);
            Controls.Add(maskedTextBox1);
            Controls.Add(LblNumeroMatricula);
            Controls.Add(TxtCpf);
            Controls.Add(lblCpf);
            Controls.Add(lblNome);
            Controls.Add(TxtNumeroMatricula);
            Controls.Add(textNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNome;
        private TextBox TxtNumeroMatricula;
        private Label lblNome;
        private Label lblCpf;
        private MaskedTextBox TxtCpf;
        private Label LblNumeroMatricula;
        private MaskedTextBox maskedTextBox1;
        private Label TxtTelefone;
        private Label label1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox2;
        private TextBox TxtEmail;
        private Label LblEmail;
        private MaskedTextBox TxtNascimento;
        private Label LblNascimento;
        private Label LblNomeMae;
        private MaskedTextBox TxtNomeMae;
    }
}
