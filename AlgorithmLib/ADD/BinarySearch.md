# Algorithm Description Document

Author: Alexander Perazzo

Date: 9/23/23

## 1. Name
Binary Search

## 2. Abstract
Splits sorted list in half repeatedly to find target's index.

## 3. Methodology
The algorithm takes a sorted list and a desired target. It checks to see if the center item is the target. If it is not the target, it will delete the half of the list that the target does not appear in. It then checks the middle of the remaining list and repeats this process until it finds the desired target.

## 4. Pseudocode


```
BINARY-SEARCH(data, target)

While center number of data is not target:  
    If center number of data is desired number:  
        Return index of desired number  
    Else:  
        If list is empty return NOT FOUND.  

        Delete the half of the list that the desired number is not in

```

## 5. Inputs & Outputs

Inputs: Target (int): The item the algorithm is looking for in the list.
Data (list of ints): The sorted list of ints

Outputs: Index (therefore an int) of the target's location in data. Alternatively -1 if not in list.

## 6. Analysis Results

* Worst Case: $O(1)$

* Best Case: $\Omega(logn)$

