using Provah1B1.Models;


namespace Provah1B1.Repository
{
    public class EleitorRepository : IEleitorRepository
    {
        public static List<Eleitor> listaEleitores = new List<Eleitor>();

        public void InserirEleitor(Eleitor eleitor)
        {
            listaEleitores.Add(eleitor);
        }

        public List<Eleitor> GetEleitores()
        {
            return listaEleitores;
        }
    }
}
