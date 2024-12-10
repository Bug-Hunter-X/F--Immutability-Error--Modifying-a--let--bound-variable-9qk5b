# F# Immutability Error: Modifying a `let`-bound variable

This example demonstrates a common error in F#: attempting to modify a variable declared with `let` (which creates an immutable binding) using the `<-` assignment operator.

The file `bug.fs` contains the erroneous code. The file `bugSolution.fs` provides a corrected version that uses `mutable` for variables that need to be modified. 

## How to Reproduce

1. Compile `bug.fs` using an F# compiler (like the one included with .NET SDK).
2. Observe the compiler error indicating that `x` is immutable.

## Solution

The `bugSolution.fs` file shows the correct way to modify variables in F# using the `mutable` keyword.