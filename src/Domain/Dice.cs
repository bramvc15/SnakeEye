namespace Domain;

class Dice
{
    private Random _randomizer = new Random();
    public int Dots { get; set; }

    public Dice()
    {
        this.Dots = 6;
    }
    public void Roll()
    {
        Dots = _randomizer.Next(1, 7);
    }
}