using Raylib_cs;

public class DartClass : Enemy
{
    public Texture2D dart;

    public DartClass()
    {
        // Skapar bilden för fienderna / ubåtarna.
        Raylib.ImageResize(ref dartIMG, 75, 75);
        dart = Raylib.LoadTextureFromImage(dartIMG);
        Raylib.UnloadImage(dartIMG);
    }

    // Renderar ubåten och dess förflyttning
    public override void Render()
    {
        Raylib.DrawTexture(dart, Pos, (int)Depths, Color.WHITE);
        enemyHitbox = new Rectangle(Pos + 20, (int)Depths + 55, 35, 20);
        Raylib.DrawRectangleRec(enemyHitbox, Color.BLANK);

        if (LeftSide == true) Pos += 2;
        else if (LeftSide == false) Pos += 2;
    }
}
