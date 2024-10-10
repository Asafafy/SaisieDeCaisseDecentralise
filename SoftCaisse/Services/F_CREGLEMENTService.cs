using SoftCaisse.Models;
using SoftCaisse.Repositories;

namespace SoftCaisse.Services
{
    internal class F_CREGLEMENTService
    {
        private readonly IRepository<F_CREGLEMENT> _reglementRepository;

        public F_CREGLEMENTService(IRepository<F_CREGLEMENT> reglementRepository)
        {
            _reglementRepository = reglementRepository;
        }

        public void AjouterF_CREGLEMENT(F_CREGLEMENT reglement)
        {
            _reglementRepository.Add(reglement);
        }
    }
}
