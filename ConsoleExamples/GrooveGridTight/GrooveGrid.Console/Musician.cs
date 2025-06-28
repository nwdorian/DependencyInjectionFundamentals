namespace GrooveGrid.Console;

public class Musician
{
    private readonly Guitar _guitar = new();
    public void Perform(string song)
    {
        _guitar.Play(song);
    }
}
