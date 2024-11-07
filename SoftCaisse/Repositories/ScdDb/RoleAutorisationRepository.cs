using SoftCaisse.Models;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories.ScdDb
{
    internal class RoleAutorisationRepository : IRepository<RoleAutorisation>
    {
        private readonly string _cheminVersAuthJson;
        private readonly SCDContext _scdContext;

        public RoleAutorisationRepository(SCDContext scdContext)
        {
            _scdContext = scdContext;
            _cheminVersAuthJson = "E:\\Softwell\\SCDJNM\\SoftCaisse\\DataJSon\\Autorisation.json";
        }





        // ==================================================================================================================
        // ============================================== Méthodes IRepository ==============================================
        public void Add(RoleAutorisation entity)
        {
            _scdContext.RoleAutorisation.Add(entity);
            _scdContext.SaveChanges();
        }

        public void Delete(int id)
        {
            RoleAutorisation roleAutToDelete = _scdContext.RoleAutorisation.Find(id);
            if (roleAutToDelete != null)
            {
                _scdContext.RoleAutorisation.Remove(roleAutToDelete);
                _scdContext.SaveChanges();
            }
        }

        public List<RoleAutorisation> GetAll()
        {
            return _scdContext.RoleAutorisation.ToList();
        }

        public RoleAutorisation GetById(int id)
        {
            return _scdContext.RoleAutorisation.Find(id);
        }

        public void Update(RoleAutorisation entity)
        {
            RoleAutorisation roleAutorisationToUpdate = _scdContext.RoleAutorisation.Find(entity.Id);
            roleAutorisationToUpdate.EstAutorise = entity.EstAutorise;
            _scdContext.SaveChanges();
        }
        // ============================================== Méthodes IRepository ==============================================
        // ==================================================================================================================



        // =================================================================================================================
        // TODO: =============================================== Mila fafana ===============================================
        //       ===========================================================================================================

        //// ==================== Autres méthodes ===================
        //public int GetRubriqueAuth(RoleAutorisation auth, string nodeName)
        //{
        //    int index = 0;
        //    int estautorise = 0;
        //    while (index < 29)
        //    {
        //        if (index.ToString() == nodeName)
        //        {
        //            estautorise = auth.Autorisations[index];
        //        }
        //        index++;
        //    }
        //    return estautorise;
        //}
        //// ==================== Autres méthodes ===================





        //// =================================================================
        //// ========================= Méthodes CRUD =========================
        //static void Create(List<RoleAutorisation> elements, RoleAutorisation newElement)
        //{
        //    elements.Add(newElement);
        //}
        //static RoleAutorisation Read(List<RoleAutorisation> elements, int id)
        //{
        //    return elements.Find(e => e.Id == id);
        //}

        //static void Update(List<RoleAutorisation> elements, int id, List<int> newAutorisations)
        //{
        //    var element = elements.Find(e => e.Id == id);
        //    if (element != null)
        //    {
        //        element.Autorisations = newAutorisations;
        //    }
        //}

        //static void DeleteAuthFromAuths(List<RoleAutorisation> elements, int id)
        //{
        //    var element = elements.Find(e => e.Id == id);
        //    if (element != null)
        //    {
        //        elements.Remove(element);
        //    }
        //}
        //// ========================= Méthodes CRUD =========================
        //// =================================================================





        //// =============================================================================================================
        //// ========================== Fonctions en intéractions directes avec le fichier JSON ==========================
        //public List<RoleAutorisation> LoadData()
        //{
        //    if (File.Exists(_cheminVersAuthJson))
        //    {
        //        string json = File.ReadAllText(_cheminVersAuthJson);
        //        return JsonSerializer.Deserialize<List<RoleAutorisation>>(json);
        //    }
        //    return new List<RoleAutorisation>();
        //}

        //public void SaveData(List<RoleAutorisation> autorisations)
        //{
        //    string json = JsonSerializer.Serialize(autorisations, new JsonSerializerOptions { WriteIndented = true });
        //    File.WriteAllText(_cheminVersAuthJson, json);
        //}
        //// ========================== Fonctions en intéractions directes avec le fichier JSON ==========================
        //// =============================================================================================================
    }
}
