namespace App

open Feliz
open Browser.Dom
open Fable.Core.JsInterop
open App.Components

module Index =
    importDynamic "./App.css" |> fun x -> x.``then``(fun x -> printfn "App.css loaded") |> ignore

    let root = ReactDOM.createRoot(document.getElementById "app")

    root.render(Button().make())
