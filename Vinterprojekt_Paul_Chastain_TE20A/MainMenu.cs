using Raylib_cs;

// Denna kod har jag återanvänt från ett gammalt projekt: https://github.com/Deathstructor/Vinterprojekt
// Jag vet att det finns bättre och effektivare sätt att göra menyerna på, men jag vill hellre lägga mer
// tid på själva spelet än på menyerna, så jag kanske fixar det senare om jag har tid över till det.

public static class MainMenu
{
    // Färgerna för alla knappar och text.
    static Color startColor = Color.GREEN;
    static Color helpColor = Color.GREEN;
    static Color exitColor = Color.GREEN;
    static Color textColor = Color.WHITE;

    // Skapar knapparna i huvudmeyn
    static Rectangle startRec = new Rectangle(Raylib.GetScreenWidth() / 2 - 100, 300, 200, 100);
    static Rectangle helpRec = new Rectangle(Raylib.GetScreenWidth() / 2 - 100, 450, 200, 100);
    static Rectangle exitRec = new Rectangle(Raylib.GetScreenWidth() / 2 - 100, 600, 200, 100);

    public static void Menu()
    {
        while (true)
        {
            // Ritar ut spelets titel, samt knapparna och texten på dem.
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
                    MainGame.Game();
                }
            }
            else { startColor = Color.GREEN; }

            if (Raylib.CheckCollisionPointRec(mousePos, helpRec))
            {
                helpColor = Color.DARKGREEN;

                // Laddar in hjälp menyn där man kan hitta instruktioner för hur spelet funkar om man trycker på "help" knappen
                if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                {
                    HelpMenu.HelpScreen();
                }
            }
            else { helpColor = Color.GREEN; }

            if (Raylib.CheckCollisionPointRec(mousePos, exitRec))
            {
                exitColor = Color.DARKGREEN;

                // Stänger ner spelet om man trycker på "exit knappen"
                if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                {
                    return;
                }
            }
            else { exitColor = Color.GREEN; }

        }
    }
}