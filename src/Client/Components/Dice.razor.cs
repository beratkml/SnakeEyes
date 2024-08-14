using Microsoft.AspNetCore.Components;

namespace Client.Components;

public partial class Dice
{
    [Parameter] public int Pips { get; set; }
}
