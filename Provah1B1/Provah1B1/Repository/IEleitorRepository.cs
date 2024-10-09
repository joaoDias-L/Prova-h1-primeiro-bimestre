
using Provah1B1.Models;
namespace Provah1B1.Repository

{
    public interface IEleitorRepository
    {

        public void InserirEleitor(Eleitor eleitor);

        public List<Eleitor> GetEleitores();
        
    
    }
}
