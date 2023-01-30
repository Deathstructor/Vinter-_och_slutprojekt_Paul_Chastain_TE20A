using Raylib_cs;

public class Weapon
{
    protected int posX { get; set; }
    protected int posY { get; set; } = 100;
    protected int speed { get; set; }
    protected int size { get; set; }
    public static bool isBig { get; set; }

    public virtual void Draw()
    {
        posY++;
    }
}
