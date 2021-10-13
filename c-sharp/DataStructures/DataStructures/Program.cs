using System;
namespace DataStructures
{
  public class Program
  {
    public static void Main(string[] args) 
    {
      Console.WriteLine("hi");

      LinkedList list = new LinkedList();
      list.Insert(4);
      list.Insert(3);
      list.Insert(2);
      list.Insert(1);

      Console.WriteLine(list);
      list.printNthFromLast(2);

    }
  }
}
