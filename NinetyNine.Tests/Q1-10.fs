namespace NinetyNine.Tests
open Xunit
open NinetyNine.Question1To10
open Swensen.Unquote

module Question1Tests =
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
    [<Fact>]
    let EmptyList_ShouldReturnNone() =
        test <@ myButLast [] = None @>

    [<Fact>]
    let ListWithOneElement_ShouldReturnNone() =
        test <@ myButLast [4] = None @>

    [<Fact>]
    let ListWithMoreThanOneElement_ShouldReturnSecondToLastElement() =
        test <@ myButLast [4; 2; 6; 7] = Some 6 @>

module Question3Tests =
    [<Fact>]
    let IndexLargerThanListSize_ShouldReturnNone() =
        test <@ elementAt [2; 4] 3 = None @>

    [<Fact>]
    let IndexLessThanListSize_ShouldReturnKthElement() =
        test <@ elementAt [2; 5; 6; 7; 8] 3 = Some 6 @>

    [<Fact>]
    let IndexOfCharacterList_ShouldReturnKthElement() =
        test <@ elementAt (List.ofSeq "abcdef") 3 = Some 'c' @>