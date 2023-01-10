using Raylib_cs;

public class MainGame
{
    Image boat = Raylib.LoadImage(@"Images/deep_scan_boat.png");

    public void Game()
    {
        while (true)
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.SKYBLUE);
            Raylib.DrawRectangle(0, 100, 700, 800, Color.DARKBLUE);

            Raylib.ImageDrawRectangle(ref boat, Raylib.GetScreenWidth() / 2 - 25, 50, 50, 50, Color.WHITE);

            Raylib.EndDrawing();


            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT))
            {
                return;
            }
        }
    }
}
