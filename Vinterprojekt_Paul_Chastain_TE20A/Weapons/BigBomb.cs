using Raylib_cs;

public class BigBomb : Weapon
{
    public BigBomb(int bombX)
    {
        speed = 1;
        size = 10;
        bombX = posX + 50;
    }

    // Ritar ut den stora bomben
    public override void Draw()
    {
        base.Draw();
        Raylib.DrawCircle(Player.pos, posY, size, Color.RED);
        posY++;
    }
}
