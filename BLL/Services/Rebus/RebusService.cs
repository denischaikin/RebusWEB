using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Extensions;
using DAL.Repositories.Rebus;

namespace BLL.Services.Rebus
{
    public class RebusService : IRebusService
    {
        private IRebusRepository _rebusRepository;

        public RebusService(IRebusRepository rebusRepository)
        {
            _rebusRepository = rebusRepository;
        }

        public async Task AddRebusAsync(RebusDTO rebusDto)
        {
            await _rebusRepository.AddAsync(new DAL.Models.Rebus
            {
                ImagePath = "http://luntiki.ru/uploads/images/3/a/7/c/5/da23697edf.jpg",
                СorrectAnswer = "узор",
                Level = 1
            });
        }

        public async Task<List<RebusDTO>> GetAllRebus()
        {
            return (await _rebusRepository.GetAsync()).Select(rebus => rebus.ToRebusDto()).ToList();
        }
    }
}
