using Raylib_cs;

public class SubmarineClass : Enemy
{
    public Texture2D submarine;

    public SubmarineClass()
    {
        // Skapar bilden för fienderna / ubåtarna.
        Raylib.ImageResize(ref submarineIMG, 100, 100);
        submarine = Raylib.LoadTextureFromImage(submarineIMG);
        Raylib.UnloadImage(submarineIMG);

        isDart = false;
    }

    // Renderar ubåten och dess förflyttning
    public override void Render()
    {
        Raylib.DrawTexture(submarine, Pos, (int)Depths, Color.WHITE);
        enemyHitbox = new Rectangle(Pos, (int)Depths + 65, 100, 35);
        Raylib.DrawRectangleRec(enemyHitbox, Color.BLANK);

        if (LeftSide == true) Pos++;
        else if (LeftSide == false) Pos--;
    }
}