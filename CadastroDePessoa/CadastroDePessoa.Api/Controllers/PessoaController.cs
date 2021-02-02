using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CadastroDePessoa.Api.ViewModels;
using CadastroDePessoa.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDePessoa.Api.Controllers
{
    public class PessoaController : CrudGenericoController<int, Pessoa, PessoaVM>
    {
        public PessoaController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
      
    }
}
