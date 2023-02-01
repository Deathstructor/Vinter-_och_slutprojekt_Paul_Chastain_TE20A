using Raylib_cs;

public class BigBomb : Weapon
{
    public BigBomb(int bombX)
    {
        speed = 1;
        size = 10;
        posX = bombX + 50;
    }

    // Ritar ut den stora bomben
    public override void Draw()
    {
        base.Draw();
        Raylib.DrawCircle(posX, posY, size, Color.RED);
        posY++;
    }
}
