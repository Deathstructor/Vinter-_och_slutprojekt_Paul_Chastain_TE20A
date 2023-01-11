using Raylib_cs;

public class Enemy
{
    public int enemyPos { get; set; }
    public int enemySpawnSide { get; set; }
    public Texture2D submarine;

    public Enemy()
    {
        // Skapar bilden för fienderna / ubåtarna och renderar den i spelet.
        Image submarineIMG = Raylib.LoadImage(@"Images/submarine.png");
        Raylib.ImageResize(ref submarineIMG, 100, 100);
        submarine = Raylib.LoadTextureFromImage(submarineIMG);
        Raylib.UnloadImage(submarineIMG);
    }
}
