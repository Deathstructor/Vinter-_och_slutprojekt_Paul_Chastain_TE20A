using Raylib_cs;

public class Enemy
{
    public static int maxAmount { get; set; } = 3;
    public static int currentAmount { get; set; } = 0;
    public int pos { get; set; }
    public int spawnSide { get; set; }
    public Depth depths { get; set; }
    public Side sides { get; set; }
    public bool leftSide { get; set; }
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

    // X-koordinaterns som ubåtarna kan spawna på.
    public enum Side
    {
        left = -200,
        right = 900
    }

    public Enemy()
    {
        int depthLevel = rdm.Next(7);
        int spawnSide = rdm.Next(2);

        Image submarineIMG = Raylib.LoadImage(@"Images/submarine.png");

        // Anger vilken höjd ubåten ska spawna på baserat på det slumpade värdet.
        if (depthLevel < 1) depths = Depth.one;
        else if (depthLevel < 2) depths = Depth.two;
        else if (depthLevel < 3) depths = Depth.three;
        else if (depthLevel < 4) depths = Depth.four;
        else if (depthLevel < 5) depths = Depth.five;
        else if (depthLevel < 6) depths = Depth.six;
        else if (depthLevel < 7) depths = Depth.seven;

        // Anger vilken sida ubåten ska spawna på, samt "flippar" bilden horizontelt
        // om den spawnar på vänster sida.
        if (spawnSide == 0) 
        {
            sides = Side.left;
            leftSide = true;
            Raylib.ImageFlipHorizontal(ref submarineIMG);
        }
        else if(spawnSide == 1) 
        {
            sides = Side.right;
            leftSide = false;
        }
        pos = (int) sides;

        // Skapar bilden för fienderna / ubåtarna.
        Raylib.ImageResize(ref submarineIMG, 100, 100);
        submarine = Raylib.LoadTextureFromImage(submarineIMG);
        Raylib.UnloadImage(submarineIMG);
    }

    // Renderar ubåten och dess förflyttning.
    public void Render()
    {
        Raylib.DrawTexture(submarine, pos, (int) depths, Color.WHITE);

        if (leftSide == true) pos++;
        else if (leftSide == false) pos--;
    }
}