using Raylib_cs;

public class MainGame
{
    public void Game()
    {
        Player player = new();

        while (true)
        {
            player.Movement();

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.SKYBLUE);
            Raylib.DrawRectangle(0, 100, 700, 800, Color.DARKBLUE);

            Raylib.DrawTexture(player.boat, player.playerPos, 0, Color.WHITE);

            Raylib.EndDrawing();


            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT))
            {
                return;
            }
        }
    }
}
