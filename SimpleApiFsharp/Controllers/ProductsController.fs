namespace SimpleApiFsharp.Controllers

open Microsoft.AspNetCore.Mvc
open System.Collections.Generic
open SimpleApiFsharp.Models
open SimpleApiFsharp.Models.tables



[<ApiController>]
[<Route("[controller]")>]
type ProductsController(context: DataContext) =
    inherit ControllerBase()

    let product = {|name="Computadora"|}

    [<HttpGet>]
    member _.Get() =
       ActionResult<IEnumerable<Product>>(context.Product)

