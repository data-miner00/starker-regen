namespace App.Components

open Feliz

module Showcase =
    [<ReactComponent(import="Showcase", from="../components/Showcase.jsx")>]
    let Make () = React.imported()
