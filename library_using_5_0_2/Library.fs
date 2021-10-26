namespace library_using_5_0_2

module Say =
    // This will only work with FSharp.Core 5+
    let interpolated = $"hello {42}"

    let hello name =
        printfn "Hello %s" name
