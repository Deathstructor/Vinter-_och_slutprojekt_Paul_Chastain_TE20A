using Raylib_cs;

public class Enemy
{
    public static int MaxAmount { get; set; } = 3;
    public static int CurrentAmount { get; set; } = 0;
    public int Pos { get; set; }
    protected int SpawnSide { get; set; }
    protected Depth Depths { get; set; }
    protected Side Sides { get; set; }
    protected bool LeftSide { get; set; }
    public Rectangle enemyHitbox;
    protected Image submarineIMG = Raylib.LoadImage(@"Images/submarine.png");
    protected Image dartIMG = Raylib.LoadImage(@"Images/dart.png");


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
        six = 650
    }

    // X-koordinaterns som ubåtarna kan spawna på.
    public enum Side
    {
        left = -200,
        right = 800
    }

    public Enemy()
    {
        int depthLevel = rdm.Next(6);
        int spawnSide = rdm.Next(2);


        // Anger vilken höjd ubåten ska spawna på baserat på det slumpade värdet.
        if (depthLevel < 1) Depths = Depth.one;
        else if (depthLevel < 2) Depths = Depth.two;
        else if (depthLevel < 3) Depths = Depth.three;
        else if (depthLevel < 4) Depths = Depth.four;
        else if (depthLevel < 5) Depths = Depth.five;
        else if (depthLevel < 6) Depths = Depth.six;

        // Anger vilken sida ubåten ska spawna på, samt "flippar" bilden horizontelt
        // om den spawnar på vänster sida.
        if (spawnSide == 0) 
        {
            Sides = Side.left;
            LeftSide = true;
            Raylib.ImageFlipHorizontal(ref submarineIMG);
            Raylib.ImageFlipHorizontal(ref dartIMG);
        }
        else if(spawnSide == 1) 
        {
            Sides = Side.right;
            LeftSide = false;
        }
        Pos = (int) Sides;
    }

    // idk man
    public virtual void Render(){}
}