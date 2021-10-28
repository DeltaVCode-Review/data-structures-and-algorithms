# Tree Fizz Buzz

## Problem Domain

Conduct "FizzBuzz" on a binary tree of numbers, while traversing through it to create a new tree of string.

**FizzBuzz**:

* If a number is divisible by 3, replace it with the word "*Fizz*".
* If a number is divisible by 5, replace it with the word "*Buzz*".
* If a number is divisible by both 3 *and* 5, replace it with the word "*FizzBuzz*".

> **Input**: Binary Tree of Numbers
>
> **Output**: Binary Tree of Strings

### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

## Whiteboard

![TreeFizzBuzz Whiteboard](TreeFizzBuzz.jpg)

![TreeFizzBuzz Whiteboard + Keith Notes](treeFizzBuzz2.png)

## Approach & Efficiency

Ian and I used a depth-first, pre-order traversal to move through the given int binary tree, checking each node for whether or not the value is divisible by 3, 5 or both.

## Solution

---

[Home](/README.md)
