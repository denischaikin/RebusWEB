namespace DAL.Repositories.Rebus
{
    public class RebusRepository : BaseRepository<Models.Rebus>, IRebusRepository
    {
        public RebusRepository(RebusContext context) : base(context) { }
    }
}
