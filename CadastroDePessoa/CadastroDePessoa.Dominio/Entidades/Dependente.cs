namespace CadastroDePessoa.Dominio.Entidades
{
    public class Dependente : EntidadeBase<int>
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}