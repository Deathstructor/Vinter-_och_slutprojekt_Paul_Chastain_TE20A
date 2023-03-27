using Raylib_cs;

public class SmallBomb : Weapon
{
    public SmallBomb(int bombX)
    {
        Speed = 3;
        Size = 4;
        PosX = bombX + 50;
    }

    // Ritar ut den lilla bomben
    public override void Draw()
    {
        base.Draw();
        Raylib.DrawCircle(PosX, PosY, Size, Color.RED);

        PosY += Speed;
        return;
    }
}
