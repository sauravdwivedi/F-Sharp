(** A left rotation operation on an array shifts each of the array's
 *  elements 1 unit to the left. For example, if 2 left rotations are
 *  performed on array [1,2,3,4,5], then the array would become
 *  [3,4,5,1,2]. Note that the lowest index item moves to the highest
 *  index in a rotation. This is called a circular array.
 *
 *  Given an array a of n integers and a number, d, perform d left
 *  rotations on the array. Return the updated array to be printed
 *  as a single line of space-separated integers.
 *)

let oneLeftRot (a: int list) =
    let mutable x: int list = []
    for j = 0 to a.Length - 1 do
        if (j < a.Length - 1) then
            x <- a.[j+1..j+1] |> List.append x
        else
            x <- a.[0..0] |> List.append x
    x

let main() =
    printfn "Enter array of integers (space separated e.g. '1 2 3'): "
    let mutable a = System.Console.ReadLine().Trim().Split ' ' |>
                    Array.map(int) |> List.ofArray
    printfn "Enter no. of rotations: "
    let d = System.Console.ReadLine() |> int
    let mutable c = 0
    while (c < d) do
        a <- oneLeftRot a
        c <- c + 1
    printfn "Array after %i rotations: %A" d a
main()


