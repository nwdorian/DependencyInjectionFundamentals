namespace GrooveGrid.Console;

public class Guitar : IInstrument
{
    public void Play(string song)
    {
        System.Console.WriteLine($"Played {song} on the guitar.");
    }
}
