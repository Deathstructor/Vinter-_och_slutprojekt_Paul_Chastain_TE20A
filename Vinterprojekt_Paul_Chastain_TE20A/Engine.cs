using Raylib_cs;

public class Engine
{
    Mode navigation;

    private enum Mode
    {
        Game,
        Help,
        Exit
    }

    public Engine()
    {
        Menu menu = new MainMenu();
    }

    public void Run()
    {
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.SKYBLUE);
            Raylib.EndDrawing();

            switch (navigation)
            {
                case Mode.Game:
                    break;
                
                case Mode.Help:
                    break;

                case Mode.Exit:
                    break;

                default:
                    break;
            }
        }
    }
}
