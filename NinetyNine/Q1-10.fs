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

    let elementAt ls index =
        let rec loop current = function
            | h::_ when index = current -> Some h
            | _::t when index > current -> loop (current + 1) t
            | _ -> None

        loop 1 ls

    let rec myLength = function
        | [] -> 0
        | _::t -> 1 + myLength t

    let myReverse input =
        let rec loop acc = function
            | [] -> acc
            | h::t -> loop (h::acc) t

        loop [] input