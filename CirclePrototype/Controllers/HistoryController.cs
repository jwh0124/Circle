
using CirclePrototype.Models;
using CirclePrototype.Repository;
using LightQuery;
using LightQuery.Client;
using LightQuery.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CirclePrototype.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private readonly IHistoryRepository _repository;
        public HistoryController(IHistoryRepository repository)
        {
            _repository = repository;
        }

        [AsyncLightQuery(forcePagination: false, defaultPageSize: 3, defaultSort: "UserName desc")]
        [ProducesResponseType(typeof(PaginationResult<History>), 200)]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _repository.GetList());
        }
    }
}