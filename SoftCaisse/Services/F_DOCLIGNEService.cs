using SoftCaisse.Models;
using SoftCaisse.Repositories;

namespace SoftCaisse.Services
{
    internal class F_DOCLIGNEService
    {
        private readonly IRepository<F_DOCLIGNE> _F_DOCLIGNERepository;

        public F_DOCLIGNEService(IRepository<F_DOCLIGNE> F_DOCLIGNERepository)
        {
            _F_DOCLIGNERepository = F_DOCLIGNERepository;
        }

        public void AjouterF_DOCLIGNE(F_DOCLIGNE F_DOCLIGNE)
        {
            _F_DOCLIGNERepository.Add(F_DOCLIGNE);
        }
    }
}
