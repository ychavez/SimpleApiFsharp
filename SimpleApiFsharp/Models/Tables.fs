namespace SimpleApiFsharp.Models

open System
open System.ComponentModel.DataAnnotations
module tables =

    [<CLIMutable>]
    type Product = {
    Id: int
    [<Required>]
    Name:string
    [<Required>]
    Price:decimal
    }
