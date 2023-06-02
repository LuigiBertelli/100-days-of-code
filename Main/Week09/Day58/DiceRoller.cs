using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Day58;

public class DiceRoller
{
    // Dict => (Number of Dices, Dices number of faces)
    public Dictionary<int, int> DiceComposition { get; private set; } = new Dictionary<int, int>();

    public DiceRoller(string[] diceComp)
    {
        try
        {
            for(int i = 1; i <= diceComp.Count(); i++)
            {
                var splittedcomp = diceComp[i - 1].Split('d');
                var dicesCount = Int32.Parse(splittedcomp.ElementAt(0));
                var dicesFace = Int32.Parse(splittedcomp.ElementAt(1));

                if(dicesCount > 100 && dicesCount < 0)
                    throw new Exception($"Composition #{i} - Invalid number of dices");

                if(dicesFace > 100 && dicesFace < 0)
                    throw new Exception($"Composition #{i} - Invalid number of faces");

                DiceComposition.Add(dicesCount, dicesFace);
            }
        } catch(Exception ex) {
            Console.WriteLine(ex.Message);
        } 
    }

    public void Roll()
    {
        Random rnd = new Random();

        foreach(var pair in DiceComposition)
        {
            var diceArray = new int[pair.Key];
            var sum = 0;

            for(int i = 0; i < pair.Key; i++) 
            {
                diceArray[i] = rnd.Next(pair.Value) + 1;
                sum += diceArray[i];
            }
            
            Console.Write($"{sum}:");
            foreach(var it in diceArray) Console.Write(" " + it.ToString());

            Console.WriteLine("");
        }
    }
}