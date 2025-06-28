namespace GrooveGrid.Console;

public class Musician
{
    private readonly IInstrument _instrument;
    public Musician(IInstrument instrument)
    {
        _instrument = instrument;
    }
    public void Perform(string song)
    {
        _instrument.Play(song);
    }
}
