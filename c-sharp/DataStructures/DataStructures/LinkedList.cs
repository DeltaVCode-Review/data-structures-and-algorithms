using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class LinkedList
  {
    public Node Head { get; set; }

    public void Insert(int value)
    {
      Node newNode = new Node();
      newNode.Value = value;
      newNode.Next = Head;
      Head = newNode;
    }

    public void Append(int value)
    {
      Node newNode = new Node();
      newNode.Value = value;
      Node current = Head;

      while (current != null)
      {
        if (current.Next == null)
        {
          current.Next = newNode;
          break;
        }
        else
        {
          current = current.Next;
        }
      }
    }

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

    public override string ToString()
    {
      string output = "";

      Node current = Head;
      while (current != null)
      {
        // Do something interesting with current
        output += current.Value;
        output += " -> ";

        // Traverse to Next
        current = current.Next;
      }

      // Got to the end
      output = output + "NULL";

      return output;
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

    public int printNthFromLast(int n)
    {
      int length = 0;
      Node current = Head;

      // 1) count the number of nodes in Linked List 
      while (current != null)
      {
        if (length < n)
        {
          break;
        }
        else
        {
          current = current.Next;
          length++;
        }
        return length;
      }
      
      int stopHere = length - n;

      Node current2 = Head;

      for(int i = 0; i < stopHere; i++)
      {
        current2 = current.Next;
      }
      return current.Value;
    }
  }
}
