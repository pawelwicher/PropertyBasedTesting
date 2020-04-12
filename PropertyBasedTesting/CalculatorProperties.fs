namespace PropertyBasedTesting

module CalculatorProperties =

    open FsCheck
    open FsCheck.Xunit

    type Numbers =
        static member Int32() =
            Gen.choose(0, 1000) |> Arb.fromGen

    type CalculatorPropertyAttribute() =
        inherit PropertyAttribute(Arbitrary = [| typeof<Numbers> |])

    [<CalculatorPropertyAttribute>]
    let ``Calculator adds numbers`` (a : int) (b : int) =
        let actual = Calculator.add a b
        (a + b) = actual