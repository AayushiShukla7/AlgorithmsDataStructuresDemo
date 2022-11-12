
#region Demo Code

//using AlgorithmsDataStructuresConsoleApp.Stack;
//using AlgorithmsDataStructuresConsoleApp.LinkedList;
//using AlgorithmsDataStructuresConsoleApp.ADT;
//using System.Collections;

//Pokemon squirtle = new Pokemon();

//Stack ts = new Stack();

//string[] arr = new string[] { "pikachu", "charmander", "squirtle" };

#region O(n) - Linear loop
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
#endregion

#region O(n^2) - Quadratic - Loop inside loop - "Brute Force"
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
#endregion

#region Arrays
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
#endregion

#region Linear Search Array
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
#endregion

#region Linked-List [Objectified Arrays] 

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

#region Stack

//Stack stack = new Stack(10);

//for (int i = 0; i < 3; i++)
//{
//    stack.Push("Squirtle");
//    stack.Push("Pikachu");
//    stack.Push("Charmander");
//}

//stack.Pop();
//stack.Peek();

//while (!stack.isEmpty())
//{
//    var value = stack.Pop();
//    Console.WriteLine(value);
//}
#endregion

#region Queue 

//using AlgorithmsDataStructuresConsoleApp.Queue;

//Queue queue = new Queue(10);

//queue.Enqueue(1);
//queue.Enqueue(2);
//queue.Enqueue(3);
//queue.Enqueue(4);

//queue.Dequeue();
//queue.Dequeue();

//Console.WriteLine($"Front of the Queue is: {queue.Peek()}");
#endregion

#region Binary Search

//int[] intArray = { -20, -15, 2, 7, 20, 30, 54 };

//Console.WriteLine(BinarySearch(intArray, 2) != -1 ? "Found the #" : "No luck!!");   //Found the #
//Console.WriteLine(BinarySearch(intArray, 3) != -1 ? "Found the #" : "No luck!!");   //No luck!!

//int BinarySearch(int[] intArray, int value)
//{
//    int start = 0;
//    int end = intArray.Length;

//    //start end + while less than is going criss-crossing
//    while (start < end)
//    {
//        //Put in paranthesis because add then incorrect
//        int midPoint = (start + end) / 2;

//        //Search the middle of the book
//        if (intArray[midPoint] == value)
//        {
//            return midPoint;
//        }
//        else if (intArray[midPoint] < value)
//        {
//            start = midPoint + 1;
//        }
//        else
//        {
//            end = midPoint;
//        }        
//    }
//    return -1;  //Whole iteration finished and number not found means the number is not there in the array
//}
#endregion

#region Tree + Binary Search Tree

//using AlgorithmsDataStructuresConsoleApp.BinarySearchTree;

//BinarySearchTree bst = new BinarySearchTree();
//bst.Insert(7, "Squirtle");
//bst.Insert(23, "Ekans");
//bst.Insert(151, "Mew");
//bst.Insert(4, "Charmander");
//bst.Insert(1, "Bulbasaur");

////Find operation in BST
//Console.WriteLine(bst.Find(151));

#endregion

#region Bubble Sort 

//using AlgorithmsDataStructuresConsoleApp.BinarySearchTree;

//int[] intArray = new int[] { 6, 5, 1, 7, 2, 4 };

//int[] value = BubbleSort(intArray);
//int joker = 0;  //Placeholder for verifying sorted result

//int[] BubbleSort(int[] array)
//{
//    //Variable to hold temporrary variable for the swap - Think State
//    int temp = 0;

//    //Iterates over entire loop many times
//    for (int pointer = 0; pointer < array.Length; pointer++)
//    {
//        //Form the 'box' that does the comparison
//        for (int sort = 0; sort < array.Length - 1; sort++)
//        {
//            //This checks to see if the left side is larger than the right
//            if (array[sort] > array[sort + 1])
//            {
//                //Do the Swap
//                //We store variable as temp so we dont overwrite it when we swap
//                temp = array[sort + 1];
//                //Put left variable in the right
//                array[sort + 1] = array[sort];
//                //Put the right variable in he left
//                array[sort] = temp;
//            }
//        }
//    }
//    return array;
//}
#endregion

#region Recursion

////Without Recursion
//PartyFunction();
//PartyFunction();    //Next call is made when previous 'PartyFunction' is popped off the call stack
//PartyFunction();

//bool PartyFunction()
//{
//    return true;
//}

////With Recursion
//PartyFunction();

//void PartyFunction()
//{
//    var val = Guid.NewGuid();
//    PartyFunction();
//}

//var val = 0;

/* A sophisticated approach to demonstrate Recursion 
 */
//MinusByOne(5);

//void MinusByOne(int n) {
//    //Base case -> To prevent a stack overflow 
//    if (n != 0) {
//        MinusByOne(n - 1);
//    }

//    //All these functions are going to execute, store state, THEN they are going minus
//    Console.WriteLine("Call: " + n);
//}

/* Recursion Example - Factorial */

////An iterative factorial
//Console.WriteLine("IterativeFactorial: " + IterativeFactorial(5));

//int IterativeFactorial(int num)
//{
//    int factorial = 1;
//    for (int i = 1; i <= num; i++)
//    {
//        factorial = factorial * i;
//    }

//    return factorial;
//}

////A recursive factorial
//Console.WriteLine("RecursiveFactorial: " + RecursiveFactorial(5));

//int RecursiveFactorial(int num)
//{
//    if (num == 0) return 1;

//    return num * RecursiveFactorial(num - 1);
//}

#endregion

#region Tree Traversal + Binary Search Tree (BST)

//using AlgorithmsDataStructuresConsoleApp.BinarySearchTree;

//BinarySearchTree bst = new BinarySearchTree();
//bst.Insert(10, "");
//bst.Insert(7, "");
//bst.Insert(11, "");
//bst.Insert(6, "");
//bst.Insert(1, "");
//bst.Insert(8, "");
//bst.Insert(9, "");
//bst.Insert(20, "");
//bst.Insert(14, "");
//bst.Insert(22, "");

////DFS (In Order)
//Console.WriteLine("DFS (In Order):");
//bst.PrintInOrderTraversal();

// DFS (In Order):
//1
//6
//7
//8
//9
//10
//11
//14
//20
//22
// */

////DFS (Pre Order)
//Console.WriteLine("\nDFS (Pre Order):");
//bst.PrintPreOrderTraversal();

//DFS (Pre Order):
//10
//7
//6
//1
//8
//9
//11
//20
//14
//22 
// */

////DFS (Post Order)
//Console.WriteLine("\nDFS (Post Order):");
//bst.PrintPostOrderTraversal();

// DFS (Post Order):
//1
//6
//9
//8
//7
//14
//22
//20
//11
//10
// */

#endregion

#region Hash Tables

//https://www.md5.cz/
//aayushi - 157b3b6ade020d511958e0450d53b72c

using AlgorithmsDataStructuresConsoleApp.HashTable;

HashTable hashtable = new HashTable();
hashtable.Set("Teddy", "123-456-7890");
hashtable.Set("Steve", "987-654-3210");
hashtable.Set("Jessica", "999-888-7777");
hashtable.Set("Sarah", "666-555-4444");
hashtable.Set("Jennifer", "333-222-1111");

Console.WriteLine(hashtable.Get("Teddy"));
Console.WriteLine(hashtable.Get("Steve"));  //Causes Hash Collision
Console.WriteLine(hashtable.Get("Jessica"));
Console.WriteLine(hashtable.Get("Sarah"));
Console.WriteLine(hashtable.Get("Jennifer"));

#endregion

#endregion

