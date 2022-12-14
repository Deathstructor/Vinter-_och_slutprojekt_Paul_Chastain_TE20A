using Raylib_cs;


Raylib.SetTargetFPS(60);
Raylib.InitWindow(700, 900, "Deep Scan");

LoadScreen l = new();
MainMenu m = new();

while (l.quit == false)
{
    if (l.menu) { m.Menu(); }
    if (l.start) {  }
    if (l.htp) {  }
    if (l.exit) {  }
}