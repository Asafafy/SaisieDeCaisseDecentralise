using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Repositories.BIJOU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Services
{
    internal class F_DOCREGLService
    {
        // ==========================================================================================================================================================================
        // ==================================================================== DEBUT DECLARATION DES VARIABLES =====================================================================
        // ==========================================================================================================================================================================
        private readonly F_DOCREGLRepository _f_DOCREGLRepository;
        private readonly F_DOCENTETEService _f_DOCENTETEService;
        // ==========================================================================================================================================================================
        // ===================================================================== FIN DECLARATION DES VARIABLES ======================================================================
        // ==========================================================================================================================================================================









        // ==========================================================================================================================================================================
        // ========================================================================== DEBUT CONSTRUCTEUR ============================================================================
        // ==========================================================================================================================================================================
        public F_DOCREGLService(F_DOCREGLRepository f_DOCREGLRepository, F_DOCENTETEService f_DOCENTETEService)
        {
            _f_DOCREGLRepository = f_DOCREGLRepository;
            _f_DOCENTETEService = f_DOCENTETEService;
        }
        // ==========================================================================================================================================================================
        // ============================================================================ FIN CONSTRUCTEUR ============================================================================
        // ==========================================================================================================================================================================













        public void InsertNewF_DOCREGL(List<F_DOCREGL> listeDocRegl, List<F_REGLEMENTT> listeReglT, string numPieceActu, List<F_COMPTET> listeClients, string typeDocu)
        {
            int? newDrNo = listeDocRegl.Max(element => element.DR_No);
            
            foreach (var reglT in listeReglT)
            {
                DateTime date = DateTime.Now.AddDays((double)reglT.RT_NbJour);
                if (reglT.RT_Condition == 0)
                {
                    List<short?> joursTb = new List<short?>
                    {
                        reglT.RT_JourTb01,
                        reglT.RT_JourTb02,
                        reglT.RT_JourTb03,
                        reglT.RT_JourTb04,
                        reglT.RT_JourTb05,
                        reglT.RT_JourTb06
                    };
                    joursTb.RemoveAll(x => x == 0);
                    if (joursTb.Count > 0)
                    {
                        int? nextDay = joursTb.Where(d => d >= date.Day).OrderBy(d => d).FirstOrDefault();
                        if (!nextDay.HasValue)
                            nextDay = joursTb.FirstOrDefault();
                        date = new DateTime(date.Year, date.Month, (int)nextDay);
                    }
                }
                else if (reglT.RT_Condition == 1)
                {
                    date = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
                    // Si le dernier jour du mois est un samedi, revenir au vendredi
                    if (date.DayOfWeek == DayOfWeek.Saturday)
                    {
                        date.AddDays(-1);
                    }
                    // Si le dernier jour du mois est un dimanche, revenir au vendredi
                    else if (date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        date.AddDays(-2);
                    }
                }
                else
                {
                    date = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
                }
                newDrNo++;
                F_DOCREGL newDocRegl = new F_DOCREGL
                {
                    DR_No = newDrNo,
                    DO_Domaine = 0,
                    DO_Type = 6,
                    DO_Piece = numPieceActu,
                    DR_TypeRegl = 2,
                    DR_Date = date,
                    DR_Libelle = "",
                    DR_Pourcent = reglT.RT_VRepart,
                    DR_Montant = 0,
                    DR_MontantDev = 0,
                    DR_Equil = 1,
                    EC_No = 0,
                    cbEC_No = 0,
                    DR_Regle = 0,
                    N_Reglement = 1,
                    CA_No = 3,
                    DO_DocType = (short?)_f_DOCENTETEService.GetDocTypeNo(typeDocu),
                    cbCreateur = "COLS",
                    DR_RefPaiement = null,
                    DR_AdressePaiement = "",
                };
                _f_DOCREGLRepository.Add(newDocRegl);
            }
        }





        public void SupprimerDocumentsDesReglements(List<F_DOCREGL> f_DOCREGLs)
        {
            foreach (F_DOCREGL f_DOCREGL in f_DOCREGLs)
            {
                _f_DOCREGLRepository.DeleteByDoPiece(f_DOCREGL.DO_Piece);
            }
        }









    }
}
