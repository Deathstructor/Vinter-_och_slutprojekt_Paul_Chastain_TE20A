using Raylib_cs;

public class MainMenu : Menu
{
    // protected List<(Rectangle, string)> buttons;

    public MainMenu()
    {
        Rectangle button = new Rectangle(250, 300, 200, 100);

        buttons.Add(new(button, "Start"));
    }
}
