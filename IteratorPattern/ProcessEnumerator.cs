﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemActivityMonitor.IteratorPattern
{
    public class ProcessEnumerator : IEnumerator
    {
        ProcessesCollection Collection;
        int current = -1;

        public ProcessEnumerator(ProcessesCollection collection)
        {
            Collection = collection;
        }

        public object Current => Collection[current];

        public bool MoveNext()
        {
            if (current < Collection.Count - 1)
            {
                current++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            current = -1;
        }
    }
}
