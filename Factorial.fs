[<EntryPoint>]
let main argv = 
    let rec fact n:uint64 = 
        match n with
        | 0UL | 1UL -> 1UL
        | _ -> n * fact(n-1UL) 
    
    let number = System.Console.ReadLine() |> System.UInt64.Parse
    printfn "Factorial: %d" (fact number)
    0
