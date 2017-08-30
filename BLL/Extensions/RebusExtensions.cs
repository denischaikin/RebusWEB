using BLL.DTO;
using DAL.Models;

namespace BLL.Extensions
{
    public static class RebusExtensions
    {
        public static RebusDTO ToRebusDto(this Rebus model)
        {
            return new RebusDTO
            {
                Id = model.Id,
                ImagePath = model.ImagePath,
                Level = model.Level,
                СorrectAnswer = model.СorrectAnswer
            };
        }

        public static Rebus ToRebus(this RebusDTO dto)
        {
            return new Rebus
            {
                Id = dto.Id,
                ImagePath = dto.ImagePath,
                Level = dto.Level,
                СorrectAnswer = dto.СorrectAnswer
            };
        }
    }
}
