namespace App.Components.Icons

open Feliz

module Github =
    [<ReactComponent(import="Github", from="./icons/Github.jsx")>]
    let Make () = React.imported()
