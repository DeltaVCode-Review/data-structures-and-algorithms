using System;
namespace CodeChallenges.Sorting
{
  public class SortChallenges
  {
    public void InsertionSort(int[] arr)
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
  }
}
