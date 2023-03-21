using Raylib_cs;

public class Player
{
    public static int pos { get; set; } = Raylib.GetScreenWidth() / 2 - 50;
    public Texture2D boat;

    public Weapon weapon;

    List<Weapon> bombs = new();

    public Player()
    {
        // Skapar bilden för spelaren / båten och renderar den i spelet.
        Image boatIMG = Raylib.LoadImage(@"Images/boat.png");
        Raylib.ImageResize(ref boatIMG, 100, 100);
        boat = Raylib.LoadTextureFromImage(boatIMG);
        Raylib.UnloadImage(boatIMG);
    }

    // Förflyttar spelaren till höger eller vänster beroende på om man trycker på A eller D.
    // Skjuter även bomber om man trycker på mellanslag.
    public void Update()
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

        // Ritar ut en bomb om man trycker på mellanslag och lägger till den i listan "bombs".
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
        {
            if (Weapon.isBig == false)
            {
                bombs.Add(new SmallBomb(pos));
            }
            else if (Weapon.isBig == true)
            {
                bombs.Add(new BigBomb(pos));
            }
        }

        // for (var i = 0; i < bombs.Count; i++)
        // {
        //     if (bombs[i].posY > Raylib.GetScreenHeight() + 50)
        //     {
        //         bombs.RemoveAt(i);
        //     }
        // }
    }

    public void DrawBombs()
    {
        if (bombs is null || bombs.Count == 0) return;

        foreach(Weapon b in bombs)
        {
            b.Draw();
        }
    }
}
