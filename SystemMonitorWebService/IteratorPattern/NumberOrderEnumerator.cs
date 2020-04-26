namespace SystemMonitorWebService.IteratorPattern
{
    public class NumberOrderEnumerator : IEnumerator
    {
        ProcessesCollection Collection;
        int current = -1;

        public NumberOrderEnumerator(ProcessesCollection collection)
        {
            Collection = collection;
        }
        public object Current => Collection[current];

        public bool MoveNext()
        {
            Collection.GetProcesses().Sort(new IdComparer());

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