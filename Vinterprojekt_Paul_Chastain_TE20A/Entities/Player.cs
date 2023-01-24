using Raylib_cs;

public class Player
{
    public static int pos { get; set; } = Raylib.GetScreenWidth() / 2 - 50;
    public Texture2D boat;

    public Player()
    {
        // Skapar bilden för spelaren / båten och renderar den i spelet.
        Image boatIMG = Raylib.LoadImage(@"Images/boat.png");
        Raylib.ImageResize(ref boatIMG, 100, 100);
        boat = Raylib.LoadTextureFromImage(boatIMG);
        Raylib.UnloadImage(boatIMG);
    }

    // Förflyttar spelaren till höger eller vänster beroende på om man trycker på A eller B.
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
    }
}
