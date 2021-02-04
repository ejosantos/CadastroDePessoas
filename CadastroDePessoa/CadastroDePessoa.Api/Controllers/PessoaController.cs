using System;
using CadastroDePessoa.Api.ViewModels;
using CadastroDePessoa.Dominio.Entidades;

namespace CadastroDePessoa.Api.Controllers
{
    public class PessoaController : CrudGenericoController<int, Pessoa, PessoaVM>
    {
        public PessoaController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
      
    }
}
