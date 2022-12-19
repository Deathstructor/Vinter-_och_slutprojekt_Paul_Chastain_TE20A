using Raylib_cs;


Raylib.SetTargetFPS(60);
Raylib.InitWindow(700, 900, "Deep Scan");

MainMenu m = new();
MainGame g = new();
HelpMenu h = new();


while (!Raylib.WindowShouldClose())
{
    if (m.menu) { m.Menu(); }
    if (m.start) { g.Game(); }
    if (m.help) { h.HelpScreen(); }

    m = new();
}
