using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public class Game
{
    private Dice _dice1;
    private Dice _dice2;
    private List<int> _highscores = new();
    public int Eye1 => _dice1.Dots;
    public int Eye2 => _dice2.Dots;
    public bool HasSnakeEyes => _dice1.Dots==1 && _dice2.Dots==1;
    public IReadOnlyList<int> Highscores=> _highscores.AsReadOnly();
    public int Total { get; set; }

    public Game()
    {
        Initialize();
    }

    public void Initialize()
    {
        _dice1 = new Dice();
        _dice2 = new Dice();
    }
    public void Play()
    {
        _dice1.Roll();
        _dice2.Roll();
        if (HasSnakeEyes)
        {
            _highscores.Add(Total);
            Total = 0;
        }
        else
        {
            Total += _dice1.Dots + _dice2.Dots;
        }
    }
    public void Restart()
    {
        Initialize();
    }
}
