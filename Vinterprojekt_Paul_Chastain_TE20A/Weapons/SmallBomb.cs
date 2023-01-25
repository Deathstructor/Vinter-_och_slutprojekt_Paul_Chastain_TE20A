using Raylib_cs;

public class SmallBomb : Weapon
{
    protected SmallBomb()
    {
        speed = 2;
        size = 2;
        posY = 100;
    }

    public static void Draw()
    {
        Raylib.BeginDrawing();
        Raylib.DrawCircle(Player.pos, posY, size, Color.RED);
        Raylib.EndDrawing();

        posY++;
        return;
    }
}
