using System;
using System.Collections.Generic;

namespace CadastroDePessoa.Dominio.Entidades
{
    public class Pessoa : EntidadeBase<int>
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string NomeMae { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual ICollection<Dependente> Dependentes { get; set; }
    }
}
