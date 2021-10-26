using System;
namespace DataStructures.Trees
{
  class BinarySearchTree : BinaryTree<int>
  {
    void Add(int value) { ... }
    bool Contains(int value) { ... }
  }

  //// Stretch goal
  //class BinarySearchTree<T> : BinaryTree<T>
  //    where T : IComparable<T>
  //{
  //  void Add(T value) { ... }
  //  bool Contains(T value) { ... }
  //}

}
