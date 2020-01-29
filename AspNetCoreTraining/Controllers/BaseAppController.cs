using AspNetCoreTraining.Data.Models;
using AspNetCoreTraining.Data.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTraining.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseAppController<TEntity,TRepo>: ControllerBase
        where TEntity: class, IEntity
        where TRepo: class, IRepo<TEntity>
    {
        
        private readonly TRepo _repo;

        public BaseAppController( TRepo repo)
        {
            //_logger = logger;
            _repo = repo;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await _repo.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var TEntity = await _repo.Get(id);
            if (TEntity == null)
            {
                return NotFound();
            }
            return TEntity;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity TEntity)
        {
            if (id != TEntity.ID)
            {
                return BadRequest();
            }
            await _repo.Update(TEntity);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity TEntity)
        {
            await _repo.Add(TEntity);
            return CreatedAtAction("Get", new { id = TEntity.ID }, TEntity);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var TEntity = await _repo.Delete(id);
            if (TEntity == null)
            {
                return NotFound();
            }
            return TEntity;
        }
    }
}
