using System;
using System.Linq;
using CodeChallenges;
using CodeChallenges.Sorting;
using Xunit;

namespace CodeChallengesTests
{
  public class SortingTests
  {

    [Fact]
    public void InsertionSort_Sorts()
    {
      //ARRANGE

      // Sample Array [8,4,23,42,16,15]

      int[] arr = new int[6];
      arr[0] = 8;
      arr[1] = 4;
      arr[2] = 23;
      arr[3] = 42;
      arr[4] = 16;
      arr[5] = 15;

      //ACT

      SortChallenges.InsertionSort(arr);

      //ASSERT

      Assert.Equal(new[] { 4, 8, 15, 16, 23, 42 }, arr);

    }

    [Theory]
    [InlineData(new[] { 1, 1, 1, 1 })]
    [InlineData(new[] { 4, 3, 2, 1 })]
    [InlineData(new[] { 1, 2, 3, 4 })]
    [InlineData(new[] { -1, -2, -3, -4 })]
    [InlineData(new[] { 7, 2, 5, 4 })]
    public void InsertionSort_works(int[] arr)
    {
      // Arrange

      // Use LINQ to re-sort into a new array
      // int[] expected = arr.OrderBy(n => n).ToArray();

      // Map each value to itself, in a copy, then sort
      int[] expected = Array.ConvertAll(arr, n => n);
      Array.Sort(expected);

      // Act
      SortChallenges.InsertionSort(arr);

      // Assert
      Assert.Equal(expected, arr);
    }
  }
}
