using Raylib_cs;

public class BigBomb : Weapon
{
    public int posY { get; set; } = 100;

    protected BigBomb()
    {
        speed = 1;
        size = 10;
    }

    protected void Draw()
    {
        Raylib.BeginDrawing();
        Raylib.DrawCircle(Player.pos, posY, size, Color.RED);
        Raylib.EndDrawing();
    }
}
