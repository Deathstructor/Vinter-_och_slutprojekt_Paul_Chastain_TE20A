using Raylib_cs;

Engine e = new();

CreateWindow();
Start();

void CreateWindow()
{
    Raylib.SetTargetFPS(60);
    Raylib.InitWindow(700, 900, "Deep Scan");
}

void Start()
{
    e.Run();
}