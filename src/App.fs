namespace App

open Feliz
open Feliz.Router
open App.Components
open App.Pages
open Fable.Core.JsInterop

module App =
    [<ReactComponent>]
    let Make() =
        let (currentUrl, updateUrl) = React.useState(Router.currentUrl())

        React.router [
            router.onUrlChanged updateUrl
            router.children [
                match currentUrl with
                | [ ] -> Landing.Make()
                | [ "button" ] -> Button().make()
                | _ -> Html.h1 "Not found"
            ]
        ]
