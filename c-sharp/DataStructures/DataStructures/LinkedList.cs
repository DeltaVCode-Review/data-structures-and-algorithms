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

      while (current != null)
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



    public void InsertBefore(int valueToStop, int valueToAdd)
    {
      Node current = Head;

      while (current != null)
      {
        if (current.Next.Value == valueToStop)
        {
          Node newNode = new Node();
          newNode.Value = valueToAdd;
          current.Next = newNode;
        }
      }
    }

    public void Append(int value)
    {
      Node newLastNode = new Node();

      newLastNode.Value = value;

      Node current = Head;

      while (current != null)
      {
        if (current.Next == null)
        {
          current.Next = newLastNode;
        }
      }
    }

    public void InsertAfter(int valueToStop, int valueToAdd)
    {
      Node current = Head;

      while (current != null)
      {
        if (current.Value == valueToStop)
        {
          Node newNode = new Node();
          newNode.Value = valueToAdd;
          current.Next = newNode;
        }
      }
    }




  }
}
