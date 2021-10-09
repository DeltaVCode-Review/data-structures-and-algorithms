using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class LinkedList
  {
    public Node Head { get; set; }

    // insert

                        //int 'value' = type & value to be inserted 
    public void Insert(int value)
    {

      Node newNode = new Node();
      newNode.Value = value;

      newNode.Next = Head;
      Head = newNode;
      
    }
    

    // includes

    public bool Includes(int valueToFind)
    {
      return false;
    }

    // to string
    public override string ToString()
    {
      return "NULL";
    }






  }
}
