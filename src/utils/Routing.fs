namespace App.Utils

open Feliz.Router
open Browser.Types

module Routing =
    type State = { CurrentUrl: string list }

    type Msg = NavigateTo of string

    let update msg state =
        match msg with
        | NavigateTo href -> state, Cmd.navigatePath href

    let goToUrl (dispatch: Msg -> unit) (href: string) (e: MouseEvent) =
        e.preventDefault()

        dispatch (NavigateTo href)
