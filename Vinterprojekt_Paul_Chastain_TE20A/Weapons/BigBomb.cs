using Raylib_cs;

public class BigBomb : Weapon
{
    protected BigBomb()
    {
        speed = 1;
        size = 10;
        posY = 100;
    }

    public static void Draw()
    {
        Raylib.BeginDrawing();
        Raylib.DrawCircle(Player.pos, posY, size, Color.RED);
        Raylib.EndDrawing();

        posY++;
    }
}
