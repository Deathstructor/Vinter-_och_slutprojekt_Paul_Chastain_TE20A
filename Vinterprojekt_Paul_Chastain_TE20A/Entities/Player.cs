using Raylib_cs;

public class Player
{
    public int playerPos { get; set; } = Raylib.GetScreenWidth() / 2 - 50;
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
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && playerPos > 0)
        {
            playerPos--;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && playerPos < Raylib.GetScreenWidth() - 100)
        {
            playerPos++;
        }
    }
}
