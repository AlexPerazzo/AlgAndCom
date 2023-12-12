# Algorithm Description Document

Author: Alexander Perazzo

Date: 11/3/2023

## 1. Name

String Matcher

## 2. Abstract

The String Matcher algorithm uses a finite state machine to keep track of how many times the inputted string has a specific pattern in it. It creates a table that has the various states alongside which state goes to which state depending on the next letter. Every time the next letter takes you to the match state, it knows there's another instance of the pattern in the string.

## 3. Methodology
The String Matcher algorithm is split into two functions both serving a vital purpose. The build-table function and the match function. The build-table function does just that -- build a table. This table has one row for each different letter that could be in the string + 1 and one column for each possible state (which is the length of the pattern + 1). This grid is filled with numbers -- that number signifies what state the machine should go to depending on the inputted letter. For example: You're currently in state 2 and you're inputting letter 'A'. You look down row 'A' column '2' and it gives you the number '3'. This means you go into state 3.

With the table in place, the match function is straight forward. It loops through the inputted string. You start at state 0. It utilizes the table as explained above. It takes the first letter, looks at that column in the row of state 0. It gives you the state you should go into. In that new state's row, you look at the column of the next letter. So on and so forth. Every time you go to the match state, you could add one to a counter (to know how many times the pattern appears) or add the index to a list (so you know the location of the last letter in each instance) or you could do something else entirely.


## 4. Pseudocode

```
BUILD-TABLE(pattern, inputs)

MATCH(text, pattern, inputs)

```

## 5. Inputs & Outputs

List only inputs and outputs for the MATCH function. 

Inputs: text (string). This is the list of characters (of which you want to know how many times the pattern appears in)
pattern (string). This is the pattern you are looking for in the text.
inputs (list of characters). This is all the different characters that can appear in the text. This is used to help build the table.

Outputs:

## 6. Analysis Results

For Matcher (not including Build Table):
* Worst Case: $O(n)$
You only loop once regardless, so it's O(n)
* Best Case: $\Omega(n)$

For Build Table:
* Worst Case: $O(rm^3)$
  m is length of the pattern. r is length of inputs
* Best Case: $\Omega(rm^3)$

