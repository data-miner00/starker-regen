namespace App.Components

open App.Core
open Feliz

type Button() =
    interface IComponent with
        [<ReactComponent>]
        member this.make() = Html.button [
            prop.className [
                "border border-solid border-blue-100 text-xl font-bold"
                "bg-gray-200 px-3 py-1 rounded-lg hover:bg-gray-300"
            ]
            prop.text "My button"
        ]

    member this.make() = (this :> IComponent).make()
