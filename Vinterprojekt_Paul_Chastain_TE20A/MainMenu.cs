using Raylib_cs;

public class MainMenu
{
    LoadScreen l = new();
    
    protected Color startColor = Color.GREEN;
    protected Color htpColor = Color.GREEN;
    protected Color exitColor = Color.GREEN;
    protected Color textColor = Color.WHITE;

    protected Rectangle startRec = new Rectangle(Raylib.GetScreenWidth() / 2 - 100, 250, 200, 100);
    protected Rectangle howToPlayRec = new Rectangle(Raylib.GetScreenWidth() / 2 - 100, 400, 200, 100);
    protected Rectangle exitRec = new Rectangle(Raylib.GetScreenWidth() / 2 - 100, 550, 200, 100);

    public void Menu()
    {
        while (!Raylib.WindowShouldClose() && l.quit == false)
        {
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.SKYBLUE);
            Raylib.DrawText("Deep Scan", Raylib.GetScreenWidth() / 2 - 80, 225, 100, Color.RED);

            Raylib.DrawRectangleRec(startRec, startColor);
            Raylib.DrawText("Start", Raylib.GetScreenWidth() / 2 - 80, 375, 50, textColor);

            Raylib.DrawRectangleRec(howToPlayRec, htpColor);
            Raylib.DrawText("How to play", Raylib.GetScreenWidth() / 2 - 80, 525, 50, textColor);

            Raylib.DrawRectangleRec(exitRec, exitColor);
            Raylib.DrawText("Exit", Raylib.GetScreenWidth() / 2 - 50, 525, 50, textColor);

            Raylib.EndDrawing();

            // Kollar om muspekaren är på en knapp och ändrar färgen om den är på en knapp
            if (Raylib.GetMouseX() >= Raylib.GetScreenWidth() / 2 - 80 && Raylib.GetMouseX() <= Raylib.GetScreenWidth() / 2 + 80 && Raylib.GetMouseY() >= 350 && Raylib.GetMouseY() <= 450)
            {
                startColor = Color.DARKGREEN;

                //Laddar in spelet om man klickar på "start" knappen
                if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                {
                    l.start = true;
                    l.menu = false;
                    return;
                }
            }
            else
            {
                startColor = Color.BLUE;
            }

            if (Raylib.GetMouseX() >= Raylib.GetScreenWidth() / 2 - 160 && Raylib.GetMouseX() <= Raylib.GetScreenWidth() / 2 + 140 && Raylib.GetMouseY() >= 500 && Raylib.GetMouseY() <= 600)
            {
                exitColor = Color.DARKBLUE;

                // Stänger ner spelet om man trycker på "exit knappen"
                if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                {
                    l.quit = true;
                    System.Console.WriteLine(l.quit);
                    return;
                }
            }
            else
            {
                exitColor = Color.BLUE;
            }
        }
    }
    // protected List<(Rectangle, string)> buttons

    // public void CreateButtons()
    // {
    //     buttons.Add(new(new(250, 300, 200, 100), "Start"));
    //     buttons.Add(new(new(400, 300, 200, 100), "Start"));
    //     buttons.Add(new(new(550, 300, 200, 100), "Exit"));
    // }

    // public override void MenuButtons()
    // {
    //     Raylib.BeginDrawing();
    //     Raylib.ClearBackground(Color.SKYBLUE);
    //     base.MenuButtons();
    //     Raylib.EndDrawing();
    // }
}   