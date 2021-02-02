namespace CadastroDePessoa.Api.ViewModels
{
    public class EnderecoVM
    {
        public int Id { get; set; }
        public string TipoDeLogradouro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Referencia { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
