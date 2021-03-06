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

## Approach & Efficiency

| Big O | Time | Space |
| :----------- | :----------- | :----------- |
|  | O(n^2) | O(1) |

We have to scan through the array as many times as there are elements in the array. So worst case scenario for Time would be when all of the elements are in the absolute opposite order of where we want them to be.

Sorting is happening in place, so it will not require any additional space.

## Solution

```csharp
public static void InsertionSort(int[] arr)
    {
      for (int i = 1; i < arr.Length; i++)
      {
        int j = i - 1;

        int temp = arr[i];

        while (j >= 0 && temp < arr[j])
        {
          arr[j] = arr[j + 1];
          j--;
        }

        temp = arr[j + 1];
      }
    }
```

---
