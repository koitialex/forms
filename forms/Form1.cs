using forms.model;

namespace forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            /*
             
            if (!ValidaNome(txtNome.Text))
                MessageBox.Show("Nome inválido");

            if (!ValidaCpf(TxtCpf.Text))
                MessageBox.Show("CPF Inválido");

            if (!ValidaData2(TxtNascimento.Text))
                MessageBox.Show("Data de Nascimento Inválida");
             */
            aluno novoAluno = new aluno();
            novoAluno.Nome = txtNome.Text;

            string cpf = TxtCpf.Text.Replace("-", "");
            cpf = TxtCpf.Text.Replace(".", "");
            novoAluno.Cpf = cpf;

            novoAluno.Email = TxtEmail.Text;

            string telefone = TxtTelefone.Text.Replace("(", "");
            telefone = telefone.Replace(")", "");
            telefone = telefone.Replace("-", "");
            novoAluno.Telefone = telefone;

            novoAluno.DataNascimento = Convert.ToDateTime(TxtNascimento.Text);


        }
        private bool ValidaNome(string nome)
        {
            if (nome == null || nome.Trim() == "")
                return false;
            else
                return true;
        }
        private bool ValidaCpf(string cpf)
        {
            cpf = cpf.Remove(3, 1);
            cpf = cpf.Remove(6, 1);
            cpf = cpf.Remove(9, 1);
            if (cpf == null || cpf.Trim() == "" || !cpf.All(char.IsDigit) || cpf.Length != 11)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private bool ValidaData(string DataNascimento)
        {
            DateTime hoje = DateTime.Today;
            DateTime nascimento = Convert.ToDateTime(DataNascimento);

            if (nascimento > hoje)
                return false;

            return true;
           
           
        }
        private bool ValidaData2(string dataNascimento)
        {
            //Verifica se o valor que vem na data de nascimento é vazio ou nulo
            if (string.IsNullOrEmpty(dataNascimento))
                return false;

            //Utiliza a estrutura DateTime para buscar o valor da data de hoje e armazenar na variável hoje
            DateTime hoje = DateTime.Today;
            DateTime nascimento;

            //Executa o método TryParse, que tenta converter o valor dataNascimento, que é uma string
            //em uma data, caso dê sucesso, irá armazenar o valor da dataNascimento na variável nascimento.
            bool sucesso = DateTime.TryParse(dataNascimento, out nascimento);

            //Verifica se a conversão de data foi bem sucedida e se a data de nascimento é maior que a data de hoje.
            if (!sucesso || nascimento > hoje)
                return false;

            return true;
        }
        private bool ValidaEmail(string Email)
        {
            bool contemArroba;
            if(Email.Contains("@"))
                contemArroba = true;
            else
                return false;
            if(ContemArroba)
            {
                int posicaoDoArroba = Email.IndexOf("@");

                if
            }
        }


}
}
