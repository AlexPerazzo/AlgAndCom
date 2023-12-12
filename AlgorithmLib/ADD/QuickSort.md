# Algorithm Description Document

Author: Alexander Perazzo

Date: 10/8/23

## 1. Name

Quick Sort

## 2. Abstract
Sorts a list by dividing the list into two parts, numbers that are higher than a random pivot and numbers that are lower than a random pivot. This process is then done recursively on both sides until the whole list is sorted.

## 3. Methodology
[Still learning how to write a better methodology, so just let me know if/what I need to improve *thumbs up*]
This algorithm takes a unsorted list and picks a random number to be what we call the pivot. We will put this number at the far right. The items in the list are compared against the pivot. Each number that is smaller will be put on the left side and each number that is larger will be put on the right side of the pivot in the end. In order to accomplish this, we label the first item in the least as the lmgp (left most greater pivot). 

As the comparisons are done, if one is found to be smaller than the pivot, that number is swapped with the item in the lmgp spot. The lmgp spot is then shifted to the right by one. This means it will be shifted n total times where n is the number of items that were smaller than the pivot. This means the lmgp will end up exactly at the index the pivot fits into the list. After comparing all the numbers, the pivot and the number in the lmgp spot are swapped, slotting the pivot number into the correct spot.

Then recursion takes place. We do the same process on both the left and the right side. As individual items are put into their correct locations, the list becomes sorted.


## 4. Pseudocode

```
PARTITION(data, first, last)
Set pivot to last.
Set lmgp to first.
For each item in list:
    If item is less than item in pivot spot:
        Swap item with item at index lmgp.
        Increment lmgp by 1
        
Then swap the item in the lmgp spot with the item in the pivot spot.

SORT(data, first, last)
If there's only one item in the list: Return
Otherwise:
Find index of pivot by calling PARTITION.
Recursively call SORT on both the left side of the pivot and the right side, not including the pivot itself (since it's already sorted).
Ex: 
SORT(data, first, PIVOTINDEX - 1) [the left side of the pivot, not including the pivot]
SORT(data, PIVOTINDEX + 1, last) [the right side of the pivot, not including the pivot]

```

## 5. Inputs & Outputs

List only inputs and outputs for the SORT function.

Inputs: 
Unsorted list (of IComparables in this case, but could easily be altered to accepted other variable types)
The index of the first item in the list (int)
The index of the last item in the list (int)

Outputs: Sorted list (of whatever type your unsorted list was)

## 6. Analysis Results

* Worst Case: $O(n^2)$

* Best Case: $\Omega(nlogn)$

