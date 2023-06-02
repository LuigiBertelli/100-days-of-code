using System;
using System.Linq;

namespace Day58;

public class Program
{
    static void Main(string[] args) {
        var diceComp = new List<string>();

        Console.WriteLine("""Insert the dices composition and when its finished type "s" """);
        var typed = Console.ReadLine();

        while(typed != "s")
        {   
            diceComp.Add(typed);
            typed = Console.ReadLine();
        }

        var diceRoller = new DiceRoller(diceComp.ToArray());

        diceRoller.Roll();
    }
}