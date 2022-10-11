using Games.Contexts;
using Games.Domains;
using Games.Interfaces;

namespace Games.Repositories
{
    public class StudioRepository : IStudio
    {
        Context ctx = new();

        public void Create(Studio newStudio)
        {
            throw new NotImplementedException();
        }

        public void Delete(int idEstudio)
        {
            throw new NotImplementedException();
        }

        public List<Studio> List()
        {
            return ctx.Studios.ToList();
        }
    }
}
