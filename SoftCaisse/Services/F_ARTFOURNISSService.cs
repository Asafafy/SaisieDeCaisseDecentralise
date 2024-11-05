using SoftCaisse.Models;
using SoftCaisse.Repositories;

namespace SoftCaisse.Services
{
    internal class F_ARTFOURNISSService
    {
        private readonly F_ARTFOURNISSRepository _artFournissRepo;

        public F_ARTFOURNISSService(F_ARTFOURNISSRepository artFournissRepo)
        {
            _artFournissRepo = artFournissRepo;
        }

        public F_ARTFOURNISS GetByARRefAndPrincipal(string arRef)
        {
            return _artFournissRepo.GetByARRefAndPrincipal(arRef);
        }
    }
}
