using Raylib_cs;

public class MainGame : LoadScreen
{
    public void Game()
    {
        Player p = new();
        Enemy e = new();

        List<Enemy> spawnedEnemies = new(); // En lista med alla fiender på skärmen

        while (true)
        {
            p.Movement(); // Spelarens rörelse

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.SKYBLUE);
            Raylib.DrawRectangle(0, 100, 700, 800, Color.DARKBLUE);

            Raylib.DrawTexture(p.boat, Player.pos, 0, Color.WHITE); // Ritar ut spelaren/båten

            // Kollar om antalet fiender har nått max antal fiender och lägger till fiender så
            // länge antelet fiender inte har nått max antal fiender.
            if (Enemy.currentAmount < Enemy.maxAmount)
            {
                Enemy.currentAmount++;
                spawnedEnemies.Add(e = new());
                Console.WriteLine(spawnedEnemies.Count);
            }

            // Renderar varje fiende i listan med fiender och kollar var varje fiende befinner sig.
            // Om en fiende åker för långt utaför skärmen tas den bort, vilket kommer leda till att
            // en ny fiende skapas istället.
            if (spawnedEnemies.Count > 0)
            {
                spawnedEnemies[0].Render();

                if (spawnedEnemies[0].pos < -210 || spawnedEnemies[0].pos > 910)
                {
                    spawnedEnemies.RemoveAt(0);
                    Console.WriteLine("Deleted [0]");
                    Enemy.currentAmount--;
                }
            }
            if (spawnedEnemies.Count > 1)
            {
                spawnedEnemies[1].Render();

                if (spawnedEnemies[1].pos < -210 || spawnedEnemies[1].pos > 910)
                {
                    spawnedEnemies.RemoveAt(1);
                    Console.WriteLine("Deleted [1]");
                    Enemy.currentAmount--;
                }
            }
            if (spawnedEnemies.Count > 2)
            {
                spawnedEnemies[2].Render();

                if (spawnedEnemies[2].pos < -210 || spawnedEnemies[2].pos > 910)
                {
                    spawnedEnemies.RemoveAt(2);
                    Console.WriteLine("Deleted [2]");
                    Enemy.currentAmount--;
                }
            }

            if (p.weapon != null) p.weapon.Draw();

            Raylib.EndDrawing();
        }
    }
}
