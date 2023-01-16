using Raylib_cs;

public class Enemy
{
    public int enemyPos { get; set; }
    public int enemySpawnSide { get; set; }
    public Depth depths { get; set; }
    public Texture2D submarine;

    private static Random rdm = new Random();

    // Y-koordinaterna som ubåtarna kan spawna på.
    public enum Depth
    {
        one = 150,
        two = 250,
        three = 350,
        four = 450,
        five = 550,
        six = 650,
        seven = 750
    }

    public Enemy()
    {
        int depthLevel = rdm.Next(7);

        // Skapar bilden för fienderna / ubåtarna.
        Image submarineIMG = Raylib.LoadImage(@"Images/submarine.png");
        Raylib.ImageResize(ref submarineIMG, 100, 100);
        submarine = Raylib.LoadTextureFromImage(submarineIMG);
        Raylib.UnloadImage(submarineIMG);

        // Kollar vilken höjd ubåten ska spawna på baserat på det slumpade värdet.
        if (depthLevel < 1) depths = Depth.one;
        else if (depthLevel < 2) depths = Depth.two;
        else if (depthLevel < 3) depths = Depth.three;
        else if (depthLevel < 4) depths = Depth.four;
        else if (depthLevel < 5) depths = Depth.five;
        else if (depthLevel < 6) depths = Depth.six;
        else if (depthLevel < 7) depths = Depth.seven;
    }

    // Renderar ubåten
    public void Render()
    {
        Raylib.DrawTexture(submarine, 400, (int) depths, Color.WHITE);
    }
}
