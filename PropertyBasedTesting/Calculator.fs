namespace PropertyBasedTesting

/// The Great Calculation System
module Calculator =

    let add a b =
        if a < 0 || b < 0 then
            failwith (sprintf "%i, %i" a b)
        else
            a + b