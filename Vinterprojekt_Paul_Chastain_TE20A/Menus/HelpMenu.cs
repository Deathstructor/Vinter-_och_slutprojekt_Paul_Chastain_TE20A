using Raylib_cs;

public class HelpMenu
{
    static Color backColor = Color.GREEN;
    static Rectangle backRec =  new Rectangle(70, 800, 100, 50);

    public static void HelpScreen()
    {
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.SKYBLUE);

            Raylib.DrawText("Help", 70, 50, 100, Color.RED);

            Raylib.DrawText("The point of the game is to kill", 80, 200, 35, Color.WHITE);
            Raylib.DrawText("as many enemy submarines as", 80, 235, 35, Color.WHITE);
            Raylib.DrawText("possible and to not get killed", 80, 270, 35, Color.WHITE);
            Raylib.DrawText("by the enemy projectiles!", 80, 305, 35, Color.WHITE);

            Raylib.DrawText("Controls", 70, 405, 70, Color.RED);
            Raylib.DrawText("Move left: A", 80, 475, 35, Color.WHITE);
            Raylib.DrawText("Move right: D", 80, 510, 35, Color.WHITE);
            Raylib.DrawText("Shoot/drop bomb: SPACE", 80, 545, 35, Color.WHITE);
            Raylib.DrawText("Back to menu: ESC", 80, 580, 35, Color.WHITE);
            Raylib.DrawText("Select small bomb: 1", 80, 615, 35, Color.WHITE);
            Raylib.DrawText("Select big bomb: 2", 80, 650, 35, Color.WHITE);

            Raylib.DrawRectangleRec(backRec, backColor);
            Raylib.DrawText("Back", 85, 810, 30, Color.WHITE);

            Raylib.EndDrawing();

            var mousePos = Raylib.GetMousePosition();
            if (Raylib.CheckCollisionPointRec(mousePos, backRec))
            {
                backColor = Color.DARKGREEN;

                // Går tillbaka till huvudmenyn om man trycken på knappen
                if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                {
                    return;
                }
            } else backColor = Color.GREEN;
        }
    }
}
