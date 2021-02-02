using AutoMapper;
using CadastroDePessoa.Api.ViewModels;
using CadastroDePessoa.Dominio.Entidades;

namespace CadastroDePessoa.Api.ProfileMap
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Dependente, DependenteVM>();
            CreateMap<DependenteVM, Dependente>();
            CreateMap<Endereco, EnderecoVM>();
            CreateMap<EnderecoVM, Endereco>();
            CreateMap<Pessoa, PessoaVM>();
            CreateMap<PessoaVM, Pessoa>();
        }
    }
}
