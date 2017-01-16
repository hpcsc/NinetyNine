namespace NinetyNine

module Question1To10 =
    let rec myLast = function
        | [] -> None
        | [h] -> Some h
        | _::t -> myLast t

    let rec myButLast = function
        | [] | [_] -> None
        | [h;t] -> Some h
        | _::t -> myButLast t