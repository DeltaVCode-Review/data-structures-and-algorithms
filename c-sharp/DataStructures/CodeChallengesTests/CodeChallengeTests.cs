using System;
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
  }
}
