using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AC1
{
    public static class Helper
    {
        // Validar player, només pot contenir caràcters alfabètics (sense accents ni caràcters especials)
        public static bool PlayerIsValid(string player)
        {
            string pattern = @"^[a-zA-Z]+$";
            return Regex.IsMatch(player, pattern);
        }

        // Validar mission, ha de contenir com prefix el nom adaptat de les consonnats en grec, seguit d'un guió i un número de 3 xifres
        public static bool MissionIsValid(string mission)
        {
            string pattern = @"^(alpha|beta|gamma|delta|epsilon|zeta|eta|theta|kappa|lambda|mu|nu|xi|omicron|pi|rho|sigma|tau|upsilon|phi|chi|psi|omega)-\d{3}$";
            return Regex.IsMatch(mission, pattern);
        }

        // Validar scoring, ha de ser un nombre entre 0 i 500 inclosos
        public static bool ScoringIsValid(int scoring)
        {
            return scoring >= 0 && scoring <= 500;
        }

        // Generar una llista amb les puntuacions úniques de cada jugador
        public static void GenerateUniqueRanking(List<Score> scores)
        {
            List<Score> uniqueScores = scores.Distinct().ToList();

            // Ordenar el rànking amb el comparer
            uniqueScores.Sort(new ScoreComparer());

            // Mostrar puntuacions úniques de cada jugador
            foreach (Score item in uniqueScores)
            {
                Console.WriteLine($"Jugador: {item.Player}, Missió: {item.Mission}, Puntuació: {item.Scoring}");
            }
        }
    }
}


// Correccions:
// Tomás Marta