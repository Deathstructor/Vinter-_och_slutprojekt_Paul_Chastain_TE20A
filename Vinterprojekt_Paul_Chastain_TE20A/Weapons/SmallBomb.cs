using Raylib_cs;

public class SmallBomb : Weapon
{
    public SmallBomb(int bombX)
    {
        speed = 2;
        size = 4;
        posX = bombX + 50;
    }

    // Ritar ut den lilla bomben
    public override void Draw()
    {
        base.Draw();
        Raylib.DrawCircle(posX, posY, size, Color.RED);

        posY++;
        return;
    }
}
