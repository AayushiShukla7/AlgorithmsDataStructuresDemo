using AlgorithmsDataStructuresConsoleApp.Stack;

#region Demo Code

//using AlgorithmsDataStructuresConsoleApp.LinkedList;
//using AlgorithmsDataStructuresConsoleApp.ADT;
//using System.Collections;

//Pokemon squirtle = new Pokemon();

//Stack ts = new Stack();

//string[] arr = new string[] { "pikachu", "charmander", "squirtle" };

//// O(n) - Linear loop
//string findSquirtle(string[] arr)
//{
//    int count = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] == "squirtle")
//        {
//            return "Found Squirtle";
//        }
//    }
//    return "No Squirtle";
//}

//// O(n^2) - Quadratic - Loop inside loop - "Brute Force"
//string printLetters(string[] arr)
//{
//    for (int i = 0; i < 10; i++)
//    {
//        for (int j = 0; j < 10; j++)
//        {
//            Console.WriteLine(arr[i][j]);
//        }
//    }
//    return "No Squirtle";
//}

// Arrays
// Array Insertions & Deletions

// 1. Inserting at the end of Array [O(1)]
//int[] intArray = new int[10];

//// Make a variable to keep the length because .Length is based off capacity ad does not track the actual index
//int length = 0;

//// This adds data for us - At the end of the array
//for (int i = 0; i < 8; i++)
//{
//    intArray[length] = i + 1;
//    length++;
//}

//intArray[length] = 8;
//length++;

// 2. Inserting at the start of an array
// Moves all the elements and inserts at the start (Super complex and inefficient) 
//for (int i = 3; i >= 0; i--)
//{
//    // This is moving over all the values
//    intArray[i + 1] = intArray[i];
//}

//intArray[0] = 20;
//Console.WriteLine("Wait point to verify the insertion under Watch");


// 3. Inserting Anywhere in the array (Here we insert at position #2)
//for (int i = 8; i >= 2; i--)
//{
//    // Shift teach element one position to the right
//    intArray[i + 1] = intArray[i];
//}

//intArray[2] = 31;
//Console.WriteLine("Wait point to verify the insertion under Watch");


// Deletion from an array
//int[] intArray = new int[9];

//int length = 0;

//// Populating the array with test values - for demonstration
//for (int i = 0; i < 6; i++)
//{
//    intArray[length] = i + 1;
//    length++;
//}

// 4. Deleting an element from the end of the array
//length--;

// 5. Deleting an element from the start of the array
//for (int i = 1; i < length; i++)
//{
//    intArray[i - 1] = intArray[i];
//}

//length--;

// 6. Deleting from anywhere in the array (we want to delete #4 here)
//for (int i = 4; i < length; i++)
//{
//    intArray[i-1] = intArray[i];
//}

//length--;

//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine(intArray[i]);
//}


// Linear Search Array
//int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//// Key means what value we are searching for
//bool LinearSearch(int[] array, int key)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] == key)
//            return true;
//    }
//    return false;
//}

//Console.WriteLine(LinearSearch(array, 0));  //false
//Console.WriteLine(LinearSearch(array, 4));  //true

/* Linked-List [Objectified Arrays] */

//Node nodeA = new Node();
//nodeA.Data = 857;

//Node nodeB = new Node();
//nodeB.Data = 124;

//Node nodeC = new Node();
//nodeC.Data = 795;

//Node nodeD = new Node();
//nodeD.Data = 222;

//Node nodeE = new Node();
//nodeE.Data = 654;

//// Set Address (Reference) value
//nodeA.Next = nodeB;
//nodeB.Next = nodeC;
//nodeC.Next = nodeD;
//nodeD.Next = nodeE;

// Circular linked list
//nodeE.Next = nodeA;

// A better way of Linked List (Toolbox approach)
//LinkedList linkedList = new LinkedList();

//linkedList.InsertFirst(1);
//linkedList.InsertFirst(2);
//linkedList.InsertFirst(3);
//linkedList.InsertFirst(4);

//linkedList.DeleteFirst();
//linkedList.DeleteFirst();

//linkedList.InsertLast(546);
//linkedList.InsertLast(3434);

//linkedList.DisplayList();

//Console.WriteLine("Wait Point");

#endregion

/* Stack */

Stack stack = new Stack(10);

for(int i=0; i<3;i++)
{
    stack.Push("Squirtle");
    stack.Push("Pikachu");
    stack.Push("Charmander");
}

stack.Pop();
stack.Peek();

while(!stack.isEmpty())
{
    var value = stack.Pop();
    Console.WriteLine(value);
}