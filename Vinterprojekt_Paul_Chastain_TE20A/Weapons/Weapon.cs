using Raylib_cs;

public class Weapon
{
    protected static int posY { get; set; }
    protected static int speed { get; set; }
    protected static int size { get; set; }
    private static bool isBig { get; set; }

    public Weapon()
    {
        if(Raylib.IsKeyPressed(KeyboardKey.KEY_KP_1)) isBig = false;
        if(Raylib.IsKeyPressed(KeyboardKey.KEY_KP_2)) isBig = true;

        if (isBig == false && Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE)) SmallBomb.Draw();
        if (isBig == true && Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE)) BigBomb.Draw();
    }
}
