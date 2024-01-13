namespace Domain;

public class Game
{
    private Dice _dice1;
    private Dice _dice2;
    private List<int> _hightscores = new List<int>();

    public int Eye1 => _dice1.Dots;
    public int Eye2 => _dice2.Dots;
    public bool HasSnakeEye => Eye1 == 1 && Eye2 == 1;
    public IReadOnlyList<int> HighScores => _hightscores.AsReadOnly();
    public int Total { get; set; }

    public Game()
    {
        Initialize();
    }
    public void Initialize()
    {
        _dice2 = new Dice();
        _dice1 = new Dice();

    }
    public void Play()
    {
        _dice1.Roll();
        _dice2.Roll();
        if(HasSnakeEye)
        {
            _hightscores.Add(Total);
            Total = 0;
        }
        else
        {
            Total += Eye1 + Eye2;
        }



    }
    public void Restart()
    {
        Initialize();

    }


}
