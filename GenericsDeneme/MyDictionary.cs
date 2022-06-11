using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDeneme
{
    internal class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey item1,TValue item2)
        {
            TKey[] tempKeys = keys;
            TValue[] tempValues = values;
            keys=new TKey[tempKeys.Length+1];
            values=new TValue[tempValues.Length+1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i]=tempKeys[i];
            }
            keys[keys.Length - 1] = item1;
            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i]=tempValues[i];
            }
            values[keys.Length - 1] = item2;
        }

    }
}
