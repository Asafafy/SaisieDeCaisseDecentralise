using SoftCaisse.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SoftCaisse.Repositories.ScdDb
{
    internal class RoleRepository
    {
        // =============================================================================
        // DEBUT DECLARATION DES VARIABLES =============================================
        // =============================================================================
        //private readonly SCDContext _scdContext;
        // =============================================================================
        // FIN DECLARATION DES VARIABLES ===============================================
        // =============================================================================










        // =============================================================================
        // DEBUT CONSTRUCTEUR ==========================================================
        // =============================================================================
        public RoleRepository(SCDContext scdContext)
        {
            //_scdContext = new SCDContext();
        }
        // =============================================================================
        // DEBUT CONSTRUCTEUR ==========================================================
        // =============================================================================










        // =============================================================================
        // DEBUT GET ===================================================================
        // =============================================================================
        public async Task<List<Role>> GetAll()
        {
            using (SCDContext scdContext = new SCDContext())
            {
                return await scdContext.Role.ToListAsync();
            }
        }



        public async Task<Role> GetById(int IdRole)
        {
            using (SCDContext scdContext = new SCDContext())
            {
                return await scdContext.Role.Where(r => r.IdRole == IdRole).FirstOrDefaultAsync();
            }
        }



        public async Task<Role> GetRoleBy_RoleIntitule(string roleIntitule)
        {
            using (SCDContext scdContext = new SCDContext())
            {
                Role role = await scdContext.Role.Where(r => r.RoleIntitule == roleIntitule).FirstOrDefaultAsync();
                return role;
            }
        }



        public async Task<List<int>> GetUsersNumber()
        {
            using (SCDContext scdContext = new SCDContext())
            {
                return await scdContext.Role.GroupJoin(
                    scdContext.Users.Where(user => user.EstActif == 1),
                    role => role.IdRole,
                    user => user.RoleId,
                    (r, users) => users.Count()
                ).ToListAsync();
            }
        }
        // =============================================================================
        // FIN GET =====================================================================
        // =============================================================================










        // =============================================================================
        // DEBUT ADD ===================================================================
        // =============================================================================
        public async void Add(string RoleIntitule)
        {
            using (SCDContext scdContext = new SCDContext())
            {
                string query = @"
                    INSERT INTO [ScdDb].[dbo].[Role] (RoleIntitule)
                    VALUES (@RoleIntitule);
                ";

                await scdContext.Database.ExecuteSqlCommandAsync(
                    query,
                    new SqlParameter("@RoleIntitule", RoleIntitule)
                );
            }
        }
        // =============================================================================
        // FIN ADD =====================================================================
        // =============================================================================










        // =============================================================================
        // DEBUT DELETE ================================================================
        // =============================================================================
        public async void Delete(int id)
        {
            string queryDeleteRole = @"
                DELETE FROM [ScdDb].[dbo].[Role] WHERE IdRole = @IdRole;
            ";

            using (SCDContext scdContext = new SCDContext())
            {
                await scdContext.Database.ExecuteSqlCommandAsync(
                    queryDeleteRole,
                    new SqlParameter("@IdRole", id)
                );
            } 
        }
        // =============================================================================
        // FIN DELETE ==================================================================
        // =============================================================================












        // =============================================================================
        // DEBUT UPDATE ================================================================
        // =============================================================================
        public async void Update(Role entity)
        {
            string queryUpdate = @"
                        UPDATE [ScdDb].[dbo].[Role]
				        SET
				        	RoleIntitule = @RoleIntitule
				        WHERE IdRole = @IdRole;
                    ";
            using (SCDContext scdContext = new SCDContext())
            {
                await scdContext.Database.ExecuteSqlCommandAsync(
                    queryUpdate,
                    new SqlParameter("@RoleIntitule", entity.RoleIntitule),
                    new SqlParameter("@IdRole", entity.IdRole)
                );
            }
        }
        // =============================================================================
        // FIN UPDATE ==================================================================
        // =============================================================================


    }
}
