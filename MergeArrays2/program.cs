// C# program to merge two sorted arrays
//using maps
using System;
using System.Collections.Generic;

public class GFG {

// Function to merge arrays
static void mergeArrays(int []a, int []b, int n, int m)
{

	// Declaring a map.
	// using map as a inbuilt tool
	// to store elements in sorted order.
	SortedDictionary<int, Boolean> mp = new SortedDictionary<int, Boolean>();

	// Inserting values to a map.
	for (int i = 0; i < n; i++) {
	mp.Add(a[i], true);
	}
	for (int i = 0; i < m; i++) {
	mp.Add(b[i], true);
	}

	// Printing keys of the map.
	foreach (KeyValuePair<int, Boolean> me in mp) {
	Console.Write(me.Key + " ");
	}
}

// Driver Code
public static void Main(String[] args) {
	int []a = { 1, 3, 5, 7 };
	int []b = { 2, 4, 6, 8 };
	int size = a.Length;
	int size1 = b.Length;

	// Function call
	mergeArrays(a, b, size, size1);
}
}

// This code is contributed by gauravrajput1
