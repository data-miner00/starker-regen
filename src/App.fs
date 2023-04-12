namespace App

open Feliz
open Feliz.Router
open App.Components
open App.Pages

module App =
    [<ReactComponent>]
    let Make() =
        let (currentUrl, updateUrl) = React.useState(Router.currentUrl())

        React.router [
            router.hashMode
            router.onUrlChanged updateUrl
            router.children [
                match currentUrl with
                | [ ] -> Landing.Make()
                | [ "about" ] -> About.Make()
                | _ -> NotFound.Make() 
            ]
        ]
