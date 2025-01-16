using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Repositories.BIJOU;
using System.Collections.Generic;

namespace SoftCaisse.Services
{
    internal class F_REGLECHService
    {
        private readonly F_REGLECHRepository _f_ReglechRepository;

        public F_REGLECHService(F_REGLECHRepository f_ReglechRepository)
        {
            _f_ReglechRepository = f_ReglechRepository;
        }

        public void SupprimerReglementsDesEcheances(List<F_REGLECH> f_REGLECHes)
        {
            foreach (F_REGLECH f_REGLECH in f_REGLECHes)
            {
                _f_ReglechRepository.DeleteByDoPiece(f_REGLECH.DO_Piece);
            }
        }
    }
}
