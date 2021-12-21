(** F-Sharp script to print "Fizz" if a number is divisible by 3, print 
 *  "Buzz" if a number is divisible by 5, and print "FizzBuzz" if a number 
 *  is divisible by both 3 and 5 for numbers in a given range.
 *)
 
let fizzBuzz (targetNum: int) =
    for x = 1 to targetNum do
        if ((x % 3 = 0) && (x % 5 = 0)) then
            printfn "FizzBuzz"
        elif (x % 3 = 0) then
            printfn "Fizz"
        elif (x % 5 = 0) then
            printfn "Buzz"
        else
            printfn "%i" x

let main() = 
    printfn "Enter range of numbers: "
    let targetNum = System.Console.ReadLine() |> int
    fizzBuzz(targetNum)
main()
