using SoftCaisse.DTO;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Repositories.BIJOU
{
    internal class ListeEcheancesPourImpressionDocumentsDeVenteRepository
    {
        private readonly AppDbContext _context;
        public ListeEcheancesPourImpressionDocumentsDeVenteRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<ListeEcheancesPourImpressionDocumentsDeVente> ListerEcheancesImpressionDocVente(string CT_Num, string DO_Piece)
        {
            // Déclaration de la requête SQL brute avec un paramètre
            string query = @"
                WITH CTE_Requete1 AS (
                    SELECT
                        DR_No,
                        SUM(RC_Montant) AS Total_RC_Montant
                    FROM
                        BIJOU.dbo.F_REGLECH
                    GROUP BY
                        DR_No
                )
                
                SELECT
                    F_DOCREGL.DR_Date AS DR_Date,
                
                    -- Calcul de A_Payer
                    CASE
                        WHEN F_DOCREGL.DR_Pourcent = 0 THEN 
                            F_DOCENTETE.DO_NetAPayer - SUM(F_DOCREGL.DR_Pourcent * F_DOCENTETE.DO_NetAPayer / 100) 
                            OVER (PARTITION BY F_DOCREGL.DO_Piece)
                        ELSE 
                            F_DOCREGL.DR_Pourcent * F_DOCENTETE.DO_NetAPayer / 100
                    END AS A_Payer
                
                FROM F_DOCREGL
                INNER JOIN F_DOCENTETE ON F_DOCREGL.DO_Piece = F_DOCENTETE.DO_Piece
                LEFT JOIN CTE_Requete1 ON F_DOCREGL.DR_No = CTE_Requete1.DR_No
                
                WHERE 
                    F_DOCENTETE.CT_NumPayeur = @NumPayeur
                    AND (F_DOCENTETE.DO_Type = 7 OR F_DOCENTETE.DO_Type = 6)
                    AND F_DOCREGL.DO_Piece = @DO_Piece -- Condition sur DO_Piece
                
                GROUP BY
                    F_DOCREGL.DR_Date,
                    F_DOCREGL.DO_Piece,
                    F_DOCENTETE.CT_NumPayeur,
                    F_DOCREGL.DR_No,
                    F_DOCREGL.DR_Pourcent,
                    F_DOCENTETE.DO_NetAPayer,
                    CTE_Requete1.Total_RC_Montant
            ";

            // Définition du paramètre SQL
            var param1 = new SqlParameter("@NumPayeur", CT_Num);
            var param2 = new SqlParameter("@DO_Piece", DO_Piece);

            // Exécution de la requête SQL avec le paramètre
            var result = _context.Database
                .SqlQuery<ListeEcheancesPourImpressionDocumentsDeVente>(query, param1, param2)
                .ToList();

            return result;
        }
    }
}
