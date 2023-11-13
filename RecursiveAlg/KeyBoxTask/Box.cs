using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecursiveAlg.KeyBoxTask
{
    public class Box
    {
        public LinkedList<Object> Items;

        public Box(LinkedList<object> items)
        {
            this.Items = items;
        }

        public LinkedList<Object> MakePileToLookThrough()
        {
            return new LinkedList<object>(Items);
        }
    }
}