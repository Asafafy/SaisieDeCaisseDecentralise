using SoftCaisse.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace SoftCaisse.Repositories.ScdDb
{
    internal class AutorisationRepository : IRepository<Autorisation>
    {
        private readonly string _cheminVersAuthJson;
        private readonly SCDContext _scdContext;

        public AutorisationRepository(SCDContext scdContext)
        {
            _scdContext = scdContext;
            _cheminVersAuthJson = "E:\\Softwell\\SCDJNM\\SoftCaisse\\DataJSon\\Autorisation.json";
        }





        // ==================================================================================================================
        // ============================================== Méthodes IRepository ==============================================
        public void Add(Autorisation entity)
        {
            List<Autorisation> listeAuth = GetAll();
            Create(listeAuth, entity);
            SaveData(listeAuth);
        }

        public void Delete(int id)
        {
            List<Autorisation> listAuth = GetAll();
            DeleteAuthFromAuths(listAuth, id);
            SaveData(listAuth);
        }

        public List<Autorisation> GetAll()
        {
            List<Autorisation> listAuth = JsonSerializer.Deserialize<List<Autorisation>>(File.ReadAllText(_cheminVersAuthJson));
            return listAuth;
        }

        public Autorisation GetById(int id)
        {
            List<Autorisation> listAuth = GetAll();
            Autorisation auth = Read(listAuth, id);
            return auth;
        }

        public void Update(Autorisation entity)
        {
            List<Autorisation> listAuth = GetAll();
            Autorisation auth = listAuth.Where(a => a.Id == entity.Id).FirstOrDefault();
            Update(listAuth, entity.Id, entity.Autorisations);
            SaveData(listAuth);
        }
        // ============================================== Méthodes IRepository ==============================================
        // ==================================================================================================================





        // ==================== Autres méthodes ===================
        public int GetRubriqueAuth(Autorisation auth, string nodeName)
        {
            int index = 0;
            int estautorise = 0;
            while (index < 29)
            {
                if (index.ToString() == nodeName)
                {
                    estautorise = auth.Autorisations[index];
                }
                index++;
            }
            return estautorise;
        }
        public int GetMaxId()
        {
            List<Autorisation> auth = GetAll();
            int maxId = auth.Max(e => e.Id);
            return maxId;
        }
        // ==================== Autres méthodes ===================





        // =================================================================
        // ========================= Méthodes CRUD =========================
        static void Create(List<Autorisation> elements, Autorisation newElement)
        {
            elements.Add(newElement);
        }
        static Autorisation Read(List<Autorisation> elements, int id)
        {
            return elements.Find(e => e.Id == id);
        }

        static void Update(List<Autorisation> elements, int id, List<int> newAutorisations)
        {
            var element = elements.Find(e => e.Id == id);
            if (element != null)
            {
                element.Autorisations = newAutorisations;
            }
        }

        static void DeleteAuthFromAuths(List<Autorisation> elements, int id)
        {
            var element = elements.Find(e => e.Id == id);
            if (element != null)
            {
                elements.Remove(element);
            }
        }
        // ========================= Méthodes CRUD =========================
        // =================================================================





        // =============================================================================================================
        // ========================== Fonctions en intéractions directes avec le fichier JSON ==========================
        public List<Autorisation> LoadData()
        {
            if (File.Exists(_cheminVersAuthJson))
            {
                string json = File.ReadAllText(_cheminVersAuthJson);
                return JsonSerializer.Deserialize<List<Autorisation>>(json);
            }
            return new List<Autorisation>();
        }

        public void SaveData(List<Autorisation> autorisations)
        {
            string json = JsonSerializer.Serialize(autorisations, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_cheminVersAuthJson, json);
        }
        // ========================== Fonctions en intéractions directes avec le fichier JSON ==========================
        // =============================================================================================================
    }
}
