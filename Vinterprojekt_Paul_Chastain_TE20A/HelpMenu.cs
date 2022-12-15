using Raylib_cs;

public class HelpMenu
{
    LoadScreen l = new();

    public void HelpScreen()
    {
        while (!Raylib.WindowShouldClose() && l.help == true)
        {
            Raylib.BeginDrawing();
            
            Raylib.EndDrawing();
        }
    }
}
