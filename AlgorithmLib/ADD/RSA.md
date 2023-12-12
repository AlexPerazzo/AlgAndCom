# Algorithm Description Document

Author: Alexander Perazzo

Date: 11/12/23

## 1. Name
RSA Encryption

## 2. Abstract

## 3. Methodology

## 4. Pseudocode

Only provide pseudocode for MODULAR-EXPONENTIATION.

```
MODULAR-EXPONENTIATION(x, y, n)
Recursive.
BASE CASE: If y equals 0 return 1.
If y is an even number, set z to MODULAR-EXPONENTIATION with the same x and n, but y is divided in half. Then return (z * z) mod n.
If y is an odd number, set z to MODULAR-EXPONENTIATION with the same x and n, but y divided in half (rounded down). Then return (z * z * x) mod n.
```


## 5. Inputs & Outputs

List only inputs and outputs for the MODULAR-EXPONENTIATION function.

Inputs:
int x: The piece of information you want to encrypt (or decrypt)
int y: What you take int x to the power of. Public piece of info
int n: What you use to take the module of x^y. Public piece of info

Outputs:


## 6. Analysis Results

* Worst Case: $O(log(n))$
* Not sure if it really has a best/worst case, but my instinct says that it's log(n) or even better due to the fact that you divide the exponent in half each time.
* Best Case: $\Omega(log(n))$


