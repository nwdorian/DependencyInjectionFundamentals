namespace GrooveGrid.Console;

public class Drums : IInstrument
{
    public void Play(string song)
    {
        System.Console.WriteLine($"Played {song} on the drums.");
    }
}
