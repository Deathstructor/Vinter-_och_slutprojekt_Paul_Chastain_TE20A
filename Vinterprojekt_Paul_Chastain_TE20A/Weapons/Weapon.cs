using Raylib_cs;

public class Weapon
{
    protected int PosX { get; set; }
    public int PosY { get; set; } = 100;
    protected int Speed { get; set; }
    protected int Size { get; set; }
    public static bool IsBig { get; set; }

    public virtual void Draw()
    {
        PosY++;
    }
}
