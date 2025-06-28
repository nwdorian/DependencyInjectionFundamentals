using GrooveGrid.Console;

var musician1 = new Musician(new Guitar());
var musician2 = new Musician(new Drums());
musician1.Perform("Sultans of Swing");
musician2.Perform("Sultans of Swing");
Console.ReadLine();