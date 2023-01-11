using Raylib_cs;

// Denna kod har jag återanvänt från ett gammalt projekt: https://github.com/Deathstructor/Vinterprojekt
// Jag vet att det finns bättre och effektivare sätt att göra menyerna på, men jag vill hellre lägga mer
// tid på själva spelet än på menyerna, så jag kanske fixar det senare om jag har tid över till det.

public class MainMenu : LoadScreen
{
    protected Color startColor = Color.GREEN;
    protected Color helpColor = Color.GREEN;
    protected Color exitColor = Color.GREEN;
    protected Color textColor = Color.WHITE;

    protected Rectangle startRec = new Rectangle(Raylib.GetScreenWidth() / 2 - 100, 300, 200, 100);
    protected Rectangle helpRec = new Rectangle(Raylib.GetScreenWidth() / 2 - 100, 450, 200, 100);
    protected Rectangle exitRec = new Rectangle(Raylib.GetScreenWidth() / 2 - 100, 600, 200, 100);

    public void Menu()
    {
        while (true)
        {
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.SKYBLUE);
            Raylib.DrawText("Deep Scan", Raylib.GetScreenWidth() / 2 - 260, 125, 100, Color.RED);

            Raylib.DrawRectangleRec(startRec, startColor);
            Raylib.DrawText("Start", Raylib.GetScreenWidth() / 2 - 70, 325, 50, textColor);

            Raylib.DrawRectangleRec(helpRec, helpColor);
            Raylib.DrawText("Help", Raylib.GetScreenWidth() / 2 - 50, 475, 50, textColor);

            Raylib.DrawRectangleRec(exitRec, exitColor);
            Raylib.DrawText("Exit", Raylib.GetScreenWidth() / 2 - 50, 625, 50, textColor);

            Raylib.EndDrawing();

            // Kollar om muspekaren är på en knapp och ändrar färgen om den är på en knapp
            var mousePos = Raylib.GetMousePosition();
            if (Raylib.CheckCollisionPointRec(mousePos, startRec))
            {
                startColor = Color.DARKGREEN;

                //Laddar in spelet om man klickar på "start" knappen
                if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                {
                    start = true;
                    menu = false;
                    return;
                }
            }
            else { startColor = Color.GREEN; }

            if (Raylib.CheckCollisionPointRec(mousePos, helpRec))
            {
                helpColor = Color.DARKGREEN;

                // Laddar in hjälp menyn där man kan hitta instruktioner för hur spelet funkar om man trycker på "help" knappen
                if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                {
                    help = true;
                    menu = false;
                    return;
                }
            }
            else { helpColor = Color.GREEN; }

            if (Raylib.CheckCollisionPointRec(mousePos, exitRec))
            {
                exitColor = Color.DARKGREEN;

                // Stänger ner spelet om man trycker på "exit knappen"
                if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                {
                    Raylib.CloseWindow();
                    return;
                }
            }
            else { exitColor = Color.GREEN; }

        }
    }
}