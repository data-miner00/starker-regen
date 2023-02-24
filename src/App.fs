namespace App

open Feliz

type Components =
    /// <summary>
    /// A simple component.
    /// </summary>
    [<ReactComponent>]
    static member HelloWorld() = Html.h1 [
        prop.className [ "text-green-500" ]
        prop.text "Hello, world"
    ]
