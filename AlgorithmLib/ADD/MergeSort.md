# Algorithm Description Document

Author: 

Date: 

## 1. Name
Merge Sort

## 2. Abstract
Makes each item in the list into its own list; these small lists merge and sort until it merges back to one big sorted list.

## 3. Methodology
This algorithm takes an unsorted list. It makes each item in the list into its own list. Each of the one-item lists compares itself with another one-item list. They are merged into one list and sorted. This process continues until all lists are merged back together.

## 4. Pseudocode


```
MERGE(data, first, mid, last)
Compare two lists first items. Have a third list prepared. Which ever lists first item is smaller, that item goes into the third list. Eliminate that item from the original list. Repeat process until the two lists are empty and all their contents are in the third list.

SORT(data, first, last)
If list's length is 1: Return
Else: Divide list in half. Recall SORT function until each list gets returned.
Call MERGE to begin merging all the 1-item lists into bigger lists.


```

## 5. Inputs & Outputs

List only inputs and outputs for the SORT function.

Inputs: data: list of IComparables you want to sort
first: int of index of the first item in the list
last: int of the index of the last item in the list

Outputs: Technically no outputs, but it sorts the inputted data list as a result of the process.

## 6. Analysis Results

* Worst Case: $O(nlogn)$

* Best Case: $\Omega(nlogn)$

