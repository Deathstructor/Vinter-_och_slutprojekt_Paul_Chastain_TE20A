using Raylib_cs;

public class SmallBomb : Weapon
{
    public SmallBomb(int bombX)
    {
        Speed = 2;
        Size = 4;
        PosX = bombX + 50;
    }

    // Ritar ut den lilla bomben
    public override void Draw()
    {
        base.Draw();
        Raylib.DrawCircle(PosX, PosY, Size, Color.RED);

        PosY++;
        return;
    }
}
