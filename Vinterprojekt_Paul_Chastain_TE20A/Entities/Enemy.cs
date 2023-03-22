using Raylib_cs;

public class Enemy
{
    public static int MaxAmount { get; set; } = 3;
    public static int CurrentAmount { get; set; } = 0;
    public int Pos { get; set; }
    public int SpawnSide { get; set; }
    public Depth Depths { get; set; }
    public Side Sides { get; set; }
    public bool LeftSide { get; set; }
    public Texture2D submarine;
    public Rectangle enemyHitbox;

    private static Random rdm = new Random();

    public static List<Enemy> spawnedEnemies = new(); // En lista med alla fiender på skärmen

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
        right = 800
    }

    public Enemy()
    {
        int depthLevel = rdm.Next(7);
        int spawnSide = rdm.Next(2);

        Image submarineIMG = Raylib.LoadImage(@"Images/submarine.png");

        // Anger vilken höjd ubåten ska spawna på baserat på det slumpade värdet.
        if (depthLevel < 1) Depths = Depth.one;
        else if (depthLevel < 2) Depths = Depth.two;
        else if (depthLevel < 3) Depths = Depth.three;
        else if (depthLevel < 4) Depths = Depth.four;
        else if (depthLevel < 5) Depths = Depth.five;
        else if (depthLevel < 6) Depths = Depth.six;
        else if (depthLevel < 7) Depths = Depth.seven;

        // Anger vilken sida ubåten ska spawna på, samt "flippar" bilden horizontelt
        // om den spawnar på vänster sida.
        if (spawnSide == 0) 
        {
            Sides = Side.left;
            LeftSide = true;
            Raylib.ImageFlipHorizontal(ref submarineIMG);
        }
        else if(spawnSide == 1) 
        {
            Sides = Side.right;
            LeftSide = false;
        }
        Pos = (int) Sides;

        // Skapar bilden för fienderna / ubåtarna.
        Raylib.ImageResize(ref submarineIMG, 100, 100);
        submarine = Raylib.LoadTextureFromImage(submarineIMG);
        Raylib.UnloadImage(submarineIMG);
    }

    // Renderar ubåten och dess förflyttning.
    public void Render()
    {
        Raylib.DrawTexture(submarine, Pos, (int) Depths, Color.WHITE);
        enemyHitbox = new Rectangle(Pos, (int) Depths + 65, 100, 35);
        Raylib.DrawRectangleRec(enemyHitbox, Color.BLANK);

        if (LeftSide == true) Pos++;
        else if (LeftSide == false) Pos--;
    }
}