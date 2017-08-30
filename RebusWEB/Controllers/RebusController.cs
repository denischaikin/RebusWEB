using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Services.Rebus;
using Microsoft.AspNetCore.Mvc;

namespace RebusAPI.Controllers
{
    public class RebusController : Controller
    {
        private IRebusService _rebusService;
        public RebusController(IRebusService rebusService)
        {
            _rebusService = rebusService;
        }


        [HttpGet]
        public async Task<List<RebusDTO>> GetAll()
        {
            await _rebusService.AddRebusAsync(new RebusDTO());
            return await _rebusService.GetAllRebus();
        }

        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }
    }
}
