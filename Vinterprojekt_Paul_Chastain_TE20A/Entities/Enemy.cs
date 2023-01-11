using Raylib_cs;

public class Enemy
{
    public Texture2D submarine;

    public Enemy()
    {
        Image submarineIMG = Raylib.LoadImage(@"Images/submarine.png");
        Raylib.ImageResize(ref submarineIMG, 100, 100);
        submarine = Raylib.LoadTextureFromImage(submarineIMG);
        Raylib.UnloadImage(submarineIMG);
    }
}
