namespace AlgorithmLib;

public static class BinarySearch
{
    public static int Search(List<IComparable> data, IComparable target)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        int p = 0;
        var r = data.Count - 1;
        // var q = 0;
        while (p <= r)
        {
            decimal thing = (p + r) / 2;
            var test = Math.Floor(thing);
            var q = Convert.ToInt16(test);
            // q = (p + r) / 2;
            if (data[q].Equals(target))
            {
                return q;
            }

            else if (data[q].CompareTo(target) > 0)
            {
                r = q - 1;
            }

            else
            {
                p = q + 1;
            }
            
        }
        
        return -1;
    }
}