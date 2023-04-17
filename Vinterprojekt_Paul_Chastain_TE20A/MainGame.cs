using System;
using Raylib_cs;

public static class MainGame
{
    public static void Game()
    {
        Player p = new();
        Enemy e = new();
        SubmarineClass s = new();
        DartClass d = new();
        HUD h = new();

        Random dartSpawnChance = new Random();

        Enemy.CurrentAmount = 0;
        Player.Score = 0;

        while (true)
        {
            p.Update(); // Spelarens rörelse och bomber / vapen
            Damage.Kill(); // Dödar fienden om man träffar

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.SKYBLUE);
            Raylib.DrawRectangle(0, 100, 700, 800, Color.DARKBLUE);

            h.headsUpDisplay(); // En HUD med information.
            Raylib.DrawTexture(p.boat, Player.Pos, 0, Color.WHITE); // Ritar ut spelaren/båten

            // Kollar om antalet fiender har nått max antal fiender och lägger till fiender så
            // länge antelet fiender inte har nått max antal fiender.
            if (Enemy.CurrentAmount < Enemy.MaxAmount)
            {
                Enemy.CurrentAmount++;
                if (dartSpawnChance.Next(4) == 0) { Enemy.spawnedEnemies.Add(d = new()); }
                else { Enemy.spawnedEnemies.Add(s = new()); }
                Console.WriteLine(Enemy.spawnedEnemies.Count);
            }

            // Renderar varje fiende i listan med fiender och kollar var varje fiende befinner sig.
            // Om en fiende åker för långt utaför skärmen tas den bort, vilket kommer leda till att
            // en ny fiende skapas istället.
            if (Enemy.spawnedEnemies.Count > 0)
            {
                DartClass.spawnedEnemies[0].Render();

                if (Enemy.spawnedEnemies[0].Pos < -210 || Enemy.spawnedEnemies[0].Pos > 910)
                {
                    Enemy.spawnedEnemies.RemoveAt(0);
                    Console.WriteLine("Deleted [0]");
                    Enemy.CurrentAmount--;
                }
            }
            if (Enemy.spawnedEnemies.Count > 1)
            {
                SubmarineClass.spawnedEnemies[1].Render();

                if (Enemy.spawnedEnemies[1].Pos < -210 || Enemy.spawnedEnemies[1].Pos > 910)
                {
                    Enemy.spawnedEnemies.RemoveAt(1);
                    Console.WriteLine("Deleted [1]");
                    Enemy.CurrentAmount--;
                }
            }
            if (Enemy.spawnedEnemies.Count > 2)
            {
                SubmarineClass.spawnedEnemies[2].Render();

                if (Enemy.spawnedEnemies[2].Pos < -210 || Enemy.spawnedEnemies[2].Pos > 910)
                {
                    Enemy.spawnedEnemies.RemoveAt(2);
                    Console.WriteLine("Deleted [2]");
                    Enemy.CurrentAmount--;
                }
            }

            p.DrawBombs(); // Ritar ut bomberna

            // Går tillbaka till huvudmenyn om man trycker på ESC (tanken är att senare fixa en pausmeny när man trycker på ESC)
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_ESCAPE))
            {
                return;
            }

            Raylib.EndDrawing();
        }
    }
}
