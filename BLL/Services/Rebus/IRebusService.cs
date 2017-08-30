using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.DTO;

namespace BLL.Services.Rebus
{
    public interface IRebusService
    {
        Task AddRebusAsync(RebusDTO rebusDto);
        Task<List<RebusDTO>> GetAllRebus();
    }
}
