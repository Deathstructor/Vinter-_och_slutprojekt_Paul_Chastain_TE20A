using Raylib_cs;

public class MainGame
{
    public void Game()
    {
        while (true)
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.SKYBLUE);


            Raylib.EndDrawing();
            Raylib.DrawText("TEST", Raylib.GetScreenWidth() / 2 - 260, 125, 100, Color.RED);

            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT))
            {
                return;
            }
        }
    }
}
