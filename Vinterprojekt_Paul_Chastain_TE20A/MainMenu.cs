using Raylib_cs;

public class MainMenu
{
    Rectangle play = new Rectangle(Raylib.GetScreenWidth() / 2 - 100, 250, 200, 100);
    Rectangle howToPlay = new Rectangle(Raylib.GetScreenWidth() / 2 - 100, 400, 200, 100);
    Rectangle exit = new Rectangle(Raylib.GetScreenWidth() / 2 - 100, 550, 200, 100);

    public void Menu()
    {
        while (!Raylib.WindowShouldClose() /*&& quit == false*/)
        {
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.SKYBLUE);
            Raylib.DrawText("Deep Scan", Raylib.GetScreenWidth() / 2 - 80, 225, 100, Color.RED);

            Raylib.DrawRectangleRec(play, Color.);
            Raylib.DrawText("Start", Raylib.GetScreenWidth() / 2 - 80, 375, 50, Color.WHITE);

            Raylib.DrawRectangleRec(exit, vars.exitColor);
            Raylib.DrawText("Exit", Raylib.GetScreenWidth() / 2 - 50, 525, 50, Color.WHITE);

            Raylib.EndDrawing();

            // Kollar om muspekaren är på en knapp och ändrar färgen om den är på en knapp
            if (Raylib.GetMouseX() >= Raylib.GetScreenWidth() / 2 - 160 && Raylib.GetMouseX() <= Raylib.GetScreenWidth() / 2 + 140 && Raylib.GetMouseY() >= 350 && Raylib.GetMouseY() <= 450)
            {
                vars.playColor = Color.DARKBLUE;

                //Laddar in spelet om man klickar på "start" knappen
                if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                {
                    vars.gameStart = true;
                    vars.menu = false;
                    return;
                }
            }
            else
            {
                vars.playColor = Color.BLUE;
            }

            if (Raylib.GetMouseX() >= Raylib.GetScreenWidth() / 2 - 160 && Raylib.GetMouseX() <= Raylib.GetScreenWidth() / 2 + 140 && Raylib.GetMouseY() >= 500 && Raylib.GetMouseY() <= 600)
            {
                vars.exitColor = Color.DARKBLUE;

                // Stänger ner spelet om man trycker på "exit knappen"
                if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                {
                    quit = true;
                    System.Console.WriteLine(quit);
                    return;
                }
            }
            else
            {
                vars.exitColor = Color.BLUE;
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