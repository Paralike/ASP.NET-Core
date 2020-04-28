using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PubErtekelo.BLL.Filters;
using PubErtekelo.BLL.Services;
using PubErtekelo.BLL.ViewModels;
using PubErtekelo.BLL.Dtos;

using System.Threading;

namespace pubertekelo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FelhasznaloController
    {
        private readonly IFelhasznaloService _felhasznaloService;
        public FelhasznaloController(IFelhasznaloService felhasznaloService)
        {
            _felhasznaloService = felhasznaloService;
        }

        [HttpGet]
        public async Task<ActionResult<ItemsViewModel<FelhasznaloListViewModel>>> Get([FromQuery]PagedFilter filter, CancellationToken cancellationToken)
        {
            return await _felhasznaloService.ListAsync(filter, cancellationToken);
        }
        [HttpPost]
        public Task<FelhasznaloViewModel> Post([FromBody]FelhasznaloDto dto, CancellationToken cancellationToken) { 
            return _felhasznaloService.CreateAsync(dto, cancellationToken); 
        }

        [HttpPut("{id}")] 
        public async Task<IActionResult> Put(int id, [FromBody]FelhasznaloDto dto, CancellationToken cancellationToken) {
            await _felhasznaloService.UpdateAsync(id, dto, cancellationToken); 
            return Ok(); 
        } 
        [HttpDelete("{id}")] 
        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken) { 
            await _felhasznaloService.DeleteAsync(id, cancellationToken); 
            return Ok(); 
        }
    }
}
