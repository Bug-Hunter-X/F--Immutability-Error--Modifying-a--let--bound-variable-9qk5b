let mutable x = 1
let mutable y = 2
let z = x + y
printf "%d %d\n" x y
x <- 3
printf "%d %d\n" x y
printf "%d" z