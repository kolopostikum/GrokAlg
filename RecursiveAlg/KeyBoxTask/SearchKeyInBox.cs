using System;
using System.Collections.Generic;
using System.Linq;

namespace RecursiveAlg.KeyBoxTask;

public static class BoxSearcher<T>
{
    public static void KeySearchWithoutRec(Box mainBox)
    {
        var pile = new Pile(mainBox.MakePileToLookThrough());
        if(KeyInFirstBox(pile.Items))
            return;
        while(pile.Items.Any())
        {
            Box actualBox = pile.GrabBox();
            foreach(var item in actualBox.Items)
            {
                if (item is Box)
                    pile.Items.AddLast(item);
                else if(item is Key)
                    Console.WriteLine("found the key !");
            }
        }
    }

    public static void KeySearchRec(Box box)
    {
        foreach (var item in box.Items)
            if (item is Box boxItem)
                KeySearchRec(boxItem);
            else if(item is Key)
            {    
                Console.WriteLine("found the key !");
                return;
            }
    }


    private static bool KeyInFirstBox(LinkedList<object> pileItems)
    {
        foreach(var item in pileItems)
            if (item is Key)
            {
                Console.WriteLine("found the key !");
                return true;
            }
        return false;
    }
}
