namespace CadastroDePessoa.Dominio.Entidades
{
    public class Endereco : EntidadeBase<int>
    {
        public string TipoDeLogradouro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Referencia { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}