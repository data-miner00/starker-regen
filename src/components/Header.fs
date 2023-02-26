namespace App.Components

open App.Core
open Feliz
open App.Components.Icons

type Header() =
    interface IComponent with
        [<ReactComponent>]
        member this.make() = Html.div [
            prop.className [ 
                "border-b border-solid border-gray-200"
                "w-full h-16"
            ]
            prop.children [
                Html.header [
                    prop.className [
                        "flex justify-between max-w-screen-xl mx-auto"
                        "items-center h-full"
                    ]
                    prop.children [
                        Html.div [
                            prop.className [
                                "uppercase text-2xl font-semibold text-slate-700"
                            ]
                            prop.text "Starker"
                        ]

                        Html.div [
                            prop.children [
                                Github.Make()
                            ]
                        ]
                    ]
                ]
            ]
        ]

    member this.make() = (this :> IComponent).make()
