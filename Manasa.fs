// https://www.hackerrank.com/challenges/manasa-and-factorials

[<EntryPoint>]
let main argv = 
    let readIntNumber = System.Console.ReadLine() |> System.Int32.Parse
    let readLongNumber () = System.Console.ReadLine() |> System.Int64.Parse

    let getNumberOfTrailingZero number : System.Int64 =
        let mutable fiveInPower = 5L
        let mutable zeroCount = 0L
        while number > fiveInPower do
            zeroCount <- zeroCount + number / fiveInPower 
            fiveInPower <- fiveInPower * 5L
        zeroCount

    let isNumberHasNotLessTrailingZeroCount (number, count) : bool =
        let numberZeroesCount = getNumberOfTrailingZero number
        numberZeroesCount >= count
                
    let count = readIntNumber
    for i = count - 1 downto 0 do
        let n = readLongNumber()
        if n = 1L 
        then 
            printfn "%i" 5
        else 
            let mutable lowerBound = 1L
            let mutable upperBound = 5L * n
            while lowerBound < upperBound do
                let middle = (lowerBound + upperBound) / 2L;
                let isMiddleHasNCountOfZeroes = isNumberHasNotLessTrailingZeroCount (middle, n)
                if isMiddleHasNCountOfZeroes
                then 
                    upperBound <- middle
                else
                    lowerBound <- middle + 1L

            printfn "%i" lowerBound
    0