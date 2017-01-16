namespace NinetyNine.Tests

module Question1Tests =
    open Xunit
    open NinetyNine.Question1To10
    open Swensen.Unquote

    [<Fact>]
    let EmptyList_ShouldReturnNone() =
        test <@ myLast [] = None @>

    [<Fact>]
    let NonEmptyIntegerList_ShouldReturnSomeOfLastElement() =
        test <@ myLast [4; 2; 6; 7] = Some 7 @>

    [<Fact>]
    let NonEmptyCharacterList_ShouldReturnSomeOfLastElement() =
        test <@ myLast ['x'; 'y'; 'z'] = Some 'z' @>

module Question2Tests =
    open Xunit
    open NinetyNine.Question1To10
    open Swensen.Unquote

    [<Fact>]
    let EmptyList_ShouldReturnNone() =
        test <@ myButLast [] = None @>

    [<Fact>]
    let ListWithOneElement_ShouldReturnNone() =
        test <@ myButLast [4] = None @>

    [<Fact>]
    let ListWithMoreThanOneElement_ShouldReturnSecondToLastElement() =
        test <@ myButLast [4; 2; 6; 7] = Some 6 @>