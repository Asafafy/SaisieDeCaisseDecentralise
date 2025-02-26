using Microsoft.SqlServer.Server;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace SoftCaisse.Repositories.ScdDb
{
    internal class RoleAutorisationRepository
    {
        // ======================================================================================
        // DECLARATION DES VARIABLES ============================================================
        // ======================================================================================
        private readonly SCDContext _scdContext;
        // ======================================================================================
        // FIN DECLARATION DES VARIABLES ========================================================
        // ======================================================================================









        // ======================================================================================
        // DEBUT CONSTRUCTEUR ===================================================================
        // ======================================================================================
        public RoleAutorisationRepository()
        {
            _scdContext = new SCDContext();
        }
        // ======================================================================================
        // FIN CONSTRUCTEUR =====================================================================
        // ======================================================================================










        // ======================================================================================
        // DEBUT GET ============================================================================
        // ======================================================================================
        public async Task<RoleAutorisation> Get_RoleAutorisation_By_IdRubrique_And_IdRole(int IdRubrique, int? IdRole)
        {
            using (SCDContext scdContext = new SCDContext())
            {
                return await scdContext.RoleAutorisation.Where(rlAuth => rlAuth.IdRubrique == IdRubrique && rlAuth.IdRole == IdRole).FirstOrDefaultAsync();
            }
        }



        public async Task<List<RoleAutorisation>> Get_List_RoleAutorisation_By_IdRole(int? IdRole)
        {
            using (SCDContext scdContext = new SCDContext())
            {
                return await scdContext.RoleAutorisation.Where(roleAuth => roleAuth.IdRole == IdRole).ToListAsync();
            }
        }
        // ======================================================================================
        // FIN GET ==============================================================================
        // ======================================================================================










        // ======================================================================================
        // DEBUT ADD ============================================================================
        // ======================================================================================
        public async void Add(RoleAutorisation entity)
        {
            using (SCDContext scdContext = new SCDContext())
            {
                scdContext.RoleAutorisation.Add(entity);
                await scdContext.SaveChangesAsync();
            }
        }
        // ======================================================================================
        // FIN ADD ==============================================================================
        // ======================================================================================










        // ======================================================================================
        // DEBUT UPDATE =========================================================================
        // ======================================================================================
        public async void Update(RoleAutorisation entity)
        {
            string queryUpdate = @"
                    UPDATE [ScdDb].[dbo].[RoleAutorisation]
                    SET
                        IdRole = @IdRole,
                        EstAutorise = @EstAutorise
                    WHERE Id = @Id;
                ";

            using (SCDContext scdContext = new SCDContext())
            {
                await scdContext.Database.ExecuteSqlCommandAsync(
                    queryUpdate,
                    new SqlParameter("@IdRole", entity.IdRole ?? (object)DBNull.Value),
                    new SqlParameter("@EstAutorise", entity.EstAutorise),
                    new SqlParameter("@Id", entity.Id)
                );
            }
        }
        // ======================================================================================
        // FIN UPDATE ===========================================================================
        // ======================================================================================










        // ======================================================================================
        // DEBUT DELETE =========================================================================
        // ======================================================================================
        public async void Delete(int id)
        {
            string queryDeleteRoleAutorisation = @"
                DELETE FROM [ScdDb].[dbo].[RoleAutorisation] WHERE Id = @Id;
            ";

            using (SCDContext scdContext = new SCDContext())
            {
                await scdContext.Database.ExecuteSqlCommandAsync(
                    queryDeleteRoleAutorisation,
                    new SqlParameter("@Id", id)
                );
            }
        }
        // ======================================================================================
        // FIN DELETE ===========================================================================
        // ======================================================================================









    }
}
