using Raylib_cs;

public class MainGame : LoadScreen
{
    public void Game()
    {
        Player p = new();
        Enemy e = new();

        while (true)
        {
            p.Movement();

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.SKYBLUE);
            Raylib.DrawRectangle(0, 100, 700, 800, Color.DARKBLUE);

            Raylib.DrawTexture(p.boat, p.playerPos, 0, Color.WHITE);
            
            e.Render();
            Raylib.EndDrawing();

            // if (Enemy.currentAmount <  Enemy.maxAmount)
            // {
                
            // }

            // if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
            // {
            //     e = new();
            // }
        }




    }
}
