using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecursiveAlg.KeyBoxTask
{
    public class Pile
    {
        public LinkedList<Object> Items;

        public Pile(LinkedList<object> items)
        {
            this.Items = items;
        }

        public Box GrabBox()
        {
            while(Items.Any())
            {
                if (Items.Last.Value is not Box)
                    Items.RemoveLast();
                else 
                {
                    var actualBox = (Box)Items.Last.Value;
                    this.Items.RemoveLast();
                    return actualBox;
                }
            }
            return null;
        }
    }
}