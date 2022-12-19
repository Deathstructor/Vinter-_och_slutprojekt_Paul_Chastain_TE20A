using Raylib_cs;

public class HelpMenu
{
    public void HelpScreen()
    {
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.SKYBLUE);

            Raylib.DrawText("Help", Raylib.GetScreenWidth() / 2 - 260, 125, 100, Color.RED);

            Raylib.EndDrawing();
        }
    }
}
