using System;
using System.Collections.Generic;
using DataStructures.Trees;

namespace DataStructures
{
  public class BinaryTree<T>
  {
    public Node<T> Root { get; set; }

    public IEnumerable<T> PreOrder()
    {
      // Option 1
      return PreOrder(Root);

      List<T> results = new List<T>();
      PreOrder(Root, results);
      return results;
    }

    // Option 1
    private IEnumerable<T> PreOrder(Node root) { /* use yield return */ }

    // Option 2
    private static IEnumerable<T> PreOrder(Node root, List<T> results) { }

    // InOrder() + PostOrder()
  }

}
