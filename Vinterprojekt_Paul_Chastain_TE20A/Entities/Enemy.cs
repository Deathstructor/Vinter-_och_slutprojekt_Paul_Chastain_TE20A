using Raylib_cs;

public class Enemy
{
    public static int MaxAmount { get; set; } = 3;
    public static int CurrentAmount { get; set; } = 0;
    public int Pos { get; set; }
    protected int SpawnSide { get; set; }
    protected int Depths { get; set; }
    protected int Sides { get; set; }
    protected bool LeftSide { get; set; }
    public Rectangle enemyHitbox;
    protected Image submarineIMG = Raylib.LoadImage(@"Images/submarine.png");
    protected Image dartIMG = Raylib.LoadImage(@"Images/dart.png");
    public bool isDart { get; set; }


    private static Random rdm = new Random();

    public static List<Enemy> spawnedEnemies = new(); // En lista med alla fiender på skärmen

    public Enemy()
    {
        // Y-koordinaterna som ubåtarna kan spawna på.
        Dictionary<string, int> depth = new Dictionary<string, int>();
        depth.Add("one", 150);
        depth.Add("two", 250);
        depth.Add("three", 350);
        depth.Add("four", 450);
        depth.Add("five", 550);
        depth.Add("six", 650);

        // X-koordinaterns som ubåtarna kan spawna på.
        Dictionary<string, int> side = new Dictionary<string, int>();
        side.Add("left", -200);
        side.Add("right", 800);

        int depthLevel = rdm.Next(6);
        int spawnSide = rdm.Next(2);


        // Anger vilken höjd ubåten ska spawna på baserat på det slumpade värdet.
        if (depthLevel < 1) Depths = depth["one"];
        else if (depthLevel < 2) Depths = depth["two"];
        else if (depthLevel < 3) Depths = depth["three"];
        else if (depthLevel < 4) Depths = depth["four"];
        else if (depthLevel < 5) Depths = depth["five"];
        else if (depthLevel < 6) Depths = depth["six"];

        // Anger vilken sida ubåten ska spawna på, samt "flippar" bilden horizontelt
        // om den spawnar på vänster sida.
        if (spawnSide == 0) 
        {
            Sides = side["left"];
            LeftSide = true;
            Raylib.ImageFlipHorizontal(ref submarineIMG);
            Raylib.ImageFlipHorizontal(ref dartIMG);
        }
        else if(spawnSide == 1) 
        {
            Sides = side["right"];
            LeftSide = false;
        }
        Pos = (int) Sides;
    }

    // idk man
    public virtual void Render(){}
}