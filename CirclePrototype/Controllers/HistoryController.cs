using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CirclePrototype.Models;
using CirclePrototype.Repository;
using LightQuery;
using LightQuery.Client;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CirclePrototype.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private readonly IHistoryRepository _repository;
        public HistoryController(IHistoryRepository repository)
        {
            _repository = repository;
        }

        [AllowAnonymous]
        [LightQuery(forcePagination: true, defaultPageSize: 3)]
        [ProducesResponseType(typeof(PaginationResult<History>), 200)]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetList());
        }
    }
}