# Insertion Sort

## Challenge Summary

Review the pseudocode below, then trace the algorithm by stepping through the process with the provided sample array.

Document your explanation by creating a blog article that shows the step-by-step output after each iteration through some sort of visual.

### **Sample Array**

    [8,4,23,42,16,15]

---

## Pseudocode

    InsertionSort(int[] arr)

      FOR i = 1 to arr.length

        int j <-- i - 1
        int temp <-- arr[i]

        WHILE j >= 0 AND temp < arr[j]
          arr[j + 1] <-- arr[j]
          j <-- j - 1

        arr[j + 1] <-- temp

---

### Implementation

* Provide a visual step through for each of the sample arrays based on the provided pseudo code

* Convert the pseudo-code into working code in your language

* Present a complete set of working tests

---

## Whiteboard Process

<!-- Embedded whiteboard image -->

## Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->

## Solution

<!-- Show how to run your code, and examples of it in action -->

---
