using Games.Domains;

namespace Games.Interfaces
{
    public interface IStudio
    {
        List<Studio> List();

        void Create(Studio newStudio);

        void Delete(int idEstudio);
    }
}
