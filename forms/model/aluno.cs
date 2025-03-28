using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms.model
{
    public class aluno
    {
        public string Nome { get; set; }
        public string NumeroMatricula { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public endereco EnderecoAluno { get; set; }
        public string NomeMae { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
    }
}
