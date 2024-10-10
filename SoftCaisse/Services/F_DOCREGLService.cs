using SoftCaisse.Models;
using SoftCaisse.Repositories;

namespace SoftCaisse.Services
{
    internal class F_DOCREGLService
    {
        private readonly IRepository<F_DOCREGL> _fDocreglRepository;

        public F_DOCREGLService(IRepository<F_DOCREGL> f_DocreglRepository)
        {
            _fDocreglRepository = f_DocreglRepository;
        }

        public void AjouterF_DOCREGL(F_DOCREGL f_DOCREGL)
        {
            _fDocreglRepository.Add(f_DOCREGL);
        }

    }
}
