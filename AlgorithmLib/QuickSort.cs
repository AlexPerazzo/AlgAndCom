namespace AlgorithmLib;

public static class QuickSort
{
    private static int Partition(List<IComparable> data, int first, int last)
    {
        
        // can make pivot random to make algorithm faster, but for simplicity right now we'll just set it to last.
        // Random random = new Random();
        // int pivot = random.Next(first, last);
        // (data[pivot], data[last]) = (data[last], data[pivot]);
        var pivot = last;
        
        
        // lmgp means left most greater pivot. It is where the pivot will eventually swap with. It is the left most of all the numbers that are greater than the pivot.
        int lmgp = first;

        // compare each item in the list to the pivot. If it's smaller, we're going to put it to the left side of the lmgp until eventually the lmgp is the is the left most number that is greater than the pivot
        for (var i = first; i < last; i++)
        {
            if (data[i].CompareTo(data[pivot]) <= 0)
            {
                (data[lmgp], data[i]) = (data[i], data[lmgp]);
                lmgp += 1;
            }
        }
        
        // Swap the lmgp and the pivot numbers so the pivot is in the correct location.
        (data[lmgp], data[last]) = (data[last], data[lmgp]);
        
        //return location of pivot
        return lmgp;
    }

    public static void Sort(List<IComparable> data)
    {
        // We need the first pivot and last, so we make a helper function that receives those variables.
        SortHelper(data, 0, data.Count - 1);
    }

    public static void SortHelper(List<IComparable> data, int first, int last)
    {
        // Base case: There is only one item in the list.
        if (first >= last)
        {
            return;
        }
        
        //get the index of the pivot from the partition function
        var pivotIndex = Partition(data, first, last);
        
        //recursively call sort on both sides not including the pivot
        SortHelper(data, first, pivotIndex - 1);
        SortHelper(data, pivotIndex + 1, last);

    }

}