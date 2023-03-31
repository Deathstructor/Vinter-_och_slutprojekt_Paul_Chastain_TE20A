using Raylib_cs;

public class HUD
{
    public void headsUpDisplay()
    {
        // Boxen längst ner på skärmen med all data
        Raylib.DrawRectangle(0, 800, 700, 100, Color.DARKBLUE);
        Raylib.DrawLine(0, 800, 700, 800, Color.WHITE);

        Raylib.DrawText($"Score: {Player.Score}", 50, 830, 50, Color.WHITE);
    }
}
