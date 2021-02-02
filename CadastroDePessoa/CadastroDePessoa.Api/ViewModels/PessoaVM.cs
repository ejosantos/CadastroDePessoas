using System;
using System.Collections.Generic;

namespace CadastroDePessoa.Api.ViewModels
{
    public class PessoaVM
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string NomeMae { get; set; }
        public EnderecoVM Endereco { get; set; }
        public List<DependenteVM> Dependentes { get; set; }
    }
}
