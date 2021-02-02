using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CadastroDePessoa.Dominio.Entidades;
using CadastroDePessoa.Dominio.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace CadastroDePessoa.Api.Controllers
{
    [Route("api/[controller]")]
    public abstract class CrudGenericoController<TKey, TEntity, TModel> : ControllerBase where TKey : struct where TEntity : EntidadeBase<TKey>
    {
        protected readonly IServicoCrud<TKey, TEntity> _Service;
        protected readonly IMapper _Mapper;

        protected CrudGenericoController(IServiceProvider serviceProvider)
        {
            _Service = serviceProvider.GetRequiredService<IServicoCrud<TKey, TEntity>>();
            _Mapper = serviceProvider.GetRequiredService<IMapper>();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<TEntity> entities = await _Service.GetAllAsync();
            IEnumerable<TModel> models = _Mapper.Map<IEnumerable<TModel>>(entities);
            return Ok(models);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(TKey id)
        {
            TEntity entity = await _Service.GetAsync(id);

            if (entity == null) return NotFound();

            TModel model = _Mapper.Map<TModel>(entity);
            return Ok(model);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] TModel model)
        {
            var entitidade = _Mapper.Map<TEntity>(model);
            TEntity entity = await _Service.AddAsync(entitidade);

            string action = Url.Action("Get", this.ControllerContext.ActionDescriptor.ControllerName, new { id = entity.Id });

            return Created(action, _Mapper.Map<TModel>(entity));
        }

        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] TModel model) => Ok(await _Service.UpdateAsync(_Mapper.Map<TEntity>(model)));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(TKey id) => Ok(await _Service.DeleteAsync(id));
    }
}
