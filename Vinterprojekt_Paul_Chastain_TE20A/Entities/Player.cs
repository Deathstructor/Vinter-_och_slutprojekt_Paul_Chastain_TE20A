using Raylib_cs;

public class Player
{
    public static int Pos { get; set; } = Raylib.GetScreenWidth() / 2 - 50;
    public static int Score { get; set; }
    public Texture2D boat;

    public static List<Weapon> bombs = new();

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
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && Pos > 0)
        {
            Pos--;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && Pos < Raylib.GetScreenWidth() - 100)
        {
            Pos++;
        }

        // Kollar om man har tryckt på 1 eller två för att välja vapen / bomb.
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE)) Weapon.IsBig = false;
        else if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO)) Weapon.IsBig = true;

        // Ritar ut en bomb om man trycker på mellanslag och lägger till den i listan "bombs".
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
        {
            if (Weapon.IsBig == false)
            {
                bombs.Add(new SmallBomb(Pos));
            }
            else if (Weapon.IsBig == true)
            {
                bombs.Add(new BigBomb(Pos));
            }
        }
    }

    // Funktion för att rita ut bomber
    public void DrawBombs()
    {
        if (bombs is null || bombs.Count == 0) return;

        foreach(Weapon b in bombs)
        {
            b.Draw();
        }
    }
}
