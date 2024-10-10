using SoftCaisse.Models;
using SoftCaisse.Repositories;

namespace SoftCaisse.Services
{
    internal class F_DOCENTETEService
    {
        private readonly IRepository<F_DOCENTETE> _f_DOCENTETERepository;

        public F_DOCENTETEService(IRepository<F_DOCENTETE> f_DOCENTETERepository)
        {
            _f_DOCENTETERepository = f_DOCENTETERepository;
        }

        public void AjouterF_DOCENTETE(F_DOCENTETE f_DOCENTETE)
        {
            _f_DOCENTETERepository.Add(f_DOCENTETE);
        }
    }
}
