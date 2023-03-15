using Raylib_cs;

public class Player
{
    public static int pos { get; set; } = Raylib.GetScreenWidth() / 2 - 50;
    public Texture2D boat;

    public Weapon weapon;

    public Player()
    {
        // Skapar bilden för spelaren / båten och renderar den i spelet.
        Image boatIMG = Raylib.LoadImage(@"Images/boat.png");
        Raylib.ImageResize(ref boatIMG, 100, 100);
        boat = Raylib.LoadTextureFromImage(boatIMG);
        Raylib.UnloadImage(boatIMG);
    }

    // Förflyttar spelaren till höger eller vänster beroende på om man trycker på A eller D.
    public void Movement()
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && pos > 0)
        {
            pos--;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && pos < Raylib.GetScreenWidth() - 100)
        {
            pos++;
        }

        // Kollar om man har tryckt på 1 eller två för att välja vapen / bomb.
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE)) Weapon.isBig = false;
        else if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO)) Weapon.isBig = true;

        // Ritar ut en bomb om man trycker på mellanslag.
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
        {
            if (Weapon.isBig == false) weapon = new SmallBomb(pos);
            else if (Weapon.isBig == true) weapon = new BigBomb(pos);
        }
    }
}
