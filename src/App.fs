namespace App

open Feliz

type Components =
    /// <summary>
    /// A simple component.
    /// </summary>
    [<ReactComponent>]
    static member HelloWorld() = Html.h1 "Hello, world"
