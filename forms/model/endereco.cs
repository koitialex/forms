using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms.model
{
    public class endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public int Cep { get; set; }
        public string bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade{ get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

    }
}
