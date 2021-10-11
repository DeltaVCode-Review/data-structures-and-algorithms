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

    // TODO includes
    // Arguments: value
    // Returns: Boolean
    // Indicates whether that value exists as a Node’s value somewhere within the list.

    public bool Includes(int valueToFind)
    {

      Node current = Head;

      while(current != null)
      {
        if (current.Value == valueToFind)
        {
          return true;
        }

        current = current.Next;
      }

      return false;
    }

   
    // TODO to string
    // Arguments: none
    // Returns: a string representing all the values in the Linked List, formatted as:
    // "{ a } -> { b } -> { c } -> NULL"

    public override string ToString()
    {
      return "NULL";
    }


    

  }
}
