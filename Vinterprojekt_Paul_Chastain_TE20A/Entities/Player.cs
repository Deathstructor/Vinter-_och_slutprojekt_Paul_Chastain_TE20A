using Raylib_cs;

public class Player
{
    public int playerPos { get; set; } = Raylib.GetScreenWidth() / 2 - 50;
    public Texture2D boat;

    public Player()
    {
        Image boatIMG = Raylib.LoadImage(@"Images/boat.png");
        Raylib.ImageResize(ref boatIMG, 100, 100);
        boat = Raylib.LoadTextureFromImage(boatIMG);
        Raylib.UnloadImage(boatIMG);
    }

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
