using Raylib_cs;

public class Weapon
{
    public int speed { get; set; }
    public int size { get; set; }
    public bool isBig { get; set; }

    public static void Render()
    {
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_KP_1)) isBig = false;

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
        {
            
        }
    }
}
