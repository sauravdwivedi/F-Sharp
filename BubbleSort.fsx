(** Consider the following version of Bubble Sort:
 *  for (int i = 0; i < n; i++) {
 *    for (int j = 0; j < n - 1; j++) {
 *      // Swap adjacent elements if they are in decreasing order
 *      if (a[j] > a[j + 1]) {
 *          swap(a[j], a[j + 1]);
 *      }
 *    }
 *  }
 *  Given an array of integers, sort the array in ascending order using
 *  the Bubble Sort algorithm above. Once sorted, print the following
 *  three lines:
 *
 *  Array is sorted in numSwaps swaps., where numSwaps is the number of
 *  swaps that took place.
 *
 *  First Element: firstElement, where firstElement is the first element
 *  in the sorted array.
 *
 *  Last Element: lastElement, where lastElement is the last element in
 *  the sorted array.
 *
 *  Hint: To complete this challenge, you must add a variable that keeps
 *  a running tally of all swaps that occur during execution.
 *)
 
let bubbleSort (arrayInt: int array) = 
    (** Method to count number of swaps to sort the array *)
    let mutable numSwaps: int = 0
    for i = 0 to arrayInt.Length - 1 do
        for j = 0 to arrayInt.Length - 2 do
            if (arrayInt.[j] > arrayInt.[j+1]) then
                let left: int = arrayInt.[j]
                arrayInt.[j] <- arrayInt.[j+1] 
                arrayInt.[j+1] <- left
                numSwaps <- numSwaps + 1
    printfn "Sorted array: %A" arrayInt
    printfn "Array is sorted in %i swaps." numSwaps
    printfn "First element: %i" arrayInt.[0]
    printfn "Last element: %i" arrayInt.[arrayInt.Length-1]

let main() =
    printfn "Enter array of integers (space separated e.g. '1 2 3'): "
    let arrayInt = System.Console.ReadLine().Trim().Split ' ' |>
                   Array.map(int)
    printfn "Given array: %A" arrayInt
    bubbleSort arrayInt
main()
