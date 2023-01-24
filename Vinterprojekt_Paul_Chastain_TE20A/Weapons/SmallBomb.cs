using Raylib_cs;

public class SmallBomb : Weapon
{
    public int posY { get; set; } = 100;

    protected SmallBomb()
    {
        speed = 2;
        size = 2;
    }

    protected void Draw()
    {
        Raylib.BeginDrawing();
        Raylib.DrawCircle(Player.pos, posY, size, Color.RED);
        Raylib.EndDrawing();
    }
}
