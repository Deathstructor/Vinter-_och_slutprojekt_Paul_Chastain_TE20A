using Raylib_cs;


Raylib.SetTargetFPS(60);
Raylib.InitWindow(700, 900, "Deep Scan");

LoadScreen l = new();
MainMenu m = new();
MainGame g = new();
HelpMenu h = new();


while (!Raylib.WindowShouldClose())
{
    if (l.menu) { m.Menu(); }
    if (l.start) { g.Game(); }
    if (l.help) { h.HelpScreen(); }
}
