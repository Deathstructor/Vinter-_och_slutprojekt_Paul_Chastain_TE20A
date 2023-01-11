using System;

// Bools för alla menyer. Dessa ser till att endast den menyn (metoden) som ska köras faktiskt körs
// så att inte flera menyer laddas in samtidigt och skapar buggar och lagg.
public abstract class LoadScreen
{
    public bool game { get; set; } = false;
    public bool menu { get; set; } = true;
    public bool help { get; set; } = false;
}
