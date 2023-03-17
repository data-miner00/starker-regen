namespace App.Pages

open Feliz
open Fable.Core
open App.Components

module About =
    [<ReactComponent>]
    let Make () =
        Html.div [
            Header().make()

            Html.section [
                prop.className "flex items-center justify-center relative "
                prop.children [
                    //Html.div [
                    //    prop.className "h-[500px] w-[500px] backdrop-invert z-10 absolute left-[50%]"
                    //]

                    Html.div [
                        prop.className "max-w-screen-md min-h-screen text-center"
                        prop.children [
                            Html.h1 [
                                prop.className "text-7xl font-bold"
                                prop.text "About"
                            ]

                            Html.p [
                                prop.className "text-2xl"
                                prop.text "An elusive React starter template with F# that is full of bugs"
                            ]
                        ]
                    ]
                ]
            ]
        ]
