using Raylib_cs;

public class MainGame : LoadScreen
{
    public void Game()
    {
        Player p = new();
        Enemy e = new();

        List<Enemy> spawnedEnemies = new();

        while (true)
        {
            p.Movement();

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.SKYBLUE);
            Raylib.DrawRectangle(0, 100, 700, 800, Color.DARKBLUE);

            Raylib.DrawTexture(p.boat, p.playerPos, 0, Color.WHITE);

            if (Enemy.currentAmount <  Enemy.maxAmount)
            {
                Enemy.currentAmount++;
                spawnedEnemies.Add(e = new());
                Console.WriteLine(spawnedEnemies.Count);
            }

            if (spawnedEnemies.Count > 0) 
            {
                spawnedEnemies[0].Render();

                if (spawnedEnemies[0].pos < -210 || spawnedEnemies[0].pos > 910)
                {
                    spawnedEnemies.RemoveAt(0);
                    Console.WriteLine("deleted");
                    Enemy.currentAmount--;
                }
            }
            if (spawnedEnemies.Count > 1) 
            {
                spawnedEnemies[1].Render();

                if (spawnedEnemies[1].pos < -210 || spawnedEnemies[1].pos > 910)
                {
                    spawnedEnemies.RemoveAt(1);
                    Console.WriteLine(spawnedEnemies.Count);
                    Enemy.currentAmount--;
                }
            }
            if (spawnedEnemies.Count > 2) 
            {
                spawnedEnemies[2].Render();

                if (spawnedEnemies[2].pos < -210 || spawnedEnemies[2].pos > 910)
                {
                    spawnedEnemies.RemoveAt(2);
                    Console.WriteLine(spawnedEnemies.Count);
                    Enemy.currentAmount--;
                }
            }
            
            
            Raylib.EndDrawing();

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
            {
                e = new();
            }
        }
    }
}
