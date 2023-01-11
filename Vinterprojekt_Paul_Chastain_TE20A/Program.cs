using Raylib_cs;

Raylib.SetTargetFPS(60);
Raylib.InitWindow(700, 900, "Deep Scan");

MainMenu m = new();
MainGame g = new();
HelpMenu h = new();

// Laddar in menyerna
while (!Raylib.WindowShouldClose())
{
    if (m.menu) { m.Menu(); }
    if (m.game) { g.Game(); }
    if (m.help) { h.HelpScreen(); }

    m = new();
}