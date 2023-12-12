using Microsoft.VisualBasic;

namespace AlgorithmLib;

public static class MergeSort
{
    private static void Merge(List<IComparable> data, int first, int mid, int last)
    {
        // ADD CODE HERE
        var n1 = mid - first;
        var n2 = last - mid;
        // var num1 = data.Count / 2;
        var b = data.GetRange(0, n1);
        var c = data.GetRange(mid + 1, n2);

        var index1 = 0;
        var index2 = 0;

        for (var i = 0; i <= last; i++)
        {
            if (b[index1].CompareTo(c[index2]) <= 0)
            {
                data[i] = b[index1];
                index1 += 1;
            }
            else
            {
                data[i] = c[index2];
                index2 += 1;
            }
        }





        // var first_half = data.GetRange(first, mid);
        // var second_half = data.GetRange(mid + 1, last);
        // int index1 = 0;
        // int index2 = 0;
        //
        // for (var i = 0; i < last + 1; i++)
        // {
        //     if (index1 >= first_half.Count)
        //     {
        //         data[i] = second_half[index2];
        //         index2 += 1;
        //     }
        //     
        //     else if (index2 >= second_half.Count)
        //     {
        //         data[i] = first_half[index1];
        //     }
        //     
        //     else if (second_half[index2].CompareTo(first_half[index1]) > 0)
        //     {
        //         data[i] = first_half[index1];
        //         index1 += 1;
        //     }
        //
        //     else
        //     {
        //         data[i] = second_half[index2];
        //         index2 += 1;
        //     }
        // }


    }

    public static void Sort(List<IComparable> data)
    {
        // ADD CODE HERE 
        var first = 0;
        var last = data.Count - 1;
        
        SortHelper(data, first, last);

        

        

    }

    public static void SortHelper(List<IComparable> data, int first, int last)
    {
        if (first >= last)
        {
            return;
        }

        int mid = (first + last) / 2;
        
        SortHelper(data, first, mid);
        SortHelper(data, mid + 1, last);
        
        Merge(data, first, mid, last);
    }

}

