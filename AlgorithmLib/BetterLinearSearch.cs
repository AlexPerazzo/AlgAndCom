namespace AlgorithmLib;

public static class BetterLinearSearch
{
    public static int Search(List<IComparable> data, IComparable target)
    {
        var index = 0;
        //set initial index to check
        
        foreach (var i in data)
            //cycle through each thing in the list
        {
            
            if (i.Equals(target))
                //check if it's equal to the target
            {
                return index;
                //if it is equal, return the index of the target
            }

            index++;
        }
        
        return -1;
    }
}