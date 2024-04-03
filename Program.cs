using System;
using System.Collections.Generic;
using System.Linq;

namespace AC1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string Title = "- - - Intergalactic Exploration Missions - - -";
            const string MsgError = "Format incorrecte, torna a introduir el valor";
            int count = 1;
            string player;
            string mission;
            int scoring;

            Console.WriteLine(Title);
            Console.WriteLine();

            // Llista de Score
            List<Score> scores = new List<Score>();

            // Demanar nom, missió i puntuació dels 10 jugadors
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Introdueix el nom del jugador {count}");
                player = Console.ReadLine();
                Console.WriteLine();
                    while (!Helper.PlayerIsValid(player)) // Validar jugador
                    {
                        Console.WriteLine(MsgError);
                        player = Console.ReadLine();
                        Console.WriteLine();
                    }

                Console.WriteLine("Introdueix el nom de la missió: ");
                mission = Console.ReadLine();
                Console.WriteLine();
                    while (!Helper.MissionIsValid(mission)) // Validar missió
                    {
                        Console.WriteLine(MsgError);
                        mission = Console.ReadLine();
                        Console.WriteLine();
                    }

                Console.WriteLine("Introdueix la puntuació: "); 
                scoring = int.Parse(Console.ReadLine());
                Console.WriteLine();               
                    while (!Helper.ScoringIsValid(scoring)) // Validar puntuació
                    {
                        Console.WriteLine(MsgError);
                        scoring = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                    }

                // Afegir a la llista de puntuacions
                scores.Add(new Score(player, mission, scoring)); 
                count++;
                Console.WriteLine();
            }

            // Mostrar la llista de puntuacions
            Console.WriteLine("Llista de puntuacions:");
            Console.WriteLine();
            foreach (Score item in scores)
            {
                Console.WriteLine($"Jugador: {item.Player}\nMissió: {item.Mission}\nPuntuació: {item.Scoring}");
                Console.WriteLine();
            }
            Console.WriteLine();

            // Mostrar ranking de puntuacions úniques
            Console.WriteLine("Ranking de puntuacions úniques:");
            Console.WriteLine();
            Helper.GenerateUniqueRanking(scores);
        }
    }
}
