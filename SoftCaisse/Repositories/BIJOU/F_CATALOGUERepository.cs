using SoftCaisse.Models;
using System.Linq;

namespace SoftCaisse.Repositories
{
    internal class F_CATALOGUERepository
    {
        private readonly AppDbContext _context;
        public F_CATALOGUERepository(AppDbContext context)
        {
            _context = context;
        }

        public F_CATALOGUE GetById(int id)
        {
            return _context.F_CATALOGUE.Select(x => new F_CATALOGUE
            {
                CL_No = x.CL_No,
                CL_Intitule = x.CL_Intitule,
                CL_Code = x.CL_Code,
                CL_Stock = x.CL_Stock,
                CL_NoParent = x.CL_NoParent,
                cbCL_NoParent = x.cbCL_NoParent,
                CL_Niveau = x.CL_Niveau,
                cbProt = x.cbProt,
                cbMarq = x.cbMarq,
                cbCreateur = x.cbCreateur,
                cbModification = x.cbModification,
                cbReplication = x.cbReplication,
                cbFlag = x.cbFlag,
                cbCreation = x.cbCreation,
                cbCreationUser = x.cbCreationUser
            }).Where(catal => catal.CL_No == id).FirstOrDefault();
        }
    }
}
