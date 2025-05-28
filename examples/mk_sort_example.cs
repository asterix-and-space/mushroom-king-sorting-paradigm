// Mushroom-King Sort (MK-Sort) Example
//
// Copyright © 1965–2025 asterix-and-space organisation. All rights reserved.
//
// This code is strictly proprietary. See licence.txt in the repository root for terms.

using System;
using System.Collections.Generic;

class MushroomKingTuple
{
    public int MushroomMentions { get; set; }
    public int ReignDuration { get; set; }
}

class Program
{
    static List<MushroomKingTuple> MkSort(List<MushroomKingTuple> data)
    {
        data.Sort((a, b) =>
        {
            int cmp = b.MushroomMentions.CompareTo(a.MushroomMentions);
            if (cmp != 0) return cmp;
            return a.ReignDuration.CompareTo(b.ReignDuration);
        });
        return data;
    }

    static void Main()
    {
        var dataset = new List<MushroomKingTuple>
        {
            new MushroomKingTuple { MushroomMentions = 42, ReignDuration = 10 },
            new MushroomKingTuple { MushroomMentions = 42, ReignDuration = 5 },
            new MushroomKingTuple { MushroomMentions = 7, ReignDuration = 20 },
            new MushroomKingTuple { MushroomMentions = 100, ReignDuration = 1 }
        };
        var result = MkSort(dataset);
        Console.WriteLine("I am the mushroom king");
        foreach (var t in result)
        {
            Console.Write($"({t.MushroomMentions}, {t.ReignDuration}) ");
        }
        Console.WriteLine();
    }
}
