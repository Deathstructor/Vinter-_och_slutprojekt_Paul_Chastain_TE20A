using Raylib_cs;
using System.Numerics;

// Denna klass ser till att registrera skada. Den kollar om en bomb
// träffar en fiende, och om den gör det så tas fienden och bomben bort.
public class Damage
{
    public static void Kill()
    {
        for (var i = 0; i < Player.bombs.Count; i++)
        {
            for (var j = Enemy.spawnedEnemies.Count - 1; j >= 0; j--)
            {
                // Kollar om en bomb och en fiende kolliderar med varandra.
                if (Raylib.CheckCollisionCircleRec(new Vector2(Player.bombs[i].PosX, Player.bombs[i].PosY), Player.bombs[i].Size, Enemy.spawnedEnemies[j].enemyHitbox))
                {
                    if (Enemy.spawnedEnemies[j].isDart == false)
                    {
                        Player.Score += 5; // Lägger till poäng för att ha dödat en submarine.
                    }
                    else if (Enemy.spawnedEnemies[j].isDart == true)
                    {
                        Player.Score += 15; // Lägger till poäng för att ha dödat en dart.
                    }

                    Enemy.spawnedEnemies.RemoveAt(j); // Tar bort fienden
                    Player.bombs.RemoveAt(i); // Tar bort bomben
                    Console.WriteLine($"Deleted [{j}]");
                    Enemy.CurrentAmount--;
                    j = 0; // Sätter j på 0 så att den inte får tal som är större än listans index när en fiende tas bort.
                }
            }
        }
    }
}
