open System
open System.Collections.Generic

let lookup = Dictionary<string, string>()
lookup.["animal"] <- "Not a human"
lookup.["fish"] <- "Not a human that swims"
lookup.["human"] <- "Us"

printfn "The definition of fish is %s" lookup.["fish"]

let employees = Dictionary<int, string>()
employees.[95] <- "Tim Corey"
employees.[28] <- "Sue Storm"

printfn "The employee with ID number 28 is %s" employees.[28]

let dayOfWeek = Dictionary<string, int>()
dayOfWeek.["Wednesday"] <- 4
dayOfWeek.["Thursday"] <- 5
dayOfWeek.["Friday"] <- 6

printfn "Wednesday is day number %d" dayOfWeek.["Wednesday"]

