namespace SimpleApiFsharp.Models

open SimpleApiFsharp.Models.tables
open Microsoft.EntityFrameworkCore
open System.Linq

type DataContext(options: DbContextOptions<DataContext>) = 
    inherit DbContext(options)

    [<DefaultValue>]
    val mutable product : DbSet<Product>
    member public this.Product with get() = this.product
                                and set value = this.product <- value

