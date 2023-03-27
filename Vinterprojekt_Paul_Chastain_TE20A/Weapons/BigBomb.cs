using Raylib_cs;

public class BigBomb : Weapon
{
    public BigBomb(int bombX)
    {
        Speed = 1;
        Size = 10;
        PosX = bombX + 50;
    }

    // Ritar ut den stora bomben
    public override void Draw()
    {
        base.Draw();
        Raylib.DrawCircle(PosX, PosY, Size, Color.RED);
        PosY += Speed;
    }
}
