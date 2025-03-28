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
            txtNome = new TextBox();
            TxtNumeroMatricula = new TextBox();
            lblNome = new Label();
            lblCpf = new Label();
            TxtCpf = new MaskedTextBox();
            LblNumeroMatricula = new Label();
            maskedTextBox1 = new MaskedTextBox();
            TxtTelefone = new Label();
            LblCidade = new Label();
            TxtEmail = new TextBox();
            LblEmail = new Label();
            TxtNascimento = new MaskedTextBox();
            LblNascimento = new Label();
            LblNomeMae = new Label();
            TxtNomeMae = new MaskedTextBox();
            LblLogradouro = new Label();
            TxtLogradouro = new MaskedTextBox();
            LblNumero = new Label();
            txtNumero = new TextBox();
            LblCep = new Label();
            TxtCep = new MaskedTextBox();
            LblBairro = new Label();
            TxtBairro = new TextBox();
            Compl = new Label();
            TxtComplemento = new TextBox();
            TxtCidade = new TextBox();
            label2 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            LblPais = new Label();
            TxtPais = new TextBox();
            BtnSalvar = new Button();
            tcTabela = new TabControl();
            tpCadastro = new TabPage();
            panel2 = new Panel();
            panel1 = new Panel();
            tpRegistro = new TabPage();
            panel3 = new Panel();
            listView1 = new ListView();
            chNome = new ColumnHeader();
            chMatricula = new ColumnHeader();
            chDataNascimento = new ColumnHeader();
            chLogradouro = new ColumnHeader();
            chEstado = new ColumnHeader();
            tcTabela.SuspendLayout();
            tpCadastro.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tpRegistro.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(18, 28);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(338, 23);
            txtNome.TabIndex = 0;
            // 
            // TxtNumeroMatricula
            // 
            TxtNumeroMatricula.Location = new Point(132, 88);
            TxtNumeroMatricula.Name = "TxtNumeroMatricula";
            TxtNumeroMatricula.Size = new Size(100, 23);
            TxtNumeroMatricula.TabIndex = 3;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(19, 8);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(38, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "nome";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(19, 68);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 5;
            lblCpf.Text = "CPF";
            // 
            // TxtCpf
            // 
            TxtCpf.Location = new Point(18, 84);
            TxtCpf.Mask = "000.000.000-00";
            TxtCpf.Name = "TxtCpf";
            TxtCpf.Size = new Size(72, 23);
            TxtCpf.TabIndex = 6;
            // 
            // LblNumeroMatricula
            // 
            LblNumeroMatricula.AutoSize = true;
            LblNumeroMatricula.Location = new Point(133, 70);
            LblNumeroMatricula.Name = "LblNumeroMatricula";
            LblNumeroMatricula.Size = new Size(90, 15);
            LblNumeroMatricula.TabIndex = 7;
            LblNumeroMatricula.Text = "N° de matricula";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(283, 86);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(73, 23);
            maskedTextBox1.TabIndex = 8;
            // 
            // TxtTelefone
            // 
            TxtTelefone.AutoSize = true;
            TxtTelefone.Location = new Point(283, 68);
            TxtTelefone.Name = "TxtTelefone";
            TxtTelefone.Size = new Size(51, 15);
            TxtTelefone.TabIndex = 9;
            TxtTelefone.Text = "Telefone";
            // 
            // LblCidade
            // 
            LblCidade.AutoSize = true;
            LblCidade.Location = new Point(15, 194);
            LblCidade.Name = "LblCidade";
            LblCidade.Size = new Size(44, 15);
            LblCidade.TabIndex = 10;
            LblCidade.Text = "Cidade";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(19, 211);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(337, 23);
            TxtEmail.TabIndex = 11;
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(18, 193);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(36, 15);
            LblEmail.TabIndex = 10;
            LblEmail.Text = "Email";
            // 
            // TxtNascimento
            // 
            TxtNascimento.Location = new Point(18, 152);
            TxtNascimento.Mask = "00/00/0000";
            TxtNascimento.Name = "TxtNascimento";
            TxtNascimento.Size = new Size(100, 23);
            TxtNascimento.TabIndex = 12;
            TxtNascimento.ValidatingType = typeof(DateTime);
            // 
            // LblNascimento
            // 
            LblNascimento.AutoSize = true;
            LblNascimento.Location = new Point(15, 134);
            LblNascimento.Name = "LblNascimento";
            LblNascimento.Size = new Size(115, 15);
            LblNascimento.TabIndex = 10;
            LblNascimento.Text = "Dada de nascimento";
            // 
            // LblNomeMae
            // 
            LblNomeMae.AutoSize = true;
            LblNomeMae.Location = new Point(136, 134);
            LblNomeMae.Name = "LblNomeMae";
            LblNomeMae.Size = new Size(82, 15);
            LblNomeMae.TabIndex = 10;
            LblNomeMae.Text = "Nome da Mãe";
            // 
            // TxtNomeMae
            // 
            TxtNomeMae.Location = new Point(133, 152);
            TxtNomeMae.Name = "TxtNomeMae";
            TxtNomeMae.Size = new Size(223, 23);
            TxtNomeMae.TabIndex = 12;
            // 
            // LblLogradouro
            // 
            LblLogradouro.AutoSize = true;
            LblLogradouro.Location = new Point(14, 8);
            LblLogradouro.Name = "LblLogradouro";
            LblLogradouro.Size = new Size(69, 15);
            LblLogradouro.TabIndex = 10;
            LblLogradouro.Text = "Logradouro";
            // 
            // TxtLogradouro
            // 
            TxtLogradouro.Location = new Point(16, 35);
            TxtLogradouro.Name = "TxtLogradouro";
            TxtLogradouro.Size = new Size(337, 23);
            TxtLogradouro.TabIndex = 12;
            // 
            // LblNumero
            // 
            LblNumero.AutoSize = true;
            LblNumero.Location = new Point(15, 61);
            LblNumero.Name = "LblNumero";
            LblNumero.Size = new Size(51, 15);
            LblNumero.TabIndex = 10;
            LblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(14, 92);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(152, 23);
            txtNumero.TabIndex = 11;
            // 
            // LblCep
            // 
            LblCep.AutoSize = true;
            LblCep.Location = new Point(195, 60);
            LblCep.Name = "LblCep";
            LblCep.Size = new Size(28, 15);
            LblCep.TabIndex = 10;
            LblCep.Text = "CEP";
            // 
            // TxtCep
            // 
            TxtCep.Location = new Point(195, 92);
            TxtCep.Mask = "00000-000";
            TxtCep.Name = "TxtCep";
            TxtCep.Size = new Size(51, 23);
            TxtCep.TabIndex = 12;
            // 
            // LblBairro
            // 
            LblBairro.AutoSize = true;
            LblBairro.Location = new Point(14, 123);
            LblBairro.Name = "LblBairro";
            LblBairro.Size = new Size(38, 15);
            LblBairro.TabIndex = 10;
            LblBairro.Text = "Bairro";
            // 
            // TxtBairro
            // 
            TxtBairro.Location = new Point(13, 152);
            TxtBairro.Name = "TxtBairro";
            TxtBairro.Size = new Size(152, 23);
            TxtBairro.TabIndex = 11;
            // 
            // Compl
            // 
            Compl.AutoSize = true;
            Compl.Location = new Point(193, 119);
            Compl.Name = "Compl";
            Compl.Size = new Size(84, 15);
            Compl.TabIndex = 10;
            Compl.Text = "Complemento";
            // 
            // TxtComplemento
            // 
            TxtComplemento.Location = new Point(182, 152);
            TxtComplemento.Name = "TxtComplemento";
            TxtComplemento.Size = new Size(171, 23);
            TxtComplemento.TabIndex = 11;
            // 
            // TxtCidade
            // 
            TxtCidade.Location = new Point(13, 217);
            TxtCidade.Name = "TxtCidade";
            TxtCidade.Size = new Size(151, 23);
            TxtCidade.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 194);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 13;
            label2.Text = "Estado";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(193, 217);
            maskedTextBox3.Mask = "00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(51, 23);
            maskedTextBox3.TabIndex = 12;
            // 
            // LblPais
            // 
            LblPais.AutoSize = true;
            LblPais.Location = new Point(265, 194);
            LblPais.Name = "LblPais";
            LblPais.Size = new Size(28, 15);
            LblPais.TabIndex = 13;
            LblPais.Text = "País";
            // 
            // TxtPais
            // 
            TxtPais.Location = new Point(265, 217);
            TxtPais.Name = "TxtPais";
            TxtPais.Size = new Size(88, 23);
            TxtPais.TabIndex = 11;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(39, 513);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(352, 41);
            BtnSalvar.TabIndex = 14;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // tcTabela
            // 
            tcTabela.Controls.Add(tpCadastro);
            tcTabela.Controls.Add(tpRegistro);
            tcTabela.Location = new Point(12, 4);
            tcTabela.Name = "tcTabela";
            tcTabela.SelectedIndex = 0;
            tcTabela.Size = new Size(453, 598);
            tcTabela.TabIndex = 15;
            // 
            // tpCadastro
            // 
            tpCadastro.BackColor = Color.DarkGray;
            tpCadastro.BorderStyle = BorderStyle.FixedSingle;
            tpCadastro.Controls.Add(panel2);
            tpCadastro.Controls.Add(panel1);
            tpCadastro.Controls.Add(BtnSalvar);
            tpCadastro.Location = new Point(4, 24);
            tpCadastro.Name = "tpCadastro";
            tpCadastro.Padding = new Padding(3);
            tpCadastro.Size = new Size(445, 570);
            tpCadastro.TabIndex = 0;
            tpCadastro.Text = "cadastro";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TxtComplemento);
            panel2.Controls.Add(LblLogradouro);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(TxtPais);
            panel2.Controls.Add(LblPais);
            panel2.Controls.Add(LblNumero);
            panel2.Controls.Add(TxtLogradouro);
            panel2.Controls.Add(TxtCidade);
            panel2.Controls.Add(TxtCep);
            panel2.Controls.Add(LblCep);
            panel2.Controls.Add(maskedTextBox3);
            panel2.Controls.Add(LblBairro);
            panel2.Controls.Add(LblCidade);
            panel2.Controls.Add(TxtBairro);
            panel2.Controls.Add(txtNumero);
            panel2.Controls.Add(Compl);
            panel2.Location = new Point(26, 259);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 248);
            panel2.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(TxtEmail);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(LblNascimento);
            panel1.Controls.Add(LblNomeMae);
            panel1.Controls.Add(TxtNumeroMatricula);
            panel1.Controls.Add(LblEmail);
            panel1.Controls.Add(TxtTelefone);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(TxtNascimento);
            panel1.Controls.Add(LblNumeroMatricula);
            panel1.Controls.Add(lblCpf);
            panel1.Controls.Add(TxtCpf);
            panel1.Controls.Add(TxtNomeMae);
            panel1.Location = new Point(26, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 250);
            panel1.TabIndex = 15;
            // 
            // tpRegistro
            // 
            tpRegistro.Controls.Add(panel3);
            tpRegistro.Location = new Point(4, 24);
            tpRegistro.Name = "tpRegistro";
            tpRegistro.Padding = new Padding(3);
            tpRegistro.Size = new Size(445, 570);
            tpRegistro.TabIndex = 1;
            tpRegistro.Text = "Registro";
            tpRegistro.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(listView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(439, 564);
            panel3.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { chNome, chMatricula, chDataNascimento, chLogradouro, chEstado });
            listView1.GridLines = true;
            listView1.Location = new Point(38, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(388, 523);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // chNome
            // 
            chNome.Text = "Nome";
            // 
            // chMatricula
            // 
            chMatricula.Text = "Matricula";
            // 
            // chDataNascimento
            // 
            chDataNascimento.Text = "Data de Nascimento";
            // 
            // chLogradouro
            // 
            chLogradouro.Text = "Logradouro";
            // 
            // chEstado
            // 
            chEstado.Text = "Estado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 614);
            Controls.Add(tcTabela);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            tcTabela.ResumeLayout(false);
            tpCadastro.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tpRegistro.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNome;
        private TextBox TxtNumeroMatricula;
        private Label lblNome;
        private Label lblCpf;
        private MaskedTextBox TxtCpf;
        private Label LblNumeroMatricula;
        private MaskedTextBox maskedTextBox1;
        private Label TxtTelefone;
        private Label LblCidade;
        private TextBox TxtEmail;
        private Label LblEmail;
        private MaskedTextBox TxtNascimento;
        private Label LblNascimento;
        private Label LblNomeMae;
        private MaskedTextBox TxtNomeMae;
        private Label LblLogradouro;
        private MaskedTextBox TxtLogradouro;
        private Label LblNumero;
        private TextBox txtNumero;
        private Label LblCep;
        private MaskedTextBox TxtCep;
        private Label LblBairro;
        private TextBox TxtBairro;
        private Label Compl;
        private TextBox TxtComplemento;
        private TextBox TxtCidade;
        private Label label2;
        private MaskedTextBox maskedTextBox3;
        private Label LblPais;
        private TextBox TxtPais;
        private Button BtnSalvar;
        private TabControl tcTabela;
        private TabPage tpCadastro;
        private Panel panel1;
        private TabPage tpRegistro;
        private Panel panel2;
        private Panel panel3;
        private ListView listView1;
        private ColumnHeader chNome;
        private ColumnHeader chMatricula;
        private ColumnHeader chDataNascimento;
        private ColumnHeader chLogradouro;
        private ColumnHeader chEstado;
    }
}
